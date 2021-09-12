using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constant
{
    public class Messages
    {
        public static string Addeded = "Ürün eklendi";
        public static string Deleted = "Ürün silindi";
        public static string Updated = "Ürün güncellendi";
        public static string CarNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string Listed = "Ürünler listelendi";
        public static string CarImageLimitExceded="Bir Arabanın en fazla 5 resmi olabilir";
        public static string CarImageNotFound="CarImage bulunamadı";
        public static string UserUpdated = "Başarıyla güncellendi";
        public static string GetConsumer = "Nesne getirildi";
        public static string ConsumerDeleted = "Başarıyla silindi";
        public static string ConsumerAdded = "Başarıyla eklendi";
        public const string AddedSuccess = "Başarıyla eklendi";
        public const string UpdatedSuccess = "Başarıyla güncellendi";
        public const string DeletedSuccess = "Başarıyla silindi";
        public const string GetItem = "Nesne getirildi";
        public const string ItemsListed = "Nesneler listelendi";
        public const string UserNotFound = "Böyle bir kullanıcı yok.";
        public const string PasswordError = "Hatalı şifre.";
        public const string SuccessfulLogin = "Giriş başarılı.";
        public const string UserAlreadyExists = "Kullanıcı zaten mevcut.";
        public const string AccessTokenCreated = "Access token oluşturuldu.";
        public const string UserRegistered = "Kullanıcı başarıyla kaydedildi.";
        public const string AuthorizationDenied = "Yetkiniz yok.";
        //////////////////////////////////////////////////////////////////////////////////////////


    }
}
