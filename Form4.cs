using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectAhmadMalakh
{
    public partial class Form4 : Form
    {
        public static string TheHorizontalFrames = "";
        public static string TheTotalArea = "";
        public static string TheVerticalFrames = "";
        public static string TheRubber = "";
        public static string TheStarterStrip = "";
        public static string TheShearBlock = "";
        public static string TheGlass = "";
        public static string ThePerimeter = "";
        public static string TheInstallation = "";
        public static string TheFabrication = "";
        public static string time;
        public static string date;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.RowTemplate.MinimumHeight = 40;
            //var dgv = new DataGridView();
            //dataGridView1.RowTemplate.Height = 90;
            // TODO: This line of code loads data into the 'allResultDataSet.Final_Result' table. You can move, or remove it, as needed.
            this.final_ResultTableAdapter.Fill(this.allResultDataSet.Final_Result);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                finalResultBindingSource.EndEdit();
                final_ResultTableAdapter.Update(allResultDataSet.Final_Result);
                MessageBox.Show("Database Updated");
                this.final_ResultTableAdapter.Fill(this.allResultDataSet.Final_Result);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //    {   
            //        dataGridView1.CurrentRow.Selected = true;
            //        MessageBox.Show("This Row ID is: " + dataGridView1.Rows[e.RowIndex].Cells["Date"].FormattedValue.ToString());
            //        MessageBox.Show("This Row Vertical Frames is: " + dataGridView1.Rows[e.RowIndex].Cells["Time"].FormattedValue.ToString());
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //if(e.RowIndex>=0)
            //{
            //    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            //    //textBox1.Text = row.Cells["horizontalFramesDataGridViewTextBoxColumn"].Value.ToString();
            //    MessageBox.Show(row.Cells["horizontalFramesDataGridViewTextBoxColumn"].Value.ToString());
            //}

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-SKCF6NO\\SQLEXPRESS;Initial Catalog=AllResult;Integrated Security=True";
            
          

            string queryString =
           "SELECT ID, Time FROM Final_Result Where Id=@ID;";

            using (SqlConnection connection =
                       new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command =
                    new SqlCommand(queryString, connection);
                command.Parameters.Add(new SqlParameter("@ID", System.Data.SqlDbType.Int));

                command.Parameters["@ID"].Value = 1;
                
                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    ReadSingleRow((IDataRecord)reader);
                }

                // Call Close when done reading.
                reader.Close();
            }


        }
        private static void ReadSingleRow(IDataRecord record)
        {
            MessageBox.Show(String.Format("{0}", record[0]));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            //    textBox1.Text = row.Cells["horizontalFramesDataGridViewTextBoxColumn"].Value.ToString();
            //    MessageBox.Show(row.Cells["horizontalFramesDataGridViewTextBoxColumn"].Value.ToString());
            //}
            try
            {
              //MessageBox.Show(dataGridView1.Columns[0].Name);
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    TheHorizontalFrames=dataGridView1.Rows[e.RowIndex].Cells["HorizontalFrames"].FormattedValue.ToString();
                    TheVerticalFrames = dataGridView1.Rows[e.RowIndex].Cells["VerticalFrames"].FormattedValue.ToString();
                    time = dataGridView1.Rows[e.RowIndex].Cells["Time"].FormattedValue.ToString();
                    date = dataGridView1.Rows[e.RowIndex].Cells["Date"].FormattedValue.ToString();
                    TheTotalArea = dataGridView1.Rows[e.RowIndex].Cells["TotalArea"].FormattedValue.ToString();
                    TheRubber = dataGridView1.Rows[e.RowIndex].Cells["Rubber"].FormattedValue.ToString();
                    TheStarterStrip = dataGridView1.Rows[e.RowIndex].Cells["StarterStrip"].FormattedValue.ToString();
                    TheShearBlock= dataGridView1.Rows[e.RowIndex].Cells["ShearBlock"].FormattedValue.ToString();
                    TheGlass= dataGridView1.Rows[e.RowIndex].Cells["Glass"].FormattedValue.ToString();
                    ThePerimeter= dataGridView1.Rows[e.RowIndex].Cells["Perimeter"].FormattedValue.ToString();
                    TheInstallation=dataGridView1.Rows[e.RowIndex].Cells["Installation"].FormattedValue.ToString();
                    TheFabrication=dataGridView1.Rows[e.RowIndex].Cells["Fabrication"].FormattedValue.ToString();
                    Details details = new Details();
                    details.Show();
    }
            }
            catch (Exception ex)
            {
            //    MessageBox.Show(ex.Message);
            }
        }
    }
}
