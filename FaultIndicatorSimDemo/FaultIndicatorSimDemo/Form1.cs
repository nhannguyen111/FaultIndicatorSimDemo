namespace FaultIndicatorSimDemo
{
    public partial class Form1 : Form
    {

        public static class GlobalTimers
        {

            public static System.Windows.Forms.Timer blinkTimer = new System.Windows.Forms.Timer();

        }


        //private System.Windows.Forms.Timer blinkTimer;

        public Form1()
        {
            InitializeComponent();
            GlobalTimers.blinkTimer.Interval = 1000;

        }

        private Graphics graphics; // Private field to hold Graphics context

        // Method to set up the graphics object (called in Paint handlers)
        private void InitializeGraphics(PaintEventArgs e)
        {
            graphics = e.Graphics;
        }

        // General method to draw a circle
        private void DrawWhiteCircle()
        {
            if (graphics == null) return;

            using (Pen pen = new Pen(Color.White, 2))
            {
                graphics.DrawEllipse(pen, 0, 0, 10, 10);
            }
        }

        // General method to draw a green arrow pointing to the right
        private void DrawRightGreenArrow()
        {
            if (graphics == null) return;

            Point[] greenArrowPoints = {
                new Point(0, 4), new Point(12, 4), new Point(12, 0),
                new Point(18, 6), new Point(12, 12), new Point(12, 8),
                new Point(0, 8)
            };

            using (Brush brush = new SolidBrush(Color.Green))
            {
                graphics.FillPolygon(brush, greenArrowPoints);
            }
        }

        // General method to draw a red arrow pointing to the left
        private void DrawLeftRedArrow()
        {
            if (graphics == null) return;

            Point[] redArrowPoints = {
                new Point(18, 4), new Point(6, 4), new Point(6, 0),
                new Point(0, 6), new Point(6, 12), new Point(6, 8),
                new Point(18, 8)
            };

            using (Brush brush = new SolidBrush(Color.Red))
            {
                graphics.FillPolygon(brush, redArrowPoints);
            }
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            InitializeGraphics(e);
            DrawWhiteCircle();
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {
            InitializeGraphics(e);
            DrawWhiteCircle();
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            InitializeGraphics(e);
            DrawWhiteCircle();
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {
            InitializeGraphics(e);
            DrawWhiteCircle();
        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {
            InitializeGraphics(e);
            DrawRightGreenArrow();
        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {
            InitializeGraphics(e);
            DrawRightGreenArrow();
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {
            InitializeGraphics(e);
            DrawRightGreenArrow();
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {
            InitializeGraphics(e);
            DrawRightGreenArrow();
        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {
            InitializeGraphics(e);
            DrawLeftRedArrow();
        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {
            InitializeGraphics(e);
            DrawLeftRedArrow();
        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {
            InitializeGraphics(e);
            DrawLeftRedArrow();
        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {
            InitializeGraphics(e);
            DrawLeftRedArrow();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            panel27.Visible = !panel27.Visible;
        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            panel15.Visible = false;
            panel16.Visible = false;
            panel17.Visible = false;
            panel18.Visible = false;
            panel19.Visible = false;
            panel20.Visible = false;
            panel21.Visible = false;
            panel22.Visible = false;
            panel23.Visible = false;
            panel24.Visible = false;
            panel25.Visible = false;
            panel26.Visible = false;

            panel1.BackColor = Color.Green;
            label9.ForeColor = Color.Green;
            panel3.BackColor = Color.Green;
            label7.ForeColor = Color.Green;

            GlobalTimers.blinkTimer.Stop();

            panel23.Visible = true;
            panel24.Visible = true;
            panel25.Visible = true;
            panel26.Visible = true;

            GlobalTimers.blinkTimer.Tick += (sender, e) =>
            {
                panel23.Visible = !panel23.Visible;
                panel24.Visible = !panel24.Visible;
                panel25.Visible = !panel25.Visible;
                panel26.Visible = !panel26.Visible;
            };
            GlobalTimers.blinkTimer.Start(); 

        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel15.Visible = false;
            panel16.Visible = false;
            panel17.Visible = false;
            panel18.Visible = false;
            panel19.Visible = false;
            panel20.Visible = false;
            panel21.Visible = false;
            panel22.Visible = false;
            panel23.Visible = false;
            panel24.Visible = false;
            panel25.Visible = false;
            panel26.Visible = false;

            panel1.BackColor = Color.Green;
            label9.ForeColor = Color.Green;
            panel3.BackColor = Color.Green;
            label7.ForeColor = Color.Green;

            GlobalTimers.blinkTimer.Stop();

            panel19.Visible = true;
            panel24.Visible = true;
            panel25.Visible = true;
            panel26.Visible = true;

            GlobalTimers.blinkTimer.Tick += (sender, e) =>
            {
                panel19.Visible = !panel19.Visible;
                panel24.Visible = !panel24.Visible;
                panel25.Visible = !panel25.Visible;
                panel26.Visible = !panel26.Visible;
            };
            GlobalTimers.blinkTimer.Start();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            panel15.Visible = false;
            panel16.Visible = false;
            panel17.Visible = false;
            panel18.Visible = false;
            panel19.Visible = false;
            panel20.Visible = false;
            panel21.Visible = false;
            panel22.Visible = false;
            panel23.Visible = false;
            panel24.Visible = false;
            panel25.Visible = false;
            panel26.Visible = false;

            panel1.BackColor = Color.Green;
            label9.ForeColor = Color.Green;
            panel3.BackColor = Color.Green;
            label7.ForeColor = Color.Green;

            GlobalTimers.blinkTimer.Stop();

            panel19.Visible = true;
            panel20.Visible = true;
            panel21.Visible = true;
            panel26.Visible = true;

            GlobalTimers.blinkTimer.Tick += (sender, e) =>
            {
                panel19.Visible = !panel19.Visible;
                panel20.Visible = !panel20.Visible;
                panel21.Visible = !panel21.Visible;
                panel26.Visible = !panel26.Visible;
            };
            GlobalTimers.blinkTimer.Start();


        }

        private void button4_Click(object sender, EventArgs e)
        {

            panel15.Visible = false;
            panel16.Visible = false;
            panel17.Visible = false;
            panel18.Visible = false;
            panel19.Visible = false;
            panel20.Visible = false;
            panel21.Visible = false;
            panel22.Visible = false;
            panel23.Visible = false;
            panel24.Visible = false;
            panel25.Visible = false;
            panel26.Visible = false;

            panel1.BackColor = Color.Green;
            label9.ForeColor = Color.Green;
            panel3.BackColor = Color.Green;
            label7.ForeColor = Color.Green;

            GlobalTimers.blinkTimer.Stop();

            panel19.Visible = true;
            panel20.Visible = true;
            panel21.Visible = true;
            panel22.Visible = true;

            GlobalTimers.blinkTimer.Tick += (sender, e) =>
            {
                panel19.Visible = !panel19.Visible;
                panel20.Visible = !panel20.Visible;
                panel21.Visible = !panel21.Visible;
                panel22.Visible = !panel22.Visible;
            };
            GlobalTimers.blinkTimer.Start();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            panel15.Visible = false;
            panel16.Visible = false;
            panel17.Visible = false;
            panel18.Visible = false;
            panel19.Visible = false;
            panel20.Visible = false;
            panel21.Visible = false;
            panel22.Visible = false;
            panel23.Visible = false;
            panel24.Visible = false;
            panel25.Visible = false;
            panel26.Visible = false;

            panel1.BackColor = Color.Green;
            label9.ForeColor = Color.Green;
            panel3.BackColor = Color.Green;
            label7.ForeColor = Color.Green;

            Random random = new Random();

            int randomNumber = random.Next(1, 5);

            switch (randomNumber)
            {
                case 1:
                    panel23.Visible = true;
                    panel24.Visible = true;
                    panel25.Visible = true;
                    panel26.Visible = true;
                    break;
                case 2:
                    panel19.Visible = true;
                    panel24.Visible = true;
                    panel25.Visible = true;
                    panel26.Visible = true;
                    break;

                case 3:
                    panel19.Visible = true;
                    panel20.Visible = true;
                    panel21.Visible = true;
                    panel26.Visible = true;
                    break;
                case 4:
                    panel19.Visible = true;
                    panel20.Visible = true;
                    panel21.Visible = true;
                    panel22.Visible = true;
                    break; 
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            panel15.Visible = false;
            panel16.Visible = false;
            panel17.Visible = false;
            panel18.Visible = false;
            panel19.Visible = false;
            panel20.Visible = false;
            panel21.Visible = false;
            panel22.Visible = false;
            panel23.Visible = false;
            panel24.Visible = false;
            panel25.Visible = false;
            panel26.Visible = false;

            panel1.BackColor = Color.Red;
            label9.ForeColor = Color.Red;
            panel3.BackColor = Color.Red;
            label7.ForeColor = Color.Red;

            GlobalTimers.blinkTimer.Stop();

            panel15.Visible = true;
            panel16.Visible = true;
            panel17.Visible = true;
            panel18.Visible = true;

        }
    }
}
