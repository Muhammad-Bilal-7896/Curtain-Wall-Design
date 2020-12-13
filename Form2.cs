using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
//for printers
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace ProjectAhmadMalakh
{
    
    public partial class Form2 : Form
    {

        public static int TotalArea = 0;

        public static ColorDialog MyDialog;

        //This is a data to shown as a result
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
        //This is a data to shown as a result
        public static int starterStrip = 0;
        public static int totalHeight = 0;

        public static int currentScale = 0;
        
        public Form2()
        {
            InitializeComponent();
            
        }

           

       
        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{
            //int h=Form1.SetValueForWidth;
            //int v=Form1.SetValueForHeight;

            

            //int wd = 0;
            //int hd = 0;
            //int max = 0;
            //Graphics l = e.Graphics;
            //string input = Microsoft.VisualBasic.Interaction.InputBox("Enter the height of box for the row: "+0,
            //           "Define your height of this row boxes",
            //           "0",
            //           50,
            //           50);
            //v = Int32.Parse(input);
            //if (v > max)
            //{ max = v; }
            //else { max = 0; }
            //int rowCounter = 0;
            //for (int i = 0; i < (Form1.SetValueForNumberOfRows*Form1.SetValueForNumberOfCols); i++)
            //{
            //    rowCounter++;
            //    if (wd == (h * Form1.SetValueForNumberOfRows))
            //    {
                    
            //        hd = hd + v;
            //        wd = wd - (h * Form1.SetValueForNumberOfRows);
            //        input = Microsoft.VisualBasic.Interaction.InputBox("Enter the height of box for the row: " + rowCounter,
            //           "Define your height of this row boxes",
            //           "0",
            //           500,
            //           500);
            //        v = Int32.Parse(input);
            //        int area = (h*Form1.SetValueForNumberOfCols) * v;
                    
            //        TotalArea = TotalArea + area;
            //        //////////////////////
            //        if (v > max)
            //        { max = v; }
            //        else { max = 0; }
            //    }
            //    ///////////////////////////////////////////////////
            //    Button testbutton = new Button();
            //    testbutton.Location = new Point(wd,hd);
            //    testbutton.Size = new Size(h,v);
            //    testbutton.Visible = true;
            //    //testbutton.BringToFront();
            //    this.Controls.Add(testbutton);
            //    ///////////////////////////////////////////////////

            //    //l.DrawRectangle(Pens.Black, new System.Drawing.Rectangle(wd, hd, h, v));
            //    wd = wd + h;
                
            //}
            //MessageBox.Show("Area is: " + TotalArea);
            //label6.Text = TotalArea.ToString();
        //}
        private void LoadData()
        {
            
            //Setting the value for current scale

            //Setting the value for current scale
            //////////////////////////////////////////////////////////
            MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = true;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = button1.BackColor;
            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = MyDialog.Color;
                testbutton.BackColor = MyDialog.Color;
            }


            int wd = 0;
            int hd = 130;
            int max = 0;
            string height, width;

            int h = 0, v = 0;

            /////////////////////////////////////////////////////////////////
            height = Microsoft.VisualBasic.Interaction.InputBox("Enter the height of box for the row: " + 1,
                       "Define the height of frame (feet) ",
                       "1",
                       500,
                       500);
            if (height == "")
            {
                MessageBox.Show("Please enter the height of frame 1 " + " to continue");
                return;
            }
            v = Int32.Parse(height);
            totalHeight = totalHeight + v;
            //Converting feet to pixels
            v = v * currentScale * 96;
            //Taking the length for the width of rectangle
            width = Microsoft.VisualBasic.Interaction.InputBox("Enter the width of box for the row: " + 1,
                       "Define the width of frame (feet)",
                       "1",
                       500,
                       500);
            if (width == "")
            {
                MessageBox.Show("Please enter the width of frame 1 " + " to continue");
                return;
            }
            h = Int32.Parse(width);
            starterStrip = starterStrip + h;

            h = h * currentScale * 96;
            //Taking the length for the width of rectangle
            ///////////////////////////////////////////////////////////////
            //h = Form1.SetValueForWidth;
            //v = Form1.SetValueForHeight;



            if (v > max)
            { max = v; }
            else { max = 0; }
            int rowCounter = 1;
            for (int i = 0; i < (Form1.SetValueForNumberOfRows * Form1.SetValueForNumberOfCols); i++)
            {
                int area = ((h / (currentScale * 96)) * (v / (currentScale * 96)));

                TotalArea = TotalArea + area;
                //MessageBox.Show("Area total inside loop is: " + TotalArea);

                if (wd == (h * Form1.SetValueForNumberOfRows))
                {
                    rowCounter++;
                    hd = hd + v;
                    wd = wd - (h * Form1.SetValueForNumberOfRows);
                    height = Microsoft.VisualBasic.Interaction.InputBox("Enter the height of box for the row(feet): " + rowCounter,
                       "Define the height of frame ",
                       "1",
                       500,
                       500);
                    if (height == "")
                    {
                        MessageBox.Show("Please enter the height of row : " + rowCounter);
                        return;
                    }
                    v = Int32.Parse(height);
                    totalHeight = totalHeight + v;
                    //converting to feet
                    v = v * (currentScale * 96);
                    //For the width of box 
                    width = Microsoft.VisualBasic.Interaction.InputBox("Enter the width of box for the row: " + rowCounter,
                       "Define the width of frame ",
                       "1",
                       500,
                       500);
                    if (width == "")
                    {
                        MessageBox.Show("Please enter the width of row : " + rowCounter);
                        return;
                    }
                    h = Int32.Parse(width);
                    if (i == 0)
                    {
                        starterStrip = starterStrip + h;
                    }
                    h = h * (currentScale * 96);
                    //area = ((h/1152) * (v/1152));
                    //MessageBox.Show("Area indide loop: " + area);
                    //TotalArea = TotalArea + area;
                    //////////////////////
                    if (v > max)
                    { max = v; }
                    else { max = 0; }
                }
                ///////////////////////////////////////////////////
                testbutton = new Button();
                testbutton.Location = new Point(wd, hd);
                testbutton.Size = new Size(h, v);
               

                //////////////////////////////////////////////////////////
                // Get the controls index
             
                //////////////////////////////////////////////////////////

                testbutton.Visible = true;
                testbutton.BackColor = MyDialog.Color;
                //testbutton.BringToFront();
                this.Controls.Add(testbutton);
                ///////////////////////////////////////////////////
                //Graphics l = e.Graphics;
                //l.DrawRectangle(Pens.Black, new System.Drawing.Rectangle(wd, hd, h, v));
                wd = (wd + h);

            }
            //MessageBox.Show("Area is: " + TotalArea);
            //MessageBox.Show("No.Of Cols is: " + Form1.SetValueForNumberOfRows);
            //MessageBox.Show("Scale is: " + (currentScale * 96));
            //label6.Text = TotalArea.ToString() + " ft";

            int rows = Form1.SetValueForNumberOfCols;

            int cols = Form1.SetValueForNumberOfRows;
            ///////////////////////////////////////////////////
            //MessageBox.Show("Form1.value ==> " + Form1.value);
            //TotalArea = TotalArea / Form1.value;
            ///////////////////////////////////////////////////
            //label4.Text = rows.ToString() + " ft";
            //label5.Text = cols.ToString() + " ft";
            //label8.Text = (TotalArea * 24 * 4).ToString() + " ft";
            //label10.Text = (starterStrip).ToString() + " ft";
            //label13.Text = (((Form1.SetValueForNumberOfRows) * 2) * (Form1.SetValueForNumberOfCols + 1)).ToString() + " ft";
            //label15.Text = (TotalArea).ToString() + " ft";
            //label17.Text = (starterStrip + totalHeight).ToString() + " ft";
            //label19.Text = (TotalArea).ToString() + " ft";
            //label21.Text = (((Form1.SetValueForNumberOfRows) * 2) * (Form1.SetValueForNumberOfCols + 1)).ToString() + " ft";
            //////////////////////////////////////////////////////////////////////////////////////////
            TheHorizontalFrames = rows.ToString();
            TheTotalArea = TotalArea.ToString();
            TheVerticalFrames = cols.ToString();
            TheRubber = (TotalArea * 24 * 4).ToString();
            TheStarterStrip = (starterStrip).ToString();
            TheShearBlock = (((Form1.SetValueForNumberOfRows) * 2) * (Form1.SetValueForNumberOfCols + 1)).ToString();
            TheGlass = (TotalArea).ToString();
            ThePerimeter = (starterStrip + totalHeight).ToString();
            TheInstallation = (TotalArea).ToString();
            TheFabrication = (((Form1.SetValueForNumberOfRows) * 2) * (Form1.SetValueForNumberOfCols + 1)).ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            currentScale = Int32.Parse(Form1.selectedScale);
            label1.Text = Form1.selectedScale + " inches";
            materialTextBox1.Text = Form1.selectedScale.ToString();
            LoadData();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btntakepic_Click(object sender, EventArgs e)
        {
            SelectArea sa = new SelectArea();
            sa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectArea sa = new SelectArea();
            sa.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
            //ColorDialog MyDialog = new ColorDialog();
            //// Keeps the user from selecting a custom color.
            //MyDialog.AllowFullOpen = true;
            //// Allows the user to get help. (The default is false.)
            //MyDialog.ShowHelp = true;
            //// Sets the initial color select to the current text color.
            //MyDialog.Color = button1.BackColor;

            //// Update the text box color if the user clicks OK 
            //if (MyDialog.ShowDialog() == DialogResult.OK)
            //    button1.BackColor = MyDialog.Color;
            //    testbutton.BackColor = MyDialog.Color;
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp,0,0);
        }

        Bitmap bmp;

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllValues av = new AllValues();
            av.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void getDetailedResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllValues av = new AllValues();
            av.Show();
        }

        private void takePrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void takePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectArea sa = new SelectArea();
            sa.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Curtain Drawing Software\n" +
                "You can estimate the frame length and shape and get its area and estimation by entering the width and height of each row."+
                "\nCopyright © 2020 Ahmed Malakh");
        }

        private void aboutUSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("This is Curtain Drawing Software\n"+
                "Copyright © 2020 Ahmed Malakh");
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phone No.:- 03081511889\n" +"Email Address: bilalmohib7896@gmail.com\n"+ "Github Profile:- https://github.com/Muhammad-Bilal-7896/"+
                "\nLinkedin Profile:- https://www.linkedin.com/in/muhammad-bilal-028843199/"+
                "\nFacebook Profile:- https://www.facebook.com/MuhammadBilal2001"+
                "\nCopyright © 2020 Ahmed Malakh");
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {



        TotalArea = 0;

        //This is a data to shown as a result
        starterStrip = 0;
        totalHeight = 0;
        currentScale = 0;




            //this.Close();

            currentScale = Int32.Parse(materialTextBox1.Text);
            label1.Text = currentScale.ToString() + " inches";
            LoadData();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AllValues av = new AllValues();
            av.Show();
        }

        private void btntakepic_Click_1(object sender, EventArgs e)
        {
            SelectArea sa = new SelectArea();
            sa.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }


        
    }
}
