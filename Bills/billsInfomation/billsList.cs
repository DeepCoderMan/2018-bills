using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bills;

namespace billsInfomation
{
    public partial class billsList: UserControl
    {
        public delegate void voidEventHandle();
        public voidEventHandle updataList;
        object _lock = new object();

        object _data = new object();
        public object data { get { return _data; }
            set { _data = value; }
        }
        public billsList()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            updataList += InitListView;
            InitListView();
        }

        private void InitListView()
        {
            lock (_lock)
            {
                billsTabel.Clear();

                billsTabel.Columns.Add("Index", 50, HorizontalAlignment.Left);    //将列头添加到ListView控件。

                billsTabel.Columns.Add("Date", 160, HorizontalAlignment.Left); //一步添加

                billsTabel.Columns.Add("Total Expenditure", 400, HorizontalAlignment.Left);

                billsTabel.Columns.Add("Remarks", 400, HorizontalAlignment.Left);
                this.billsTabel.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度

                int i = 1;
                foreach (var it in CTCT.instance.ExpendData.item)
                {
                    SetListItem(i, it);
                    i++;
                }
                billsTabel.EndUpdate();
            }
        }
        private void SetListItem(int index,billsData.billseDataBase data)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = index.ToString();
            lvi.SubItems.Add(data.date);
            lvi.SubItems.Add(data.totalExgpend);
            lvi.SubItems.Add(data.remarks);
            billsTabel.Items.Add(lvi);
        }
    }
}
