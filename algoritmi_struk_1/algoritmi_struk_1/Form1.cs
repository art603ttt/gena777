using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algoritmi_struk_1
{
    public partial class Form1 : Form
    {

        MyOch new_och;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_add.Enabled = false;
            button_del.Enabled = false;
            button_empty.Enabled = false;
            button_first.Enabled = false;
            button_show.Enabled = false;
        }

        //создать
        private void button_create_Click(object sender, EventArgs e)
        {
            button_add.Enabled = true;
            button_del.Enabled = true;
            button_empty.Enabled = true;
            button_first.Enabled = true;
            button_show.Enabled = true;

            new_och = new MyOch();
            new_och.Show(ref listBox1);
        }

        //пусто
        private void button_empty_Click(object sender, EventArgs e)
        {
            if (new_och.Empty()) MessageBox.Show("очередь пустая");
            else MessageBox.Show("очередь не пустая");
        }

        //первый
        private void button_first_Click(object sender, EventArgs e)
        {
            try
            {

                MessageBox.Show((new_och.First()).ToString(),"первый элемент");  ////////////////!1!

            }
            catch(Exception ex)
            { MessageBox.Show( ex.Message, "внимание"); }

        }

        //добавить
        private void button_add_Click(object sender, EventArgs e)
        {
            new_och.AddOch(new InfElem(int.Parse(textBox_key.Text),textBox_info.Text));
        }

        //показать очередь
        private void button_show_Click(object sender, EventArgs e)
        {
            new_och.Show(ref listBox1);
        }


        //удалить
        private void button_del_Click(object sender, EventArgs e)
        {
            new_och.DelOch();
        }

        //выход
        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
