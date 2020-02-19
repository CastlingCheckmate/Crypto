using System;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

using Extensions.BigIntegerExtensions;

using MVP.Presenter;

using HomeWork4.Models;

namespace HomeWork4.Presenters
{

    internal sealed class IrreduciblePolynomialSelectorPresenter : PresenterBase
    {

        #region Control fields

        private ComboBox _irreduciblePolynomialComboBox;
        private Label _loseFocusFromIrreduciblePolynomialComboBoxLabel;

        #endregion

        #region Constructors

        public IrreduciblePolynomialSelectorPresenter()
            : base(new IrreduciblePolynomialSelectorModel()
                  , "HomeWork4.Presenters.IrreduciblePolynomialSelectorPresenter.")
        {

        }

        #endregion

        #region Properties

        internal new IrreduciblePolynomialSelectorModel Model =>
            base.Model as IrreduciblePolynomialSelectorModel;

        #endregion

        #region Control properties

        public ComboBox IrreduciblePolynomialComboBox
        {
            private get => _irreduciblePolynomialComboBox ??
                throw new ArgumentNullException(Path + nameof(IrreduciblePolynomialComboBox));

            set => _irreduciblePolynomialComboBox = value;
        }

        public Label LoseFocusFromIrreduciblePolynomialComboBoxLabel
        {
            private get => _loseFocusFromIrreduciblePolynomialComboBoxLabel ??
                throw new ArgumentNullException(Path + nameof(LoseFocusFromIrreduciblePolynomialComboBoxLabel));

            set => _loseFocusFromIrreduciblePolynomialComboBoxLabel = value;
        }

        #endregion

        #region Public methods

        public void SetSelectedIrreduciblePolynomialIndex(byte selectedIrreduciblePolynomialIndex)
        {
            Model.SelectedIrreduciblePolynomialIndex = selectedIrreduciblePolynomialIndex;
        }

        public void CancelSettingSelectedIrreduciblePolynomial()
        {
            Model.ResetSelectedIrreduciblePolynomialIndex();
        }

        #endregion

        #region PresenterBase class abstract methods implementation

        public override void Initialize()
        {
            Model.IrreduciblePolynomialsCreated += new Action<byte[]>(irreduciblePolynomials =>
            {
                IrreduciblePolynomialComboBox.Invoke((MethodInvoker)(() =>
                {
                    IrreduciblePolynomialComboBox.Items.AddRange(irreduciblePolynomials
                        .Select(p =>
                        {
                            var result = new StringBuilder();
                            for (var i = 0; i <= 8; i++)
                            {
                                if (((p >> i) & 1) == 0)
                                {
                                    continue;
                                }
                                switch (i)
                                {
                                    case 0:
                                        result.Append("1 ");
                                        break;
                                    case 1:
                                        result.Append("x ");
                                        break;
                                    default:
                                        result.Append($"x{((BigInteger)i).ToSuperscriptString()} ");
                                        break;
                                }
                            }
                            if (result.Length == 0)
                            {
                                result.Append("0");
                            }
                            result.Append($"x{((BigInteger)8).ToSuperscriptString()} ");
                            return "< " + string.Join(" + ", result.ToString()
                                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Reverse()) + " >";

                        })
                        .ToArray());
                }));
            });
            Model.SelectedIrreduciblePolynomialIndexChanged += new Action<byte>(selectedIrreduciblePolynomialIndex =>
            {
                IrreduciblePolynomialComboBox.Invoke((MethodInvoker)(() =>
                {
                    IrreduciblePolynomialComboBox.SelectedIndex = selectedIrreduciblePolynomialIndex;
                }));
                LoseFocusFromIrreduciblePolynomialComboBoxLabel.Invoke((MethodInvoker)(() =>
                {
                    LoseFocusFromIrreduciblePolynomialComboBoxLabel.Focus();
                }));
            });
            Model.Initialize();
        }

        #endregion

    }

}