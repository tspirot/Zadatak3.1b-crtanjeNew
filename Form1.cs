namespace Zadatak3._1b
{
    public partial class Form1 : Form
    {
        int px, py;
        Pen olovka = new Pen(Color.Black, 2);
        Graphics gr;
        Point[] tacke = new Point[3];
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.BackColor = colorDialog1.Color;
                olovka.Color = colorDialog1.Color;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                px = e.X;
                py = e.Y;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (radioButtonLinija.Checked)
                    gr.DrawLine(olovka,
                    px, py, e.X, e.Y);
                if (checkBoxProvidan.Checked)
                {
                    if (radioButtonPravougaonik.Checked)
                        gr.DrawRectangle(olovka,
                        Math.Min(px, e.X), Math.Min(py, e.Y),
                        Math.Abs(e.X - px), Math.Abs(e.Y - py));
                    if (radioButtonElipsa.Checked)
                        gr.DrawEllipse(olovka,
                        Math.Min(px, e.X), Math.Min(py, e.Y),
                        Math.Abs(e.X - px), Math.Abs(e.Y - py));
                }
                else // nije providan
                {
                    if (radioButtonPravougaonik.Checked)
                        gr.FillRectangle(new SolidBrush(olovka.Color),
                        Math.Min(px, e.X), Math.Min(py, e.Y),
                        Math.Abs(e.X - px), Math.Abs(e.Y - py));
                    if (radioButtonElipsa.Checked)
                        gr.FillEllipse(new SolidBrush(olovka.Color),
                        Math.Min(px, e.X), Math.Min(py, e.Y),
                        Math.Abs(e.X - px), Math.Abs(e.Y - py));
                }
            }
        }

        /// <summary>
        /// Handles the MouseMove event of the pictureBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The MouseEventArgs instance containing the event data.</param>
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // Set the form's text to the current mouse coordinates
            this.Text = e.X + "," + e.Y;

            // Get the brush size from the numericUpDown control
            int d = (int)numericUpDown1.Value;

            // Check if the drawing mode is enabled
            if (radioButtonCrtanje.Checked)
            {
                // Check if the left mouse button is pressed
                if (e.Button == MouseButtons.Left)
                {
                    // Fill an ellipse with the current pen color and size at the current mouse coordinates
                    gr.FillEllipse(
                        new SolidBrush(olovka.Color),
                        e.X - d / 2, e.Y - d / 2, d, d);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            olovka.Width = (float)numericUpDown1.Value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}