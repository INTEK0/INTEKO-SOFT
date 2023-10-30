using İNTEKO.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İNTEKO.Messages
{
    public static class CustomerMessages
    {
        public static readonly string CUSTOMER_ADDED = "Müştəri yaradıldı";
        public static readonly string CUSTOMER_DELETED = "Müştəri silindi";
        public static readonly string CUSTOMER_STATUS_ACTIVATING = "Müştəri statusu aktiv edildi";
        public static readonly string CUSTOMER_STATUS_DEACTIVATING = "Müştəri statusu deaktiv edildi";
        public static readonly string LICENCE_KEY_NULL = "Lisenziya mövcud deyil";
        public static readonly string LICENCE_ACTIVATING = "Lisenziya aktiv edildi";
        public static readonly string LICENCE_DEACTIVATING = "Lisenziya deaktiv edildi";
        public static readonly string LICENCE_STATUS_CONTROL = "Lisenziya statusu sistemdən kontrol edildi";
        public static readonly string LICENCE_KEY_COPY = "Lisenziya açarı kopyalandı";

        //Validations
        public static readonly string NAME_SURNAME_NOT_FOUND = "Ad soyadı daxil edin";
        public static readonly string COMPANY_NAME_NOT_FOUND = "Şirkət adını daxil edin";
        public static readonly string VOEN_NOT_FOUND = "Vöen nömrəsini daxil edin";
        public static readonly string COMPANY_CODE_NOT_FOUND = "Obyekt kodunu daxil edin";
        public static readonly string PHONE_NUMBER_NOT_FOUND = "Telefon nömrəsini daxil edin";
        public static readonly string CITY_NOT_FOUND = "Şəhər seçimi etmədiniz !";
        public static readonly string AREA_NOT_FOUND = "Rayon seçimi etmədiniz !";
        public static readonly string ADDRESS_NOT_FOUND = "Ünvanı daxil edin";
        public static readonly string REGISTERED_DATE_NOT_FOUND = "Qeydiyyat tarixini seçmədiniz";
        public static readonly string CONTRACTNO_NOT_FOUND = "Müqavilə nömrəsini daxil edin";
        public static readonly string KASSA_MODEL_NOT_FOUND = "Kassa modelini seçin";
        public static readonly string KASSA_SERIAL_NUMBER_NOT_FOUND = "Kassanın seriya nömrəsini daxil edin";
        public static readonly string PAYMENT_TYPE_NOT_FOUND = "Ödəniş növünü seçin";
        public static readonly string REGISTER_PRICE_NOT_FOUND = "Yazılma qiymətini daxil edin";
        public static readonly string SUPPORT_PRICE_NOT_FOUND = "Servis qiymətini daxil edin";
    }
}
