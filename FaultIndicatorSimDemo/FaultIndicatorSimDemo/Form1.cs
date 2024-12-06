namespace FaultIndicatorSimDemo
{
    public partial class Form1 : Form
    {
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
    }
}
