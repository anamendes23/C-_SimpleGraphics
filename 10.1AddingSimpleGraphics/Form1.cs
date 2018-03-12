/*
 * Ana Mendes
 * anamendes23@gmail.com
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10._1AddingSimpleGraphics
{
    /*
         * Adding graphics such as: lines, rectangles, circle... to a bitmap
         * A bitmap is an empty image. Once graphics is added to a bitmap
         * we add the bitmap to a picturebox to display it.
         * 
         * Graphics class
         * **************
         * Defines methods such as DrawXXX and FillXXX to draw or fill
         * different shapes
         * 
         *      1. create a graphics object for the bitmap (global)
         *      2. pen object to draw, or a brush object to fill
         *      3. coordinates and size of the shape to draw/fill
         * */
    public partial class Form1 : Form
    {
        //declare a bitmap
        Bitmap bmap;
        //declare a Graphics object for a bitmap
        Graphics g;
        //color selected from colordialog to use for the shapes
        Color selectedColor = Color.Blue; //initial-default value
        //array of colors
        Color[] pallet = { Color.Aquamarine, Color.Pink, Color.Yellow, Color.Orange };
        //array of strings
        string[] planet = { "Mercury","Venus","Earth","Mars","Jupiter","Saturn",
                            "Uranus","Neptune","Pluto - yes, I am here"};
        //index to hold current planet to be displayed
        int index = 0;

        /*******************************FORM1***********************************/
        public Form1()
        {
            InitializeComponent();
            //create a bitmap wiith same dimensions as picturebox
            bmap = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            //create graphics object for this bitmap
            g = Graphics.FromImage(bmap);
        }
        /*******************************BTN DRAW LINE***************************/
        private void btnLines_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            //generate random numbers to determine pen's line thickness and color
            int lineThickness = rand.Next(1, 5);
            int cIndex = rand.Next(0, 4);
            //create a Pen
            Pen pen = new Pen(pallet[cIndex], lineThickness);
            //if you want t o keep pen's color as the selected one, use:
            //Pen pen = new Pen(selectedColor, lineThickness);
            //Remove cIndex and the previous pen!!
            //x1,y1,x2,y2
            int x1 = rand.Next(bmap.Width);
            int y1 = rand.Next(bmap.Height);

            int x2 = rand.Next(bmap.Width);
            int y2 = rand.Next(bmap.Height);

            //draw line - in bitmap
            g.DrawLine(pen, x1, y1, x2, y2);
            //display bitmap to picturebox
            pictureBox1.Image = bmap;
        }
        /*******************************BTN DRAW RECTANGLE**********************/
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            //generate random numbers to determine pen's line thickness and color
            int lineThickness = rand.Next(1, 5);
            int cIndex = rand.Next(0, 4);
            //create a Pen
            Pen pen = new Pen(pallet[cIndex], lineThickness);
            //if you want t o keep pen's color as the selected one, use:
            //Pen pen = new Pen(selectedColor, lineThickness);
            //Remove cIndex and the previous pen!!
            //Drawing a rectangle withing the bitmap bounds
            //x,y,width, height
            int x = rand.Next(bmap.Width);
            int y = rand.Next(bmap.Height);

            int width = rand.Next(bmap.Width - x);
            int height = rand.Next(bmap.Height - y);
            //draw line - in bitmap
            g.DrawRectangle(pen, x, y, width, height);
            //display bitmap to picturebox
            pictureBox1.Image = bmap;
        }
        /*******************************BTN DRAW CIRCLE*************************/
        private void btnCircle_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            //generate random numbers to determine pen's line thickness and color
            int lineThickness = rand.Next(1, 5);
            int cIndex = rand.Next(0, 4);
            //create a Pen
            Pen pen = new Pen(pallet[cIndex], lineThickness);
            //if you want t o keep pen's color as the selected one, use:
            //Pen pen = new Pen(selectedColor, lineThickness);
            //Remove cIndex and the previous pen!!
            //x,y, diameter
            int diameter = rand.Next(bmap.Height);

            int x = rand.Next(bmap.Width - diameter);
            int y = rand.Next(bmap.Height - diameter);
            //draw line - in bitmap
            g.DrawEllipse(pen, x, y, diameter, diameter);
            //display bitmap to picturebox
            pictureBox1.Image = bmap;
        }
        /*******************************BTN CHOOSE COLOR************************/
        private void btnColor_Click(object sender, EventArgs e)
        {
            //set the starting color for the dialog
            //colorDialog1.Color = Color.Blue;

            //create a Color dialog using Toolbox > Dialogs > ColorDialog
            if (DialogResult.OK == colorDialog1.ShowDialog())
            {                
                //get the selected color
                //save it to a color variable that is accessible from the
                //draw... buttons
                selectedColor = colorDialog1.Color;
                //optional
                btnColor.BackColor = selectedColor;
            }            
        }
        /*******************************TIMER**********************************/
        private void timer1_Tick(object sender, EventArgs e)
        {
            //clear the display
            g.FillRectangle(new SolidBrush(pictureBox1.BackColor), 0, 0, pictureBox1.Width,
                            pictureBox1.Height);
            Random rand = new Random();
            int number = rand.Next(0, 3);
            switch(number)
            {
                case 0:
                    btnLines_Click(this, e);
                    break;
                case 1:
                    btnRectangle_Click(this, e);
                    break;
                case 2:
                    btnCircle_Click(this, e);
                    break;
                default:
                    break;
            }

            //-------------------string----------------------
            //get next index value
            index = (index + 1) % planet.Length;
            string text = planet[index];
            //draw the text at position 50,50
            SolidBrush brush = new SolidBrush(selectedColor);
            Font font = new Font("Arial", 24, FontStyle.Bold);
            g.DrawString(text, font, brush, 50, 50);
            pictureBox1.Image = bmap;

        }
        /*******************************FORM LOAD*******************************/
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        /*******************************BTN START TIMER*************************/
        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            //Start timer
            timer1.Start();
            //Locked btnColor because using random color selection
            btnColor.Enabled = false;
        }
        /*******************************BTN STOP TIMER**************************/
        private void btnStop_Click(object sender, EventArgs e)
        {
            //Stop timer
            timer1.Stop();
            btnColor.Enabled = true;
        }
        /*******************************BTN FILL RECTANGLE**********************/
        private void btnFillRect_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            //generate random numbers to determine pen's line thickness and color
            int cIndex = rand.Next(0, 4);
            //create a Pen
            SolidBrush brush = new SolidBrush(pallet[cIndex]);
            //Filling a rectangle withing the bitmap bounds
            //x,y,width, height
            int x = rand.Next(bmap.Width);
            int y = rand.Next(bmap.Height);

            int width = rand.Next(bmap.Width - x);
            int height = rand.Next(bmap.Height - y);
            //draw line - in bitmap
            g.FillRectangle(brush, x, y, width, height);
            //display bitmap to picturebox
            pictureBox1.Image = bmap;
        }
        /*******************************BTN FILL CIRCLE*************************/
        private void btnFillCircle_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            //generate random numbers to determine pen's line thickness and color
            int cIndex = rand.Next(0, 4);
            //create a Pen
            SolidBrush brush = new SolidBrush(pallet[cIndex]);
            //x,y, diameter
            int diameter = rand.Next(bmap.Height);

            int x = rand.Next(bmap.Width - diameter);
            int y = rand.Next(bmap.Height - diameter);
            //draw line - in bitmap
            g.FillEllipse(brush, x, y, diameter, diameter);
            //display bitmap to picturebox
            pictureBox1.Image = bmap;
        }
        /*******************************BTN ARC CIRCLE**************************/
        private void btnArc_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            //generate random numbers to determine pen's line thickness and color
            int lineThickness = rand.Next(1, 5);
            int cIndex = rand.Next(0, 4);
            //create a Pen
            Pen pen = new Pen(pallet[cIndex], lineThickness);
            //x,y, diameter
            int diameter = rand.Next(bmap.Height);

            int x = rand.Next(bmap.Width - diameter);
            int y = rand.Next(bmap.Height - diameter);
            
            int startAngle = rand.Next(180); //up to 180 degrees
            int sweepAngle = rand.Next(360-startAngle); //up to 270 degrees
            //draw line - in bitmap
            g.DrawArc(pen, x, y, diameter, diameter, startAngle, sweepAngle);
            //display bitmap to picturebox
            pictureBox1.Image = bmap;
        }
        /*************************BTN DRAW 3 CONCENTRIC CIRCLES******************/
        private void btn3Circles_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            //generate random numbers to determine pen's line thickness and color
            int lineThickness = rand.Next(1, 5);
            int cIndex = rand.Next(0, 2);
            //create a Pen
            Pen pen = new Pen(pallet[cIndex], lineThickness);
            //if you want t o keep pen's color as the selected one, use:
            //Pen pen = new Pen(selectedColor, lineThickness);
            //Remove cIndex and the previous pen!!
            //diameters
            int d3 = rand.Next(bmap.Height);
            int d2 = rand.Next(d3);
            int d1 = rand.Next(d2);

            //xs and ys
            int x3 = rand.Next(bmap.Width - d3);
            int y3 = rand.Next(bmap.Height - d3);
            int x2 = (x3 + (d3 - d2) / 2);
            int y2 = (y3 + (d3 - d2) / 2);
            int x1 = (x3 + (d3 - d1) / 2);
            int y1 = (y3 + (d3 - d1) / 2);
            //draw line - in bitmap
            g.DrawEllipse(pen, x3, y3, d3, d3);
            g.DrawEllipse(pen, x2, y2, d2, d2);
            g.DrawEllipse(pen, x1, y1, d1, d1);
            //display bitmap to picturebox
            pictureBox1.Image = bmap;
        }
        /*******************************BTN CLEAR PICBOX************************/
        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Gray);
            pictureBox1.Image = bmap;
        }
        /*******************************BTN SQUARE/CIRCLE***********************/
        private void btnSquare_Click(object sender, EventArgs e)
        {
            ///add button to draw a circle inside of a square, where the circle
            ///should be touching the side of the square but not crossing
            Random rand = new Random();
            //generate random numbers to determine pen's line thickness and color
            int lineThickness = rand.Next(1, 5);
            int cIndex = rand.Next(0, 4);
            //create a Pen
            Pen pen = new Pen(pallet[cIndex], lineThickness);
            //Drawing a square withing the bitmap bounds
            //x,y,width, height
            int w = rand.Next(bmap.Width);
            int h = rand.Next(bmap.Height);
            int l = Math.Min(w, h);

            int x = rand.Next(bmap.Width - w);
            int y = rand.Next(bmap.Height - h);
            //circle will have diameter iguals l and position the same as square
            g.DrawEllipse(pen, x, y, l, l);
            //draw line - in bitmap
            g.DrawRectangle(pen, x, y, l, l);
            //display bitmap to picturebox
            pictureBox1.Image = bmap;
        }
        /*******************************BTN TINY CIRCLE*************************/
        private void btnTCircle_Click(object sender, EventArgs e)
        {
            ///add button to fill small circles (diameter about 3 to 7)
            ///randomly (position wise)
        }
        /*******************************BTN DRAW PIE****************************/
        private void btnDrawPie_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            //generate random numbers to determine pen's line thickness and color
            int lineThickness = rand.Next(1, 5);
            int cIndex = rand.Next(0, 4);
            //create a Pen
            Pen pen = new Pen(pallet[cIndex], lineThickness);
            //x,y, diameter
            int diameter = rand.Next(bmap.Height);

            int x = rand.Next(bmap.Width - diameter);
            int y = rand.Next(bmap.Height - diameter);

            int startAngle = rand.Next(180); //up to 180 degrees
            int sweepAngle = rand.Next(360 - startAngle); //up to 270 degrees
            //draw line - in bitmap
            g.DrawPie(pen, x, y, diameter, diameter, startAngle, sweepAngle);
            //display bitmap to picturebox
            pictureBox1.Image = bmap;
        }
        /*******************************BTN FILL PIE****************************/
        private void btnFillPie_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            //generate random numbers to determine pen's line thickness and color
            int cIndex = rand.Next(0, 4);
            //create a Pen
            SolidBrush brush = new SolidBrush(pallet[cIndex]);
            //x,y, diameter
            int diameter = rand.Next(bmap.Height);

            int x = rand.Next(bmap.Width - diameter);
            int y = rand.Next(bmap.Height - diameter);
            int startAngle = rand.Next(-180,180); //up to 180 degrees
            int sweepAngle = rand.Next(90); //up to 270 degrees
            //draw line - in bitmap
            g.FillPie(brush, x, y, diameter, diameter, startAngle, sweepAngle);
            //display bitmap to picturebox
            pictureBox1.Image = bmap;
        }
        /*******************************BTN POLYGON*****************************/
        private void btnDrawPolygon_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            //generate random numbers to determine pen's line thickness and color
            int lineThickness = 1;
            int cIndex = rand.Next(0, 4);
            //create a Pen
            Pen pen = new Pen(pallet[cIndex], lineThickness);
            //array of points
            Point p1 = new Point(50, 50);
            Point p2 = new Point(200, 25);
            Point p3 = new Point(250,100);
            Point p4 = new Point(200, 300);
            Point p5 = new Point(50, 290);
            Point p6 = new Point(25, 125);
            //create an array of points
            Point[] points = { p1, p2, p3, p4, p5, p6 };

            //Point[] points = new Point[6];
            //for (int i = 0; i < points.Length; i++)
            //{
            //    points[i] = new Point(rand.Next(bmap.Width), rand.Next(bmap.Height));
            //}

            g.DrawPolygon(pen, points);
            pictureBox1.Image = bmap;
        }

        private void btnFillPolygon_Click(object sender, EventArgs e)
        {

        }

        private void btnString_Click(object sender, EventArgs e)
        {

        }


    }
}
///Exercise
///Complete code to draw rectangles and circles
///you should make sure that both rectangles and circles are
///drawn inside the bitmap, should not be clipped
///
///go to the Graphics class to see the method definition for
///DrawRect and DrawEllipse
///
///New project:
///add button to fill small circles (diameter about 3 to 7)
///randomly (position wise)
///
///add button to draw 3 circles (circle1, circle2, circle3) where
///circle 1 is drawn inside circle 2, and circle2 is drawn inside circle3
///
///add button to draw a circle inside of a square, where the circle
///should be touching the side of the square but not crossing
///
///Exercise:
///Create a timer. Have two buttons to start and stop timer
///
///Have radiobuttons to select shape to draw or fill
///then the timer, when started, should draw or fill the shapes
///at random positions.
///
///include an array that contains about a dozen strings
///have the time draw the strings one by one in rotational way.
///(see Method DrawString)
///
///Exercise
///Draw 3 pies next to each other, or touching each other
///first one starts at 30 degrees and sweeps 45 deg, second one
///sweeps 60 deg and the third one sweeps 100 deg.
///each one should have it own color
///draw a small string inside each pie: pie1, pie2, pie3
