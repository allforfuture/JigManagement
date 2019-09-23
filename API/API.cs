using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Net;
using System.Configuration;
//using Newtonsoft.Json;
//using System.Xml.Linq;
//using Newtonsoft.Json.Linq;
//using System.Threading;

namespace JigManagement.API
{
    class API
    {
        readonly static string APIurl = ConfigurationManager.AppSettings["APIurl"];
        readonly static string ContentType = ConfigurationManager.AppSettings["ContentType"];


        public static bool /*string*/ PostHttp( string APIbody)
        {
            byte[] btBodys = Encoding.UTF8.GetBytes(APIbody);

            HttpWebRequest httpWebRequest = null;
            HttpWebResponse httpWebResponse = null;
            Stream reqStream = null;
            StreamReader streamReader = null;
            string responseContent = "";

            try
            {
                httpWebRequest = (HttpWebRequest)WebRequest.Create(APIurl);
                httpWebRequest.ContentType = ContentType;
                httpWebRequest.Method = "POST";
                httpWebRequest.Timeout = 10 * 1000;
                //httpWebRequest.ContentLength = btBodys.Length;

                reqStream = httpWebRequest.GetRequestStream();
                reqStream.Write(btBodys, 0, btBodys.Length);




                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                streamReader = new StreamReader(httpWebResponse.GetResponseStream());
                responseContent = streamReader.ReadToEnd();

                //return responseContent;
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                //return responseContent;
                return false;
            }
            finally
            {
                if (httpWebRequest != null) httpWebRequest.Abort();
                if (httpWebResponse != null) httpWebResponse.Close();
                if (reqStream != null) reqStream.Close();
                if (streamReader != null) streamReader.Close();
            }
        }
    }
}
