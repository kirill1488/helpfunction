using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;

namespace helpfunc
{
   
   public class Class2
    {

        public static void load(string link,string path)
        {
            WebClient wc = new WebClient();
            wc.DownloadFile(link, path);
        }
        
        public static string ebatdurak;
        
       public static void create(string dir,string name)
        {
            if (Directory.Exists(dir))
            {

                try
                {

                    File.Create(dir + name);
                }
                catch
                {

                   // MessageBox.Show("Ошибка #3:Не удалось создать файл!");
                }
            }
            else
            {
                Directory.CreateDirectory(dir);
            }



        }
        
        public static void write(string writepath,string text, string dir,string name)
        {

          
            if (File.Exists(writepath))
            {
                try
                {
                    StreamWriter sw = new StreamWriter(writepath, false, System.Text.Encoding.UTF8);

                    sw.Write(text);
                    sw.Close();
                    sw.Dispose();
                }
                catch
                {
                    throw new Exception("Файл не существует!");
                }

            }
            else
            {
                create(dir,name);
            }


        }

        public static void clear(string path)
        {
           // textBox1.Text = "";
           // textBox2.Text = "";     
            File.WriteAllText(path, string.Empty);
        }

        public static void read(string pathwithfile)
        {
           
            if (File.Exists(pathwithfile))
            {
                StreamReader sr = new StreamReader(pathwithfile);
                string cef = sr.ReadToEnd().ToString();
                sr.Close();
                if (cef.Length > 0)
                {
                    ebatdurak = cef;
                    /*textBox2.Width = 130;
                    textBox2.Height = 80;
                    textBox2.Text = cef;*/
                   
                    sr.Close();
                    sr.Dispose();
                }
                else
                {
                   
                    sr.Close();
                }
                sr.Close();
                sr.Dispose();
            }
            else
            {
                throw new Exception("Не найден файл для записи!");
            }

        }
    }
}
