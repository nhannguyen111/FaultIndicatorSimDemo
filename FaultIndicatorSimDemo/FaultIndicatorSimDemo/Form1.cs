namespace FaultIndicatorSimDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            // Get the Graphics object
            Graphics g = e.Graphics;

            // Define the pen to draw the circle
            using (Pen pen = new Pen(Color.White, 2)) // Blue color, 2px thickness
            {
                // Draw a circle
                g.DrawEllipse(pen, 0, 0, 10, 10); // x, y, width, height
            }
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {
            // Get the Graphics object
            Graphics g = e.Graphics;

            // Define the pen to draw the circle
            using (Pen pen = new Pen(Color.White, 2)) // Blue color, 2px thickness
            {
                // Draw a circle
                g.DrawEllipse(pen, 0, 0, 10, 10); // x, y, width, height
            }
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            // Get the Graphics object
            Graphics g = e.Graphics;

            // Define the pen to draw the circle
            using (Pen pen = new Pen(Color.White, 2)) // Blue color, 2px thickness
            {
                // Draw a circle
                g.DrawEllipse(pen, 0, 0, 10, 10); // x, y, width, height
            }
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {
            // Get the Graphics object
            Graphics g = e.Graphics;

            // Define the pen to draw the circle
            using (Pen pen = new Pen(Color.White, 2)) // Blue color, 2px thickness
            {
                // Draw a circle
                g.DrawEllipse(pen, 0, 0, 10, 10); // x, y, width, height
            }
        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {
            // Get the Graphics object from the PaintEventArgs
            Graphics g = e.Graphics;

            // Define the brush for filling the arrow
            using (Brush brush = new SolidBrush(Color.Green))
            {
                // Define the points of the arrow
                Point[] arrowPoints = {
                    new Point(0, 4),  // Left point of the arrow tail
                    new Point(12, 4), // Right end of the tail
                    new Point(12, 0), // Top indent
                    new Point(18, 6), // Arrowhead tip
                    new Point(12, 12), // Bottom indent
                    new Point(12, 8), // Right end of the tail
                    new Point(0, 8)  // Left point of the arrow tail
                };

                // Draw and fill the polygon (the arrow)
                g.FillPolygon(brush, arrowPoints);
            }
        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {
            // Get the Graphics object from the PaintEventArgs
            Graphics g = e.Graphics;

            // Define the brush for filling the arrow
            using (Brush brush = new SolidBrush(Color.Green))
            {
                // Define the points of the arrow
                Point[] arrowPoints = {
                    new Point(0, 4),  // Left point of the arrow tail
                    new Point(12, 4), // Right end of the tail
                    new Point(12, 0), // Top indent
                    new Point(18, 6), // Arrowhead tip
                    new Point(12, 12), // Bottom indent
                    new Point(12, 8), // Right end of the tail
                    new Point(0, 8)  // Left point of the arrow tail
                };

                // Draw and fill the polygon (the arrow)
                g.FillPolygon(brush, arrowPoints);
            }
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {
            // Get the Graphics object from the PaintEventArgs
            Graphics g = e.Graphics;

            // Define the brush for filling the arrow
            using (Brush brush = new SolidBrush(Color.Green))
            {
                // Define the points of the arrow
                Point[] arrowPoints = {
                    new Point(0, 4),  // Left point of the arrow tail
                    new Point(12, 4), // Right end of the tail
                    new Point(12, 0), // Top indent
                    new Point(18, 6), // Arrowhead tip
                    new Point(12, 12), // Bottom indent
                    new Point(12, 8), // Right end of the tail
                    new Point(0, 8)  // Left point of the arrow tail
                };

                // Draw and fill the polygon (the arrow)
                g.FillPolygon(brush, arrowPoints);
            }
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {
            // Get the Graphics object from the PaintEventArgs
            Graphics g = e.Graphics;

            // Define the brush for filling the arrow
            using (Brush brush = new SolidBrush(Color.Green))
            {
                // Define the points of the arrow
                Point[] arrowPoints = {
                    new Point(0, 4),  // Left point of the arrow tail
                    new Point(12, 4), // Right end of the tail
                    new Point(12, 0), // Top indent
                    new Point(18, 6), // Arrowhead tip
                    new Point(12, 12), // Bottom indent
                    new Point(12, 8), // Right end of the tail
                    new Point(0, 8)  // Left point of the arrow tail
                };

                // Draw and fill the polygon (the arrow)
                g.FillPolygon(brush, arrowPoints);
            }
        }
    }
}
