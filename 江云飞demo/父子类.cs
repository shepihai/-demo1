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
    public partial class 父子类 : Form
    {
        public 父子类()
        {
            InitializeComponent();
        }

        private void 父子类_Load(object sender, EventArgs e)
        {
            //实例化子类
            ma m = new zi();
            m.Name = "江云飞";
            m.Sex = "男";
            //将父类转换为子类
            zi z = (zi)m;
            z.Age = "1";
            z.Name = "测试";
            MessageBox.Show("" + z.Age + z.Name + z.Sex + "");
        }
    }
    /// <summary>
    /// 父类
    /// </summary>
    public class ma
    {
        private string name;
        private string sex;

        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
    }
    /// <summary>
    /// 子类
    /// </summary>
    public class zi : ma
    {
        private string age;

        public string Age { get => age; set => age = value; }
    }
    
}
