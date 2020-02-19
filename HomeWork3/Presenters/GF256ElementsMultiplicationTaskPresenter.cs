using System;
using System.Numerics;
using System.Windows.Forms;

using Cryptography.HomeWork3;

using HomeWork3.Models;

using MVP.Presenter;

namespace HomeWork3.Presenters
{

    internal sealed class GF256ElementsMultiplicationTaskPresenter : PresenterBase
    {

        #region Control fields

        private Label _firstFactorLabel;
        private Label _secondFactorLabel;
        private Label _moduloLabel;
        private Label _multiplicationResultLabel;

        #endregion

        #region Constructors

        public GF256ElementsMultiplicationTaskPresenter()
            : base(new GF256ElementsMultiplicationTaskModel(), "HomeWork3.Presenters.")
        {

        }

        #endregion

        #region Properties

        private new GF256ElementsMultiplicationTaskModel Model =>
            base.Model as GF256ElementsMultiplicationTaskModel;

        #endregion

        #region Control properties

        public Label FirstFactorLabel
        {
            private get => _firstFactorLabel ??
                throw new ArgumentNullException(Path + nameof(FirstFactorLabel));

            set => _firstFactorLabel = value;
        }

        public Label SecondFactorLabel
        {
            private get => _secondFactorLabel ??
                throw new ArgumentNullException(Path + nameof(SecondFactorLabel));

            set => _secondFactorLabel = value;
        }

        public Label ModuloLabel
        {
            private get => _moduloLabel ??
                throw new ArgumentNullException(Path + nameof(ModuloLabel));

            set => _moduloLabel = value;
        }

        public Label MultiplicationResultLabel
        {
            private get => _multiplicationResultLabel ??
                throw new ArgumentNullException(Path + nameof(MultiplicationResultLabel));

            set => _multiplicationResultLabel = value;
        }

        #endregion

        #region Public methods

        public void ParseFirstFactor(string firstFactorString)
        {
            if (!BigInteger.TryParse(firstFactorString, out var firstFactor))
            {
                Model.FirstFactor = null;
                return;
            }
            try
            {
                Model.FirstFactor = new GF256Element(new BinaryPolynomial(firstFactor));
            }
            catch (ArgumentException)
            {
                Model.FirstFactor = null;
            }
        }

        public void ParseSecondFactor(string secondFactorString)
        {
            if (!BigInteger.TryParse(secondFactorString, out var secondFactor))
            {
                Model.SecondFactor = null;
                return;
            }
            try
            {
                Model.SecondFactor = new GF256Element(new BinaryPolynomial(secondFactor));
            }
            catch (ArgumentException)
            {
                Model.SecondFactor = null;
            }
        }

        public void ParseModulo(string moduloString)
        {
            if (!BigInteger.TryParse(moduloString, out var modulo))
            {
                Model.Modulo = null;
                return;
            }
            try
            {
                Model.Modulo = new GF256Modulo(new BinaryPolynomial(modulo));
            }
            catch (ArgumentException)
            {
                Model.Modulo = null;
            }
        }

        #endregion

        #region PresenterBase class abstract methods implementation

        public override void Initialize()
        {
            Model.FirstFactorChanged += new Action<string>((firstFactorString) =>
            {
                FirstFactorLabel.Invoke((MethodInvoker)(() =>
                {
                    FirstFactorLabel.Text = firstFactorString;
                }));
            });
            Model.SecondFactorChanged += new Action<string>((secondFactorString) =>
            {
                SecondFactorLabel.Invoke((MethodInvoker)(() =>
                {
                    SecondFactorLabel.Text = secondFactorString;
                }));
            });
            Model.ModuloChanged += new Action<string>((moduloString) =>
            {
                ModuloLabel.Invoke((MethodInvoker)(() =>
                {
                    ModuloLabel.Text = moduloString;
                }));
            });
            Model.MultiplicationResultChanged += new Action<string>((multiplicationResultString) =>
            {
                MultiplicationResultLabel.Invoke((MethodInvoker)(() =>
                {
                    MultiplicationResultLabel.Text = multiplicationResultString;
                }));
            });
            Model.Initialize();
        }

        #endregion

    }

}