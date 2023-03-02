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

namespace MayinTarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList mayinlar = new ArrayList();

        private void kolayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mayinlar.Clear();
            tableLayoutPanel1.Controls.Clear();
            int oMayin = 15;
            int oTarla = 81;
            tableLayoutPanel1.ColumnCount = 9;
            label2.Text = "Mayin:" +oMayin;
            label3.Text = "Boyut" + tableLayoutPanel1.ColumnCount + " x " + tableLayoutPanel1.ColumnCount;   
            
            Random rast = new Random();
            int sayi = 0;
            for (int i = 0; i < oMayin; i++)
            {
                uret:
                sayi = rast.Next(0, oTarla);
                if (mayinlar.Contains(sayi)) 
                {
                    goto uret;
                }
                else
                {
                    mayinlar.Add(sayi);
                }
            }

            for (int i = 0; i < oTarla; i++)
            {
                Button button = new Button();
                button.Size = new Size(50, 50);
                if (mayinlar.Contains(i))
                {
                    button.Tag = -1;
                }
                else
                {
                   button.Tag = rast.Next(1, 20);
                }
                button.Click += button_Click;
                tableLayoutPanel1.Controls.Add(button);
            }
            this.Size = new Size(tableLayoutPanel1.ColumnCount * 50 + 25, tableLayoutPanel1.ColumnCount * 50 + 110);
        }

        int gPuan = 0;

        private void button_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            if (int.Parse(tiklanan.Tag.ToString()) == -1)
            {
                tiklanan.BackgroundImage = Image.FromFile("mayin.png");
                tiklanan.BackColor = Color.Red;
                for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
                {
                    tableLayoutPanel1.Controls[i].Enabled = false;
                    if (int.Parse(tableLayoutPanel1.Controls[i].Tag.ToString()) == -1)
                    {
                        tableLayoutPanel1.Controls[i].BackgroundImage = Image.FromFile("mayin.png");
                    }
                    else
                    {
                        tableLayoutPanel1.Controls[i].Text = tableLayoutPanel1.Controls[i].Tag.ToString();
                    }
                }
            }
            else
            {
                gPuan += int.Parse(tiklanan.Tag.ToString());
                tiklanan.Text = tiklanan.Tag.ToString();
                label1.Text = "Puan:" + gPuan;
                tiklanan.Enabled =  false;
            }
        }

        private void ortaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mayinlar.Clear();
            tableLayoutPanel1.Controls.Clear();
            int oMayin = 30;
            int oTarla = 81;
            tableLayoutPanel1.ColumnCount = 9;
            label2.Text = "Mayin:" + oMayin;
            label3.Text = "Boyut" + tableLayoutPanel1.ColumnCount + " x " + tableLayoutPanel1.ColumnCount;
            
            Random rast = new Random();
            int sayi = 0;
            for (int i = 0; i < oMayin; i++)
            {
            uret:
                sayi = rast.Next(0, oTarla);
                if (mayinlar.Contains(sayi))
                {
                    goto uret;
                }
                else
                {
                    mayinlar.Add(sayi);
                }
            }

            for (int i = 0; i < oTarla; i++)
            {
                Button button = new Button();
                button.Size = new Size(50, 50);
                if (mayinlar.Contains(i))
                {
                    button.Tag = -1;
                }
                else
                {
                    button.Tag = rast.Next(1, 20);
                }
                button.Click += button_Click;
                tableLayoutPanel1.Controls.Add(button);
            }
            this.Size = new Size(tableLayoutPanel1.ColumnCount * 50 + 25, tableLayoutPanel1.ColumnCount * 50 + 110);
        }

        private void zorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mayinlar.Clear();
            tableLayoutPanel1.Controls.Clear();
            int oMayin = 45;
            int oTarla = 81;
            tableLayoutPanel1.ColumnCount = 9;
            label2.Text = "Mayin:" + oMayin;
            label3.Text = "Boyut" + tableLayoutPanel1.ColumnCount + " x " + tableLayoutPanel1.ColumnCount;
            
            Random rast = new Random();
            int sayi = 0;
            for (int i = 0; i < oMayin; i++)
            {
            uret:
                sayi = rast.Next(0, oTarla);
                if (mayinlar.Contains(sayi))
                {
                    goto uret;
                }
                else
                {
                    mayinlar.Add(sayi);
                }
            }

            for (int i = 0; i < oTarla; i++)
            {
                Button button = new Button();
                button.Size = new Size(50, 50);
                if (mayinlar.Contains(i))
                {
                    button.Tag = -1;
                }
                else
                {
                    button.Tag = rast.Next(1, 20);
                }
                button.Click += button_Click;
                tableLayoutPanel1.Controls.Add(button);
            }
            this.Size = new Size(tableLayoutPanel1.ColumnCount * 50 + 25, tableLayoutPanel1.ColumnCount * 50 + 110);
        }
    }
}
