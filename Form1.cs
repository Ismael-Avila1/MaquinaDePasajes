namespace MaquinaDePasajes
{
    public partial class Form1 : Form
    {

        float price;
        float amount;

        public Form1()
        {
            InitializeComponent();

            price = 9.5f;   // precio del pasaje
            amount = 0;     // acumulado
        }

        private void buttonDiezPesos_Click(object sender, EventArgs e)  // se ejecuta cuando se presionan los 10 pesos
        {
            amount += 10;   // al monto se le aumentan 10 pesos

            if(amount > price) {           // si acumulado es mayor que el monto
                amount = amount - price;    // se le resta al acumulado el precio, para mostra el "cambio"
                label.Text = amount.ToString();
            }

            if(amount == price) {           // si son justos los 9.50
                Task.Delay(1000).Wait();    // se hace un delay de 1s
                amount = 0;                 // se hace cero el acumulado
                label.Text = "--";          // se reinicia el display
            }
        }

        private void buttonCincoPesos_Click(object sender, EventArgs e) // se ejecuta cuando se presionan los 5 pesos
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

        private void buttonDosPesos_Click(object sender, EventArgs e)   // se ejecuta cuando se presionan los 2 pesos
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

        private void buttonUnPeso_Click(object sender, EventArgs e) // se ejecuta cuando se presiona el peso
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

        private void buttonCincuentaCentavos_Click(object sender, EventArgs e)  // se ejecuta cuando se presionan los 50 centavos
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