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
    }
}
