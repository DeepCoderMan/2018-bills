using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;
using System.Windows.Forms;
namespace Other
{
    public class Logs
    {
        private static string _Path;
        private static string _remark;

        /// <summary>
        /// path : 设置或填入一个文件夹全路径
        /// </summary>
        /// <param name="path"></param>
        /// <param name="remark"></param>
        public Logs(string path, string remark = "Log")
        {
            _Path = path;
            _remark = remark;
        }
        public void Log(string log)
        {
            try
            {
                string path = _Path + "/" + GetCurrentDateTime() + ".txt";
                if (!Directory.Exists(_Path))
                {
                    Directory.CreateDirectory(_Path);
                }

                StreamWriter sw = File.AppendText(path);

                var InputLog = DateTime.Now.ToString() + "  [" + _remark + "]:  " + log;
                sw.WriteLine(InputLog);
                //清空缓冲区
                sw.Flush();
                //关闭流
                sw.Close();
                //               fs.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void Log(string log, string remark)
        {
            try
            {
                string path = _Path + "/" + GetCurrentDateTime() + ".txt";
                if (!Directory.Exists(_Path))
                {
                    Directory.CreateDirectory(_Path);
                }

                StreamWriter sw = File.AppendText(path);

                var InputLog = DateTime.Now.ToString() + "  [" + remark + "]:  " + log;
                sw.WriteLine(InputLog);
                //清空缓冲区
                sw.Flush();
                //关闭流
                sw.Close();
                //               fs.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private string GetCurrentDateTime()
        {
            return DateTime.Now.ToLongDateString();
        }
    }
}

