using System;

using Cryptography.HomeWork3;

using MVP.Model;

namespace HomeWork3.Models
{

    internal sealed class GF256ElementToStringTaskModel : ModelBase
    {

        #region Fields

        GF256Element _element;

        #endregion

        #region Constructors

        public GF256ElementToStringTaskModel()
            : base("HomeWork3.Models.")
        {

        }

        #endregion

        #region Properties

        public GF256Element Element
        {
            get => _element;

            set
            {
                _element = value;
                ElementChanged?.Invoke(Element.ToString(true));
            }
        }

        #endregion

        #region Events

        public event Action<string> ElementChanged;

        #endregion

        #region ModelBase abstract methods implementation

        public override void Initialize()
        {
            ElementChanged?.Invoke(string.Empty);
        }

        #endregion

    }

}