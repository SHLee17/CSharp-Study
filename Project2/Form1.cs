using MySql.Data.MySqlClient;

namespace Project2
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text.ToString();
            string name = txtName.Text.ToString();
            string hp = txtHp.Text.ToString();
            decimal age = nAge.Value;

            DBAccess.Instance.UpdateUser(uid, name, hp, age);
            Reset();

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text.ToString();
            string name = txtName.Text.ToString();
            string hp = txtHp.Text.ToString();
            decimal age = nAge.Value;

            DBAccess.Instance.InsertUser(uid, name, hp, age);
           
            Reset();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        void Reset()
        {
            txtUid.Text = "";
            txtName.Text = "";
            txtHp.Text = "";
            nAge.Text = "0";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Inquiry();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[index];

            string name = row.Cells[1].Value.ToString();

            txtUid.Text = row.Cells[0].Value.ToString();
            txtName.Text = name;
            txtHp.Text = row.Cells[2].Value.ToString();
            nAge.Value = decimal.Parse(row.Cells[3].Value.ToString());

            Console.WriteLine("name : " + name);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Inquiry();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text.ToString();

            DBAccess.Instance.DeleteUser(uid);
            Reset();
        }

        void Inquiry()
        {
            List<User> users = DBAccess.Instance.SelectUsers();

            dataGridView1.DataSource = users;
        }

    }
}