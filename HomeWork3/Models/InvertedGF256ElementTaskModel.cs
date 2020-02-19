using System;
using System.Threading;
using System.Threading.Tasks;

using Cryptography.HomeWork3;

using MVP.Model;

namespace HomeWork3.Models
{

    internal sealed class InvertedGF256ElementTaskModel : ModelBase, IDisposable
    {

        #region Fields

        private GF256Element _element;
        private GF256Modulo _modulo;

        #endregion

        #region Constructors

        public InvertedGF256ElementTaskModel()
            : base("HomeWork3.Models.")
        {

        }

        #endregion

        #region Properties
        // TODO: not used yet[2]
        // TODO: move idisposable to MVP lib
        private CancellationTokenSource InvertByPotentiationMethodTaskGrave
        {
            get;

            set;
        }

        private CancellationTokenSource InvertByExtendedEucledianAlgorithmTaskGrave
        {
            get;

            set;
        }

        public GF256Element Element
        {
            private get => _element;

            set
            {
                _element = value;
                ElementChanged?.Invoke(Element?.ToString(true) ?? string.Empty);
                Invert();
            }
        }

        public GF256Modulo Modulo
        {
            private get => _modulo;

            set
            {
                _modulo = value;
                ModuloChanged?.Invoke(Modulo?.ToString(true) ?? string.Empty);
                Invert();
            }
        }

        #endregion

        #region Private methods

        private async void Invert()
        {
            if (Element == null || Modulo == null)
            {
                InvertedByPotentiationMethodElementChanged?.Invoke(string.Empty);
                InvertedByExtendedEucledianAlgorithmElementChanged?.Invoke(string.Empty);
                return;
            }
            // TODO: is modulo an irreducible polynomial?
            // TODO: refactor names (main form + model & presenter)
            InvertedByPotentiationMethodElementChanged?.Invoke((await Task<GF256Element>.Factory.StartNew(() =>
                GF256Element.MultiplicativeInvertedByPotentiation(Element, Modulo)
            )).ToString(true));
            InvertedByExtendedEucledianAlgorithmElementChanged?.Invoke((await Task<GF256Element>.Factory.StartNew(() =>
                GF256Element.MultiplicativeInvertedByExtendedEuclideanAlgorithm(Element, Modulo)
            )).ToString(true));
        }

        #endregion

        #region Events

        public event Action<string> ElementChanged;
        public event Action<string> ModuloChanged;
        public event Action<string> InvertedByPotentiationMethodElementChanged;
        public event Action<string> InvertedByExtendedEucledianAlgorithmElementChanged;

        #endregion

        #region ModelBase abstract methods implementation

        public override void Initialize()
        {
            ElementChanged?.Invoke(string.Empty);
            ModuloChanged?.Invoke(string.Empty);
            InvertedByPotentiationMethodElementChanged?.Invoke(string.Empty);
            InvertedByExtendedEucledianAlgorithmElementChanged?.Invoke(string.Empty);
        }

        #endregion

        #region IDisposable interface implementation

        public override void Dispose()
        {
            InvertByPotentiationMethodTaskGrave?.Dispose();
            InvertByExtendedEucledianAlgorithmTaskGrave?.Dispose();
        }

        #endregion

    }

}