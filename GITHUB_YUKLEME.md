# GitHub'a Yükleme Talimatları

## Yöntem 1: Visual Studio'dan (Önerilen)

1. **Visual Studio'da projeyi açın**
2. **Solution Explorer**'da projeye sağ tıklayın
3. **Add > Add to Source Control** seçeneğini seçin
4. **Git** sekmesine gidin
5. **Create Git Repository** butonuna tıklayın
6. **View > Git Changes** menüsünden Git penceresini açın
7. **Commit** butonuna tıklayın ve commit mesajı girin: "Initial commit: MultiLangTranslator Windows Forms Application"
8. **GitHub** sekmesine gidin
9. **Publish to GitHub** butonuna tıklayın
10. GitHub hesabınızla giriş yapın ve repository adını girin: `MultiLangTranslator`
11. **Publish** butonuna tıklayın

## Yöntem 2: Komut Satırından

### Adım 1: Proje Klasörüne Git
```powershell
cd "C:\Users\OGUZHAN\OneDrive\Desktop\Yeni klasör (2)\cokludilceviriapp"
```

### Adım 2: Git Repository Başlat
```powershell
git init
```

### Adım 3: Dosyaları Ekle
```powershell
git add .
```

### Adım 4: İlk Commit
```powershell
git commit -m "Initial commit: MultiLangTranslator Windows Forms Application"
```

### Adım 5: GitHub'da Yeni Repository Oluştur
1. GitHub.com'a gidin
2. Sağ üstteki **+** butonuna tıklayın
3. **New repository** seçin
4. Repository adı: `MultiLangTranslator`
5. **Public** veya **Private** seçin
6. **Initialize this repository with a README** seçeneğini işaretlemeyin
7. **Create repository** butonuna tıklayın

### Adım 6: Remote Ekle ve Push
GitHub'da oluşturduğunuz repository'nin URL'ini kopyalayın (örn: `https://github.com/kullaniciadi/MultiLangTranslator.git`)

```powershell
git remote add origin https://github.com/KULLANICI_ADINIZ/MultiLangTranslator.git
git branch -M main
git push -u origin main
```

## Önemli Notlar

- `.gitignore` dosyası zaten oluşturuldu, bu yüzden `bin/` ve `obj/` klasörleri otomatik olarak ignore edilecek
- Eğer GitHub hesabınızda iki faktörlü kimlik doğrulama varsa, Personal Access Token kullanmanız gerekebilir
- İlk push'tan sonra GitHub'da tüm dosyalarınızı görebilirsiniz

## Sorun Giderme

### "fatal: pathspec did not match any files" Hatası
- Proje klasörüne doğru şekilde gittiğinizden emin olun
- `git status` komutuyla hangi dosyaların takip edildiğini kontrol edin

### "Permission denied" Hatası
- Git repository'sinin kullanıcı klasöründe değil, proje klasöründe olduğundan emin olun
- Proje klasörüne gidip `git init` komutunu tekrar çalıştırın

