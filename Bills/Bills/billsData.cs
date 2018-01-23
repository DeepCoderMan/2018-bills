using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using Json;


namespace Bills
{
    public class billsData
    {
        //public List<billseDataBase> item = new List<billseDataBase>();
        public billseDataBase item = new billseDataBase();
        public string name;
        JsonPaser jp;
        public billsData(string fileName)
        {
            jp = new JsonPaser();
            jp.PathFile = fileName;

            Read();
        }
        public bool Read()
        {
            item = jp.Deserialize<billseDataBase>();
            return true;
        }
        public bool Save()
        {
            if (File.Exists(jp.PathFile))
            {
                jp.Serialize(item);
            }
            else
            {
                jp.CreateJasonFile(item, jp.PathFile);
            }
            return true;
        }

        public class billseDataBase
        {
            public List<data> DataBase { get; set; }
        }
        public class data
        {
            public string date { get; set; }
            public string totalExgpend { get; set; }

            public string remarks { get; set; }
        }

    }
}
