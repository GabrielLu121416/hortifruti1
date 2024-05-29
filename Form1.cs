namespace Sistema_HortiFruti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int produto_1 = 0, produto_2 = 0, produto_3 = 0, produto_4 = 0, produto_5 = 0, produto_6 = 0, produto_7 = 0, produto_8 = 0, produto_9 = 0;

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void adicaoP1_Click(object sender, EventArgs e)
        {
            produto_1++;
            selecaoP1.Text = produto_1.ToString();

            valorSubTotalP1.Text =(produto_1 * 3.99).ToString();
        }

        private void adicaoP2_Click(object sender, EventArgs e)
        {
            produto_2++;
            selecaoP2.Text = produto_2.ToString();

            valorSubTotalP2.Text = (produto_2 * 1.99).ToString();
        }

        private void adicaoP3_Click(object sender, EventArgs e)
        {
            produto_3++;
            selecaoP3.Text = produto_3.ToString();

            valorSubTotalP3.Text = (produto_3 * 2.75).ToString();
        }

        private void adicaoP4_Click(object sender, EventArgs e)
        {
            produto_4++;
            selecaoP4.Text = produto_4.ToString();

            valorSubTotalP4.Text = (produto_4 * 8.70).ToString();
        }

        private void adicaoP5_Click(object sender, EventArgs e)
        {
            produto_5++;
            selecaoP5.Text = produto_5.ToString();

            valorSubTotalP5.Text = (produto_5 * 5.50).ToString();
        }

        private void adicaoP6_Click(object sender, EventArgs e)
        {
            produto_6++;
            selecaoP6.Text = produto_6.ToString();

            valorSubTotalP6.Text = (produto_6 * 4.20).ToString();
        }

        private void adicaoP7_Click(object sender, EventArgs e)
        {
            produto_7++;
            selecaoP7.Text = produto_7.ToString();

            valorSubTotalP7.Text = (produto_7 * 4.30).ToString();
        }

        private void adicaoP8_Click(object sender, EventArgs e)
        {
            produto_8++;
            selecaoP8.Text = produto_8.ToString();

            valorSubTotalP8.Text = (produto_8 * 10.00).ToString();

        }

        private void adicaoP9_Click(object sender, EventArgs e)
        {
            produto_9++;
            selecaoP9.Text = produto_9.ToString();

            valorSubTotalP9.Text = (produto_9 * 6.10).ToString();

        }

        private void reducaoP1_Click(object sender, EventArgs e)
        {
            produto_1--;
            selecaoP1.Text = produto_1.ToString();

            valorSubTotalP1.Text = (produto_1 * 3.99).ToString();
        }

        private void reducaoP2_Click(object sender, EventArgs e)
        {
            produto_2--;
            selecaoP2.Text = produto_2.ToString();

            valorSubTotalP2.Text = (produto_2 * 1.99).ToString();
        }


        private void reducaoP3_Click(object sender, EventArgs e)
        {
            produto_3--;
            selecaoP3.Text = produto_3.ToString();

            valorSubTotalP3.Text = (produto_3 * 2.75).ToString();
        }

        private void reducaoP4_Click(object sender, EventArgs e)
        {
            produto_4--;
            selecaoP4.Text = produto_4.ToString();

            valorSubTotalP4.Text = (produto_4 * 8.70).ToString();
        }

        private void reducaoP5_Click(object sender, EventArgs e)
        {
            produto_5--;
            selecaoP5.Text = produto_5.ToString();

            valorSubTotalP5.Text = (produto_5 * 5.50).ToString();
        }

        private void reducaoP6_Click(object sender, EventArgs e)
        {
            produto_6--;
            selecaoP6.Text = produto_6.ToString();

            valorSubTotalP6.Text = (produto_6 * 4.20).ToString();
        }

        private void reducaoP7_Click(object sender, EventArgs e)
        {
            produto_7--;
            selecaoP7.Text = produto_7.ToString();

            valorSubTotalP7.Text = (produto_7 * 4.30).ToString();
        }

        private void reducaoP8_Click(object sender, EventArgs e)
        {
            produto_8--;
            selecaoP8.Text = produto_8.ToString();

            valorSubTotalP8.Text = (produto_8 * 10.00).ToString();
        }

        private void reducaoP9_Click(object sender, EventArgs e)
        {
            produto_9--;
            selecaoP9.Text = produto_9.ToString();

            valorSubTotalP9.Text = (produto_9 * 6.10).ToString();
        }

        private void valor_Click(object sender, EventArgs e)
        {

        }
    }
}
