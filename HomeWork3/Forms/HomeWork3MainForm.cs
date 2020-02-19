using System;
using System.ComponentModel;
using System.Windows.Forms;

using HomeWork3.Presenters;

using MVP.Presenter;

namespace HomeWork3.Forms
{

    public partial class HomeWork3MainForm : Form
    {

        #region Fields

        private PresenterBase[] _presenters;

        #endregion

        #region Constructors

        public HomeWork3MainForm()
        {
            InitializeComponent();
            Presenters = new PresenterBase[5]
            {
                new HomeWork3MainFormPresenter()
                , new GF256ElementToStringTaskPresenter
                {
                    ElementLabel = GF256ElementToStringTaskElementValuePolynomialRepresentationLabel
                }
                , new BinaryPolynomialsMultiplicationTaskPresenter
                {
                    FirstFactorLabel = binaryPolynomialsMultiplicationTaskFirstFactorValuePolynomialRepresentationLabel
                    , SecondFactorLabel = binaryPolynomialsMultiplicationTaskSecondFactorValuePolynomialRepresentationLabel
                    , MultiplicationResultLabel = binaryPolynomialsMultiplicationTaskMultiplicationResultValuePolynomialRepresentationLabel
                }
                , new GF256ElementsMultiplicationTaskPresenter
                {
                    FirstFactorLabel = GF256ElementsMultiplicationTaskFirstFactorValuePolynomialRepresentationLabel
                    , SecondFactorLabel = GF256ElementsMultiplicationTaskSecondFactorValuePolynomialRepresentationLabel
                    , ModuloLabel = GF256ElementsMultiplicationTaskModuloValuePolynomialRepresentationLabel
                    , MultiplicationResultLabel = GF256ElementsMultiplicationTaskMultiplicationResultValuePolynomialRepresentationLabel
                }
                , new InvertedGF256ElementTaskPresenter
                {
                    ElementLabel = invertedGF256ElementTaskElementValuePolynomialRepresentationLabel
                    , ModuloLabel = invertedGF256ElementTaskModuloValuePolynomialRepresentationLabel
                    , InvertedByPotentiationMethodElementLabel = invertedGF256ElementTaskInvertedByPotentiationMethodElementValuePolynomialRepresentationLabel
                    , InvertedByExtendedEucledianAlgorithmElementLabel = invertedGF256ElementTaskInvertedByAdvancedEuclideanAlgorithmElementValuePolynomialRepresentationLabel
                }
            };
        }

        #endregion

        #region Properties

        private PresenterBase[] Presenters
        {
            get => _presenters;

            set => _presenters = value;
        }

        private HomeWork3MainFormPresenter HomeWork3MainFormPresenter =>
            Presenters[0] as HomeWork3MainFormPresenter;

        private GF256ElementToStringTaskPresenter GF256ElementToStringTaskPresenter =>
            Presenters[1] as GF256ElementToStringTaskPresenter;

        private BinaryPolynomialsMultiplicationTaskPresenter BinaryPolynomialsMultiplicationTaskPresenter =>
            Presenters[2] as BinaryPolynomialsMultiplicationTaskPresenter;

        private GF256ElementsMultiplicationTaskPresenter GF256ElementsMultiplicationTaskPresenter =>
            Presenters[3] as GF256ElementsMultiplicationTaskPresenter;

        private InvertedGF256ElementTaskPresenter InvertedGF256ElementTaskPresenter =>
            Presenters[4] as InvertedGF256ElementTaskPresenter;

        #endregion

        #region Event handlers

        private void HomeWork3Form_Load(object sender, EventArgs e)
        {
            foreach (var presenter in Presenters)
            {
                presenter.Initialize();
            }
        }

        private void HomeWork3Form_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            //HomeWork3MainFormPresenter.ShowAboutDialog(this, e);
        }

        private void GF256ElementToStringTaskElementValueTextBox_TextChanged(object sender, EventArgs e)
        {
            GF256ElementToStringTaskPresenter.ParseElement((sender as TextBox).Text);
        }

        private void binaryPolynomialsMultiplicationTaskFirstFactorValueTextBox_TextChanged(object sender, EventArgs e)
        {
            BinaryPolynomialsMultiplicationTaskPresenter.ParseFirstFactor((sender as TextBox).Text);
        }

        private void binaryPolynomialsMultiplicationTaskSecondFactorValueTextBox_TextChanged(object sender, EventArgs e)
        {
            BinaryPolynomialsMultiplicationTaskPresenter.ParseSecondFactor((sender as TextBox).Text);
        }

        private void GF256ElementsMultiplicationTaskFirstFactorValueTextBox_TextChanged(object sender, EventArgs e)
        {
            GF256ElementsMultiplicationTaskPresenter.ParseFirstFactor((sender as TextBox).Text);
        }

        private void GF256ElementsMultiplicationTaskSecondFactorValueTextBox_TextChanged(object sender, EventArgs e)
        {
            GF256ElementsMultiplicationTaskPresenter.ParseSecondFactor((sender as TextBox).Text);
        }

        private void GF256ElementsMultiplicationTaskModuloValueTextBox_TextChanged(object sender, EventArgs e)
        {
            GF256ElementsMultiplicationTaskPresenter.ParseModulo((sender as TextBox).Text);
        }

        private void invertedGF256ElementTaskElementValueTextBox_TextChanged(object sender, EventArgs e)
        {
            InvertedGF256ElementTaskPresenter.ParseElement((sender as TextBox).Text);
        }

        private void invertedGF256ElementTaskModuloValueTextBox_TextChanged(object sender, EventArgs e)
        {
            InvertedGF256ElementTaskPresenter.ParseModulo((sender as TextBox).Text);
        }

        #endregion

    }

}