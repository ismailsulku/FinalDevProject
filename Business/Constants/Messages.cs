using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bu Kategoride Ürün Sayısı Fazla";
        public static string ProductNameAlreadyExists = "Bu isimde başka bir ürün var";
        public static string CategoryLimitedExceded = "Kategori limiti aşıldığı için eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered { get; internal set; }
        public static User UserNotFound { get; internal set; }
        public static User PasswordError { get; internal set; }
        public static string SuccessfulLogin { get; internal set; }
        public static string UserAlreadyExists { get; internal set; }
        public static string AccessTokenCreated { get; internal set; }
    }
}
