using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS

{

    public partial class FIFO : Form
    {
        Button[] buttons_memory = new Button[5];
        Button[] buttons_page = new Button[12];
        int[] memory = new int[5];
        int[] pages = new int[12];
        int count = 0;
        public FIFO()
        {

            InitializeComponent();
            OK.Enabled = false;
            Random random = new Random();
            for (int i = 0; i < memory.Length; i++)
            {
                memory[i] = random.Next(1, 20);
            }
            buttons_memory[0] = button1Memory;
            buttons_memory[1] = button2Memory;
            buttons_memory[2] = button3Memory;
            buttons_memory[3] = button4Memory;
            buttons_memory[4] = button5Memory;
            for (int i = 0; i < buttons_memory.Length; i++)
            {
                buttons_memory[i].Text = memory[i].ToString();
            }

            for (int i = 0; i < pages.Length; i++)
            {
                pages[i] = random.Next(1, 20);
            }
            buttons_page[0] = button1Page;
            buttons_page[1] = button2Page;
            buttons_page[2] = button3Page;
            buttons_page[3] = button4Page;
            buttons_page[4] = button5Page;
            buttons_page[5] = button6Page;
            buttons_page[6] = button7Page;
            buttons_page[7] = button8Page;
            buttons_page[8] = button9Page;
            buttons_page[9] = button10Page;
            buttons_page[10] = button11Page;
            buttons_page[11] = button12Page;
            for (int i = 0; i < buttons_page.Length; i++)
            {
                buttons_page[i].Text = pages[i].ToString();
            }
        }

        private void button1Page_Click(object sender, EventArgs e)
        {
            int index = 0;
            int x= 0, y=0;
            Button button_temp = new Button();
            Button button = (Button)sender;
            x = button.Left;
            y = button.Top;
            if (y > 100)
            {
                for (int k = 0; k < buttons_page.Length; k++)
                {
                    if (buttons_page[k] == button)
                    {
                        index = k;
                    }
                }
                button_temp = buttons_memory[0];
                bool flag = true;
                for (int j = 0; j < 5; j++)
                {
                    if (buttons_memory[j].Text != button.Text)
                        flag = true;
                    else
                    {
                        flag = false;
                        break;
                    }

                }

                if (flag)
                {
                    button_temp = buttons_memory[0];
                    int n = 0;

                    for (int i = 0; i < 4; i++)
                    {
                        buttons_memory[i] = buttons_memory[i + 1];
                        buttons_memory[i + 1].Location = new Point(16 + n, 61);
                        n = n + 116;
                    }
                    buttons_memory[4] = button;
                    button.Location = new Point(480, 61);
                    buttons_page[index] = button_temp;
                    buttons_page[index].Location = new Point(x, y);
                    count += 1;
                    Information.Text += "Была запрошена страница: " + button.Text + 
                        ". \r\nЗамещена страница: "+ buttons_page[index].Text + ". \r\nПроизошло прерывание.\r\n\r\n";
                    PageFaults.Text = count.ToString();
                }
                else
                {
                    Information.Text += "Была запрошена страница: " + button.Text + ". \r\nКоличество прерываний: 0\r\n\r\n";
                    
                }
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            memory  = MemoryPages.Text.
                   Split(new Char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).
                   ToArray();
            pages = Pages.Text.
                  Split(new Char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).
                  ToArray();
            try
            {
                for (int i = 0; i < buttons_memory.Length; i++)
                {
                    buttons_memory[i].Text = memory[i].ToString();
                }
                for (int i = 0; i < buttons_page.Length; i++)
                {
                    buttons_page[i].Text = pages[i].ToString();
                }
            }
            catch
            {
                MessageBox.Show(text: "Введенные данные некорректны! Попробуйте снова.", caption: "Ошибка!",
                      buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "txt files (*.txt)|*.txt|All files(*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string filename = open.FileName;
                try
                {
                   int[] arr = File.ReadAllText(filename).
                   Split(new Char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).
                   ToArray();
                   int size = arr.Length;
                    if (size == 17)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            memory[i] = arr[i];
                            
                        }
                        for (int j = 5; j < 17; j++)
                        {
                            pages[j-5] = arr[j];
                           
                        }
                        
                    }
                    else
                        MessageBox.Show(text: "Данные в файле некорректны! Попробуйте снова.", caption: "Ошибка!",
                      buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show(text: "Данные в файле некорректны! Попробуйте снова.", caption: "Ошибка!",
                       buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                }
                for (int i = 0; i < buttons_memory.Length; i++)
                {
                    buttons_memory[i].Text = memory[i].ToString();
                }
                for (int i = 0; i < buttons_page.Length; i++)
                {
                    buttons_page[i].Text = pages[i].ToString();
                }

            }
        }

        private void MemoryPages_TextChanged(object sender, EventArgs e)
        {
            if (MemoryPages.Text.Length == 0 && Pages.Text.Length == 0)
            {
                OK.Enabled = false;
            }
            else
                OK.Enabled = true;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: "Автор программы: Голова Елена, 474\n" +
            "Назначение программы - Визуализация алгоритма \n" +
            "замены страниц: FIFO.\n\n",
            caption: "О программе",
            buttons: MessageBoxButtons.OK,
            icon: MessageBoxIcon.Information);
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: "Принцип алгоритма FIFO заключается в том, что в первую очередь\n" + 
                "вытесняется пришедшая первой страница.\n" + 
                "Общая реализация этого метода заключается в том, что когда появляется необходимость\n" +
                "удалять из основной памяти какую-нибудь страницу, выбирается та, \nкоторая находилась в памяти дольше других.\n\n" +
            "Программа принимает на вход 5 блоков памяти и 12 замещающих страниц. \n" +
            "Для того, чтобы ввести однозначное число, используйте ноль как заполнитель.\n\n",
            caption: "Помощь",
            buttons: MessageBoxButtons.OK,
            icon: MessageBoxIcon.Information);
        }

    }

}



