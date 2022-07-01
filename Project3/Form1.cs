namespace Project3
{
    public partial class Form1 : Form
    {
        enum STONE
        {
            none,
            black,
            white
        }
        int margin = 40;
        int sizeNun = 30;
        int sizeDol = 28;
        STONE[,] go = new STONE[19, 19];

        Graphics g;
        Pen pen;
        Brush wBrush, bBrush;
        bool isBlack = true;
        bool isWin = false;
        public Form1()
        {
            InitializeComponent();

            BackColor = Color.Orange;

            int size = margin * 2 + sizeNun * 18;

            ClientSize = new Size(size, size);

            g = CreateGraphics();

            pen = new Pen(Color.Black);

            wBrush = new SolidBrush(Color.White);
            bBrush = new SolidBrush(Color.Black);

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (e.X - margin + sizeNun / 2) / sizeNun;
            int y = (e.Y - margin + sizeNun / 2) / sizeNun;

            Rectangle dol = new Rectangle(margin + sizeNun * x - sizeNun / 2,
                margin + sizeNun * y - sizeNun / 2, sizeDol, sizeDol);

            if (go[y, x] != STONE.none)
                return;

            if (isBlack)
            {
                g.FillEllipse(bBrush, dol);
                go[y, x] = STONE.black;
                isBlack = false;
            }
            else if (!isBlack)
            {
                go[y, x] = STONE.white;
                g.FillEllipse(wBrush, dol);
                isBlack = true;
            }

            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    for (int type = 0; type < 4; type++)
                    {
                        Match(5, type, go[y, x], i, j);
                        if(isWin) goto gameOver;
                    }
                }
            }

            gameOver:
            //CheckOmok(y, x);
            Console.WriteLine("{0} {1}", y, x);
        }


        public void CheckOmok(int y, int x)
        {
            int count = 1;

            #region 수평 오목
            for (int i = x+1; i <= 18; i++)
            {
                if (go[y, i] == go[y, x])
                    count++;
                else
                    break;
            }
            for (int i = x - 1; i >= 0; i--)
            {
                if (go[y, i] == go[y, x])
                    count++;
                else
                break;
            }
            if (OmokCheck(count)) return;
            count = 1;
            #endregion

            #region 수직 오목
            for (int i = y + 1; i <= 18; i++)
            {
                if (go[i, x] == go[y, x])
                    count++;
                else
                    break;
            }
            for (int i = y - 1; i >= 0; i--)
            {
                if (go[i, x] == go[y, x])
                    count++;
                else
                    break;
            }
            if (OmokCheck(count)) return;
            count = 1;
            #endregion

            #region 대각선

            //오른쪽 대각선 아래
            for (int i = y + 1 , j = x + 1; i <= 18 && j <= 18; i++, j++)
            {
                if (go[i, j] == go[y, x])
                    count++;
                else
                    break;
            }
            //왼쪽 대각선 위
            for (int i = y - 1, j = x - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (go[i, j] == go[y, x])
                    count++;
                else
                    break;
            }
            if (OmokCheck(count)) return;
            count = 1;

            //왼쪽 대각선 위
            for (int i = y + 1, j = x - 1; i <= 18 && j <= 18; i++, j--)
            {
                if (go[i, j] == go[y, x])
                    count++;
                else
                    break;
            }
            //오른쪽 대각선 아래
            for (int i = y - 1, j = x + 1; i >= 0 && j >= 0; i--, j++)
            {
                if (go[i, j] == go[y, x])
                    count++;
                else
                    break;
            }
            if (OmokCheck(count)) return;
            count = 1;
            #endregion

        }
        public void NewGame()
        {
            Invalidate();

            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                    go[i, j] = STONE.none;
            }

            isBlack = true;
        }
        bool OmokCheck(int count)
        {
            if (count >= 5)
            {
                DialogResult result = MessageBox.Show("오목입니다! 새로운 게임을 시작할까요?",
                    "확인", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    NewGame();
                }
                else
                {
                    Close();
                }
                return true;
            }
            return false;
        }
        void Match(int count, int type, STONE color, int y, int x)
        {
            if (count == 0)
            {
                Console.WriteLine("승리");
                isWin = true;
                DialogResult result = MessageBox.Show("오목입니다! 새로운 게임을 시작할까요?",
                    "확인", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    NewGame();
                }
                else
                {
                    Close();
                }
                return;
            }
            if (!isWin)
            {
                if (x >= 0 && x < 19 && y >= 0 && y < 19)
                {
                    if (go[y, x] == color)
                    {
                        switch (type)
                        {
                            case 0: //수평 오목
                                Match(count - 1, type, color, y, x - 1);
                                break;
                            case 1:// 수직 오목
                                Match(count - 1, type, color, y + 1, x);
                                break;
                            case 2:// 왼쪽 대각선
                                Match(count - 1, type, color, y + 1, x + 1);
                                break;
                            case 3: // 오른쪽 대각선
                                Match(count - 1, type, color, y - 1, x + 1);
                                break;
                        }
                    }
                    else if (go[y, x] != color)
                        return;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            for (int i = 0; i < 19; i++)
            {
                int y = margin + (sizeNun * i);
                Point p1 = new Point(margin, y);
                Point p2 = new Point(ClientSize.Width - margin, y);
                g.DrawLine(pen, p1, p2);

                int x = margin + (sizeNun * i);
                Point p3 = new Point(x, margin);
                Point p4 = new Point(x, ClientSize.Height - margin);
                g.DrawLine(pen, p3, p4);
            }




        }
    }
}