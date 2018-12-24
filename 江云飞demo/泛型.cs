using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 江云飞demo
{
    public partial class 泛型 : Form
    {
        public 泛型()
        {
            InitializeComponent();
        }

        public void A()
        {
            List<string> list = new List<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");
        }
        public void B()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
        }

        public void C()
        {
            //字典
            Dictionary<long, string> tem = new Dictionary<long, string>();
            tem.Add(1, "A");
            tem.Add(2, "B");
            tem.Add(3, "C");
            tem.Add(4, "D");
            //查找字典中的key对应的value
            if (tem.ContainsKey(1))
            {
                MessageBox.Show(tem[1]);
            }
            //查找字典中的key和value值
            foreach (KeyValuePair<long, string> itme in tem)
            {
                MessageBox.Show(itme.Key+itme.Value);
            }
            //查找字典的key值
            Dictionary<long, string>.KeyCollection keyCol = tem.Keys;
            foreach (var key in keyCol)
            {
                MessageBox.Show(key.ToString());
            }
        }
        public void D()
        {
            Dictionary<long, string> tem = new Dictionary<long, string>();
            tem.Add(1, "A");
            tem.Add(2, "B");
            tem.Add(3, "C");
            tem.Add(4, "D");
            tem[1] = tem[1] + "B";
            MessageBox.Show(tem[1]);
        }

        private void 泛型_Load(object sender, EventArgs e)
        {
            D();
        }
    }
}
