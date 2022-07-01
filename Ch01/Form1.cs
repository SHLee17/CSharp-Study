namespace Project1
{
    public partial class Form1 : Form
    {

        List<int> numList = new List<int>();
        List<int> list = new List<int>();
        List<int> operators = new List<int>();
        int result = 0;
        // 1:plus 2:minus 3:multi 4: divi

        public Form1()
        {
            InitializeComponent();
        }
        private void bntEqual_Click(object sender, EventArgs e)
        {
            string currentNum = txtResult.Text.ToString();
            numList.Add(int.Parse(currentNum));
            list.Clear();

            while (operators.Contains(3) || operators.Contains(4))
            {
                for (int i = 0; i < operators.Count; i++)
                {
                    switch (operators[i])
                    {
                        case 3:
                            numList[i] = numList[i] * numList[i + 1];
                            numList.RemoveAt(i + 1);
                            operators.RemoveAt(i);
                            break;

                        case 4:
                            numList[i] = numList[i] / numList[i + 1];
                            numList.RemoveAt(i + 1);
                            operators.RemoveAt(i);
                            break;
                    }
                }
            }
            while (numList.Count > 1)
            {
                for (int i = 0; i < operators.Count; i++)
                {
                    switch (operators[i])
                    {
                        case 1:
                            numList[i] = numList[i] + numList[i + 1];
                            numList.RemoveAt(i + 1);
                            operators.RemoveAt(i);
                            break;

                        case 2:
                            numList[i] = numList[i] - numList[i + 1];
                            numList.RemoveAt(i + 1);
                            operators.RemoveAt(i);
                            break;
                    }
                }
            }

            txtResult.Text = numList[0].ToString();

        }

        private void bntPlus_Click(object sender, EventArgs e)
        {
            Fuc(1);
        }
        private void bntMinus_Click(object sender, EventArgs e)
        {
            Fuc(2);
        }
        private void bntMulpti_Click(object sender, EventArgs e)
        {
            Fuc(3);
        }

        private void bntDivision_Click(object sender, EventArgs e)
        {
            Fuc(4);
        }
        void Fuc(int operate)
        {
            operators.Add(operate);
            //this.operate = operate;
            string currentNum = txtResult.Text.ToString();
            numList.Add(int.Parse(currentNum));
            list.Clear();
        }
        private void bntC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";

            list.Clear();
            numList.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bnt0_Click(object sender, EventArgs e)
        {
            list.Add(0);
            txtResult.Text = string.Join("", list);
        }
        private void bnt1_Click(object sender, EventArgs e)
        {
            list.Add(1);
            txtResult.Text = string.Join("", list);
        }

        private void bnt2_Click(object sender, EventArgs e)
        {
            list.Add(2);
            txtResult.Text = string.Join("", list);
        }

        private void bnt3_Click(object sender, EventArgs e)
        {
            list.Add(3);
            txtResult.Text = string.Join("", list);
        }

        private void bnt4_Click(object sender, EventArgs e)
        {
            list.Add(4);
            txtResult.Text = string.Join("", list);
        }

        private void bnt5_Click(object sender, EventArgs e)
        {
            list.Add(5);
            txtResult.Text = string.Join("", list);
        }

        private void bnt6_Click(object sender, EventArgs e)
        {
            list.Add(6);
            txtResult.Text = string.Join("", list);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            list.Add(7);
            txtResult.Text = string.Join("", list);
        }

        private void bnt8_Click(object sender, EventArgs e)
        {
            list.Add(8);
            txtResult.Text = string.Join("", list);
        }

        private void bnt9_Click(object sender, EventArgs e)
        {
            list.Add(9);
            txtResult.Text = string.Join("", list);
        }

    }
}