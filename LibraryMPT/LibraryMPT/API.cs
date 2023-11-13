using LibraryMPT.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMPT
{
    public static class API
    {
        public static string url = "https://localhost:44315/api/";

        public static Model GET<Model>(string urlController)
        {
            Cursor.Current = Cursors.WaitCursor;
            return Task.Run(() => GetAsync<Model>(urlController)).Result;
        }

        private static async Task<Model> GetAsync<Model>(string urlController)
        {
            var resultArray = "";
            try
            {
                var client = new HttpClient { BaseAddress = new Uri(url) };
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseMessage = await client.GetAsync($"{urlController}", HttpCompletionOption.ResponseContentRead);
                resultArray = await responseMessage.Content.ReadAsStringAsync();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка");
            }
            Cursor.Current = Cursors.Default;
            return JsonConvert.DeserializeObject<Model>(resultArray);
        }

        public static Model POST<Model>(string urlController, Model entry)
        {
            return JsonConvert.DeserializeObject<Model>(PostOrPutOrDelete(urlController, entry, "POST"));
        }

        public static string PUT<Model>(string urlController, Model entry, int id)
        {
            return PostOrPutOrDelete($"{urlController}/{id}", entry, "PUT");
        }

        public static string DELETE<Model>(string urlController, Model entry, int id)
        {
            return PostOrPutOrDelete($"{urlController}/{id}", entry, "DELETE");
        }

        private static string PostOrPutOrDelete<Model>(string urlController, Model entry, string method)
        {
            var json = "";
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                HttpWebRequest webRequest;

                string requestParams = JsonConvert.SerializeObject(entry);

                webRequest = (HttpWebRequest)WebRequest.Create(url + urlController);

                webRequest.Method = method;
                webRequest.ContentType = "application/json";

                byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
                webRequest.ContentLength = byteArray.Length;
                using (Stream requestStream = webRequest.GetRequestStream())
                {
                    requestStream.Write(byteArray, 0, byteArray.Length);
                }

                using (WebResponse response = webRequest.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        StreamReader rdr = new StreamReader(responseStream, Encoding.UTF8);
                        json = rdr.ReadToEnd();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка");
            }
            Cursor.Current = Cursors.Default;
            return json;
        }
    }
}
