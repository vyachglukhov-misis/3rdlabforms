using MyStack;
using MyDeque;
using MyQueue;
using System.ComponentModel;
using System.Collections;

namespace withForms
{
    public partial class Form1 : Form
    {
        MyStack<string> ms = new MyStack<string>();
        MyDeque<string> md = new MyDeque<string>();
        MyQueue<string> mq = new MyQueue<string>();
        Queue<string> sysQueue = new Queue<string>();
        Stack<string> sysStack = new Stack<string>();
        int sortCounter = 0;
        static List<string>listOfStrings = new List<string>();
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
            listOfStrings.Add(textBox1.Text);
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
            }
            else if (checkedButton.Text == "MyDeque")
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
            else if (checkedButton.Text == "SysStack")
            {
                try
                {
                    sysStack.Push(listBox1.SelectedItem.ToString());
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    if (radioButton4.Checked == true)
                    {
                        List<string> items = new List<string>() { };
                        listBox2.Items.Clear();
                        int i = 1;
                        foreach (var item in sysStack)
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
            else if (checkedButton.Text == "MyQueue")
            {
                try
                {
                    mq.FirstOut();
                    if (radioButton5.Checked == true)
                    {
                        List<string> items = new List<string>() { };
                        listBox2.Items.Clear();
                        int i = 1;
                        foreach (var item in mq)
                        {
                            items.Add($"{i}. " + item.ToString());
                            i++;
                        }
                        listBox2.Items.AddRange(items.ToArray());
                    }
                }
                catch
                {
                    MessageBox.Show("no item in MyQueue left");
                }
            }
            else if (checkedButton.Text == "SysStack")
            {
                try
                {
                    sysStack.Pop();
                    if (radioButton4.Checked == true)
                    {
                        List<string> items = new List<string>() { };
                        listBox2.Items.Clear();
                        int i = 1;
                        foreach (var item in sysStack)
                        {
                            items.Add($"{i}. " + item.ToString());
                            i++;
                        }
                        listBox2.Items.AddRange(items.ToArray());
                    }
                }
                catch
                {
                    MessageBox.Show("no items in in SysStack left");
                }
            }
            else if (checkedButton.Text == "SysQueue")
            {
                try
                {
                    sysQueue.Dequeue();
                    if (radioButton6.Checked == true)
                    {
                        List<string> items = new List<string>() { };
                        listBox2.Items.Clear();
                        int i = 1;
                        foreach (var item in sysQueue)
                        {
                            items.Add($"{i}. " + item.ToString());
                            i++;
                        }
                        listBox2.Items.AddRange(items.ToArray());
                    }
                }
                catch
                {
                    MessageBox.Show("no item in SysQueue left");
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button5.Enabled = false;
            button1.Enabled = true;
            button3.Enabled = true;
            if (radioButton4.Checked == true)
            {
                List<string> items = new List<string>() { };
                listBox2.Items.Clear();
                int i = 1;
                foreach (var item in sysStack)
                {
                    items.Add($"{i}. " + item.ToString());
                    i++;
                }
                listBox2.Items.AddRange(items.ToArray());
            }
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
            } else if(checkedButton.Text == "MyQueue")
            {
                try
                {
                    mq.Add(listBox1.SelectedItem.ToString());
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    if (radioButton5.Checked == true)
                    {
                        List<string> items = new List<string>() { };
                        listBox2.Items.Clear();
                        int i = 1;
                        foreach (var item in mq)
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
            else if (checkedButton.Text == "SysQueue")
            {
                try
                {
                    sysQueue.Enqueue(listBox1.SelectedItem.ToString());
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    if (radioButton6.Checked == true)
                    {
                        List<string> items = new List<string>() { };
                        listBox2.Items.Clear();
                        int i = 1;
                        foreach (var item in sysQueue)
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
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button5.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sortCounter % 2 == 0)
            {
                listBox1.Items.Clear();
                string[] arr = new string[listOfStrings.ToArray().Length];
                listOfStrings.ToArray().CopyTo(arr, 0);
                listBox1.Items.AddRange(SortedList(arr));
                sortCounter++;
            }
            else
            {
                listBox1.Items.Clear();
                string[] arr = new string[listOfStrings.ToArray().Length];
                listOfStrings.ToArray().CopyTo(arr, 0);
                listBox1.Items.AddRange(arr);
                sortCounter++;
            }
        }

        protected string[] SortedList(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (needToReOrder(arr[j], arr[j + 1]))
                    {
                        string s = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = s;
                    }
                }
            }
            bool needToReOrder(string s1, string s2)
            {
                for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
                {
                    if (s1.ToCharArray()[i] < s2.ToCharArray()[i]) return false;
                    if (s1.ToCharArray()[i] > s2.ToCharArray()[i]) return true;
                }
                return false;
            }
            return arr;
        }
    }
}