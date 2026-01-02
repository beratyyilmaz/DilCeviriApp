using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiLangTranslator
{
    /// <summary>
    /// Ana form sınıfı - Çoklu dil çeviri uygulaması
    /// </summary>
    public partial class Form1 : Form
    {
        private TranslationService translationService;

        /// <summary>
        /// Form constructor - Form başlatıldığında çalışır
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            translationService = new TranslationService();
            InitializeLanguages();
        }

        /// <summary>
        /// ComboBox'ları dillerle doldurur
        /// </summary>
        private void InitializeLanguages()
        {
            // Kaynak ve hedef dil ComboBox'larına dilleri ekle
            string[] languages = { "İngilizce", "Türkçe", "Almanca", "Fransızca", "İspanyolca", "İtalyanca" };
            
            comboBoxSourceLanguage.Items.AddRange(languages);
            comboBoxTargetLanguage.Items.AddRange(languages);
            
            // Varsayılan olarak İngilizce ve Türkçe seçili
            comboBoxSourceLanguage.SelectedIndex = 0; // İngilizce
            comboBoxTargetLanguage.SelectedIndex = 1; // Türkçe
        }

        /// <summary>
        /// Çeviri butonuna tıklandığında çalışır
        /// Async metod kullanarak UI'ı dondurmadan API çağrısı yapar
        /// </summary>
        private async void btnTranslate_Click(object sender, EventArgs e)
        {
            // Kullanıcı girişini kontrol et
            if (string.IsNullOrWhiteSpace(textBoxInput.Text))
            {
                MessageBox.Show("Lütfen çevrilecek metni giriniz!", "Uyarı", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Dil seçimlerini kontrol et
            if (comboBoxSourceLanguage.SelectedItem == null || 
                comboBoxTargetLanguage.SelectedItem == null)
            {
                MessageBox.Show("Lütfen kaynak ve hedef dilleri seçiniz!", "Uyarı", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aynı dili seçmişse uyarı ver
            if (comboBoxSourceLanguage.SelectedIndex == comboBoxTargetLanguage.SelectedIndex)
            {
                MessageBox.Show("Kaynak ve hedef dil aynı olamaz!", "Uyarı", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Butonu devre dışı bırak ve kullanıcıya işlem yapıldığını göster
            btnTranslate.Enabled = false;
            btnTranslate.Text = "Çevriliyor...";
            textBoxOutput.Text = "";

            try
            {
                // Seçilen dilleri API formatına çevir
                string sourceLang = GetLanguageCode(comboBoxSourceLanguage.SelectedItem.ToString());
                string targetLang = GetLanguageCode(comboBoxTargetLanguage.SelectedItem.ToString());
                
                // Çeviri servisini çağır (async)
                string translatedText = await translationService.TranslateAsync(
                    textBoxInput.Text, 
                    sourceLang, 
                    targetLang
                );

                // Sonucu göster
                textBoxOutput.Text = translatedText;
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show($"Çeviri sırasında bir hata oluştu:\n{ex.Message}", 
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxOutput.Text = "";
            }
            finally
            {
                // Butonu tekrar aktif et
                btnTranslate.Enabled = true;
                btnTranslate.Text = "Çevir";
            }
        }

        /// <summary>
        /// Türkçe dil isimlerini API'nin beklediği kod formatına çevirir
        /// </summary>
        /// <param name="languageName">Türkçe dil adı</param>
        /// <returns>API dil kodu (örn: "en", "tr", "de")</returns>
        private string GetLanguageCode(string languageName)
        {
            switch (languageName)
            {
                case "İngilizce": return "en";
                case "Türkçe": return "tr";
                case "Almanca": return "de";
                case "Fransızca": return "fr";
                case "İspanyolca": return "es";
                case "İtalyanca": return "it";
                default: return "en";
            }
        }
    }
}

