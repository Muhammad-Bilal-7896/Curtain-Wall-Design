using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAhmadMalakh
{
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        Bitmap bmp;
        private void LoadData()
        {
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Material Name", typeof(string));
            table.Columns.Add("Material Estimation", typeof(string));
            

            dataGridView1.DataSource = table;

            dataGridView1.RowTemplate.Height = 50;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            //table.Rows.Add(Form2.TheHorizontalFrames + ",    " + (cost * (int.Parse(Form2.TheHorizontalFrames))) + " $",
            //    Form2.TheTotalArea + "ft,    " + (cost * (int.Parse(Form2.TheTotalArea))) + " $",
            //    Form2.TheVerticalFrames + ",    " + (cost * (int.Parse(Form2.TheVerticalFrames))) + " $",
            //    Form2.TheRubber + "ft,    " + (cost * (int.Parse(Form2.TheRubber))) + " $",
            //    Form2.TheStarterStrip + "ft,    " + (cost * (int.Parse(Form2.TheStarterStrip))) + " $",
            //    Form2.TheShearBlock + "ft,    " + (cost * (int.Parse(Form2.TheShearBlock))) + " $",
            //    Form2.TheGlass + "ft,    " + (cost * (int.Parse(Form2.TheGlass))) + " $",
            //    Form2.ThePerimeter + "ft,    " + (cost * (int.Parse(Form2.ThePerimeter))) + " $",
            //    Form2.TheInstallation + "ft,    " + (cost * (int.Parse(Form2.TheInstallation))) + " $",
            //    Form2.TheFabrication + "ft,    " + (cost * (int.Parse(Form2.TheFabrication))) + " $"
            //    );
            table.Rows.Add(1, "Time Submitted ", Form4.time);
            table.Rows.Add(2, "Date Submitted ", Form4.date);
            table.Rows.Add(3, "Horizontal Frames ", Form4.TheHorizontalFrames);
            table.Rows.Add(4, "Vertical Frames ", Form4.TheVerticalFrames);
            table.Rows.Add(5, "Total Area", Form4.TheTotalArea);
            table.Rows.Add(6, "Rubber", Form4.TheRubber);
            table.Rows.Add(7, "Starter Strip", Form4.TheStarterStrip);
            table.Rows.Add(8, "Shear Block", Form4.TheShearBlock);
            table.Rows.Add(9, "Glass", Form4.TheGlass);
            table.Rows.Add(10, "Perimeter", Form4.ThePerimeter);
            table.Rows.Add(11, "Installation", Form4.TheHorizontalFrames);
            table.Rows.Add(12, "Fabrication", Form4.TheHorizontalFrames);

            dataGridView1.DataSource = table;
        }

        private void Details_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
