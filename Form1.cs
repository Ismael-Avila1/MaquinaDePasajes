namespace MaquinaDePasajes
{
    public partial class Form1 : Form
    {

        float price;
        float amount;

        public Form1()
        {
            InitializeComponent();

            price = 9.5f;
            amount = 0;
        }

        private void buttonDiezPesos_Click(object sender, EventArgs e)
        {
            amount += 10;

            if(amount > price) {
                amount = amount - price;
                label.Text = amount.ToString();
            }

            if(amount == price) {
                Task.Delay(1000).Wait();
                amount = 0;
                label.Text = "--";
            }
        }

        private void buttonCincoPesos_Click(object sender, EventArgs e)
        {
            amount += 5;

            if(amount > price) {
                amount = amount - price;
                label.Text = amount.ToString();
            }
            else
                label.Text = amount.ToString();

            if(amount == price) {
                Task.Delay(1000).Wait();
                amount = 0;
                label.Text = "--";
            }
        }

        private void buttonDosPesos_Click(object sender, EventArgs e)
        {
            amount += 2;

            if(amount > price) {
                amount = amount - price;
                label.Text = amount.ToString();
            }
            else
                label.Text = amount.ToString();

            if(amount == price) {
                Task.Delay(1000).Wait();
                amount = 0;
                label.Text = "--";
            }
        }

        private void buttonUnPeso_Click(object sender, EventArgs e)
        {
            amount += 1;

            if(amount > price) {
                amount = amount - price;
                label.Text = amount.ToString();
            }
            else
                label.Text = amount.ToString();

            if(amount == price) {
                Task.Delay(1000).Wait();
                amount = 0;
                label.Text = "--";
            }
        }

        private void buttonCincuentaCentavos_Click(object sender, EventArgs e)
        {
            amount += .5f;

            if(amount > price) {
                amount = amount - price;
                label.Text = amount.ToString();
            }
            else
                label.Text = amount.ToString();

            if(amount == price) {
                Task.Delay(1000).Wait();
                amount = 0;
                label.Text = "--";
            }
        }


    }
}