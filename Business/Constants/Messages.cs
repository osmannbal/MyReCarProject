using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarsListed = "Arabalar listelendi.";
        public static string CarAdded = "Araba eklendi.";
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarNameInvalid = "Araba ismi geçersiz.";
        public static string CarDailyPriceInvalid = "Günlük fiyat 0'dan büyük olmalıdır.";

        public static string BrandsListed = "Markalar listelendi.";
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string BrandDeleted = "Marka silindi.";

        public static string ColorsListed = "Renkler listelendi.";
        public static string ColorAdded = "Renk eklendi.";
        public static string ColorUpdated = "Renk güncellendi.";
        public static string ColorDeleted = "Renk silindi.";

        public static string RentalsListed = "Kiralık listesi listelendi.";
        public static string CarRented = "Araba kiralandı.";
        public static string RentalUpdated = "Kiralama işlemi güncellendi.";
        public static string RentalDeleted = "Kiralama işlemi silindi.";
        public static string CarReceived = "Ödeme sayfasına yönlendiriliyorsunuz.";
        public static string CarReceivedError = "Araba teslim alınmamış kiralama işlemi başarısız.";

        public static string UsersListed = "Kullanıcılar listelendi.";
        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UserDeleted = "Kullanıcı silindi.";

        public static string CustomersListed = "Müşteriler listelendi.";
        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomerDeleted = "Müşteri silindi.";

        public static string CarImagesListed = "Araba görüntüleri listelendi.";
        public static string CarImagesAdded = "Araba görüntüsü eklendi.";
        public static string CarImagesUpdated = "Araba görüntüsü güncellendi.";
        public static string CarImagesDeleted = "Araba görüntüsü silindi.";
        public static string CarImagesLimitedExceded = "Arabanın görüntü sayısı 5'den fazla olamaz!";

        public static string MaintenanceTime = "Sistem bakımda.";

        public static string UserNotFound = "Kullanıcı bulunamadı.";

        public static string PasswordError = "Şifre hatalı.";

        public static string SuccessfulLogin = "Sisteme giriş başarılı.";

        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";

        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi.";

        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu.";

        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string PaymentCompleted = "Ödeme tamamlandı.";
        public static string PaymentError = "Ödeme başarısız.";
    }
}
