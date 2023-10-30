using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İNTEKO.Messages
{
    public static class PaymentMessage
    {
        public static readonly string PAYMENT_ADDED = "Ödəniş yaradıldı";
        public static readonly string PAYMENT_EDIT = "Ödənişdə düzəliş edildi";
        public static readonly string PAYMENT_DELETE = "Ödəniş silindi";
        public static readonly string PAYMENT_COMPLETED = "Ödəniş edildi";
        public static readonly string DOCUMENT_NOT_NUMBER = "Qaimə nömrəsi daxil edilmədi";

        //Validation
        public static readonly string CUSTOMER_NAME_NOT_FOUND = "Müştəri adını daxil edin";
        public static readonly string VOEN_NOT_FOUND = "Vöen daxil edin";
        public static readonly string CONTRACT_NUMBER_NOT_FOUND = "Müqavilə nömrəsini daxil edin";
        public static readonly string PRICE_NOT_FOUND = "Məbləği daxil edin";
        public static readonly string DATE_NOT_FOUND = "Ödəniş tarixini qeyd edin";
    }
}
