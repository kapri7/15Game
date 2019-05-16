using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15game
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            New();
        }

  
        int[] M = new int[16];
        int k;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Button2.Text == "")
            {
                k++;
                string k1 = Convert.ToString(k);
                textBox1.Text = k1;
                string t = Button2.Text;
                Button2.Text = button1.Text;
                button1.Text = t;
            }
            if (Button5.Text == "")
            {
                k++;
                string k1 = Convert.ToString(k);
                textBox1.Text = k1;
                string t = Button5.Text;
                Button5.Text = button1.Text;
                button1.Text = t;
            }
            Prov();
        }
        private void Prov()
        {
            if (button1.Text == "1")
            {
                 if (Button2.Text == "2")
                 {
                      if (Button3.Text == "3")
                      {
                          if (Button4.Text == "4")
                          {
                              if (Button5.Text == "5")
                              {
                                  if (Button6.Text == "6") 
                                  { 
                                      if (Button7.Text == "7") 
                                      { 
                                          if (Button8.Text == "8") 
                                          {
                                              if (Button9.Text == "9")
                                              { 
                                                  if (Button10.Text == "10") 
                                                  { 
                                                      if (Button11.Text == "11") 
                                                      { 
                                                          if (Button12.Text == "12")
                                                          { 
                                                              if (Button13.Text == "13") 
                                                              {
                                                                  if (Button14.Text == "14") 
                                                                  { 
                                                                      if (Button15.Text == "15")
                                                                      {
                                                                          Peremoga(); } 
                                                                  } 
                                                              }
                                                          }
                                                      }
                                                  }
                                              } 
                                          } 
                                      } 
                                  }
                              }
                          }
                      }
                 }
            }
        }
        string k1 = "";
        private void Peremoga()
        {
            k1 = Convert.ToString(k);
            if (MessageBox.Show ("Ходов: "+k1+"\nЖелаете сыграть еще раз?","Вы выиграли",
                MessageBoxButtons.YesNo) ==DialogResult.No )
            {
                this.Dispose();
            }
            else New();

        }
        
    
         private void New()
        {
             
            k = 0;
            for (int i = 1; i < 16; i++)
                M[i] = 0;
            int a = 1,x;
            Random rand = new Random();
            while (a<=15)
            {
                x = rand.Next(1, 16);
                if (M[x]==0)
                {
                    M[x] = a;
                    a++;
                }
            }
                button1.Text = Convert.ToString(M[1]);
                Button2.Text = Convert.ToString(M[2]);
                Button3.Text = Convert.ToString(M[3]);
                Button4.Text = Convert.ToString(M[4]);
                Button5.Text = Convert.ToString(M[5]);
                Button6.Text = Convert.ToString(M[6]);
                Button7.Text = Convert.ToString(M[7]);
                Button8.Text = Convert.ToString(M[8]);
                Button9.Text = Convert.ToString(M[9]);
                Button10.Text = Convert.ToString(M[10]);
                Button11.Text = Convert.ToString(M[11]);
                Button12.Text = Convert.ToString(M[12]);
                Button13.Text = Convert.ToString(M[13]);
                Button14.Text = Convert.ToString(M[14]);
                Button15.Text = Convert.ToString(M[15]);
                Button16.Text = "";
                textBox1.Text = "0";
        }
        private void button17_Click_2(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Вы действительно хотите попробовать заново?", "Новая игра",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                New();
                textBox1.Text = "0";
            }
           
  
            
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (Button16.Text == "")
            {
                string t = Button16.Text;
                Button16.Text = Button15.Text;
                Button15.Text = t;
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
            }
            if (Button11.Text == "")
            {
                string t = Button11.Text;
                Button11.Text = Button15.Text;
                Button15.Text = t; k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
            }
            if (Button14.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button14.Text;
                Button14.Text = Button15.Text;
                Button15.Text = t;
            }
            Prov();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = button1.Text;
                button1.Text = Button2.Text;
                Button2.Text = t;
            }
            if (Button6.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button6.Text;
                Button6.Text = Button2.Text;
                Button2.Text = t;
            }
            if (Button3.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button3.Text;
                Button3.Text = Button2.Text;
                Button2.Text = t;
            }
            Prov();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (Button2.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button2.Text;
                Button2.Text = Button3.Text;
                Button3.Text = t;
            }
            if (Button4.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button4.Text;
                Button4.Text = Button3.Text;
                Button3.Text = t;
            }
            if (Button7.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button7.Text;
                Button7.Text = Button3.Text;
                Button3.Text = t;
            }
            Prov();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (Button3.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button3.Text;
                Button3.Text = Button4.Text;
                Button4.Text = t;
            }
            if (Button8.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button8.Text;
                Button8.Text = Button4.Text;
                Button4.Text = t;
            }
            Prov();
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = button1.Text;
                button1.Text = Button5.Text;
                Button5.Text = t;
            }
            if (Button6.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button6.Text;
                Button6.Text = Button5.Text;
                Button5.Text = t;
            }
            if (Button9.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button9.Text;
                Button9.Text = Button5.Text;
                Button5.Text = t;
            }
            Prov();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (Button2.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button2.Text;
                Button2.Text = Button6.Text;
                Button6.Text = t;
            }
            if (Button5.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button5.Text;
                Button5.Text = Button6.Text;
                Button6.Text = t;
            }
            if (Button7.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button7.Text;
                Button7.Text = Button6.Text;
                Button6.Text = t;
            }
            if (Button10.Text == "")
            {
                k++;
                string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button10.Text;
                Button10.Text = Button6.Text;
                Button6.Text = t;
            }
            Prov();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (Button6.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button6.Text;
                Button6.Text = Button7.Text;
                Button7.Text = t;
            }
            if (Button8.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button8.Text;
                Button8.Text = Button7.Text;
                Button7.Text = t;
            }
            if (Button3.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button3.Text;
                Button3.Text = Button7.Text;
                Button7.Text = t;
            }
            if (Button11.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button11.Text;
                Button11.Text = Button7.Text;
                Button7.Text = t;
            }
            Prov();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (Button4.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button4.Text;
                Button4.Text = Button8.Text;
                Button8.Text = t;
            }
            if (Button7.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button7.Text;
                Button7.Text = Button8.Text;
                Button8.Text = t;
            }
            if (Button12.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button12.Text;
                Button12.Text = Button8.Text;
                Button8.Text = t;
            }
            Prov();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (Button5.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button5.Text;
                Button5.Text = Button9.Text;
                Button9.Text = t;
            }
            if (Button10.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button10.Text;
                Button10.Text = Button9.Text;
                Button9.Text = t;
            }
            if (Button13.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button13.Text;
                Button13.Text = Button9.Text;
                Button9.Text = t;
            }
            Prov();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (Button6.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button6.Text;
                Button6.Text = Button10.Text;
                Button10.Text = t;
            }
            if (Button9.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button9.Text;
                Button9.Text = Button10.Text;
                Button10.Text = t;
            }
            if (Button11.Text == "")
            {
                k++;string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button11.Text;
                Button11.Text = Button10.Text;
                Button10.Text = t;
            }
            if (Button14.Text == "")
            {
                k++;
                string k1 = Convert.ToString(k);
                textBox1.Text = k1;
                string t = Button14.Text;
                Button14.Text = Button10.Text;
                Button10.Text = t;
            }
            Prov();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (Button7.Text == "")
            {
                k++;
                string k1 = Convert.ToString(k);
                textBox1.Text = k1;
                string t = Button7.Text;
                Button7.Text = Button11.Text;
                Button11.Text = t;
            }
            if (Button10.Text == "")
            {
                k++;
                string k1 = Convert.ToString(k);
                textBox1.Text = k1;
                string t = Button10.Text;
                Button10.Text = Button11.Text;
                Button11.Text = t;
            }
            if (Button12.Text == "")
            {
                k++;
                string k1 = Convert.ToString(k);
                textBox1.Text = k1;
                string t = Button12.Text;
                Button12.Text = Button11.Text;
                Button11.Text = t;
            }
            if (Button15.Text == "")
            {
                k++;
                string k1 = Convert.ToString(k);
                textBox1.Text = k1;
                string t = Button15.Text;
                Button15.Text = Button11.Text;
                Button11.Text = t;
            }
            Prov();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (Button13.Text == "")
            {
                k++;
                string k1 = Convert.ToString(k);
                textBox1.Text = k1;
                string t = Button13.Text;
                Button13.Text = Button14.Text;
                Button14.Text = t;
            }
            if (Button10.Text == "")
            {
                k++;
                string k1 = Convert.ToString(k);
                textBox1.Text = k1;
                string t = Button10.Text;
                Button10.Text = Button14.Text;
                Button14.Text = t;
            }
            if(Button15.Text=="")
            {
                k++;
                string k1 = Convert.ToString(k);
                textBox1.Text = k1;
                string t = Button15.Text;
                Button15.Text = Button14.Text;
                Button14.Text = t;
            }
            Prov();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            if (Button15.Text == "")
            {
                k++;
                string k1 = Convert.ToString(k);
                textBox1.Text = k1;
                string t = Button15.Text;
                Button15.Text = Button16.Text;
                Button16.Text = t;
            }
            if (Button12.Text == "")
            {
                k++;
                string k1 = Convert.ToString(k);
                textBox1.Text = k1;
                string t = Button12.Text;
                Button12.Text = Button16.Text;
                Button16.Text = t;
            }
            Prov();
        }

        private void Button12_Click_1(object sender, EventArgs e)
        {
            if (Button8.Text == "")
            {
                k++;
                string k1 = Convert.ToString(k);
                textBox1.Text = k1;
                string t = Button8.Text;
                Button8.Text = Button12.Text;
                Button12.Text = t;
            }
            if (Button11.Text == "")
            {
                k++;
                string k1 = Convert.ToString(k);
                textBox1.Text = k1;
                string t = Button11.Text;
                Button11.Text = Button12.Text;
                Button12.Text = t;
            }
            if (Button16.Text == "")
            {
                k++;
                string k1 = Convert.ToString(k);
                textBox1.Text = k1;
                string t = Button16.Text;
                Button16.Text = Button12.Text;
                Button12.Text = t;
            }
            Prov();
        }

        private void Button13_Click_1(object sender, EventArgs e)
        {
            if (Button9.Text == "")
            {
                k++;
                string k1 = Convert.ToString(k);
                textBox1.Text = k1;
                string t = Button9.Text;
                Button9.Text = Button13.Text;
                Button13.Text = t;
            }
            if (Button14.Text == "")
            {
                k++;
                string k1 = Convert.ToString(k);textBox1.Text = k1;
                string t = Button14.Text;
                Button14.Text = Button13.Text;
                Button13.Text = t;
            }
            Prov();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Желаете выйти? Все достижения будут потеряны.", "Выход",
                MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void оПрограмеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа создана Стенякиным Иваном.", "Информация",
                    MessageBoxButtons.OK);
            
                
            }

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сложить последовательность от 1 до 15 по горизонталях, начиная от верхнего левого угла.", "Правила игры",
                    MessageBoxButtons.OK);
        }
    }

}