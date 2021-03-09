using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string SuccessMessage = "İslem basariyla gerceklestirildi.";
        public static string ErrorMessage = "İslem gerceklestirilemedi.";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarImageLimitExceeded = "Araba Görüntü Sınırı Aşıldı";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
