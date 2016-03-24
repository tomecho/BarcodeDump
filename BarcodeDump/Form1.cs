using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeDump
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength == numericUpDown1.Value)
            {
                richTextBox1.AppendText(textBox1.Text + Environment.NewLine);
                textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "plain text file|*.txt";
            bool sucess = false;
            while (!sucess)
            {
                DialogResult r = saveFileDialog1.ShowDialog();
                if (r == DialogResult.Cancel) { return; }
                if (!saveFileDialog1.CheckPathExists)
                {
                    MessageBox.Show("That path doesn't Exist!");
                    sucess = false;
                    continue;
                }
                if (saveFileDialog1.CheckFileExists)
                {
                    DialogResult exists = MessageBox.Show("That already exists are you sure?", "Oh no", MessageBoxButtons.YesNoCancel);
                    if (exists == DialogResult.No)
                    {
                        continue;
                    }
                    else if (exists == DialogResult.Yes)
                    {
                        sucess = true;
                        break;
                    }
                    else if (exists == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                if (saveFileDialog1.FileName == "") { return; }
                else break;
            }
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog1.FileName))
                //@"C:\Users\" + Environment.UserName + @"\Desktop\barcodeExport.txt"))
                {
                    foreach (string line in richTextBox1.Lines)
                    {
                        file.WriteLine(line);
                    }
                }
                DialogResult r = MessageBox.Show("Wrote to file, clear text?", "Sucess!", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes) 
                {
                    richTextBox1.Clear();
                }
                else if (r == DialogResult.No)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void exitToolStripMenuItemEXPORT_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
        private void exitToolStripMenuItemEXIT_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void eXPERIMENTALOrganizationalUnitMoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In case you didnt know, this is really experimental mess up the AD quite a bit");
            Form2.ShowDialog();
        }
    }
}
