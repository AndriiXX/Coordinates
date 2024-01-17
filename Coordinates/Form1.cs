namespace Coordinates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.MouseMove += Form1_MouseMove;
            this.MouseClick += Form1_MouseClick;
        }

        private String CoordinatesToString(MouseEventArgs e)
        {
            return "Координати миші: х=" + e.X.ToString() + "; y=" + e.Y.ToString();
        }

        private void Form1_MouseMove(object? sender, MouseEventArgs e)
        {
            if (sender != null) 
             {
                Text = CoordinatesToString(e);
             }
        }

        private void Form1_MouseClick(object? sender, MouseEventArgs e)
        {
            if (sender != null)
            {
                String message = "";
                if (e.Button == MouseButtons.Right)
                {
                    message = "Ви натиснули праву кнопку миші.";
                }
                if (e.Button == MouseButtons.Left)
                {
                    message = "Ви натиснули ліву кнопку миші.";
                }
                message += "\n" + CoordinatesToString(e);

                String caption = "Клік";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
