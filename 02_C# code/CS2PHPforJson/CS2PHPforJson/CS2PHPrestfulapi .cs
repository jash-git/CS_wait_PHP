using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Net;
using System.IO;

namespace CS2PHPforJson
{

    class CS2PHPrestfulapi
    {
        public static String RESTfulAPI_get(String url)
        {
            //string url= "http://192.168.1.68:24410/syris/v8/controller";
            String StrData = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";//request.Method = "POST";
                //request.ContentType = "application/x-www-form-urlencoded";


                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                string encoding = response.ContentEncoding;

                if (encoding == null || encoding.Length < 1)
                {
                    encoding = "UTF-8"; //預設編碼
                }

                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));

                StrData = reader.ReadToEnd();

                response.Close();
            }
            catch
            {
                StrData = "{\"Ans\":\"Error\"}";
            }
            return StrData;
        }

        public static String RESTfulAPI_postBody(String url, String data1)
        {
            String data;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";

                //--
                //request.ContentType = "application/x-www-form-urlencoded";//一般POST
                request.ContentType = "application/json; charset=UTF-8";//POST to AJAX [is_ajax_request()]
                //request.Accept = "application/json, text/javascript";//POST to AJAX [is_ajax_request()]
                //request.UserAgent = "";//POST to AJAX [is_ajax_request()]
                //request.Headers.Add("X-Requested-With", "XMLHttpRequest");//POST to AJAX [is_ajax_request()]
                //--


                request.ContentLength = data1.Length;
                StreamWriter writer = new StreamWriter(request.GetRequestStream(), Encoding.ASCII);
                writer.Write(data1);
                writer.Flush();
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string encoding = response.ContentEncoding;
                if (encoding == null || encoding.Length < 1)
                {
                    encoding = "UTF-8"; //默认编码
                }

                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
                data = reader.ReadToEnd();


                response.Close();
            }
            catch
            {
                data = "{\"Ans\":\"Error\"}";
            }

            return data;
        }

        public static String RESTfulAPI_putBody(String url, String data1)
        {
            String data;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "PUT";

                //--
                //request.ContentType = "application/x-www-form-urlencoded";//一般POST
                request.ContentType = "application/json; charset=UTF-8";//POST to AJAX [is_ajax_request()]
                //request.Accept = "application/json, text/javascript";//POST to AJAX [is_ajax_request()]
                //request.UserAgent = "";//POST to AJAX [is_ajax_request()]
                //request.Headers.Add("X-Requested-With", "XMLHttpRequest");//POST to AJAX [is_ajax_request()]
                //--


                request.ContentLength = data1.Length;
                StreamWriter writer = new StreamWriter(request.GetRequestStream(), Encoding.ASCII);
                writer.Write(data1);
                writer.Flush();
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string encoding = response.ContentEncoding;
                if (encoding == null || encoding.Length < 1)
                {
                    encoding = "UTF-8"; //默认编码
                }

                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
                data = reader.ReadToEnd();


                response.Close();
            }
            catch
            {
                data = "{\"Ans\":\"Error\"}";
            }

            return data;
        }
    }

}
