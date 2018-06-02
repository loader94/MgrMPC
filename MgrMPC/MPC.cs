using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MgrMPC
{
    public partial class MPC : Form
    {
        Party_SPDZ[] Party;
        Party_GMW87[] Party_gmw;
        int I, J;
        Millioner mil;
        Love Anna;
        Love Bartosz;
        public MPC()
        {
            InitializeComponent();
            Load += MPC_Load;
        }
        void testclick()
        {
            button_SPDZ_generujliczbeudzialow.PerformClick();
            buttongenerujudzialygmw.PerformClick();
        }
        int[] wartosci_x, wartosci_y;
        int[] wartosci_gmw;
        private void button_SPDZ_generujliczbeudzialow_Click(object sender, EventArgs e)
        {
            int liczbaudz = 0;
            Random r = new Random();
            liczbaudz = r.Next(2,11);
            textBox_SPDZ_liczbaudzialow.Text = liczbaudz.ToString();
            generuj_i_zakryj(get_liczbaudzialow());
            /*for(int i=0;i<get_liczbaudzialow();i++)
            {
                Console.WriteLine(wartosci[i]);
            }*/
            comboBoxPartySPDZ.Items.Clear();
            comboBoxdodawanie1.Items.Clear();
            comboBoxdodawanie2.Items.Clear();
            comboBoxmnozenie1.Items.Clear();
            comboBoxmnozenie2.Items.Clear();
            for (int i = 0; i < get_liczbaudzialow(); i++)
            {
                comboBoxPartySPDZ.Items.Add("x" + i);
                comboBoxPartySPDZ.Items.Add("y" + i);
                comboBoxdodawanie1.Items.Add("x" + i);
                comboBoxdodawanie1.Items.Add("y" + i);
                comboBoxdodawanie2.Items.Add("x" + i);
                comboBoxdodawanie2.Items.Add("y" + i);
                comboBoxmnozenie1.Items.Add("x" + i);
                comboBoxmnozenie1.Items.Add("y" + i);
                comboBoxmnozenie2.Items.Add("x" + i);
                comboBoxmnozenie2.Items.Add("y" + i);
            }
            comboBoxPartySPDZ.SelectedIndex = 0;
            comboBoxdodawanie1.SelectedIndex = 0;
            comboBoxdodawanie2.SelectedIndex = 0;
            comboBoxmnozenie1.SelectedIndex = 0;
            comboBoxmnozenie2.SelectedIndex = 0;
            buttonwyczyscSPDZ.PerformClick();
            buttonObliczX.Enabled = false;
            buttondodawaniespdz.Enabled = false;
            buttonmnozeniespdz.Enabled = false;
        }
        public int get_liczbaudzialow()
        {
            return Convert.ToInt32(textBox_SPDZ_liczbaudzialow.Text);
        }
        private void generuj_i_zakryj(int udzialy)
        {
            textBoxwejsciowewart.Text = "";
            wartosci_x = new int[udzialy];
            wartosci_y = new int[udzialy];
            Random seed = new Random();
            for (int i=0;i<udzialy;i++)
            {
                wartosci_x[i] = seed.Next(3000);
                wartosci_y[i] = seed.Next(3000);
            }
            string tempx = string.Empty;
            string tempy = string.Empty;
            for (int i = 0; i < udzialy; i++)
            {
                if (!checkBox1.Checked)
                {
                    if (i != udzialy - 1)
                    {
                        tempx = "x" + i.ToString() + " = xx";
                        textBoxwejsciowewart.AppendText(tempx);
                        textBoxwejsciowewart.AppendText(Environment.NewLine);
                        tempy = "y" + i.ToString() + " = xx";
                        textBoxwejsciowewart.AppendText(tempy);
                        textBoxwejsciowewart.AppendText(Environment.NewLine);
                    }
                    else
                    {
                        tempx = "x" + i.ToString() + " = xx";
                        textBoxwejsciowewart.AppendText(tempx);
                        textBoxwejsciowewart.AppendText(Environment.NewLine);
                        tempy = "y" + i.ToString() + " = xx";
                        textBoxwejsciowewart.AppendText(tempy);
                    }
                }
                else
                {

                    if (i != udzialy - 1)
                    {
                        tempx = "x" + i.ToString() + " = " + wartosci_x[i];
                        textBoxwejsciowewart.AppendText(tempx);
                        textBoxwejsciowewart.AppendText(Environment.NewLine);
                        tempy = "y" + i.ToString() + " = " + wartosci_y[i];
                        textBoxwejsciowewart.AppendText(tempy);
                        textBoxwejsciowewart.AppendText(Environment.NewLine);
                    }
                    else
                    {
                        tempx = "x" + i.ToString() + " = " + wartosci_x[i];
                        textBoxwejsciowewart.AppendText(tempx);
                        textBoxwejsciowewart.AppendText(Environment.NewLine);
                        tempy = "y" + i.ToString() + " = " + wartosci_y[i];
                        textBoxwejsciowewart.AppendText(tempy);
                    }
                
                }
            }
            //textBoxwejsciowewart.Text = temp;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxwejsciowewart.Text) && checkBox1.Checked==true)
            {
                textBoxwejsciowewart.Text = "";
                int udzialy = get_liczbaudzialow();
                string tempx = string.Empty;
                string tempy = string.Empty;
                for (int i = 0; i < udzialy; i++)
                {
                    if (i != udzialy - 1)
                    {
                        tempx = "x" + i.ToString() + " = " + wartosci_x[i];
                        textBoxwejsciowewart.AppendText(tempx);
                        textBoxwejsciowewart.AppendText(Environment.NewLine);
                        tempy = "y" + i.ToString() + " = " + wartosci_y[i];
                        textBoxwejsciowewart.AppendText(tempy);
                        textBoxwejsciowewart.AppendText(Environment.NewLine);
                    }
                    else
                    {
                        tempx = "x" + i.ToString() + " = " + wartosci_x[i];
                        textBoxwejsciowewart.AppendText(tempx);
                        textBoxwejsciowewart.AppendText(Environment.NewLine);
                        tempy = "y" + i.ToString() + " = " + wartosci_y[i];
                        textBoxwejsciowewart.AppendText(tempy);
                    }
                }
            }
            if (!string.IsNullOrWhiteSpace(textBoxwejsciowewart.Text) && checkBox1.Checked == false)
            {
                textBoxwejsciowewart.Text = "";
                int udzialy = get_liczbaudzialow();
                string tempx = string.Empty;
                string tempy = string.Empty;
                for (int i = 0; i < udzialy; i++)
                {
                    if (i != udzialy - 1)
                    {
                        tempx = "x" + i.ToString() + " = xx";
                        textBoxwejsciowewart.AppendText(tempx);
                        textBoxwejsciowewart.AppendText(Environment.NewLine);
                        tempy = "y" + i.ToString() + " = xx";
                        textBoxwejsciowewart.AppendText(tempy);
                        textBoxwejsciowewart.AppendText(Environment.NewLine);
                    }
                    else
                    {
                        tempx = "x" + i.ToString() + " = xx";
                        textBoxwejsciowewart.AppendText(tempx);
                        textBoxwejsciowewart.AppendText(Environment.NewLine);
                        tempy = "y" + i.ToString() + " = xx";
                        textBoxwejsciowewart.AppendText(tempy);
                    }
                }
            }
        }

        private void MPC_Load(object sender, EventArgs e)
        {
            testclick();
            comboBoxPartySPDZ.SelectedIndex = 0;
            
        }

        private void buttonwyczyscSPDZ_Click(object sender, EventArgs e)
        {
            textBoxkonsola.Text = "";
        }

        private void buttoninicjalizujspdz_Click(object sender, EventArgs e)
        {
            textBoxkonsola.Text = "";
            Party = new Party_SPDZ[get_liczbaudzialow()];
            Random r = new Random();
            for(int i=0;i<get_liczbaudzialow();i++)
            {
                Party[i] = new Party_SPDZ(wartosci_x[i], wartosci_y[i], get_liczbaudzialow(), i, r.Next(500), r.Next(500), r.Next(200), r.Next(200));
            }
            /*foreach (Party_SPDZ P in Party)
            {

                //textBoxwejsciowewart.AppendText(temp);
                string temp = P.index.ToString() + " " + P.x.ToString()+" "+ P.randomvalue.ToString(); ;
                textBoxkonsola.AppendText(temp);
                textBoxkonsola.AppendText(Environment.NewLine);
            }
            int R = 0;
            foreach (Party_SPDZ P in Party)
            {
                R += P.send_r();
            }*/
            //textBoxkonsola.AppendText("R = " + R.ToString());
            //textBoxkonsola.AppendText(Environment.NewLine);

            for(int i=0;i<get_liczbaudzialow();i++)
            {
                for(int j=0;j<get_liczbaudzialow();j++)
                {
                    Party[i].received_rx += Party[j].send_rx();
                    textBoxkonsola.AppendText("P" + i + " otrzymuje od P" + j + " liczbę rx" + j + " = " + Party[j].send_rx().ToString() + ", suma Rx wynosi " + Party[i].received_rx);
                    textBoxkonsola.AppendText(Environment.NewLine);
                    Party[i].received_ry += Party[j].send_ry();
                    textBoxkonsola.AppendText("P" + i + " otrzymuje od P" + j + " liczbę ry" + j + " = " + Party[j].send_ry().ToString() + ", suma Ry wynosi " + Party[i].received_ry);
                    textBoxkonsola.AppendText(Environment.NewLine);
                }
            }

            for(int i=0;i<get_liczbaudzialow();i++)
            {
                for(int j=0;j<get_liczbaudzialow();j++)
                {
                    if(Party[j].index==0)
                    {
                        Party[j].udzialx[i] = Party[j].randomvalue_x + Party[i].send_x_minus_rx();
                        textBoxkonsola.AppendText("P" + j + " oblicza x" + i + j + " = " + Party[j].udzialx[i]);
                        textBoxkonsola.AppendText(Environment.NewLine);
                        Party[j].udzialy[i] = Party[j].randomvalue_y + Party[i].send_y_minus_ry();
                        textBoxkonsola.AppendText("P" + j + " oblicza y" + i + j + " = " + Party[j].udzialy[i]);
                        textBoxkonsola.AppendText(Environment.NewLine);
                    }
                    else
                    {
                        Party[j].udzialx[i] = Party[j].randomvalue_x;
                        textBoxkonsola.AppendText("P" + j + " ustawia x" + i + j + " = " + Party[j].randomvalue_x);
                        textBoxkonsola.AppendText(Environment.NewLine);
                        Party[j].udzialy[i] = Party[j].randomvalue_y;
                        textBoxkonsola.AppendText("P" + j + " ustawia y" + i + j + " = " + Party[j].randomvalue_y);
                        textBoxkonsola.AppendText(Environment.NewLine);
                    }
                }
            }
            buttonObliczX.Enabled = true;
            buttondodawaniespdz.Enabled = true;
            buttonmnozeniespdz.Enabled = true;
        }

        private void buttondodawaniespdz_Click(object sender, EventArgs e)
        {
            //string temp = comboBoxdodawanie2.SelectedItem.ToString();
            //string temp1 = temp.Substring(temp.Length - 1, 1);
            //textBoxkonsola.AppendText(temp);
            //int ind = Convert.ToInt32(temp1);
            //int sum = 0;
            //int P_sum = 0;
            string temp1, temp2;
            temp1 = comboBoxdodawanie1.SelectedItem.ToString();
            temp2 = comboBoxdodawanie2.SelectedItem.ToString();

            string zm_1 = temp1.Substring(0, 1);
            string zm_2 = temp2.Substring(0, 1);

            int nr_zm_1 = Convert.ToInt32(temp1.Substring(1, 1));
            int nr_zm_2 = Convert.ToInt32(temp2.Substring(1, 1));

            textBoxkonsola.AppendText(temp1 + " + " + temp2);
            textBoxkonsola.AppendText(Environment.NewLine);
            textBoxkonsola.AppendText("Zbieranie udziałów");
            textBoxkonsola.AppendText(Environment.NewLine);

            int loc_sum = 0;
            int sum = 0;

            foreach (Party_SPDZ P in Party)
            {
                if(zm_1.Equals("x"))
                {
                    loc_sum += P.udzialx[nr_zm_1];
                    textBoxkonsola.AppendText("P" + P.index + " dodaje " + zm_1 + nr_zm_1 + P.index + " + ");
                }
                if(zm_1.Equals("y"))
                {
                    loc_sum += P.udzialy[nr_zm_1];
                    textBoxkonsola.AppendText("P" + P.index + " dodaje " + zm_1 + nr_zm_1 + P.index + " + ");
                }

                if (zm_2.Equals("x"))
                {
                    loc_sum += P.udzialx[nr_zm_2];
                    textBoxkonsola.AppendText(zm_2 + nr_zm_2 + P.index + " = " + loc_sum);
                    textBoxkonsola.AppendText(Environment.NewLine);
                }
                if (zm_2.Equals("y"))
                {
                    loc_sum += P.udzialy[nr_zm_2];
                    textBoxkonsola.AppendText(zm_2 + nr_zm_2 + P.index + " = " + loc_sum);
                    textBoxkonsola.AppendText(Environment.NewLine);
                }
                sum += loc_sum;
                loc_sum = 0;
            }
            textBoxkonsola.AppendText(temp1 + " + " + temp2 + " = " + sum);
            textBoxkonsola.AppendText(Environment.NewLine);
            sum = 0;
        }

        private void buttonmnozeniespdz_Click(object sender, EventArgs e)
        {
            string temp1, temp2;
            temp1 = comboBoxmnozenie1.SelectedItem.ToString();
            temp2 = comboBoxmnozenie2.SelectedItem.ToString();

            string zm_1 = temp1.Substring(0, 1);
            string zm_2 = temp2.Substring(0, 1);

            int nr_zm_1 = Convert.ToInt32(temp1.Substring(1, 1));
            int nr_zm_2 = Convert.ToInt32(temp2.Substring(1, 1));

            textBoxkonsola.AppendText(temp1 + " * " + temp2);
            textBoxkonsola.AppendText(Environment.NewLine);
            textBoxkonsola.AppendText("Zbieranie udziałów");
            textBoxkonsola.AppendText(Environment.NewLine);

            int x = 0;
            int y = 0;
            int a = 0;
            int b = 0;
            int c = 0;
            //zbieranie x-a i y-b
            foreach (Party_SPDZ P in Party)
            {
                if (zm_1.Equals("x"))
                {
                    x+=P.udzialx[nr_zm_1];
                    textBoxkonsola.AppendText("P" + P.index + " oblicza " + zm_1 + nr_zm_1 + P.index + " - a" + P.index);
                    textBoxkonsola.AppendText(Environment.NewLine);
                    a += P.a;
                }
                if (zm_1.Equals("y"))
                {
                    x += P.udzialy[nr_zm_1];
                    textBoxkonsola.AppendText("P" + P.index + " oblicza " + zm_1 + nr_zm_1 + P.index + " - a" + P.index);
                    textBoxkonsola.AppendText(Environment.NewLine);
                    a += P.a;
                }

                if (zm_2.Equals("x"))
                {
                    y += P.udzialx[nr_zm_2];
                    textBoxkonsola.AppendText("P" + P.index + " oblicza " + zm_2 + nr_zm_2 + P.index + " - b" + P.index);
                    textBoxkonsola.AppendText(Environment.NewLine);
                    b += P.b;
                }
                if (zm_2.Equals("y"))
                {
                    y += P.udzialy[nr_zm_2];
                    textBoxkonsola.AppendText("P" + P.index + " oblicza " + zm_2 + nr_zm_2 + P.index + " - b" + P.index);
                    textBoxkonsola.AppendText(Environment.NewLine);
                    b += P.b;
                }
                //c += P.c;
            }
            c = a * b;
            textBoxkonsola.AppendText(zm_1 + nr_zm_1 + " - a = " + (x-a));
            textBoxkonsola.AppendText(Environment.NewLine);
            textBoxkonsola.AppendText(zm_2 + nr_zm_2 + " - b = " + (y- b));
            textBoxkonsola.AppendText(Environment.NewLine);
            int z_sum = 0;

            z_sum = c + ((x - a) * b) + ((y - b) * a) + ((x - a) * (y - b));

            textBoxkonsola.AppendText(temp1 + " * " + temp2 + " = " + z_sum);
            textBoxkonsola.AppendText(Environment.NewLine);
            z_sum = 0;
        }

        private void buttonwyczyscgmwkonsola_Click(object sender, EventArgs e)
        {
            textBoxkonsolagmw.Clear();
        }

        private void buttonObliczX_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            int it = 0;
            comboBoxPartySPDZ.Refresh();
            string ind = comboBoxPartySPDZ.SelectedItem.ToString();
            string zmienna = ind.Substring(0, 1);
            ind = ind.Substring(1, ind.Length - 1);
            int nr_zmiennej = Convert.ToInt32(ind);
            //textBoxkonsola.AppendText(ind);
            //textBoxkonsola.AppendText(ind.ToString());
            textBoxkonsola.AppendText(zmienna + ind + " = ");
            foreach (Party_SPDZ P in Party)
            {
                if (zmienna.Equals("x"))
                {
                    x += P.udzialx[nr_zmiennej];
                    if (!(it == get_liczbaudzialow() - 1))
                        textBoxkonsola.AppendText(P.udzialx[nr_zmiennej].ToString() + " + ");
                    else
                    {
                        textBoxkonsola.AppendText(P.udzialx[nr_zmiennej].ToString());
                        textBoxkonsola.AppendText(Environment.NewLine);
                    }
                    //textBoxkonsola.AppendText(Environment.NewLine);
                    it++;
                }
                if(zmienna.Equals("y"))
                {
                    y += P.udzialy[nr_zmiennej];
                    if (!(it == get_liczbaudzialow() - 1))
                        textBoxkonsola.AppendText(P.udzialy[nr_zmiennej].ToString() + " + ");
                    else
                    {
                        textBoxkonsola.AppendText(P.udzialy[nr_zmiennej].ToString());
                        textBoxkonsola.AppendText(Environment.NewLine);
                    }
                    //textBoxkonsola.AppendText(Environment.NewLine);
                    it++;
                }
            }
            if (zmienna.Equals("x"))
                textBoxkonsola.AppendText("Wartość " + zmienna + ind + " = " + x);
            if (zmienna.Equals("y"))
                textBoxkonsola.AppendText("Wartość " + zmienna + ind + " = " + y);
            textBoxkonsola.AppendText(Environment.NewLine);
            
        }

        private void checkBoxwartosciudzialowgmw_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxwartosciudzialowgmw.Text) && checkBoxwartosciudzialowgmw.Checked == true)
            {
                textBoxwartosciudzialowgmw.Text = "";
                int udzialy = getliczbaudzialowgmw();
                string tempx = string.Empty;
                //string tempy = string.Empty;
                for (int i = 0; i < udzialy; i++)
                {
                    if (i != udzialy - 1)
                    {
                        tempx = "x" + i.ToString() + " = " + wartosci_gmw[i];
                        textBoxwartosciudzialowgmw.AppendText(tempx);
                        textBoxwartosciudzialowgmw.AppendText(Environment.NewLine);
                    }
                    else
                    {
                        tempx = "x" + i.ToString() + " = " + wartosci_gmw[i];
                        textBoxwartosciudzialowgmw.AppendText(tempx);
                    }
                }
            }
            if (!string.IsNullOrWhiteSpace(textBoxwartosciudzialowgmw.Text) && checkBoxwartosciudzialowgmw.Checked == false)
            {
                textBoxwartosciudzialowgmw.Text = "";
                int udzialy = getliczbaudzialowgmw();
                string tempx = string.Empty;
                //string tempy = string.Empty;
                for (int i = 0; i < udzialy; i++)
                {
                    if (i != udzialy - 1)
                    {
                        tempx = "x" + i.ToString() + " = xx";
                        textBoxwartosciudzialowgmw.AppendText(tempx);
                        textBoxwartosciudzialowgmw.AppendText(Environment.NewLine);
                    }
                    else
                    {
                        tempx = "x" + i.ToString() + " = xx";
                        textBoxwartosciudzialowgmw.AppendText(tempx);
                    }
                }
            }
        }

        private void buttongenerujudzialygmw_Click(object sender, EventArgs e)
        {
            comboBoxobliczxgmw.Items.Clear();
            comboBoxgmwnot.Items.Clear();
            comboBoxand1.Items.Clear();
            comboBoxand2.Items.Clear();
            textBoxwartosciudzialowgmw.Text = "";
            textBoxliczbaudzialowgmw.Text = "";
            Random lugmw = new Random();
            int liczba_udzialow_gmw = lugmw.Next(2, 11);
            wartosci_gmw = new int[liczba_udzialow_gmw];
            Random wart_gmw = new Random();
            for(int i=0;i<liczba_udzialow_gmw;i++)
            {
                wartosci_gmw[i] = wart_gmw.Next(1000);
                comboBoxobliczxgmw.Items.Add("x" + i);
                comboBoxgmwnot.Items.Add("x" + i);
                comboBoxand1.Items.Add("x" + i);
                comboBoxand2.Items.Add("x" + i);
            }
            textBoxliczbaudzialowgmw.Text = liczba_udzialow_gmw.ToString();
            comboBoxobliczxgmw.SelectedIndex = 0;
            comboBoxgmwnot.SelectedIndex = 0;
            comboBoxand1.SelectedIndex = 0;
            comboBoxand2.SelectedIndex = 0;
            string tempx = string.Empty;
            for (int i = 0; i < liczba_udzialow_gmw; i++)
            {
                if (!checkBoxwartosciudzialowgmw.Checked)
                {
                    if (i != liczba_udzialow_gmw - 1)
                    {
                        tempx = "x" + i.ToString() + " = xx";
                        textBoxwartosciudzialowgmw.AppendText(tempx);
                        textBoxwartosciudzialowgmw.AppendText(Environment.NewLine);
                    }
                    else
                    {
                        tempx = "x" + i.ToString() + " = xx";
                        textBoxwartosciudzialowgmw.AppendText(tempx);
                    }
                }
                else
                {

                    if (i != liczba_udzialow_gmw - 1)
                    {
                        tempx = "x" + i.ToString() + " = " + wartosci_gmw[i];
                        textBoxwartosciudzialowgmw.AppendText(tempx);
                        textBoxwartosciudzialowgmw.AppendText(Environment.NewLine);
                    }
                    else
                    {
                        tempx = "x" + i.ToString() + " = " + wartosci_gmw[i];
                        textBoxwartosciudzialowgmw.AppendText(tempx);
                    }

                }
            }
            buttoninicjalizujgmw.Enabled = true;
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //buttongenerujudzialygmw.PerformClick();
        }

        private void buttoninicjalizujgmw_Click(object sender, EventArgs e)
        {
            textBoxkonsolagmw.Clear();
            Random r = new Random();
            Party_gmw = new Party_GMW87[getliczbaudzialowgmw()];
            for (int i = 0; i < getliczbaudzialowgmw(); i++)
            {
                Party_gmw[i] = new Party_GMW87(wartosci_gmw[i], getliczbaudzialowgmw(), i);
                textBoxkonsolagmw.AppendText("P" + i + " zamienia swoja liczbe x" + i + "na bity");
                textBoxkonsolagmw.AppendText(Environment.NewLine);
            }
            for(int i=0;i<getliczbaudzialowgmw();i++)
            {
                for(int j=0;j<Party_gmw[i].bity_x.Length;j++)
                {
                    int[] bits = Party_gmw[i].podziel_bit(j,r.Next(10));
                    int it = 0;
                    foreach(Party_GMW87 P in Party_gmw)
                    {
                        P.bity_udzialy[i, j] = bits[it];
                        textBoxkonsolagmw.AppendText("P" + i + " wysyla bit b|" + j + "|" + it + "| do P" + P.nr);
                        textBoxkonsolagmw.AppendText(Environment.NewLine);
                        it++;
                    }
                    it = 0;
                }
            }
            buttonobliczXgmw.Enabled = true;
            buttongmwnot.Enabled = true;
            buttonandgmw.Enabled = true;
        }

        public int getliczbaudzialowgmw()
        {
            return Convert.ToInt32(textBoxliczbaudzialowgmw.Text);
        }

        private void buttongmwnot_Click(object sender, EventArgs e)
        {
            string zmienna = comboBoxgmwnot.SelectedItem.ToString();
            zmienna = zmienna.Substring(1, 1);
            int zm = Convert.ToInt32(zmienna);
            //BitArray ba = new BitArray(new[] { 0 });
            textBoxkonsolagmw.AppendText("P0 zmienia swoje bity dla x" + zm + " + 1 mod 2");
            textBoxkonsolagmw.AppendText(Environment.NewLine);
            int[] bits = Party_gmw[0].notinitialize(zm);
            BitArray ba_not = new BitArray(new[] { 0 });
            for(int i=1;i<Party_gmw.Length;i++)
            {
                for(int j=0;j<bits.Length;j++)
                {
                    bits[j] += Party_gmw[i].bity_udzialy[zm, j];
                }
            }
            for(int i=0;i<ba_not.Length;i++)
            {
                ba_not[i] = Convert.ToBoolean(bits[i] % 2);
            }
            textBoxkonsolagmw.AppendText("NOT x" + zm + " = ");
            for (int i = ba_not.Length - 1; i >= 0; i--)
            {
                textBoxkonsolagmw.AppendText((ba_not[i] ? 1:0).ToString());
            }
            textBoxkonsolagmw.AppendText(" = ");
            var result = new int[1];
            ba_not.CopyTo(result, 0);
            textBoxkonsolagmw.AppendText((result[0]).ToString());
            textBoxkonsolagmw.AppendText(Environment.NewLine);
        }

        private void buttonandgmw_Click(object sender, EventArgs e)
        {
            string zmienna1 = comboBoxand1.SelectedItem.ToString();
            zmienna1 = zmienna1.Substring(1, 1);
            int zm1 = Convert.ToInt32(zmienna1);
            string zmienna2 = comboBoxand2.SelectedItem.ToString();
            zmienna2 = zmienna2.Substring(1, 1);
            int zm2 = Convert.ToInt32(zmienna2);
            textBoxkonsolagmw.AppendText("x" + zm1 + " AND x" + zm2);
            textBoxkonsolagmw.AppendText(Environment.NewLine);
            int[] bits1 = new int[Party_gmw[0].bity_x.Length];
            int[] bits2 = new int[Party_gmw[0].bity_x.Length];
            int[] bits_wyn = new int[Party_gmw[0].bity_x.Length];
            Random rnd = new Random();
            foreach(Party_GMW87 P in Party_gmw)
            {
                //int bji = rnd.Next(10) % 2;
                //Console.WriteLine(bji);
                for(int i=0;i<bits1.Length;i++)
                {
                    //int bji = rnd.Next(10) % 2;
                    bits1[i] += P.bity_udzialy[zm1, i];
                    bits2[i] += P.bity_udzialy[zm2, i];
                }
            }
            for (int i=0;i<bits1.Length;i++)
            {
                bits1[i] = bits1[i] % 2;
                bits2[i] = bits2[i] % 2;
            }
            textBoxkonsolagmw.AppendText("zbieranie udzialow");
            textBoxkonsolagmw.AppendText(Environment.NewLine);
            textBoxkonsolagmw.AppendText("x" + zm1 + "\t\t|");
            for (int i=bits1.Length-1;i>=0;i--)
            {
                textBoxkonsolagmw.AppendText(bits1[i] + "|");
            }
            textBoxkonsolagmw.AppendText(Environment.NewLine);
            textBoxkonsolagmw.AppendText("x" + zm2 + "\t\t|");
            for (int i = bits2.Length-1; i >= 0; i--)
            {
                textBoxkonsolagmw.AppendText(bits2[i] + "|");
            }
            textBoxkonsolagmw.AppendText(Environment.NewLine);
            BitArray ba_and = new BitArray(new[] { 0 });
            for (int i = 0; i < ba_and.Length; i++)
            {
                bits_wyn[i] = bits1[i] * bits2[i];
                ba_and[i] = Convert.ToBoolean(bits_wyn[i]);
            }
            //ba_and[i] = Convert.ToBoolean(bits[i]);
            textBoxkonsolagmw.AppendText("x" + zm1 + " AND x" + zm2 + "\t|");
            for (int i = ba_and.Length - 1; i >= 0; i--)
            {
                textBoxkonsolagmw.AppendText((ba_and[i] ? 1 : 0).ToString() + "|");
            }
            textBoxkonsolagmw.AppendText(" = ");
            var result = new int[1];
            ba_and.CopyTo(result, 0);
            textBoxkonsolagmw.AppendText((result[0]).ToString());
            textBoxkonsolagmw.AppendText(Environment.NewLine);
        }
        
        private void buttongenerujmil_Click(object sender, EventArgs e)
        {
            textBoxannamil.Text = "";
            textBoxbartoszmil.Text = "";
            //Random r = new Random();

            mil = new Millioner();
            generuj_mil();
            
            if(!checkBoxmil.Checked)
            {
                textBoxannamil.Text = "I = x";
                textBoxbartoszmil.Text = "J = x";
            }
            else
            {
                textBoxannamil.Text = "I = " + I;
                textBoxbartoszmil.Text = "J = " + J;
            }
            buttonobliczmil.Enabled = true;
        }

        private void checkBoxmil_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxmil.Checked)
            {
                textBoxannamil.Text = "I = x";
                textBoxbartoszmil.Text = "J = x";
            }
            else
            {
                textBoxannamil.Text = "I = " + I;
                textBoxbartoszmil.Text = "J = " + J;
            }
        }

        private void buttonwyczyscmil_Click(object sender, EventArgs e)
        {
            textBoxkonsolamil.Text = "";
        }
        private void buttonobliczmil_Click(object sender, EventArgs e)
        {
            textBoxkonsolamil.AppendText("Anna oblicza klucze RSA i wysyla klucz publiczny (n,e) do Bartosza");
            System.Threading.Thread.Sleep(500);
            textBoxkonsolamil.AppendText(Environment.NewLine);
            Random r = new Random();
            int bart_x = 4;
            int C = (int)Math.Pow(bart_x, mil.e)%mil.n;
            int m = C - J + 1;
            textBoxkonsolamil.AppendText("Bartosz wybiera losowa liczbe X i wykonuje obliczenie C = X^e mod n");
            textBoxkonsolamil.AppendText(Environment.NewLine);
            System.Threading.Thread.Sleep(500);
            textBoxkonsolamil.AppendText("Bartosz wysyla do anny liczbe m = C - J + 1");
            textBoxkonsolamil.AppendText(Environment.NewLine);
            System.Threading.Thread.Sleep(500);
            //textBoxkonsolamil.AppendText("X =" + bart_x);
            //textBoxkonsolamil.AppendText(Environment.NewLine);
            int[] Yj = new int[100];
            for(int i=0;i<Yj.Length;i++)
            {
                Yj[i] = (int)Math.Pow((m + i - 1), mil.d)%mil.n;
                //textBoxkonsolamil.AppendText("Yj" + i + " = " + Yj[i]);
               // textBoxkonsolamil.AppendText(Environment.NewLine);
            }
            textBoxkonsolamil.AppendText("Anna oblicza Yj = (m + j - 1)^d mod n dla każdego możliwego J Bartosza");
            textBoxkonsolamil.AppendText(Environment.NewLine);
            System.Threading.Thread.Sleep(500);
            int[] Zj = new int[100];
            for(int i=0;i<Zj.Length;i++)
            {
                Zj[i] = Yj[i] % 3;
            }
            textBoxkonsolamil.AppendText("Anna oblicza Zj = Yj mod p i dobiera p, tak by wszystkie zredukowane wartości różniły się conajmniej o 2");
            textBoxkonsolamil.AppendText(Environment.NewLine);
            System.Threading.Thread.Sleep(500);
            int[] Wj = new int[100];
            for(int i=0;i< I;i++)
            {
                Wj[i] = Zj[i];
            }
            for(int i= I;i<Wj.Length;i++)
            {
                Wj[i] = Zj[i] + 1;
            }

            textBoxkonsolamil.AppendText("Anna dodaje 1 do wszystkich Zj o indeksie większym lub równym I. Następnie przekazuje Bartoszowi ciąg wartości W1, W2, ...WM, czyli Z1, Z2, .. , ZI−1, ZI + 1, ZI + 1 + 1, ..ZM + 1 i liczbę p.");
            textBoxkonsolamil.AppendText(Environment.NewLine);
            System.Threading.Thread.Sleep(500);
            textBoxkonsolamil.AppendText("Bartosz sprawdza, czy W[J] = X mod p. Jeżeli nie, to znaczy że Anna zaczęła dodawać jedynkę do wartości Zj dla indeksów mniejszych niż J, czyli I < J.");
            textBoxkonsolamil.AppendText(Environment.NewLine);
            System.Threading.Thread.Sleep(500);
            if (Wj[J] == bart_x%3)
            {
                textBoxkonsolamil.AppendText("Anna jest bogatsza od Bartosza");
                textBoxkonsolamil.AppendText(Environment.NewLine);
            }
            else
            {
                textBoxkonsolamil.AppendText("Bartosz jest bogatszy od Anny");
                textBoxkonsolamil.AppendText(Environment.NewLine);
            }
        }

        private void buttongenlove_Click(object sender, EventArgs e)
        {
            Random r_love = new Random();
            bool anna = r_love.Next(100) >= 50 ? true : false;
            bool bartosz = r_love.Next(100) >= 50 ? true : false;
            Anna = new Love(anna, anna, "Anna");
            Bartosz = new Love(bartosz, bartosz, "Bartosz");
            if(checkBoxlove.Checked)
            {
                if(anna)
                {
                    textBoxannalove.Text = "Kocha";
                }
                else
                {
                    textBoxannalove.Text = "Nie kocha";
                }
                if(bartosz)
                {
                    textBoxbartoszlove.Text = "Kocha";
                }
                else
                {
                    textBoxbartoszlove.Text = "Nie kocha";
                }
            }
            else
            {
                textBoxannalove.Text = "xxx";
                textBoxbartoszlove.Text = "xxx";
            }
            buttonannalovebartosz.Enabled = true;
            buttonbartoszloveanna.Enabled = true;
        }

        private void checkBoxlove_CheckedChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textBoxannalove.Text) && !string.IsNullOrWhiteSpace(textBoxbartoszlove.Text))
            {
                if (checkBoxlove.Checked)
                {
                    if (Anna.gets1())
                    {
                        textBoxannalove.Text = "Kocha";
                    }
                    else
                    {
                        textBoxannalove.Text = "Nie kocha";
                    }
                    if (Bartosz.gets1())
                    {
                        textBoxbartoszlove.Text = "Kocha";
                    }
                    else
                    {
                        textBoxbartoszlove.Text = "Nie kocha";
                    }
                }
                else
                {
                    textBoxannalove.Text = "xxx";
                    textBoxbartoszlove.Text = "xxx";
                }
            }
        }

        private void buttonannalovebartosz_Click(object sender, EventArgs e)
        {
            bool b = Anna.getb();
            textBoxkonsolalove.AppendText(Anna.getimie() + " wybiera swój bit b (kocha/nie kocha)");
            textBoxkonsolalove.AppendText(Environment.NewLine);
            System.Threading.Thread.Sleep(500);
            if (b == Bartosz.gets0() && Bartosz.gets1() == false)
            {
                textBoxkonsolalove.AppendText("Bit Anny to 0, więc wybiera ona wartość Bartosza s0");
                textBoxkonsolalove.AppendText(Environment.NewLine);
                System.Threading.Thread.Sleep(500);
                textBoxkonsolalove.AppendText("Anna i Bartosz nie kochają się");
                textBoxkonsolalove.AppendText(Environment.NewLine);
            }
            if(b == true && Bartosz.gets1() == false)
            {
                textBoxkonsolalove.AppendText("Bit Anny to 1, więc wybiera ona wartość Bartosza s1");
                textBoxkonsolalove.AppendText(Environment.NewLine);
                System.Threading.Thread.Sleep(500);
                textBoxkonsolalove.AppendText("Anna dowiaduje się, że Bartosz nie odwzajemnia jej uczucia bez zdradzania swoich uczuć");
                textBoxkonsolalove.AppendText(Environment.NewLine);
            }
            if (b == false && Bartosz.gets1() == true)
            {
                textBoxkonsolalove.AppendText("Bit Anny to 0, więc wybiera ona wartość Bartosza s0");
                textBoxkonsolalove.AppendText(Environment.NewLine);
                System.Threading.Thread.Sleep(500);
                textBoxkonsolalove.AppendText("Anna nie kocha Bartosza i nie wie, czy on kocha ją");
                textBoxkonsolalove.AppendText(Environment.NewLine);
            }
            if(b==true && Bartosz.gets1()==true)
            {
                textBoxkonsolalove.AppendText("Bit Anny to 1, więc wybiera ona wartość Bartosza s1");
                textBoxkonsolalove.AppendText(Environment.NewLine);
                System.Threading.Thread.Sleep(500);
                textBoxkonsolalove.AppendText("Anna dowiaduje się, że Bartosz odwzajemnia jej uczucie");
                textBoxkonsolalove.AppendText(Environment.NewLine);
            }
        }

        private void buttonbartoszloveanna_Click(object sender, EventArgs e)
        {
            bool b = Bartosz.getb();
            textBoxkonsolalove.AppendText(Bartosz.getimie() + " wybiera swój bit b (kocha/nie kocha)");
            textBoxkonsolalove.AppendText(Environment.NewLine);
            System.Threading.Thread.Sleep(500);
            if (b == Anna.gets0() && Anna.gets1() == false)
            {
                textBoxkonsolalove.AppendText("Bit Bartosza to 0, więc wybiera ona wartość Anny s0");
                textBoxkonsolalove.AppendText(Environment.NewLine);
                System.Threading.Thread.Sleep(500);
                textBoxkonsolalove.AppendText("Bartosz i Anna nie kochają się");
                textBoxkonsolalove.AppendText(Environment.NewLine);
            }
            if (b == true && Anna.gets1() == false)
            {
                textBoxkonsolalove.AppendText("Bit Bartosza to 1, więc wybiera ona wartość Anny s1");
                textBoxkonsolalove.AppendText(Environment.NewLine);
                System.Threading.Thread.Sleep(500);
                textBoxkonsolalove.AppendText("Bartosz dowiaduje się, że Anna nie odwzajemnia jego uczucia bez zdradzania swoich uczuć");
                textBoxkonsolalove.AppendText(Environment.NewLine);
            }
            if (b == false && Anna.gets1() == true)
            {
                textBoxkonsolalove.AppendText("Bit Bartosza to 0, więc wybiera ona wartość Anny s0");
                textBoxkonsolalove.AppendText(Environment.NewLine);
                System.Threading.Thread.Sleep(500);
                textBoxkonsolalove.AppendText("Bartosz nie kocha Anny i nie wie, czy ona kocha jego");
                textBoxkonsolalove.AppendText(Environment.NewLine);
            }
            if (b == true && Anna.gets1() == true)
            {
                textBoxkonsolalove.AppendText("Bit Bartosza to 1, więc wybiera ona wartość Anny s1");
                textBoxkonsolalove.AppendText(Environment.NewLine);
                System.Threading.Thread.Sleep(500);
                textBoxkonsolalove.AppendText("Bartosz dowiaduje się, że Anna odwzajemnia jego uczucie");
                textBoxkonsolalove.AppendText(Environment.NewLine);
            }
        }

        private void buttonwyczysclove_Click(object sender, EventArgs e)
        {
            textBoxkonsolalove.Text = "";
        }

        private void buttonobliczXgmw_Click(object sender, EventArgs e)
        {
            string zmienna = comboBoxobliczxgmw.SelectedItem.ToString();
            zmienna = zmienna.Substring(1, 1);
            int zm = Convert.ToInt32(zmienna);
            BitArray ba = new BitArray(new[] { 0 });
            textBoxkonsolagmw.AppendText("x" + zm + " = ");
            int[] bit_sum = new int[ba.Length];
            foreach (Party_GMW87 P in Party_gmw)
            {
                for (int j = 0; j < ba.Length; j++)
                {
                    bit_sum[j] += P.bity_udzialy[zm, j];
                }
            }
            for(int i=0;i<bit_sum.Length;i++)
            {
                //textBoxkonsolagmw.AppendText((bit_sum[i] % 2).ToString());
                ba[i] = Convert.ToBoolean(bit_sum[i] % 2);
            }
            for(int i=bit_sum.Length-1;i>=0;i--)
            {
                textBoxkonsolagmw.AppendText((bit_sum[i] % 2).ToString());
            }
            textBoxkonsolagmw.AppendText(" = ");
            var result = new int[1];
            ba.CopyTo(result, 0);
            textBoxkonsolagmw.AppendText(result[0].ToString());
            textBoxkonsolagmw.AppendText(Environment.NewLine);
            //return result[0];
        }
        void generuj_mil()
        {
            Random r = new Random();

            I = r.Next(4, 90);
            J = r.Next(4, 90);

            if (I == J)
            {
                bool takie_same = false;
                while (!takie_same)
                {
                    J = r.Next(4, 9);
                    if (J != I)
                        takie_same = true;
                }
            }
        }
    }
}
