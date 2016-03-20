using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theatre_Management
{
    public partial class SelectFilms : Form
    {
        public SelectFilms()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 无用，误点的
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinTextBox1_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// 跳转到选座页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeatSelection_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectSeat ss
        }
        /// <summary>
        /// 取消，退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
