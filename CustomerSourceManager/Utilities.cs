using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System.IO;



namespace ClientSourceManager
{
    [XmlType(TypeName = "config")]
    public class LoginInfos
    {
        [XmlArray("users")]
        public List<User> users { get; set; }
    }

    [XmlType(TypeName = "user")]
    public class User
    {
        [XmlAttribute]
        public string userName { get; set; }
        [XmlAttribute]
        public string password { get; set; }
        [XmlAttribute]
        public int authority { get; set; }
    }
    class Utilities
    {
        public static string GetXMLContent(string XMLName)
        {
            string location = typeof(Utilities).Assembly.Location;
            string xmlPath = location.Substring(0, location.IndexOf("bin"));
            XMLName = xmlPath + XMLName;

            if (!System.IO.File.Exists(XMLName))
            {
                throw new ArgumentNullException(XMLName + " not Exists");
            }

            System.IO.StreamReader reader = new System.IO.StreamReader(XMLName);
            if (reader == null)
                return null;
            string result = reader.ReadToEnd();
            reader.Close();
            return result;
        }
        //public static T XMLRead<T>(string XMLName) where T : class
        //{
        //    string XMLContent = GetXMLContent(XMLName);

        //    return XmlUtil.Deserialize(typeof(T), XMLContent) as T;
        //}

        public static bool CheckPassword(string XMLName, string userName, string password)
        {
            string location = typeof(Utilities).Assembly.Location;
            string xmlPath = location.Substring(0, location.IndexOf("bin"));
            XMLName = xmlPath + XMLName;

            if (!System.IO.File.Exists(XMLName))
            {
                throw new ArgumentNullException(XMLName + " not Exists");
            }
            System.IO.StreamReader reader = new System.IO.StreamReader(XMLName);
            if (reader == null)
                return false;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(reader);

            XmlNodeList xnl = xmlDoc.SelectSingleNode("users").ChildNodes; //查找节点  

            foreach (XmlNode node in xnl)
            {
                if(userName == ((XmlElement)node).GetAttribute("用户名"))
                {
                    if (password == ((XmlElement)node).GetAttribute("密码"))
                    {
                        reader.Close();
                        return true;
                    }
                }
            }
            reader.Close();
            return false;
        }

        public static void ModifyXml(string XMLName, int index, string[] nodeName, string[] nodeValue)
        {
            string location = typeof(Utilities).Assembly.Location;
            string xmlPath = location.Substring(0, location.IndexOf("bin"));
            XMLName = xmlPath + XMLName;

            if (!System.IO.File.Exists(XMLName))
            {
                throw new ArgumentNullException(XMLName + " not Exists");
            }
            System.IO.StreamReader reader = new System.IO.StreamReader(XMLName);
            if (reader == null)
                return;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(reader);

            XmlNodeList xnl = xmlDoc.SelectSingleNode("users").ChildNodes; //查找节点  

            XmlElement xe = (XmlElement)xnl[index];

            for (int i = 0; i < nodeName.Length; i++)
                xe.SetAttribute(nodeName[i], nodeValue[i]);

            reader.Close();
            XmlTextWriter writer = new XmlTextWriter(XMLName, Encoding.UTF8);
            xmlDoc.Save(writer);
            writer.Close();
        }


        public static void AddXml(string XMLName, string[] nodeName, string[] nodeValue)
        {
            string location = typeof(Utilities).Assembly.Location;
            string xmlPath = location.Substring(0, location.IndexOf("bin"));
            XMLName = xmlPath + XMLName;

            if (!System.IO.File.Exists(XMLName))
            {
                throw new ArgumentNullException(XMLName + " not Exists");
            }
            System.IO.StreamReader reader = new System.IO.StreamReader(XMLName);
            if (reader == null)
                return;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(reader);

            XmlNodeList xnl = xmlDoc.SelectSingleNode("users").ChildNodes; //查找节点  
            
            XmlElement xe=xmlDoc.CreateElement("user");

            for (int i = 0; i < nodeName.Length; i++)
                xe.SetAttribute(nodeName[i], nodeValue[i]);

            xnl[0].ParentNode.AppendChild(xe);

            reader.Close();
            XmlTextWriter writer = new XmlTextWriter(XMLName, Encoding.UTF8);
            xmlDoc.Save(writer);
            writer.Close();
        }

        public static void DelXml(string XMLName, int index)
        {
            string location = typeof(Utilities).Assembly.Location;
            string xmlPath = location.Substring(0, location.IndexOf("bin"));
            XMLName = xmlPath + XMLName;

            if (!System.IO.File.Exists(XMLName))
            {
                throw new ArgumentNullException(XMLName + " not Exists");
            }
            System.IO.StreamReader reader = new System.IO.StreamReader(XMLName);
            if (reader == null)
                return;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(reader);

            XmlNodeList xnl = xmlDoc.SelectSingleNode("users").ChildNodes; //查找节点  

            xnl[index].ParentNode.RemoveChild(xnl[index]);

            reader.Close();
            XmlTextWriter writer = new XmlTextWriter(XMLName, Encoding.UTF8);
            xmlDoc.Save(writer);
            writer.Close();
        }
    }


 


    public class XmlUtil
    {
        #region 反序列化
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="xml">XML字符串</param>
        /// <returns></returns>
        public static object Deserialize(Type type, string xml)
        {
            try
            {
                using (StringReader sr = new StringReader(xml))
                {
                    XmlSerializer xmldes = new XmlSerializer(type);
                    return xmldes.Deserialize(sr);
                }
            }
            catch (Exception e)
            {

                return null;
            }
        }
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="type"></param>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static object Deserialize(Type type, Stream stream)
        {
            XmlSerializer xmldes = new XmlSerializer(type);
            return xmldes.Deserialize(stream);
        }
        #endregion

        #region 序列化
        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="obj">对象</param>
        /// <returns></returns>
        public static string Serializer(Type type, object obj)
        {
            MemoryStream Stream = new MemoryStream();
            XmlSerializer xml = new XmlSerializer(type);
            try
            {
                //序列化对象
                xml.Serialize(Stream, obj);
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            Stream.Position = 0;
            StreamReader sr = new StreamReader(Stream);
            string str = sr.ReadToEnd();

            sr.Dispose();
            Stream.Dispose();

            return str;
        }

        #endregion
    }
}
