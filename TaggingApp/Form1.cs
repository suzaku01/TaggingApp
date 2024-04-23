using System;
using System.Windows.Forms;
using Python.Runtime;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Media;

namespace TaggingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Runtime.PythonDLL = @"python/python310.dll";
            PythonEngine.Initialize();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            PythonEngine.Shutdown();
            // Code
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                PyDict pyDict = new PyDict();
                PythonEngine.Exec("import hogehoge2", pyDict);
                string cmd = "hogehoge2.test('";
                cmd = cmd + openFileDialog1.FileName + "', ";
                cmd = cmd + numericUpDown1.Value.ToString() + ")";
                cmd = cmd.Replace("\\", "/");
                var ret = PythonEngine.Eval(cmd, pyDict);
                string[] kekka = ret.ToString().Split("\n");
                textBox1.Text = kekka[2];
                //label1.Text = ret.ToString();

                string[] words = kekka[2].Split(",");
                label5.Text = words.Length.ToString() + " words";
                SystemSounds.Beep.Play();

                //PythonEngine.Shutdown();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PyDict pyDict = new PyDict();
            PythonEngine.Exec("import hogehoge1", pyDict);
            string cmd = "hogehoge1.test('";
            cmd = cmd + "python/requirements.txt" + "')";
            var ret = PythonEngine.Eval(cmd, pyDict);
            SystemSounds.Beep.Play();
            label7.Text = "Successfully installed requirements";
            //textBox1.Text = ret.ToString();

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                PyDict pyDict = new PyDict();
                PythonEngine.Exec("import hogehoge3", pyDict);
                string cmd = "hogehoge3.test('";
                cmd = cmd + folderBrowserDialog1.SelectedPath + "', ";

                //しきい値
                cmd = cmd + numericUpDown1.Value.ToString();

                string usercmd = "";
                //キャプションファイルの生成
                //if (checkBox1.Checked)
                //usercmd = "," + usercmd + folderBrowserDialog1.SelectedPath;

                //上書き
                // if (checkBox2.Checked)
                // usercmd = usercmd + "," + 



                cmd = cmd + usercmd + ")";


                cmd = cmd.Replace("\\", "/");
                var ret = PythonEngine.Eval(cmd, pyDict);
                //string[] kakka = ret.ToString().Split("\n");
                //textBox1.Text = kakka[2];
                //label1.Text = ret.ToString();

                label6.Text = "Caption has done";
                SystemSounds.Beep.Play();



                //string[] words = kakka[2].Split(",");
                //label5.Text = words.Length.ToString() + " words";

               

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
