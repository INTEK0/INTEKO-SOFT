using System.ComponentModel;

namespace İNTEKO.Enums
{
    public class EnumsOperation
    {
        public enum Month
        {
            Yanvar = 1,
            Fevral = 2,
            Mart = 3,
            Aprel = 4,
            May = 5,
            İyun = 6,
            İyul = 7,
            Avqust = 8,
            Sentyabr = 9,
            Oktyabr = 10,
            Noyabr = 11,
            Dekabr = 12
        }

        public enum Operation
        {
            Add,
            Edit,
            Show,
            Payment,
            Remove
        }

        public enum StatusType
        {
            [Description("Aktiv")]
            Active,
            [Description("Deaktiv")]
            Deactive,
        }

        public enum Roles
        {
            ADMİN,
            SUPPORT,
            MENECER
        }

        public enum ButtonTextName
        {
            [Description("Əlavə et")]
            Add,
            [Description("Düzəliş et")]
            Edit,
            [Description("Yadda saxla")]
            Save,
            [Description("Ödəniş et")]
            Payment,
            [Description("Bağla")]
            Close,
            [Description("Aktiv et")]
            Activate,
            [Description("Deaktiv et")]
            Deactivate,
        }
    }
}
