# 🧮  Dinamik Hesap Makinesi (C# WinForms)

Bu proje, **2. Sınıf "Programlama II"** dersimde gördüğüm nesne yönelimli programlama (OOP) ve form mimarisi konularından hareketle geliştirdiğim öğretici bir temel uygulamadır. Dışarıdan bakıldığında standart bir hesap makinesi gibi görünse de, projenin en büyük özelliği standart "sürükle-bırak" (Designer) mantığıyla **yapılmamış** olmasıdır. 

Tüm arayüz (UI) bileşenleri, butonlar ve olaylar (events) tamamen arka planda dinamik C# kodlarıyla programatik olarak oluşturulmuştur. Bu yönüyle başlangıç seviyesi bir projeden ziyade, form elemanlarının arka planda nasıl çalıştığını kavratan eğitici bir pratik niteliğindedir.

## 🚀 Proje Vurguları ve Mimari Yaklaşım
- **Dinamik UI Üretimi:** Arayüzdeki hiçbir buton statik değildir; çalışma zamanında (runtime) boyut, renk, konum ve font özellikleri verilerek nesne yönelimli bir yaklaşımla ekrana çizdirilir.
- **Temiz Kod (Clean Code) ve DRY Prensibi:** Tekrarlayan kod blokları yerine, parametrik yardımcı metodlar (helper methods) kullanılarak kod satır sayısı optimize edilmiş ve kod okunabilirliği artırılmıştır.
- **Gelişmiş Hata Yönetimi (Error Handling):** Sıfıra bölme, negatif sayıların karekökü veya faktöriyeli gibi matematiksel hatalar `try-catch` blokları ve `TryParse` metodlarıyla güvenli bir şekilde yakalanır, uygulamanın çökmesi engellenir.

## 🛠️ Özellikler

Standart dört işlemin yanı sıra, özel matematiksel fonksiyonlar içerir:
- **Temel Matematik:** Toplama, Çıkarma, Çarpma, Bölme
- **Gelişmiş İşlemler:**
  - `x^y` (Üs Alma)
  - `√x` (Karekök Hesaplama)
  - `n!` (Faktöriyel Hesaplama)
  - `Logaritma` (İstenilen tabanda ve değerde hesaplama)
  - `Asal Kontrolü` (Girilen sayının asal olup olmadığını denetleme)
- **İşlem Özeti (Log):** Yapılan tüm işlemleri hafızada tutar ve "Özet" butonuna tıklandığında geçmişi listeler.

## 💻 Kullanılan Teknolojiler
- **Dil:** C#
- **Platform:** .NET Framework / Windows Forms (WinForms)
- **IDE:** Visual Studio 2022

## ⚙️ Kurulum ve Çalıştırma

Projeyi kendi bilgisayarınızda denemek için:

1. Bu depoyu (repository) klonlayın:
   ```bash
   git clone [https://github.com/ozlemocall/Csharp-Dynamic-Calculator.git](https://github.com/ozlemocall/Csharp-Dynamic-Calculator.git)
