using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using static System.Console;
using System.Windows.Forms;
namespace Other
{
    public class XMLoperation
    {
        
        /// <summary>
        ///  将数据写入XMl中
        /// </summary>
        public void WriteXml()
        {
            try
            {
                CardControlData _data = new CardControlData();
                FileStream file = File.OpenWrite("./data/data.xml");
                using (TextWriter writer = new StreamWriter(file))
                {
                    XmlSerializer serializer = new XmlSerializer(_data.GetType());
                    serializer.Serialize(writer, _data);
                }
            }
            catch (Exception e)
            {
                CreatNewXmlFile("./data", "data.xml");
                MessageBox.Show(e.Message + "\r\n");
            }
        }
        /// <summary>
        /// 将数据反序列化
        /// </summary>
        public void ReadXml()
        {
            CardControlData _data = new CardControlData();
            try
            {
                using (var stream = new FileStream("./data/data.xml", FileMode.OpenOrCreate))
                {
                    var serializer = new XmlSerializer(_data.GetType());
                    _data = serializer.Deserialize(stream) as CardControlData;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        void CreatNewXmlFile(string PathName, string filename)
        {
            try
            {
                if (!Directory.Exists(PathName))
                {
                    Directory.CreateDirectory(PathName);
                }
                XmlDocument xmlDoc = new XmlDocument();
                //创建类型声明节点  
                XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
                xmlDoc.AppendChild(node);
                //创建根节点  
                XmlNode root = xmlDoc.CreateElement("null");
                xmlDoc.AppendChild(root);
                CreateNode(xmlDoc, root, "null", "null");

                xmlDoc.Save(PathName + "/" + filename);
            }
            catch (Exception e)
            {
                //显示错误信息  
                MessageBox.Show(e.Message);
            }
            //Con
        }

        /// <summary>    
        /// 创建节点    
        /// </summary>    
        /// <param path="xmldoc"></param>  xml文档  
        /// <param path="parentnode"></param>父节点    
        /// <param path="name"></param>  节点名  
        /// <param path="value"></param>  节点值  
        /// 
        public void CreateNode(XmlDocument xmlDoc, XmlNode parentNode, string name, string value)
        {
            XmlNode node = xmlDoc.CreateNode(XmlNodeType.Element, name, null);
            node.InnerText = value;
            parentNode.AppendChild(node);
        }
    }

    #region 程序数据
    [XmlRoot]
    public class CardControlData
    {
        [XmlAttribute(AttributeName = "DisCount")]
        public int DisCount { get; set; }

        [XmlElement]
        public string SMC_IP {
            get { return data.SMC_IP; }
            set
            {
                data.SMC_IP = value;
            } }

        [XmlElement]
        public string Port_Name {
            get { return data.Port_Name; }
            set { data.Port_Name= value; }
        }
        [XmlElement]
        public string Port_Baud
        {
            get { return data.Port_Baud; }
            set { data.Port_Baud = value; }
        }

        [XmlElement]
        public string Port_DataBit
        {
            get { return data.Port_DataBit; }
            set { data.Port_DataBit = value; }
        }

        [XmlElement]
        public string Port_StopBit
        {
            get { return data.Port_StopBit; }
            set { data.Port_StopBit = value; }
        }
        [XmlElement]
        public string StartPos
        {
            get { return data.StartPos; }
            set { data.StartPos = value; }
        }
        [XmlElement]
        public string EndPos
        {
            get { return data.EndPos; }
            set { data.EndPos = value; }
        }
        public CardControlData()
        {
        }
    }

    static class data
    {
        public static string SMC_IP { get; set; }

        public static string Port_Name { get; set; }
        public static string Port_Baud { get; set; }
        public static string Port_DataBit { get; set; }
        public static string Port_StopBit { get; set; }

        public static string StartPos { get; set; }

        public static string EndPos { get; set; }
    }
    #endregion
}
