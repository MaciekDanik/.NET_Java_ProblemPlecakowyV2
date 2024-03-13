using ProblemPlecakowyV2;

namespace Okienko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void lbl_NumberOfItem_Click(object sender, EventArgs e)
        {
        }

        private void txtBox_NumberOfItems_TextChanged(object sender, EventArgs e)
        {
            string text = txtBox_NumberOfItems.Text;

            if (!text.All(char.IsDigit))
            {
                txtBox_NumberOfItems.BackColor = Color.Coral;
            }
            else
            {
                if (text == "")
                {
                    txtBox_NumberOfItems.BackColor = Color.White;
                }
                else
                {
                    txtBox_NumberOfItems.BackColor = Color.LightGreen;
                }
            }
        }

        private void lbl_Seed_Click(object sender, EventArgs e)
        {
        }

        private void txtBox_Seed_TextChanged(object sender, EventArgs e)
        {
            string text = txtBox_Seed.Text;

            if (!text.All(char.IsDigit))
            {
                txtBox_Seed.BackColor = Color.Coral;
            }
            else
            {
                if (text == "")
                {
                    txtBox_Seed.BackColor = Color.White;
                }
                else
                {
                    txtBox_Seed.BackColor = Color.LightGreen;
                }
            }
        }

        private void lbl_Capacity_Click(object sender, EventArgs e)
        {
        }

        private void txtBox_Capacity_TextChanged(object sender, EventArgs e)
        {
            string text = txtBox_Capacity.Text;
            if (!text.All(char.IsDigit))
            {
                txtBox_Capacity.BackColor = Color.Coral;
            }
            else
            {
                if (text == "")
                {
                    txtBox_Capacity.BackColor = Color.White;
                }
                else
                {
                    txtBox_Capacity.BackColor = Color.LightGreen;
                }
            }
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            if (!txtBox_Capacity.Text.All(char.IsDigit) || !txtBox_NumberOfItems.Text.All(char.IsDigit) || !txtBox_Seed.Text.All(char.IsDigit))
            {
                txtBox_Instances.Text = "BAD INPUT";
                txtBox_Results.Clear();
            }
            else
            {
                txtBox_Instances.Clear();
                txtBox_Results.Clear();
                Problem problem = new Problem(int.Parse(txtBox_NumberOfItems.Text), int.Parse(txtBox_Seed.Text));

                foreach (var item in problem.items)
                {
                    txtBox_Instances.Text += item.ToString() + Environment.NewLine;
                }

                Result result = problem.Solve(int.Parse(txtBox_Capacity.Text));
                txtBox_Results.Text = result.ToString();
            }
        }

        private void txtBox_Results_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBox_Instances_TextChanged(object sender, EventArgs e)
        {
        }
    }
}