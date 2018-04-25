using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        //"начало работы" - выход охранника на работу
        // рандом программа 
        // вывод картинки имя охранника 
        // 1-"бородач" label 5 и PictureBox23
        // 2-"Иванов" label 5 и PictureBox24
        // 3-"Петрович" label 5 и PictureBox25
        // активировать поле регистрация + кнопку зарегать! Старт и стоп

        Random rnd = new Random();

        private static int day = 1;

        private void timer4_Tick(object sender, EventArgs e)  //Вывод на работу Петровича вместо Иванова
        {
            int i = rnd.Next(1, 40);
            if (i < 10)
            {
                switch (i)
                {
                    case 1:
                        {
                            listBox2.Items.Add("Иванов отмечал именины. На работу не выйдет!");
                            listBox2.Items.Add("\r");
                            break;
                        }
                    case 2:
                        {
                            listBox2.Items.Add("Иванову плохо. На работу не выйдет!");
                            listBox2.Items.Add("\r");
                            break;
                        }
                    case 3:
                        {
                            listBox2.Items.Add("Иванов сломал ногу. На работу не выйдет!");
                            listBox2.Items.Add("\r");
                            break;
                        }
                    case 4:
                        {
                            listBox2.Items.Add("Иванова переехал комбайн (тоесть жена:). На работу не выйдет!");
                            listBox2.Items.Add("\r");
                            break; 
                        }
                    case 5:
                        {
                            listBox2.Items.Add("К Иванову приехала теща. На работу не выйдет!");
                            listBox2.Items.Add("\r");
                            break;
                        }
                    case 6:
                        {
                            listBox2.Items.Add("Иванов на работу не выйдет!");
                            listBox2.Items.Add("\r");
                            break;
                        }
                    case 7:
                        {
                            listBox2.Items.Add("Иванов отправился на крестины. На работу не выйдет!");
                            listBox2.Items.Add("\r");
                            break;
                        }
                    case 8:
                        {
                            listBox2.Items.Add("У жены Иванова памятная дата. Иванов на работу выйти не сможет!");
                            listBox2.Items.Add("\r");
                            break;
                        }
                    case 9:
                        {
                            listBox2.Items.Add("Петрович брат выручай. Я поехал на рыбалку (П.С. Иванов)!");
                            listBox2.Items.Add("\r");
                            break;
                        }
                }
                label5.Text = "Петрович";
                pictureBox24.Visible = false;
                pictureBox23.Visible = false;
                pictureBox25.Visible = true;
                timer4.Enabled = false;
                timer6.Enabled = true;
                listBox1.Items.Add("Вышел на работу " + label5.Text);
                listBox1.Items.Add("\r");
            }
            else
            {
                label5.Text = "Иванов";
                pictureBox23.Visible = false;
                pictureBox25.Visible = false;
                pictureBox24.Visible = true;
                timer4.Enabled = false;
                timer5.Enabled = true;
                listBox1.Items.Add("Вышел на работу " + label5.Text);
                listBox1.Items.Add("\r");

            }
        }


        private void timer5_Tick(object sender, EventArgs e) //Вывод на работу Бородача вместо Петровича 
        {
            int i = rnd.Next(1, 40);
            if (i < 10)
            {
                listBox2.Items.Add("Петрович  в печали!Приболел.");
                listBox2.Items.Add("\r");
                label5.Text = "Бородач";
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox23.Visible = true;
                timer6.Enabled = false;
                timer4.Enabled = true;
                listBox1.Items.Add("Вышел на работу " + label5.Text);
                listBox1.Items.Add("\r");
               
            }
            else
            {
                label5.Text = "Петрович";
                pictureBox24.Visible = false;
                pictureBox23.Visible = false;
                pictureBox25.Visible = true;
                timer6.Enabled = true;
                timer5.Enabled = false;
                listBox1.Items.Add("Вышел на работу " + label5.Text);
                listBox1.Items.Add("\r");
            }

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            int i = rnd.Next(1, 40);
            if (i < 10)
            {
                listBox2.Items.Add("Бородач заболел");
                listBox2.Items.Add("\r");
                label5.Text = "Иванов";
                pictureBox23.Visible = false;
                pictureBox25.Visible = false;
                pictureBox24.Visible = true;
                timer6.Enabled = false;
                timer5.Enabled = true;
                listBox1.Items.Add("Вышел на работу " + label5.Text);
                listBox1.Items.Add("\r");
               }
            else
            {
                label5.Text = "Бородач";
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox23.Visible = true;
                timer6.Enabled = false;
                timer4.Enabled = true;
                listBox1.Items.Add("Вышел на работу " + label5.Text);
                listBox1.Items.Add("\r");
               }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();

            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = 0;
                label6.Text = "День " + ++day;
                listBox1.Items.Add("Настал рабочий "+label6.Text);
                listBox1.Items.Add("\r");
            }
        }


     
    //Кнопка "Зарегистрировать"
        private void button2_Click(object sender, EventArgs e)
        {
            double d;
            int a = 0, b = 0;
            string number = "", numbercar = "", period = "", security = "";
            double c = 0;
            try
            {
                a = Convert.ToInt32(textBox3.Text);
                b = Convert.ToInt32(textBox4.Text);
                c = Convert.ToDouble(textBox2.Text);
                number = textBox1.Text;
                numbercar = textBox3.Text;
                period = textBox4.Text;
                security = label5.Text;
                c = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                return;
            }
            double oplata = Convert.ToDouble(textBox2.Text);
            DateTime data = dateTimePicker1.Value;
            dataGridView1.Rows.Add(number, data, period, numbercar, security, oplata);
            d = c * b;

            listBox1.Items.Add("\r");
            listBox1.Items.Add("Въехала машина с номером " + number);
            listBox1.Items.Add("Время и дата въезда " + data);
            listBox1.Items.Add("Машина встала на место №: " + numbercar);
            listBox1.Items.Add("На срок " + period + " д.");
            listBox1.Items.Add("Зарегестрировал охранник " + security);
            listBox1.Items.Add("К оплате " + d + " $");
            listBox1.Items.Add("\r");    

            //Показ картнинки "Машина" на картинка стоянка по местам      
            switch (a)
            {
                case 1:
                    {
                        car1.Visible = true;
                        break;
                    }

                case 2:
                    {
                        car2.Visible = true;
                        break;
                    }

                case 3:
                    {
                        car3.Visible = true;
                        break;
                    }
                case 4:
                    {
                        car4.Visible = true;
                        break;
                    }
                case 5:
                    {
                        car5.Visible = true;
                        break;
                    }
                case 6:
                    {
                        car6.Visible = true;
                        break;
                    }
                case 7:
                    {
                        car7.Visible = true;
                        break;
                    }
                case 8:
                    {
                        car8.Visible = true;
                        break;
                    }
                case 9:
                    {
                        car9.Visible = true;
                        break;
                    }
                case 10:
                    {
                        car10.Visible = true;
                        break;
                    }
                case 11:
                    {
                        car11.Visible = true;
                        break;
                    }
                case 12:
                    {
                        car12.Visible = true;
                        break;
                    }
                case 13:
                    {
                        car13.Visible = true;
                        break;
                    }
                case 14:
                    {
                        car14.Visible = true;
                        break;
                    }
                case 15:
                    {
                        car15.Visible = true;
                        break;
                    }
                case 16:
                    {
                        car16.Visible = true;
                        break;
                    }
                case 17:
                    {
                        car17.Visible = true;
                        break;
                    }
                case 18:
                    {
                        car18.Visible = true;
                        break;
                    }
                case 19:
                    {
                        car19.Visible = true;
                        break;
                    }
                case 20:
                    {
                        car20.Visible = true;
                        break;
                    }
                default:
                    MessageBox.Show("Такого места нету. Повторите ввод!");
                    break;
            }
            //  Очистка полей
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "Бородач";
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox23.Visible = true;
            groupBox1.Enabled = true;
            button1.Enabled = true;
            groupBox1.Enabled = true;
            timer4.Start();
            timer1.Start();
            listBox1.Items.Add("Настал рабочий " + label6.Text);
            listBox1.Items.Add("\r");
            listBox1.Items.Add("Вышел на работу " + label5.Text);
            listBox1.Items.Add("\r");
            button1.Enabled = false;
            btnstop.Enabled = true;
        }

    

        private void btnstop_Click(object sender, EventArgs e)
        {
            timer6.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            groupBox1.Enabled = false;
            button1.Enabled = false;
            label5.Text = "";
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            timer1.Enabled = false;
            label6.Text = "День 1";
            textBox4.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            button1.Enabled = true;
            btnstop.Enabled = false;
            car1.Visible = false;
            car2.Visible = false;
            car3.Visible = false;
            car4.Visible = false;
            car5.Visible = false;
            car6.Visible = false;
            car7.Visible = false;
            car8.Visible = false;
            car9.Visible = false;
            car10.Visible = false;
            car11.Visible = false;
            car12.Visible = false;
            car13.Visible = false;
            car14.Visible = false;
            car15.Visible = false;
            car16.Visible = false;
            car17.Visible = false;
            car18.Visible = false;
            car19.Visible = false;
            car20.Visible = false;
        }

    

        //  Открытие файла
        private void созданиеФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream mystr = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((mystr = openFileDialog1.OpenFile()) != null)
                {
                    StreamReader myread = new StreamReader(mystr);
                    string[] str;
                    int num = 0;
                    try
                    {
                        string[] str1 = myread.ReadToEnd().Split('\n');
                        num = str1.Count();
                        dataGridView1.RowCount = num;
                        for (int i = 0; i < num; i++)
                        {
                            str = str1[i].Split('^');
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                try
                                {
                                    dataGridView1.Rows[i].Cells[j].Value = str[j];
                                  }
                                catch
                                { }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myread.Close();
                    }
                }
            }
        }

        private void удалитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        // "Сохранить
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter myWritet = new StreamWriter(myStream);
                    try
                    {
                        for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                        {
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                myWritet.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + '^');
                            }
                            myWritet.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myWritet.Close();
                    }
                    myStream.Close();
                }
            }
        }


        //Выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       private void остановитьТаймерToolStripMenuItem_Click(object sender, EventArgs e)
       {
           timer6.Enabled = false;
           timer4.Enabled = false;
           timer5.Enabled = false;
           timer1.Enabled = false;
       }
    }
}
  