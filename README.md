# MultiLangTranslator

Çoklu dil çeviri uygulaması - Windows Forms ile geliştirilmiş .NET Framework 4.7.2 uygulaması.

## Özellikler

- Modern ve kullanıcı dostu arayüz
- 6 farklı dil desteği (İngilizce, Türkçe, Almanca, Fransızca, İspanyolca, İtalyanca)
- MyMemory API kullanarak ücretsiz çeviri hizmeti
- Async/await ile UI donması olmadan çeviri işlemi
- Kapsamlı hata yönetimi

## Gereksinimler

- .NET Framework 4.7.2 veya üzeri
- Visual Studio 2017 veya üzeri (veya uyumlu IDE)
- İnternet bağlantısı (API çağrıları için)

## Kurulum

1. Projeyi Visual Studio'da açın
2. Gerekli referanslar otomatik olarak yüklenir (System.Web.Extensions, System.Net.Http)
3. Projeyi derleyin ve çalıştırın

## Kullanım

1. Kaynak dili seçin (sol üst ComboBox)
2. Çevrilecek metni girin (sol alt TextBox)
3. Hedef dili seçin (sağ üst ComboBox)
4. "Çevir" butonuna tıklayın
5. Çeviri sonucu sağ alt TextBox'ta görüntülenecektir

## API Bilgisi

Bu uygulama MyMemory Translation API kullanmaktadır:
- Ücretsiz kullanım için API anahtarı gerekmez
- Küçük çaplı kullanım için yeterlidir
- API dokümantasyonu: https://mymemory.translated.net/doc/spec.php

## Proje Yapısı

- `Form1.cs` - Ana form ve UI mantığı
- `Form1.Designer.cs` - Form tasarımı
- `TranslationService.cs` - API çağrıları ve çeviri servisi
- `Program.cs` - Uygulama giriş noktası

## Notlar

- Tüm kodlar Türkçe yorumlarla açıklanmıştır
- Hata durumlarında kullanıcıya MessageBox ile bilgi verilir
- Aynı dil seçildiğinde uyarı mesajı gösterilir

