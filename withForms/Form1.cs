using MyStack;
using MyDeque;
using System.ComponentModel;

namespace withForms
{
    public partial class Form1 : Form
    {
        MyStack<string> ms = new MyStack<string>();
        MyDeque<string> md = new MyDeque<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button5.Enabled = true;
            button1.Enabled = true;
            button3.Enabled = true;

            if (radioButton3.Checked == true)
            {
                List<string> items = new List<string>() { };
                listBox2.Items.Clear();
                int i = 1;
                foreach (var item in md)
                {
                    items.Add($"{i}. " + item.ToString());
                    i++;
                }
                listBox2.Items.AddRange(items.ToArray());
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button5.Enabled = true;
            button1.Enabled = true;
            button3.Enabled = true;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var checkedButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton.Text == "MyStack")
            {
                try
                {
                    ms.Push(listBox1.SelectedItem.ToString());
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    if (radioButton2.Checked == true)
                    {
                        List<string> items = new List<string>() { };
                        listBox2.Items.Clear();
                        int i = 1;
                        foreach (var item in ms)
                        {
                            items.Add($"{i}. " + item.ToString());
                            i++;
                        }
                        listBox2.Items.AddRange(items.ToArray());
                    }
                }
                catch
                {
                    MessageBox.Show("no item selected");
                }
            }else if (checkedButton.Text == "MyDeque")
            {
                try
                {
                    md.AddFirst(listBox1.SelectedItem.ToString());
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    if (radioButton3.Checked == true)
                    {
                        List<string> items = new List<string>() { };
                        listBox2.Items.Clear();
                        int i = 1;
                        foreach (var item in md)
                        {
                            items.Add($"{i}. " + item.ToString());
                            i++;
                        }
                        listBox2.Items.AddRange(items.ToArray());
                    }
                }
                catch
                {
                    MessageBox.Show("no item selected");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var checkedButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton.Text == "MyDeque")
            {
                try
                {
                    md.RemoveLast();
                    if (radioButton3.Checked == true)
                    {
                        List<string> items = new List<string>() { };
                        listBox2.Items.Clear();
                        int i = 1;
                        foreach (var item in md)
                        {
                            items.Add($"{i}. " + item.ToString());
                            i++;
                        }
                        listBox2.Items.AddRange(items.ToArray());
                    }
                }
                catch
                {
                    MessageBox.Show("no items in in MyDeque left");
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button5.Enabled = false;
            button1.Enabled = true;
            button3.Enabled = true;
            if (radioButton2.Checked == true) {
                List<string> items = new List<string>() { };
                listBox2.Items.Clear();
                int i = 1;
                foreach (var item in ms)
                {
                    items.Add($"{i}. " + item.ToString());
                    i++;
                }
                listBox2.Items.AddRange(items.ToArray());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var checkedButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton.Text == "MyStack")
            {
                try
                {
                    ms.Pop();
                    if (radioButton2.Checked == true)
                    {
                        List<string> items = new List<string>() { };
                        listBox2.Items.Clear();
                        int i = 1;
                        foreach (var item in ms)
                        {
                            items.Add($"{i}. "+item.ToString());
                            i++;
                        }
                        listBox2.Items.AddRange(items.ToArray());
                    }
                }
                catch
                {
                    MessageBox.Show("no items in in MyStack left");
                }
            }
            else if (checkedButton.Text == "MyDeque")
            {
                try
                {
                    md.RemoveFirst();
                    if (radioButton3.Checked == true)
                    {
                        List<string> items = new List<string>() { };
                        listBox2.Items.Clear();
                        int i = 1;
                        foreach (var item in md)
                        {
                            items.Add($"{i}. " + item.ToString());
                            i++;
                        }
                        listBox2.Items.AddRange(items.ToArray());
                    }
                }
                catch
                {
                    MessageBox.Show("no item in MyDeque left");
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button5.Enabled = false;
            button1.Enabled = true;
            button3.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button5.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            var checkedButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton.Text == "MyDeque")
            {
                try
                {
                    md.AddLast(listBox1.SelectedItem.ToString());
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    if (radioButton3.Checked == true)
                    {
                        List<string> items = new List<string>() { };
                        listBox2.Items.Clear();
                        int i = 1;
                        foreach (var item in md)
                        {
                            items.Add($"{i}. " + item.ToString());
                            i++;
                        }
                        listBox2.Items.AddRange(items.ToArray());
                    }
                }
                catch
                {
                    MessageBox.Show("no item selected");
                }
            }
        }
    }
}