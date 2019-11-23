using System.ComponentModel;

namespace CashInBox.Enums
{
    public enum PhoneType
    {
        [Description("Comercial")]
        COMERCIAL = 0,
        [Description("Celular")]
        CELULAR = 1,
        [Description("Residencial")]
        RESIDENCIAL = 2,
    }
}
