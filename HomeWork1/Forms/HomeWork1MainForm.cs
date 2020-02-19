using System;
using System.ComponentModel;
using System.Windows.Forms;

using HomeWork1.Presenters;

using MVP.Presenter;

namespace HomeWork1.Forms
{

    internal partial class HomeWork1MainForm : Form
    {

        #region Fields

        private PresenterBase[] _presenters;

        #endregion

        #region Constructors

        public HomeWork1MainForm()
        {
            InitializeComponent();
            Presenters = new PresenterBase[5]
            {
                new HomeWork1MainFormPresenter()
                , new PrimesTaskPresenter
                {
                    Task1PrimesTextBox = task1PrimesTextBox
                }
                , new ReducedResidueSystemTaskPresenter
                {
                    Task2ReducedResidueSystemTextBox = task2ReducedResidueSystemElementsTextBox
                }
                , new EulerFunctionTaskPresenter
                {
                    Task3EulerFunctionValueLabel = task3EulerFunctionValueLabel
                }
                , new DiscreteLogarithmTaskPresenter
                {
                    Task4XValueLabel = task4XValueLabel
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

        private HomeWork1MainFormPresenter HomeWork1MainFormPresenter =>
            Presenters[0] as HomeWork1MainFormPresenter;

        private PrimesTaskPresenter PrimesTaskPresenter =>
            Presenters[1] as PrimesTaskPresenter;

        private ReducedResidueSystemTaskPresenter ReducedResidueSystemTaskPresenter =>
            Presenters[2] as ReducedResidueSystemTaskPresenter;

        private EulerFunctionTaskPresenter EulerFunctionTaskPresenter =>
            Presenters[3] as EulerFunctionTaskPresenter;

        private DiscreteLogarithmTaskPresenter DiscreteLogarithmTaskPresenter =>
            Presenters[4] as DiscreteLogarithmTaskPresenter;

        #endregion

        #region Event handlers

        private void HomeWork1Form_Load(object sender, EventArgs e)
        {
            foreach (var presenter in Presenters)
            {
                presenter.Initialize();
            }
        }

        private void HomeWork1Form_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            HomeWork1MainFormPresenter.ShowAboutDialog(this, e);
        }

        private void task1MValueTextBox_TextChanged(object sender, EventArgs e)
        {
            PrimesTaskPresenter.ParseM((sender as TextBox).Text);
        }

        private void task2MValueTextBox_TextChanged(object sender, EventArgs e)
        {
            ReducedResidueSystemTaskPresenter.ParseM((sender as TextBox).Text);
        }

        private void task3MValueTextBox_TextChanged(object sender, EventArgs e)
        {
            EulerFunctionTaskPresenter.ParseM((sender as TextBox).Text);
        }

        private void task4GValueTextBox_TextChanged(object sender, EventArgs e)
        {
            DiscreteLogarithmTaskPresenter.ParseG((sender as TextBox).Text);
        }

        private void task4AValueTextBox_TextChanged(object sender, EventArgs e)
        {
            DiscreteLogarithmTaskPresenter.ParseA((sender as TextBox).Text);
        }

        private void task4BValueTextBox_TextChanged(object sender, EventArgs e)
        {
            DiscreteLogarithmTaskPresenter.ParseB((sender as TextBox).Text);
        }

        #endregion

    }

}