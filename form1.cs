using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
    
{
        public partial class Form1 : Form
        
        
    {
        Random rnd = new Random();
       string[] cite0;
        string[] browser = { "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.99 Safari/537.36",
            "Mozilla/5.0 (Linux; U; Android 4.2.2; en-us; Lenovo-A516/S111) AppleWebKit/534.30 (KHTML, like Gecko) Version/4.2.2 Mobile Safari/534.30",
            "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.124 YaBrowser/15.7.2357.2877 Safari/537.36",
            "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36 OPR/32.0.1948.25",
            "Mozilla/5.0 (compatible; MSIE 10.0; Windows Phone 8.0; Trident/6.0; IEMobile/10.0; ARM; Touch; Microsoft; Lumia 532 Dual SIM",
            "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:40.0) Gecko/20100101 Firefox/40.1",
            "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; SV1; MyIE2; .NET CLR 1.1.4322; .NET CLR 2.0.50727; WinFX RunTime 3.0.50727)",
            "Mozilla/5.0 (BlackBerry; U; BlackBerry 9900; en) AppleWebKit/534.11+ (KHTML, like Gecko) Version/7.1.0.346 Mobile Safari/534.11+",
            "Opera/9.80 (J2ME/MIDP; Opera Mini/9.80 (S60; SymbOS; Opera Mobi/23.348; U; en) Presto/2.5.25 Version/10.54",
            "Mozilla/5.0 (Linux; U; Android 4.0.3; de-ch; HTC Sensation Build/IML74K) AppleWebKit/534.30 (KHTML, like Gecko) Version/4.0 Mobile Safari/534.30",
            "NokiaC5-00/GoBrowser/2.0.290",
            "NokiaE66/GoBrowser/2.0.297",
            "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/534.30 (KHTML, like Gecko) Comodo_Dragon/12.1.0.0 Chrome/12.0.742.91 Safari/534.30",
            "Mozilla/5.0 (Linux; U; Android 2.3; en-us) AppleWebKit/999+ (KHTML, like Gecko) Safari/999.9",
	        "Mozilla/5.0 (Linux; U; Android 2.3.5; en-us; HTC Vision Build/GRI40) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1",
	        "Mozilla/5.0 (Linux; U; Android 1.6; ar-us; SonyEricssonX10i Build/R2BA026) AppleWebKit/528.5+ (KHTML, like Gecko) Version/3.1.2 Mobile Safari/525.20.1",
	        "Mozilla/5.0 (BlackBerry; U; BlackBerry 9850; en-US) AppleWebKit/534.11+ (KHTML, like Gecko) Version/7.0.0.115 Mobile Safari/534.11+",
	        "BlackBerry9800/5.0.0.862 Profile/MIDP-2.1 Configuration/CLDC-1.1 VendorID/331 UNTRUSTED/1.0 3gpp-gba",
	        "SamsungI8910/SymbianOS/9.1 Series60/3.0",
	        "NokiaC5-00/061.005 (SymbianOS/9.3; U; Series60/3.2 Mozilla/5.0; Profile/MIDP-2.1 Configuration/CLDC-1.1) AppleWebKit/525 (KHTML, like Gecko) Version/3.0 Safari/525 3gpp-gba",
	        "Mozilla/5.0 (Android; Linux armv7l; rv:9.0) Gecko/20111216 Firefox/9.0 Fennec/9.0",
	        "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.2a1pre) Gecko/20110331 Firefox/4.2a1pre Fennec/4.1a1pre",
	        "Mozilla/5.0 (Windows; U; Windows CE 5.2; en-US; rv:1.9.2a1pre) Gecky = y * (x ^ 2) + a(i)	y = y * (x ^ 2) + a(i)	o/20090210 Fennec/0.11",
	        "NokiaE66/GoBrowser/2.0.297",
	        "Nokia5800XpressMusic/GoBrowser/1.6.0.46",
	        "Mozilla/5.0 (compatible; MSIE 9.0; Windows Phone OS 7.5; Trident/5.0; IEMobile/9.0)",
	        "SAMSUNG-C5212/C5212XDIK1 NetFront/3.4 Profile/MIDP-2.0 Configuration/CLDC-1.1",
	        "Mozilla/4.0 (compatible; Linux 2.6.22) NetFront/3.4 Kindle/2.5 (screen 824x1200;rotate)",
	        "Opera/9.80 (J2ME/MIDP; Opera Mini/9.80 (S60; SymbOS; Opera Mobi/23.348; U; en) Presto/2.5.25 Version/10.54",
	        "Opera/9.80 (J2ME/MIDP; Opera Mini/1.0/886; U; en) Presto/2.4.15",
	        "Opera/9.80 (Android 2.3.3; Linux; Opera Mobi/ADR-1111101157; U; es-ES) Presto/2.9.201 Version/11.50",
	        "Mozilla/5.0 (Linux armv6l; Maemo; Opera Mobi/8; U; en-GB; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6 Opera 11.00"
                           };
        string[,] cite = new string[2,2];

        public Form1()
        {
            InitializeComponent();
            
        }
        private string GET(string Url, string Data)
        {
           WebRequest req = WebRequest.Create(Url + "?" + Data);
            //WebClient req = new WebClient();

           // req.Headers.Add("User-Agent: Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
           // req.UserAgent=".NET Framework Test Client";
            //req.Headers.Add("User-Agent: SimpleHostClient");
          //var request = base.GetWebRequest(address) as HttpWebRequest;
            //req.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/6.0;)";
            //WebHeaderCollection headers = new WebHeaderCollection();
            //headers[HttpRequestHeader.UserAgent] = "userAgentString";
           // req.Headers = headers;
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string Out = sr.ReadToEnd();
            sr.Close();
            return Out;
        }
    

        private void timer1_Tick(object sender, EventArgs e)
        {
          //  string b = GET1("edis.pp.ua", ""); ;
            //string a = GET1(cite[rnd.Next(0,cite.Length),0], ""); 
            string a = GET1(cite[rnd.Next(0, cite.GetLength(0)), 0], ""); 
            label1.Text =label1.Text+"_"+ DateTime.Now.ToString("h:mm:ss tt")+"\n";
            label2.Text = DateTime.Now.ToString("h:mm:ss tt");
            //label1.Text = browser[rnd.Next(0, browser.Length - 1)];
            
            timer1.Interval = 60000 * rnd.Next(7, 15);
            //timer1.Interval = 60000 ;
            textBox1.Text = Convert.ToString(timer1.Interval / 60000)+"m.";
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            try { cite0 = File.ReadAllLines("C:\\Users\\toor\\Desktop\\cite-st.txt"); }
            /*  catch (FileNotFoundException Oops)
              {
                
                  MessageBox.Show(Oops.Message+"\no file","error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                  label4.Text = "34";
              }*/
            catch (Exception Oops1)
            {
                MessageBox.Show(Oops1.Message);
                cite0 = new string[] { "edis.pp.ua" };
            }
 
            /*dg.RowCount = 1;
            dg.Rows.Clear();
            foreach (var field in cite0)
            {
                dg.Rows.Add(field);
            }
             * */
            
        //   timer1.Interval = 60000*50;
        
             
          //  dg.DataSource = cite.ToArray();
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            m1to2();
            timer1.Enabled = true;
            timer1.Start();
            
                   }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public static string HTTP_POST(string Url, string Data)
        {
            string Out = String.Empty;
            System.Net.WebRequest req = System.Net.WebRequest.Create(Url);
            try
            {
                req.Method = "POST";
                req.Timeout = 100000;
                req.ContentType = "application/x-www-form-urlencoded";
                byte[] sentData = Encoding.UTF8.GetBytes(Data);
                req.ContentLength = sentData.Length;
                using (System.IO.Stream sendStream = req.GetRequestStream())
                {
                    sendStream.Write(sentData, 0, sentData.Length);
                    sendStream.Close();
                }
                System.Net.WebResponse res = req.GetResponse();
                System.IO.Stream ReceiveStream = res.GetResponseStream();
                using (System.IO.StreamReader sr = new System.IO.StreamReader(ReceiveStream, Encoding.UTF8))
                {
                    Char[] read = new Char[256];
                    int count = sr.Read(read, 0, 256);

                    while (count > 0)
                    {
                        String str = new String(read, 0, count);
                        Out += str;
                        count = sr.Read(read, 0, 256);
                    }
                }
            }
            catch (ArgumentException ex)
            {
                Out = string.Format("HTTP_ERROR :: The second HttpWebRequest object has raised an Argument Exception as 'Connection' Property is set to 'Close' :: {0}", ex.Message);
            }
            catch (WebException ex)
            {
                Out = string.Format("HTTP_ERROR :: WebException raised! :: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Out = string.Format("HTTP_ERROR :: Exception raised! :: {0}", ex.Message);
            }

            return Out;
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }
        private string GET1(string Url, string Data)
        {
            string Out = String.Empty;
            label1.Text = Url;
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://"+Url);
            try
            {
                //browser[rnd.Next(0, browser.Length - 1)]
                myHttpWebRequest.UserAgent = browser[rnd.Next(browser.Length)];
                //label4.Text += Url;
                //label4.Text += "\n";
                // ищем в массиве и добавляем
                label4.Text = Convert.ToString(ArraySearch(Url,"f"));
                int k=Convert.ToInt16(cite[ArraySearch(Url,"f"),1]);
                cite[ArraySearch(Url, "f"), 1] = Convert.ToString( k + 1);
                cite[ArraySearch(Url, "f"), 2] = DateTime.Now.ToString("HH:mm:ss");
                go_m2dg();

                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                Stream streamResponse = myHttpWebResponse.GetResponseStream();
                StreamReader streamRead = new StreamReader(streamResponse);
                Char[] readBuff = new Char[256];
                int count = streamRead.Read(readBuff, 0, 256);
                /*while (count > 0)
                {
                    String outputData = new String(readBuff, 0, count);
                    Console.Write(outputData);
                    count = streamRead.Read(readBuff, 0, 256);
                }
                // Release the response object resources.
                  */
                streamRead.Close();
                streamResponse.Close();
                myHttpWebResponse.Close();
                Out = "";
            }
            catch (ArgumentException ex)
            {
                Out = string.Format("HTTP_ERROR :: The second HttpWebRequest object has raised an Argument Exception as 'Connection' Property is set to 'Close' :: {0}", ex.Message);
            }
            catch (WebException ex)
            {
                Out = string.Format("HTTP_ERROR :: WebException raised! :: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Out = string.Format("HTTP_ERROR :: Exception raised! :: {0}", ex.Message);
            }

            return Out;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.Title = "Select a Cite File";
            openFileDialog1.FileName = "cite";
            MessageBox.Show("файл с сайтами");
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {    Array.Clear(cite,0,cite.Length);
                label4.Text = openFileDialog1.FileName;
                cite0 = File.ReadAllLines(openFileDialog1.FileName);
                //System.IO.StreamReader sr = new //System.IO.StreamReader(openFileDialog1.FileName);
                //MessageBox.Show(sr.ReadToEnd());  //sr.Close();
            }
//////////////////////////////////////////
            openFileDialog1.Title = "Select a Cite File";
            openFileDialog1.FileName = "id_browser";
            MessageBox.Show("файл с идентификаторами браузеров");
            
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Array.Clear(browser, 0, cite.Length);
                label4.Text = openFileDialog1.FileName;
                browser = File.ReadAllLines(openFileDialog1.FileName);
            }
           m1to2();
        }
        private string in_url(string file)
        {
            string Out="1";

            return Out;
        }
        private void go_m2dg()
        {
            sort(cite, 1);

            dg.AutoGenerateColumns = true;
            dg.ColumnCount = 3;
            dg.Rows.Clear();
            for (int i = 0; i < cite0.Length; i++)
            {
                dg.Rows.Add(cite[i, 0], cite[i, 1], cite[i, 2]);
            }

        }

        private void sort()
        {

        }

        private void m1to2()
        {
            cite = (string[,]) ResizeArray(cite, new int[]  {cite0.Length,3});
            for (int i = 0; i <= cite0.Length - 1; i++)
            {
             //   i++;

              cite[i, 0] = cite0[i];
              cite[i, 1] = "0";
              cite[i, 2] = "_";
            }

            go_m2dg();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private static Array ResizeArray(Array arr, int[] newSizes)
        {
            if (newSizes.Length != arr.Rank)
                throw new ArgumentException("arr must have the same number of dimensions " +
                                            "as there are elements in newSizes", "newSizes");

            var temp = Array.CreateInstance(arr.GetType().GetElementType(), newSizes);
            int length = arr.Length <= temp.Length ? arr.Length : temp.Length;
            Array.ConstrainedCopy(arr, 0, temp, 0, length);
            return temp;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //int i = Array.IndexOf(cite, "edis.pp.ua");
         
        }

        private int ArraySearch(string Url, string Data)
        {
            int i,j,n=-1;
           // string s = "edis.pp.ua";
            for (i = 0; i < cite.GetLength(0); i++)
            {
                for (j = 0; j < cite.GetLength(1); j++)
                    if (Url == cite[i, j])
                    {
                        n = i;
                        
                    }
                /*if (Url == cite[i, j])
                {
                    n = i;
                    //break;
                }*/
            }
            return n;
            //label4.Text = Convert.ToString(s) + "lala";
        }
        private void sort(string[,] mas, int pole)
        {
            label4.Text = "";
            string [,] s=new string[mas.GetLength(0),mas.GetLength(1)];
            for (int i = 0; i < mas.GetLength(0)-1; i++)
            {
                for (int j = i; j < mas.GetLength(0); j++)
                    //if (typeof(Convert.ToDouble(mas[i, pole])) is )
                    if (Convert.ToDouble(mas[i, pole]) < Convert.ToDouble(mas[j, pole]))
                      for(int k=0;k<mas.GetLength(1);k++)
                          {
                            s[j, k] = mas[j, k];
                            mas[j, k] = mas[i, k];
                            mas[i, k] = s[j, k]; 
                        }
                label4.Text += mas[i, pole];
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            go_m2dg();
          //  File.WriteAllLines(@"C:\\Users\\toor\\Desktop\\cite.txt", cite, Encoding.UTF8);
        }
    }
 
}
