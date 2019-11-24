using System.ComponentModel;

namespace Member.Common.Enums
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
