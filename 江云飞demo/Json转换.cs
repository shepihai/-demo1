using Newtonsoft.Json;
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
    public partial class Json转换 : Form
    {
        public Json转换()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 内容转化为json字符串
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                list list = new list();
                list.Name = "测试";
                list.Sxe = "男";
                list.Age = 18;
                textBox2.Text=JsonConvert.SerializeObject(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("请输入正确的格式！");
            }
            finally
            {

            }
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Json转换_Load(object sender, EventArgs e)
        {

        }
    }
    /// <summary>
    /// 对象list
    /// </summary>
    public class list
    {
        private string name;
        private int age;
        private string sxe;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Sxe { get => sxe; set => sxe = value; }
    }
}
