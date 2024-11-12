using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // 获取所有行的高度
            int[] rowHeights = tableLayoutPanel1.GetRowHeights();

            // 获取第一行的高度（数组索引从0开始）
            int rowHeight = rowHeights[0];
            // 获取表格的行高
            //int rowHeight = tableLayoutPanel1.ClientSize.Height / tableLayoutPanel1.RowCount;

            // 设置背景色为某行（例如，第2行）
            using (Brush brush = new SolidBrush(Color.CornflowerBlue))
            {
                // 在第二行绘制背景色
                e.Graphics.FillRectangle(brush, 0, rowHeight * 0, tableLayoutPanel1.ClientSize.Width, rowHeight);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/yuminuo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (tabControl1.TabPages[btn.Text]==null) {
                tabControl1.TabPages.Add(btn.Text, btn.Text);
                if (btn.Text =="项目管理")
                {
                    Form frm = new Form2();
                    frm.TopLevel = false;
                    frm.Dock = DockStyle.Fill;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.Show();
                    tabControl1.TabPages[btn.Text].Controls.Add(frm);
                }
            }
            tabControl1.SelectedTab = tabControl1.TabPages[btn.Text];
        }
    }
}
