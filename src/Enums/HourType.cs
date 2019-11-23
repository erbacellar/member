using System.ComponentModel;

namespace CashInBox.Enums
{
    public enum HourType
    {
        [Description("Manhã")]
        MANHA = 0,
        [Description("Tarde")]
        TARDE = 1,
        [Description("Noite")]
        NOITE = 2,
    }
}
