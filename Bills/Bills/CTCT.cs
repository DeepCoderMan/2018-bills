using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Other;
using Bills.sql;

namespace Bills
{
    /// <summary>
    /// control center
    /// </summary>
    public class CTCT
    {
        public delegate void strEventHandle(string str);
        #region Bills
        Logs _log;
        billsData _ExpendData;
        string _billsDataFileName = "./billsdata/bills.json";
        static object ctlock = new object();
        static CTCT _instance;
        public static CTCT instance
        {
            get
            {
                lock (ctlock)
                {
                    if (_instance == null)
                    {
                        _instance = new CTCT();
                    }
                }
                return _instance;
            }
        }
        /// <summary>
        /// 显示的版本信息
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 账单数据文件路径
        /// </summary>
        public string BillsFileName
        {
            get { return _billsDataFileName; }
            set {
                if(_billsDataFileName != value)
                {
                    _billsDataFileName = value;
                }
            }
        }
        /// <summary>
        /// 控制模块日志
        /// </summary>
        public Logs log { get { return _log; } }
        /// <summary>
        /// 消费数据
        /// </summary>
        public billsData ExpendData {
            get { return _ExpendData; }
        }
        #endregion

        #region 主控操作
        /// <summary>
        /// 实例化
        /// </summary>
        /// <returns></returns>
        public bool ConstructCTCT()
        {
            _log = new Logs("./log", "CTCT");
            _ExpendData = new billsData(_billsDataFileName);
            _SqlSever = new SqLliteData();
            return true;
        }
        public void Close()
        {
            _ExpendData.Save();
        }
        #endregion

        #region sql
        SqLliteData _SqlSever;
        SqLliteData SqlSever { get { return _SqlSever; }set { _SqlSever = value; } }
        


        #endregion
    }
}
