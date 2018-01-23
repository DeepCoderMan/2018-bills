/*
    需要添加程序包 Newtonsoft.Json
    程序包管理控制台输入下载：Install-Package Newtonsoft.Json 

    需要添加 System.Web.Extensions 引用
    引用->添加引用->System.Web.Extensions
*/



using System.IO;
using System.Web;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace Json
{

    /// <summary>
    /// json 文件操作类
    /// </summary>
    public class JsonPaser
    {
        string _JsDirPath;

        string _FilePath;

        /// <summary>
        /// 设置文件名
        /// </summary>
        public string PathFile {
            get { return Path.Combine(_JsDirPath, _FilePath); }
            set {
                _FilePath = Path.GetFileName(value);
                _JsDirPath = Path.GetDirectoryName(value);
            }
        }
        
        /// <summary>
        /// 串行化json文件 object-> string ,并保存
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string Serialize(object obj)
        {
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            string json = jsonSerializer.Serialize(obj);

            File.WriteAllText(Path.Combine(_JsDirPath, _FilePath), ConvertJsonString(json));
            return ConvertJsonString(json);
        }

        /// <summary>
        /// 反串行化json文件 读取string-> object,
        /// </summary>
        /// <returns></returns>
        public T Deserialize<T>()
        {
            string JsonFileName = _FilePath;

            string json = File.ReadAllText(Path.Combine(_JsDirPath, _FilePath));
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            //执行反序列化
            T obj = jsonSerializer.Deserialize<T>(json);
            return obj;
        }

        /// <summary>
        /// oj 序列化类   filename  js 文件名（无需后缀）
        /// </summary>
        /// <param name="oj"></param>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public bool CreateJasonFile(object oj, string FileName)
        {
            try
            {

                if (!Directory.Exists(_JsDirPath))
                {
                    Directory.CreateDirectory(_JsDirPath);
                }

                string jsonData = JsonConvert.SerializeObject(oj);

                File.WriteAllText(Path.Combine(_JsDirPath, _FilePath), ConvertJsonString(jsonData));

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 格式化json字符串
        /// </summary>
        /// <param name="JsStr"></param>
        /// <returns></returns>
        private string ConvertJsonString(string JsStr)
        {
            //格式化json字符串
            JsonSerializer serializer = new JsonSerializer();
            TextReader tr = new StringReader(JsStr);
            JsonTextReader jtr = new JsonTextReader(tr);
            object obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                StringWriter textWriter = new StringWriter();
                JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 4,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
            {
                return JsStr;
            }
        }
    }
}


