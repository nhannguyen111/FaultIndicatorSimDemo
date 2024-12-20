namespace FaultIndicatorSimDemo
{
    public partial class Form1 : Form
    {

        // Declare a System.Windows.Forms.Timer object at the class level
        private System.Windows.Forms.Timer blinkTimer;
        private bool isVisible = true; // Track visibility state for blinking
        private List<Panel> blinkingPanels; // Store the panels to be blinked

        public Form1()
        {
            InitializeComponent();
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

        private void greenSwitchyard()
        {
            panel1.BackColor = Color.Green;
            panel3.BackColor = Color.Green;
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

        private void InitializeBlinking()
        {
            if (blinkTimer == null)
            {
                blinkTimer = new System.Windows.Forms.Timer();
                blinkTimer.Interval = 500; // Set interval to 500 milliseconds (0.5 seconds)
                blinkTimer.Tick += BlinkTimer_Tick;
            }

            blinkTimer.Start();
        }

        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            // Toggle the visibility of the blinking panels
            isVisible = !isVisible;

            foreach (var panel in blinkingPanels)
            {
                panel.Visible = isVisible;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            greenSwitchyard();

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

            // Define the panels to blink
            blinkingPanels = new List<Panel> { panel23, panel24, panel25, panel26 };

            // Ensure initial visibility is set
            foreach (var panel in blinkingPanels)
            {
                panel.Visible = true;
            }

            InitializeBlinking();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            greenSwitchyard();

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

            // Define the panels to blink
            blinkingPanels = new List<Panel> { panel19, panel24, panel25, panel26 };

            // Ensure initial visibility is set
            foreach (var panel in blinkingPanels)
            {
                panel.Visible = true;
            }

            InitializeBlinking();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            greenSwitchyard();

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

            // Define the panels to blink
            blinkingPanels = new List<Panel> { panel19, panel20, panel21, panel26 };

            // Ensure initial visibility is set
            foreach (var panel in blinkingPanels)
            {
                panel.Visible = true;
            }

            InitializeBlinking();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            greenSwitchyard();

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

            // Define the panels to blink
            blinkingPanels = new List<Panel> { panel19, panel20, panel21, panel22 };

            // Ensure initial visibility is set
            foreach (var panel in blinkingPanels)
            {
                panel.Visible = true;
            }

            InitializeBlinking();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            greenSwitchyard();

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

            Random random = new Random();

            int randomNumber = random.Next(1, 5);

            switch (randomNumber)
            {
                case 1:
                    button1.PerformClick();
                    break;
                case 2:
                    button2.PerformClick();
                    break;

                case 3:
                    button3.PerformClick();
                    break;
                case 4:
                    button4.PerformClick();
                    break; 
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            panel1.BackColor = Color.Red;
            panel3.BackColor = Color.Red;

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

            panel15.Visible = true;
            panel16.Visible = true;
            panel17.Visible = true;
            panel18.Visible = true;

            blinkTimer.Stop();

        }
    }
}
