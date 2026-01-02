using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace MultiLangTranslator
{
    /// <summary>
    /// Çeviri servisi sınıfı - MyMemory API ile çeviri işlemlerini yönetir
    /// </summary>
    public class TranslationService
    {
        private readonly HttpClient httpClient;
        private readonly JavaScriptSerializer jsonSerializer;
        private const string API_BASE_URL = "https://api.mymemory.translated.net/get";

        /// <summary>
        /// Constructor - HttpClient ve JSON serializer'ı başlatır
        /// </summary>
        public TranslationService()
        {
            httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromSeconds(30); // 30 saniye timeout
            jsonSerializer = new JavaScriptSerializer();
        }

        /// <summary>
        /// Metni kaynak dilden hedef dile çevirir
        /// Async metod kullanarak UI thread'ini bloklamadan çalışır
        /// </summary>
        /// <param name="text">Çevrilecek metin</param>
        /// <param name="sourceLanguage">Kaynak dil kodu (örn: "en", "tr")</param>
        /// <param name="targetLanguage">Hedef dil kodu (örn: "en", "tr")</param>
        /// <returns>Çevrilmiş metin</returns>
        /// <exception cref="Exception">İnternet bağlantısı veya API hatası durumunda fırlatılır</exception>
        public async Task<string> TranslateAsync(string text, string sourceLanguage, string targetLanguage)
        {
            // Boş metin kontrolü
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Çevrilecek metin boş olamaz!");
            }

            try
            {
                // API URL'ini oluştur
                // Format: https://api.mymemory.translated.net/get?q=metin&langpair=kaynak|hedef
                string url = $"{API_BASE_URL}?q={Uri.EscapeDataString(text)}&langpair={sourceLanguage}|{targetLanguage}";

                // HTTP GET isteği gönder (async)
                HttpResponseMessage response = await httpClient.GetAsync(url);

                // HTTP yanıtını kontrol et
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"API yanıt hatası: {response.StatusCode}");
                }

                // JSON yanıtını string olarak oku
                string jsonResponse = await response.Content.ReadAsStringAsync();

                // JSON'u parse et
                MyMemoryResponse apiResponse = jsonSerializer.Deserialize<MyMemoryResponse>(jsonResponse);

                // API yanıtını kontrol et
                if (apiResponse == null || apiResponse.responseData == null)
                {
                    throw new Exception("API'den geçersiz yanıt alındı!");
                }

                // Çeviri sonucunu döndür
                return apiResponse.responseData.translatedText;
            }
            catch (HttpRequestException ex)
            {
                // İnternet bağlantısı hatası
                throw new Exception("İnternet bağlantısı hatası! Lütfen bağlantınızı kontrol ediniz.", ex);
            }
            catch (TaskCanceledException ex)
            {
                // Timeout hatası
                throw new Exception("İstek zaman aşımına uğradı! Lütfen tekrar deneyiniz.", ex);
            }
            catch (Exception ex)
            {
                // Diğer hatalar
                throw new Exception($"Çeviri hatası: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Kaynakları temizler - HttpClient'ı dispose eder
        /// </summary>
        public void Dispose()
        {
            httpClient?.Dispose();
        }
    }

    /// <summary>
    /// MyMemory API yanıt modeli - JSON deserialization için kullanılır
    /// </summary>
    public class MyMemoryResponse
    {
        public ResponseData responseData { get; set; }
        public int responseStatus { get; set; }
        public string responseDetails { get; set; }
    }

    /// <summary>
    /// API yanıtındaki çeviri verilerini içeren sınıf
    /// </summary>
    public class ResponseData
    {
        public string translatedText { get; set; }
        public double match { get; set; } // API ondalık değer döndürdüğü için double kullanılıyor (örn: 0.98)
    }
}

