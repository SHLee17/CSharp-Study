namespace Ch11
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Rectangle myRect = new Rectangle();
        Brush blueBrush = new SolidBrush(Color.Blue);
        Pen blackPen = new Pen(Color.Black);


        public Form1()
        {
            InitializeComponent();

            graphics = CreateGraphics();
            myRect.X = 360;
            myRect.Y = 10;

            myRect.Width = 10;
            myRect.Height = 10;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            graphics.DrawRectangle(blackPen, myRect);
            graphics.FillRectangle(blueBrush, myRect);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();

            Brush redBrush = new SolidBrush(Color.Red);

            Pen blackPen = new Pen(Color.Black);

            Rectangle rect = new Rectangle(10, 10, 100, 100);

            g.DrawRectangle(blackPen , rect);

            g.FillRectangle(redBrush, rect);

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();

            Pen blackPen = new Pen(Color.Black);

            g.DrawLine(blackPen, new Point(10, 120), new Point(200, 120));
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();

            Pen blackPen = new Pen(Color.Black);

            Brush greenBrush = new SolidBrush(Color.Green);

            Rectangle rect = new Rectangle(120, 10, 100, 100);

            g.DrawEllipse(blackPen, rect);
            g.FillEllipse(greenBrush, rect);

        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            myRect.Y += 10;

            Invalidate();
        }
    }
}