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
    public partial class 递归 : Form
    {
        public 递归()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 计算阶乘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sun_Click(object sender, EventArgs e)
        {
            try
            {
                int a =int.Parse(textBox1.Text.ToString().Trim());
                int rest=methoda(a);
                textBox2.Text = rest.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("请输入需要计算的数字！");
                return;
            }
        }
        /// <summary>
        /// 递归算法
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int methoda(int x)
        {
            int a;
            if (x == 1)
            {
                return 1;
            }
            else
            {
                a = methoda(x - 1) * x;
                return a;
            }
        }
    }
}
