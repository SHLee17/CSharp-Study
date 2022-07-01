namespace Project4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Rectangle racket = new Rectangle();
        Rectangle[] blocks = new Rectangle[100];
        bool[] blockVisible = new bool[100];
        Rectangle ball;

        Brush racketColor = new SolidBrush(Color.Red);
        Brush blockColor = new SolidBrush(Color.Orange);
        Brush ballColor = new SolidBrush(Color.Gold);
        Pen pen = new Pen(Color.Black);

        int formW = 300;
        int formH = 500;

        int nBlocks = 30;

        int racketY = 480;
        int racketW = 50;
        int racketH = 10;

        int blockY = 60;
        int blockW = 30;
        int blockH = 20;

        int ballW = 10;
        int ballH = 10;

        double slope; // 기울기
        double vDir;

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(formW, formH);
            Text = "Block Break v1.0";

            g = CreateGraphics();
            Init();
        }
        void Init()
        {
            InitBlock();

            InitRacket();

            InitBall();

            myTimer.Start();

        }
        void InitBlock()
        {
            for (int i = 0; i < nBlocks; i++)
            {
                blocks[i] = new Rectangle(i % 10 * blockW,
                    blockY + blockH * (i / 10),
                    blockW - 1,
                    blockH - 1);

                blockVisible[i] = true;
            }
        }
        void InitRacket()
        {

            racket.X = formW / 2 - racketW / 2;
            racket.Y = racketY;
            racket.Width = racketW;
            racket.Height = racketH;
        }

        void InitBall()
        {
            ball = new Rectangle();
            ball.X = formW / 2 - ballW / 2;
            ball.Y = blockY + nBlocks / 10 * blockH;
            ball.Width = ballW;
            ball.Height = ballH;

            slope = rand.Next(1, 20) / 10.0;
            if (rand.Next(2) % 2 == 1)
                slope = -slope;
            vDir = 1;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            for (int i = 0; i < nBlocks; i++)
            {
                if (blockVisible[i])
                g.FillRectangle(blockColor, blocks[i]);
            }

            g.FillRectangle(racketColor, racket);
            g.FillEllipse(ballColor, ball);
            g.DrawEllipse(pen, ball);


        }
        private void myTimer_Tick(object sender, EventArgs e)
        {
            double dx;
            double unit = ballW;

            dx = unit / slope;

            ball.X += (int)dx;
            ball.Y += (int)(vDir * slope * dx);


            if (ball.X >= formW - ballW || ball.X <= 0) 
                slope = -slope;

            if( ball.Y < 0 || racket.IntersectsWith(ball))
                vDir = -vDir;

            for (int i = 0; i < nBlocks; i++)
            {
                if (ball.IntersectsWith(blocks[i]) && blockVisible[i])
                {
                        vDir = -vDir;
                        blockVisible[i] = false;
                }
            }
            if (ball.Y > ClientSize.Height)
            {
                myTimer.Stop();
                DialogResult result = MessageBox.Show("다시 시작하시겠습니까?", "확인", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    Init();
                else
                    Close();
                return;
            }

                Invalidate();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left && racket.X > 0 )
                racket.X -= 20;
            else if(e.KeyCode == Keys.Right && racket.X < (formW - racketW))
                racket.X += 20;
        }
    }
}