using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Data.SqlClient;


namespace ProjectAhmadMalakh
{
    public partial class AllValues : MaterialForm
    {
        public static double cost = 0.0;
        // Create a List of int  
        //public static int[] costInputValue;
        public AllValues()
        {
            InitializeComponent();
        }
        private void ReloadForm()
        {
            LoadData();
            //and how many controls or settings you want, just add them here
        }
        DataTable table = new DataTable();
        private void LoadData()
        {



            dataGridView1.DataSource = table;

            dataGridView1.RowTemplate.Height = 50;

           

            //int rowindex =dataGridView1.CurrentCell.RowIndex; ;
            //int columnindex = dataGridView1.CurrentCell.ColumnIndex;

            //dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString();

            //MessageBox.Show(dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString());
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Material Name", typeof(string));
            table.Columns.Add("Material Estimation", typeof(string));
            table.Columns.Add("Enter the cost :", typeof(int));
            table.Columns.Add("Cost", typeof(int));


            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            table.Rows.Add(1, "Horizontal Frames ", Form2.TheHorizontalFrames, (cost * (int.Parse(Form2.TheHorizontalFrames))), 1);
            table.Rows.Add(2, "Vertical Frames ", Form2.TheVerticalFrames, (cost * (int.Parse(Form2.TheVerticalFrames))), 1);
            table.Rows.Add(3, "Total Area", Form2.TotalArea, (cost * (int.Parse(Form2.TheTotalArea))), 1);
            table.Rows.Add(4, "Rubber", Form2.TheRubber, (cost * (int.Parse(Form2.TheRubber))), 1);
            table.Rows.Add(5, "Starter Strip", Form2.TheStarterStrip, (cost * (int.Parse(Form2.TheStarterStrip))), 1);
            table.Rows.Add(6, "Shear Block", Form2.TheShearBlock, (cost * (int.Parse(Form2.TheShearBlock))), 1);
            table.Rows.Add(7, "Glass", Form2.TheGlass, (cost * (int.Parse(Form2.TheGlass))), 1);
            table.Rows.Add(8, "Perimeter", Form2.ThePerimeter, (cost * (int.Parse(Form2.ThePerimeter))), 1);
            table.Rows.Add(9, "Installation", Form2.TheHorizontalFrames, (cost * (int.Parse(Form2.TheInstallation))), 1);
            table.Rows.Add(10, "Fabrication", Form2.TheHorizontalFrames, (cost * (int.Parse(Form2.TheFabrication))), 1);


            //table.Rows.Add(1, "Horizontal Frames ", Form2.TheHorizontalFrames, (int.Parse(dataGridView1.Rows[0].Cells[4].Value.ToString()) * (int.Parse(Form2.TheHorizontalFrames))), 1);
            //table.Rows.Add(2, "Vertical Frames ", Form2.TheVerticalFrames, (int.Parse(dataGridView1.Rows[1].Cells[4].Value.ToString()) * (int.Parse(Form2.TheVerticalFrames))), 1);
            //table.Rows.Add(3, "Total Area", Form2.TotalArea, (int.Parse(dataGridView1.Rows[2].Cells[4].Value.ToString()) * (int.Parse(Form2.TheTotalArea))), 1);
            //table.Rows.Add(4, "Rubber", Form2.TheRubber, (int.Parse(dataGridView1.Rows[3].Cells[4].Value.ToString()) * (int.Parse(Form2.TheRubber))), 1);
            //table.Rows.Add(5, "Starter Strip", Form2.TheStarterStrip, (int.Parse(dataGridView1.Rows[4].Cells[4].Value.ToString()) * (int.Parse(Form2.TheStarterStrip))), 1);
            //table.Rows.Add(6, "Shear Block", Form2.TheShearBlock, (int.Parse(dataGridView1.Rows[5].Cells[4].Value.ToString()) * (int.Parse(Form2.TheShearBlock))), 1);
            //table.Rows.Add(7, "Glass", Form2.TheGlass, (int.Parse(dataGridView1.Rows[6].Cells[4].Value.ToString()) * (int.Parse(Form2.TheGlass))), 1);
            //table.Rows.Add(8, "Perimeter", Form2.ThePerimeter, (int.Parse(dataGridView1.Rows[7].Cells[4].Value.ToString()) * (int.Parse(Form2.ThePerimeter))), 1);
            //table.Rows.Add(9, "Installation", Form2.TheHorizontalFrames, (int.Parse(dataGridView1.Rows[8].Cells[4].Value.ToString()) * (int.Parse(Form2.TheInstallation))), 1);
            //table.Rows.Add(10, "Fabrication", Form2.TheHorizontalFrames, (int.Parse(dataGridView1.Rows[9].Cells[4].Value.ToString()) * (int.Parse(Form2.TheFabrication))), 1);


            dataGridView1.DataSource = table;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
            

            LoadData();

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllValues home = new AllValues();
            home.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        Bitmap bmp;
        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(dataGridView1.Size.Width, dataGridView1.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            this.Hide();
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

    

   
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SKCF6NO\\SQLEXPRESS;Initial Catalog=AllResult;Integrated Security=True");
        
            

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            DateTime dateTime = DateTime.UtcNow.Date;
            
            
            cmd = new SqlCommand("Insert into Final_Result(HorizontalFrames,VerticalFrames,TotalArea,Rubber,StarterStrip,ShearBlock,Glass,Perimeter,Installation,Fabrication,Time,Date) VALUES('" + Form2.TheHorizontalFrames + "','" + Form2.TheVerticalFrames + "','" + Form2.TotalArea + "','" + Form2.TheRubber + "'" +
                ",'" + Form2.TheStarterStrip + "','" + Form2.TheShearBlock + "','" + Form2.TheGlass + "','" + Form2.ThePerimeter + "'" +
                ",'" + Form2.TheInstallation + "','" + Form2.TheFabrication + "','" + (DateTime.Now.ToString("h:mm:ss tt")) + "','" + (dateTime.ToString("dd/MM/yyyy")) + "')", con);
            con.Open();
            int check = cmd.ExecuteNonQuery();
            if(check!=0)
            {
                MessageBox.Show("Data has been saved successfully");
            }
            else
            {
                MessageBox.Show("Error");
            }
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows[0].Cells[3].Value = (int.Parse(Form2.TheHorizontalFrames) * int.Parse(dataGridView1.Rows[0].Cells[4].Value.ToString()));
            dataGridView1.Rows[1].Cells[3].Value = (int.Parse(Form2.TheVerticalFrames) * int.Parse(dataGridView1.Rows[1].Cells[4].Value.ToString()));
            dataGridView1.Rows[2].Cells[3].Value = (int.Parse(Form2.TheTotalArea) * int.Parse(dataGridView1.Rows[2].Cells[4].Value.ToString()));
            dataGridView1.Rows[3].Cells[3].Value = (int.Parse(Form2.TheRubber) * int.Parse(dataGridView1.Rows[3].Cells[4].Value.ToString()));
            dataGridView1.Rows[4].Cells[3].Value = (int.Parse(Form2.TheStarterStrip) * int.Parse(dataGridView1.Rows[4].Cells[4].Value.ToString()));
            dataGridView1.Rows[5].Cells[3].Value = (int.Parse(Form2.TheShearBlock) * int.Parse(dataGridView1.Rows[5].Cells[4].Value.ToString()));
            dataGridView1.Rows[6].Cells[3].Value = (int.Parse(Form2.TheGlass) * int.Parse(dataGridView1.Rows[6].Cells[4].Value.ToString()));
            dataGridView1.Rows[7].Cells[3].Value = (int.Parse(Form2.ThePerimeter) * int.Parse(dataGridView1.Rows[7].Cells[4].Value.ToString()));
            dataGridView1.Rows[8].Cells[3].Value = (int.Parse(Form2.TheHorizontalFrames) * int.Parse(dataGridView1.Rows[8].Cells[4].Value.ToString()));
            dataGridView1.Rows[9].Cells[3].Value = (int.Parse(Form2.TheHorizontalFrames) * int.Parse(dataGridView1.Rows[9].Cells[4].Value.ToString()));
           
        }
    }

}
