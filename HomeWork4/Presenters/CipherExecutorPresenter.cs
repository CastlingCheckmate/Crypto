using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Cryptography.HomeWork4;

using Extensions.BinaryReaderExtensions;
using Extensions.BinaryWriterExtensions;

using MVP.Presenter;

using HomeWork4.Enumerations;
using HomeWork4.Exceptions;
using HomeWork4.Models;

namespace HomeWork4.Presenters
{

    internal sealed class CipherExecutorPresenter : PresenterBase
    {

        #region Control fields

        private MenuStrip _mainMenu;
        private ToolStripMenuItem _startEncryptionOperationMainMenuItem;
        private ToolStripMenuItem _startDecryptionOperationMainMenuItem;
        private StatusStrip _statusBar;
        private ToolStripProgressBar _cipherExecutionStatusProgressBar;
        private ToolStripStatusLabel _cipherExecutionStatusLabel;
        private ToolStripDropDownButton _stopCipherOperationExecutionButton;

        #endregion

        #region Constructors

        public CipherExecutorPresenter()
            : base(new CipherExecutorModel(), "HomeWork4.Presenters.CipherExecutorPresenter.")
        {

        }

        #endregion

        #region Properties

        internal new CipherExecutorModel Model =>
            base.Model as CipherExecutorModel;

        public bool IsExecuting =>
            Model.IsExecuting;

        #endregion

        #region Control properties

        public MenuStrip MainMenu
        {
            private get => _mainMenu ??
                throw new ArgumentException(Path + nameof(MainMenu));

            set => _mainMenu = value;
        }

        public ToolStripMenuItem StartEncryptionOperationMainMenuItem
        {
            private get => _startEncryptionOperationMainMenuItem ??
                throw new ArgumentNullException(Path + nameof(StartEncryptionOperationMainMenuItem));

            set => _startEncryptionOperationMainMenuItem = value;
        }

        public ToolStripMenuItem StartDecryptionOperationMainMenuItem
        {
            private get => _startDecryptionOperationMainMenuItem ??
                throw new ArgumentNullException(Path + nameof(StartDecryptionOperationMainMenuItem));

            set => _startDecryptionOperationMainMenuItem = value;
        }

        public StatusStrip StatusBar
        {
            private get => _statusBar ??
                throw new ArgumentNullException(Path + nameof(StatusBar));

            set => _statusBar = value;
        }

        public ToolStripProgressBar CipherExecutionStatusProgressBar
        {
            private get => _cipherExecutionStatusProgressBar ??
                throw new ArgumentNullException(Path + nameof(CipherExecutionStatusProgressBar));

            set => _cipherExecutionStatusProgressBar = value;
        }

        public ToolStripStatusLabel CipherExecutionStatusLabel
        {
            private get => _cipherExecutionStatusLabel ??
                throw new ArgumentNullException(Path + nameof(CipherExecutionStatusLabel));

            set => _cipherExecutionStatusLabel = value;
        }

        public ToolStripDropDownButton StopCipherOperationExecutionButton
        {
            private get => _stopCipherOperationExecutionButton ??
                throw new ArgumentNullException(Path + nameof(StopCipherOperationExecutionButton));

            set => _stopCipherOperationExecutionButton = value;
        }

        #endregion

        #region Private methods

        private Dictionary<string, string> ValidateParameters(CipherOperationParameters cipherOperationParameters)
        {
            var result = new Dictionary<string, string>();
            if (!File.Exists(cipherOperationParameters.InputFileName))
            {
                result.Add(nameof(cipherOperationParameters.InputFileName), "input file doesn't exist");
            }
            if (cipherOperationParameters.OutputFileName == string.Empty)
            {
                result.Add(nameof(cipherOperationParameters.OutputFileName), "output file name not defined");
            }
            if (cipherOperationParameters.InputFileName == cipherOperationParameters.OutputFileName
				&& result.Count == 0)
            {
                result.Add($"{nameof(cipherOperationParameters.InputFileName)}, " +
                    $"{nameof(cipherOperationParameters.OutputFileName)}", "input and output files are the same");
            }
            if (cipherOperationParameters.Key == null)
            {
                result.Add(nameof(cipherOperationParameters.Key), "key not set");
            }
            if (cipherOperationParameters.CipherMode != SymmetricCipherModes.ElectronicCodeBook
                && cipherOperationParameters.IV == null)
            {
                result.Add(nameof(cipherOperationParameters.IV), "IV not set");
            }
            return result;
        }

        #endregion

        #region Public methods

        public async Task Execute(CipherOperationParameters cipherOperationParameters)
        {
            var errors = ValidateParameters(cipherOperationParameters);
            if (errors.Count != 0)
            {
                throw new InvalidCipherOperationParametersException(errors);
            }
            Model.CipherExecutionCanceller.Dispose();
            Model.CipherExecutionCanceller = new CancellationTokenSource();
            Model.Completed = 0;
            Model.IsExecuting = true;
            try
            {
                await Task.Factory.StartNew(() =>
                {
                    var rijndael = new RijndaelWithCipherModes(cipherOperationParameters.BlockSize
                        , cipherOperationParameters.KeySize, cipherOperationParameters.IrreduciblePolynomial
                        , cipherOperationParameters.CipherMode, cipherOperationParameters.Key
                        , cipherOperationParameters.IV);
                    var cipherMethod = default(Func<byte[], byte[]>);
                    var inputFileReader = default(BinaryReader);
                    var outputFileWriter = default(BinaryWriter);
                    try
                    {
                        inputFileReader = new BinaryReader(new FileStream(cipherOperationParameters.InputFileName
                            , FileMode.Open));
                    }
                    catch (IOException)
                    {
                        throw;
                    }
                    try
                    {
                        outputFileWriter = new BinaryWriter(new FileStream(cipherOperationParameters.OutputFileName
                            , FileMode.Create));
                    }
                    catch (IOException)
                    {
                        inputFileReader.FluentClose().FluentDispose();
                        throw;
                    }
                    var blockSize = (byte)cipherOperationParameters.BlockSize;
                    var paddingSize = default(byte);
                    if (cipherOperationParameters.CipherOperation == CipherOperations.Encryption)
                    {
                        cipherMethod = rijndael.Encrypt;
                    }
                    else
                    {
                        if (inputFileReader.BaseStream.Length == 0
                            || inputFileReader.BaseStream.Length == blockSize
                            || inputFileReader.BaseStream.Length % blockSize != 0)
                        {
                            inputFileReader.FluentClose().FluentDispose();
                            outputFileWriter.FluentClose().FluentDispose();
                            throw new FileFormatException($"File {cipherOperationParameters.InputFileName} " +
                                $"is corrupted.");
                        }
                        cipherMethod = rijndael.Decrypt;
                    }
                    while (true)
                    {
                        var readBytes = inputFileReader.ReadBytes(blockSize * Environment.ProcessorCount);
                        if (inputFileReader.BaseStream.Position == inputFileReader.BaseStream.Length)
                        {
                            if (readBytes.Length == 0)
                            {
                                break;
                            }
                            if (cipherOperationParameters.CipherOperation == CipherOperations.Encryption)
                            {
                                if (readBytes.Length != blockSize * Environment.ProcessorCount)
                                {
                                    if (readBytes.Length % blockSize == 0)
                                    {
                                        Array.Resize(ref readBytes, readBytes.Length + blockSize);
                                        readBytes[readBytes.Length - 1] = blockSize;
                                    }
                                    else
                                    {
                                        paddingSize = (byte)(blockSize - readBytes.Length % blockSize);
                                        Array.Resize(ref readBytes, readBytes.Length + paddingSize);
                                        readBytes[readBytes.Length - 1] = paddingSize;
                                    }
                                }
                                else
                                {
                                    Array.Resize(ref readBytes, readBytes.Length + blockSize);
                                    readBytes[readBytes.Length - 1] = blockSize;
                                }
                            }
                        }
                        if (Model.CipherExecutionCanceller.Token.IsCancellationRequested)
                        {
                            inputFileReader.FluentClose().FluentDispose();
                            outputFileWriter.FluentClose().FluentDispose();
                            throw new OperationCanceledException(
                                $"{Enum.GetName(typeof(CipherOperations), cipherOperationParameters.CipherOperation)} " +
                                $"operation has been cancelled.");
                        }
                        var blocks = Enumerable
                            .Range(0, readBytes.Length / blockSize)
                            .Select((i) => readBytes.Skip(i * blockSize).Take(blockSize).ToArray())
                            .ToArray();
                        if (cipherOperationParameters.CipherMode == SymmetricCipherModes.ElectronicCodeBook)
                        {
                            Parallel.For(0, blocks.Length, (i) =>
                            {
                                cipherMethod(blocks[i]);
                            });
                        }
                        else
                        {
                            for (var i = 0; i < blocks.Length; i++)
                            {
                                cipherMethod(blocks[i]);
                            }
                        }
                        if (cipherOperationParameters.CipherOperation == CipherOperations.Decryption
                            && inputFileReader.BaseStream.Position == inputFileReader.BaseStream.Length)
                        {
                            paddingSize = (byte)(blocks.Last().Last() % blockSize);
                            Array.Resize(ref blocks[blocks.Length - 1], blockSize - paddingSize);
                        }
                        foreach (var block in blocks)
                        {
                            outputFileWriter.Write(block);
                        }
                        Model.Completed = (byte)((float)inputFileReader.BaseStream.Position /
                            inputFileReader.BaseStream.Length * 100);
                    }
                    inputFileReader.FluentClose().FluentDispose();
                    outputFileWriter.FluentClose().FluentDispose();
                }, Model.CipherExecutionCanceller.Token);
            }
            catch (Exception)
            {
                MessageBox.Show("");
                Model.IsExecuting = false;
                throw;
            }
            CipherOperationCompleted?.Invoke(cipherOperationParameters.CipherOperation);
            Model.IsExecuting = false;
        }

        public void StopExecution()
        {
            Model.CipherExecutionCanceller.Cancel();
            Model.IsExecuting = false;
        }

        #endregion

        #region Events

        public event Action<CipherOperations> CipherOperationCompleted;

        #endregion

        #region PresenterBase class abstract methods implementation

        public override void Initialize()
        {
            Model.IsExecutingChanged += new Action<bool>(isExecuting =>
            {
                MainMenu.Invoke((MethodInvoker)(() =>
                {
                    StartEncryptionOperationMainMenuItem.Enabled = !isExecuting;
                    StartDecryptionOperationMainMenuItem.Enabled = !isExecuting;
                }));
                StatusBar.Invoke((MethodInvoker)(() =>
                {
                    CipherExecutionStatusProgressBar.Visible = isExecuting;
                    CipherExecutionStatusLabel.Visible = isExecuting;
                    StopCipherOperationExecutionButton.Visible = isExecuting;
                }));

            });
            Model.CompletedChanged += new Action<byte>(completed =>
            {
                StatusBar.Invoke((MethodInvoker)(() =>
                {
                    CipherExecutionStatusProgressBar.Value = completed;
                    CipherExecutionStatusLabel.Text = $"{completed}%";
                }));
            });
            Model.Initialize();
        }

        #endregion

        #region IDisposable interface implementation

        public override void Dispose()
        {
            Model.Dispose();
        }

        #endregion

    }

}