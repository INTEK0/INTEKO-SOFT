using System.ComponentModel;

namespace İNTEKO.Enums
{
    public class EnumsOperation
    {
        public enum Month
        {
            Yanvar = 1,
            Fevral,
            Mart,
            Aprel,
            May,
            İyun,
            İyul,
            Avqust,
            Sentyabr,
            Oktyabr,
            Noyabr,
            Dekabr
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
            [Description("Ödənilib")]
            Paid,
            [Description("Ödənilməyib")]
            NotPaid,
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
