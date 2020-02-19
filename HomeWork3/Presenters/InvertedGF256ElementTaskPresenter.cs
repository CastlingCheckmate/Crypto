using System;
using System.Numerics;
using System.Windows.Forms;

using Cryptography.HomeWork3;

using HomeWork3.Models;

using MVP.Presenter;

namespace HomeWork3.Presenters
{

    internal sealed class InvertedGF256ElementTaskPresenter : PresenterBase
    {

        #region Control fields

        private Label _elementLabel;
        private Label _moduloLabel;
        private Label _invertedByPotentiationMethodElementLabel;
        private Label _invertedByExtendedEucledianAlgorithmElementLabel;

        #endregion

        #region Constructors

        public InvertedGF256ElementTaskPresenter()
            : base(new InvertedGF256ElementTaskModel(), "HomeWork3.Presenters.")
        {

        }

        #endregion

        #region Properties

        private new InvertedGF256ElementTaskModel Model => base.Model as InvertedGF256ElementTaskModel;

        #endregion

        #region Control properties
        
        public Label ElementLabel
        {
            private get => _elementLabel ??
                throw new ArgumentNullException(Path + nameof(ElementLabel));

            set => _elementLabel = value;
        }

        public Label ModuloLabel
        {
            private get => _moduloLabel ??
                throw new ArgumentNullException(Path + nameof(ModuloLabel));

            set => _moduloLabel = value;
        }

        public Label InvertedByPotentiationMethodElementLabel
        {
            private get => _invertedByPotentiationMethodElementLabel ??
                throw new ArgumentNullException(Path + nameof(InvertedByPotentiationMethodElementLabel));

            set => _invertedByPotentiationMethodElementLabel = value;
        }

        public Label InvertedByExtendedEucledianAlgorithmElementLabel
        {
            private get => _invertedByExtendedEucledianAlgorithmElementLabel ??
                throw new ArgumentNullException(Path + nameof(InvertedByExtendedEucledianAlgorithmElementLabel));

            set => _invertedByExtendedEucledianAlgorithmElementLabel = value;
        }

        #endregion

        #region Public methods

        public void ParseElement(string elementString)
        {
            if (!BigInteger.TryParse(elementString, out var firstFactor))
            {
                Model.Element = null;
                return;
            }
            try
            {
                Model.Element = new GF256Element(new BinaryPolynomial(firstFactor));
            }
            catch (ArgumentException)
            {
                Model.Element = null;
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
            Model.ElementChanged += new Action<string>((elementString) =>
            {
                ElementLabel.Invoke((MethodInvoker)(() =>
                {
                    ElementLabel.Text = elementString;
                }));
            });
            Model.ModuloChanged += new Action<string>((moduloString) =>
            {
                ModuloLabel.Invoke((MethodInvoker)(() =>
                {
                    ModuloLabel.Text = moduloString;
                }));
            });
            Model.InvertedByPotentiationMethodElementChanged += new Action<string>((invertedByPotentiationMethodElementString) =>
            {
                InvertedByPotentiationMethodElementLabel.Invoke((MethodInvoker)(() =>
                {
                    InvertedByPotentiationMethodElementLabel.Text = invertedByPotentiationMethodElementString;
                }));
            });
            Model.InvertedByExtendedEucledianAlgorithmElementChanged += new Action<string>((invertedByExtendedEucledianAlgorithmElementString) =>
            {
                InvertedByExtendedEucledianAlgorithmElementLabel.Invoke((MethodInvoker)(() =>
                {
                    InvertedByExtendedEucledianAlgorithmElementLabel.Text = invertedByExtendedEucledianAlgorithmElementString;
                }));
            });
            Model.Initialize();
        }

        #endregion

    }

}