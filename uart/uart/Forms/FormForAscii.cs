using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uart
{
    public partial class FormForAscii : Form
    {
        public FormForAscii()
        {
            InitializeComponent();

            dataGridView1.ForeColor = Color.Black;
            for ( int i=0; i<128; i++ )
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dataGridView1.Rows.Add(row);

                dataGridView1.Rows[index].Cells[0].Value = Convert.ToString(i,2).PadLeft(8,'0');
                dataGridView1.Rows[index].Cells[1].Value = Convert.ToString(i, 10);
                dataGridView1.Rows[index].Cells[2].Value = Convert.ToString(i, 16).PadLeft(2,'0');
                if( i>=33&&i<=126 )
                {
                    dataGridView1.Rows[index].Cells[3].Value = Convert.ToChar(i);
                    dataGridView1.Rows[index].Cells[4].Value = "无";
                }
                else
                {
                    switch(i)
                    {
                        case 0:dataGridView1.Rows[index].Cells[3].Value = "NUL";dataGridView1.Rows[index].Cells[4].Value = "空字符";break;
                        case 1: dataGridView1.Rows[index].Cells[3].Value = "SOH"; dataGridView1.Rows[index].Cells[4].Value = "标题开始"; break;
                        case 2: dataGridView1.Rows[index].Cells[3].Value = "STX"; dataGridView1.Rows[index].Cells[4].Value = "正文开始"; break;
                        case 3: dataGridView1.Rows[index].Cells[3].Value = "ETX"; dataGridView1.Rows[index].Cells[4].Value = "正文结束"; break;
                        case 4: dataGridView1.Rows[index].Cells[3].Value = "EOT"; dataGridView1.Rows[index].Cells[4].Value = "传输结束"; break;
                        case 5: dataGridView1.Rows[index].Cells[3].Value = "ENQ"; dataGridView1.Rows[index].Cells[4].Value = "请求"; break;
                        case 6: dataGridView1.Rows[index].Cells[3].Value = "ACK"; dataGridView1.Rows[index].Cells[4].Value = "收到通知"; break;
                        case 7: dataGridView1.Rows[index].Cells[3].Value = "BEL"; dataGridView1.Rows[index].Cells[4].Value = "响铃"; break;
                        case 8: dataGridView1.Rows[index].Cells[3].Value = "BS"; dataGridView1.Rows[index].Cells[4].Value = "退格"; break;
                        case 9: dataGridView1.Rows[index].Cells[3].Value = "HT"; dataGridView1.Rows[index].Cells[4].Value = "水平制表符"; break;
                        case 10: dataGridView1.Rows[index].Cells[3].Value = "LF"; dataGridView1.Rows[index].Cells[4].Value = "换行键"; break;
                        case 11: dataGridView1.Rows[index].Cells[3].Value = "VT"; dataGridView1.Rows[index].Cells[4].Value = "垂直制表符"; break;
                        case 12: dataGridView1.Rows[index].Cells[3].Value = "FF"; dataGridView1.Rows[index].Cells[4].Value = "换页键"; break;
                        case 13: dataGridView1.Rows[index].Cells[3].Value = "CR"; dataGridView1.Rows[index].Cells[4].Value = "回车键"; break;
                        case 14: dataGridView1.Rows[index].Cells[3].Value = "SO"; dataGridView1.Rows[index].Cells[4].Value = "不用切换"; break;
                        case 15: dataGridView1.Rows[index].Cells[3].Value = "SI"; dataGridView1.Rows[index].Cells[4].Value = "启用切换"; break;
                        case 16: dataGridView1.Rows[index].Cells[3].Value = "DLE"; dataGridView1.Rows[index].Cells[4].Value = "数据链路转义"; break;
                        case 17: dataGridView1.Rows[index].Cells[3].Value = "DC1"; dataGridView1.Rows[index].Cells[4].Value = "设备控制1"; break;
                        case 18: dataGridView1.Rows[index].Cells[3].Value = "DC2"; dataGridView1.Rows[index].Cells[4].Value = "设备控制2"; break;
                        case 19: dataGridView1.Rows[index].Cells[3].Value = "DC3"; dataGridView1.Rows[index].Cells[4].Value = "设备控制3"; break;
                        case 20: dataGridView1.Rows[index].Cells[3].Value = "DC4"; dataGridView1.Rows[index].Cells[4].Value = "设备控制4"; break;
                        case 21: dataGridView1.Rows[index].Cells[3].Value = "NAK"; dataGridView1.Rows[index].Cells[4].Value = "拒绝接收"; break;
                        case 22: dataGridView1.Rows[index].Cells[3].Value = "SYN"; dataGridView1.Rows[index].Cells[4].Value = "同步空闲"; break;
                        case 23: dataGridView1.Rows[index].Cells[3].Value = "ETB"; dataGridView1.Rows[index].Cells[4].Value = "传输块结束"; break;
                        case 24: dataGridView1.Rows[index].Cells[3].Value = "CAN"; dataGridView1.Rows[index].Cells[4].Value = "取消"; break;
                        case 25: dataGridView1.Rows[index].Cells[3].Value = "EM"; dataGridView1.Rows[index].Cells[4].Value = "介质中断"; break;
                        case 26: dataGridView1.Rows[index].Cells[3].Value = "SUB"; dataGridView1.Rows[index].Cells[4].Value = "替补"; break;
                        case 27: dataGridView1.Rows[index].Cells[3].Value = "ESC"; dataGridView1.Rows[index].Cells[4].Value = "换码/溢出"; break;
                        case 28: dataGridView1.Rows[index].Cells[3].Value = "FS"; dataGridView1.Rows[index].Cells[4].Value = "文件分隔符"; break;
                        case 29: dataGridView1.Rows[index].Cells[3].Value = "GS"; dataGridView1.Rows[index].Cells[4].Value = "分组符"; break;
                        case 30: dataGridView1.Rows[index].Cells[3].Value = "RS"; dataGridView1.Rows[index].Cells[4].Value = "记录分离符"; break;
                        case 31: dataGridView1.Rows[index].Cells[3].Value = "US"; dataGridView1.Rows[index].Cells[4].Value = "单元分隔符"; break;
                        case 32: dataGridView1.Rows[index].Cells[3].Value = " "; dataGridView1.Rows[index].Cells[4].Value = "空格"; break;
                        case 127: dataGridView1.Rows[index].Cells[3].Value = "DEL"; dataGridView1.Rows[index].Cells[4].Value = "删除"; break;
                        default:break;
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormForAscii.ActiveForm.Dispose();
        }
    }
}
