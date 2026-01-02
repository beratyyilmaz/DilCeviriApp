# Kurulum Notları

## Önemli Bilgiler

Bu proje **.NET Framework 4.7.2** kullanmaktadır. Tüm gerekli referanslar framework'ün bir parçasıdır ve **otomatik olarak yüklenir**.

## Gerekli Referanslar

Projede kullanılan referanslar:
- `System.Web.Extensions` - JavaScriptSerializer için (JSON parsing)
- `System.Net.Http` - HttpClient için (API çağrıları)

Bu referanslar **.NET Framework 4.7.2'nin bir parçasıdır** ve ekstra indirme gerektirmez.

## Visual Studio'da Projeyi Açma

1. Visual Studio'yu açın
2. `File > Open > Project/Solution` menüsünden `MultiLangTranslator.csproj` dosyasını seçin
3. Visual Studio projeyi yüklediğinde, referanslar otomatik olarak tanınacaktır

## Eğer Referans Hatası Alırsanız

Eğer `System.Web.Extensions` veya `System.Net.Http` için hata alırsanız:

1. **Solution Explorer**'da projeye sağ tıklayın
2. **Add > Reference** seçeneğini seçin
3. **Assemblies > Framework** bölümünden şunları seçin:
   - `System.Web.Extensions`
   - `System.Net.Http`
4. **OK** butonuna tıklayın

## Sistem Gereksinimleri

- Windows 7 veya üzeri
- .NET Framework 4.7.2 veya üzeri (Windows 10'da genellikle yüklü gelir)
- Visual Studio 2017 veya üzeri (veya uyumlu IDE)

## Not

Bu proje **NuGet paketleri gerektirmez**. Tüm bağımlılıklar .NET Framework'ün standart kütüphaneleridir.

