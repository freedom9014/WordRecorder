using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WordRecorder
{
    public partial class Form1 : Form
    {
        DataAccess da = null;

        public Form1()
        {
            InitializeComponent();
            da = new DataAccess();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //テキストボックスの中身をテキストファイルに書き込む
            //１レコード1行で

            da.insertRow(this.textBox1.Text, this.textBox2.Text);
            this.textBox1.Clear();
            this.textBox2.Clear();




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //バックグラウンドワーカーの起動
            this.backgroundWorker1.RunWorkerAsync();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //3秒間隔でテキストファイルの中身を表示
            for (; ;)
            {
               string line = da.getRandomLine();
                String name = line.Substring(0, line.IndexOf(","));
                String word = line.Substring(line.IndexOf(",")+1);
                this.textBox3.Text = null;
                this.textBox3.Text += name + "さんの言葉\r\n"+word;
                Thread.Sleep(3000);
                


            }
            



        }
    }
}
