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
    

    public partial class Form1 :Form
    {
        public static string selectedScale = "";
        //The scale in inches
        public static int scaleInches = 0;
        public static double value = 0;
        //The scale in inches
        public static int SetValueForWidth = 0;
        public static int SetValueForHeight = 0;
        public static int SetValueForNumberOfRows = 0;
        public static int SetValueForNumberOfCols = 0;


        public static int h = 0;
        public static int v = 0;
        public static int rows = 0;
        public static int cols = 0;


        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }
        
        private void Send_Data()
        {
            //string width = "";
            //string height = "";


            



            //width = textBox1.Text;
            //height = textBox2.Text;

            try
            {
                //h  = Int32.Parse(width);
                ////Converting from pixels to feet
                //h = h * 1152;
                //v = Int32.Parse(height);
                // //Converting from pixels to feet
                // v = v * 1152;
                rows = Int32.Parse(textBox3.Text);
                cols = Int32.Parse(textBox4.Text);
                value = Int32.Parse(textBox1.Text);
                selectedScale = value.ToString();
                scaleInches = Int32.Parse(textBox1.Text) * 96;
                //SetValueForWidth = h;
                //SetValueForHeight = v;
                SetValueForNumberOfRows = rows;
                SetValueForNumberOfCols = cols;
                label6.Text = textBox3.Text;
                label8.Text = textBox4.Text;
            }
            catch (FormatException f)
            {
                MessageBox.Show(f.Message);
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Send_Data();
            if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Please enter all the fields");
                return;
            }
            Form2 frm2 = new Form2();
            frm2.Show();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

   

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        public static bool check = false;
        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();

            selectedScale = "";
        
            scaleInches = 0;
            value = 0;
            //The scale in inches
            SetValueForWidth = 0;
            SetValueForHeight = 0;
            SetValueForNumberOfRows = 0;
            SetValueForNumberOfCols = 0;
            h = 0;
            v = 0;
            rows = 0;
            cols = 0;
            label6.Text = textBox3.Text;
            label8.Text = textBox4.Text;

            Form2.TotalArea = 0;



            //This is a data to shown as a result
            Form2.TheHorizontalFrames = "";
            Form2.TheTotalArea = "";
            Form2.TheVerticalFrames = "";
            Form2.TheRubber = "";
            Form2.TheStarterStrip = "";
            Form2.TheShearBlock = "";
            Form2.TheGlass = "";
            Form2.ThePerimeter = "";
            Form2.TheInstallation = "";
            Form2.TheFabrication = "";
            //This is a data to shown as a result
            Form2.starterStrip = 0;
            Form2.totalHeight = 0;
            Form2.currentScale = 0;
            AllValues.cost = 0.0;
            
            //Send_Data();
            
        }
        
      
    }
}
