namespace MaquinaDePasajes
{
    public partial class Form1 : Form
    {

        float price;
        float amount;
        int estado;

        public Form1()
        {
            InitializeComponent();

            price = 10;   // precio del pasaje
            amount = 0;     // acumulado;
            estado = 0;
        }

        private void buttonDiezPesos_Click(object sender, EventArgs e)  // se ejecuta cuando se presionan los 10 pesos
        {
            if(estado == 0) {
                textBoxEstados.Text = "";
                estado = 1;
                textBoxEstados.Text += "Q" + estado;
            }

            amount += 10;   // al monto se le aumentan 10 pesos

            if(amount >= price) {           // si acumulado es mayor que el monto
                label.Text = amount.ToString();
                Task.Delay(800).Wait();    // se hace un delay de 1s
                amount = 0;                 // se hace cero el acumulado
                label.Text = "--";          // se reinicia el display
                estado = 0;
            }
        }

        private void buttonCincoPesos_Click(object sender, EventArgs e) // se ejecuta cuando se presionan los 5 pesos
        {
            if(estado == 0) {
                textBoxEstados.Text = "";
                estado = 4;
                textBoxEstados.Text += "Q" + estado + ", ";
            }
            else if(estado == 3) {
                estado = 4;
                textBoxEstados.Text += "Q" + estado + ", ";
            }
            else if(estado == 4) {
                estado = 1;
                textBoxEstados.Text += "Q" + estado;
            }

            amount += 5;

            if(amount >= price) {
                label.Text = amount.ToString();
                Task.Delay(800).Wait();
                amount = 0;
                label.Text = "--";
                estado = 0;
            }
            else
                label.Text = amount.ToString();
        }

        private void buttonDosPesos_Click(object sender, EventArgs e)   // se ejecuta cuando se presionan los 2 pesos
        {
            if(estado == 0) {
                textBoxEstados.Text = "";
                estado = 3;
                textBoxEstados.Text += "Q" + estado + ", ";
            }
            else if(estado == 2) {
                estado = 3;
                textBoxEstados.Text += "Q" + estado + ", ";
            }
            else if(estado == 3) {
                estado = 13;
                textBoxEstados.Text += "Q" + estado + ", ";
            }
            else if(estado == 4) {
                estado = 14;
                textBoxEstados.Text += "Q" + estado + ", ";
            }
            else if(estado == 9) {
                estado = 15;
                textBoxEstados.Text += "Q" + estado + ", ";
            }
            else if(estado == 13) {
                estado = 14;
                textBoxEstados.Text += "Q" + estado + ", ";
            }
            else if(estado == 14) {
                estado = 15;
                textBoxEstados.Text += "Q" + estado + ", ";
            }
            else if(estado == 15) {
                estado = 1;
                textBoxEstados.Text += "Q" + estado;
            }


            amount += 2;

            if(amount >= price) {
                label.Text = amount.ToString();
                Task.Delay(800).Wait();
                amount = 0;
                label.Text = "--";
                estado = 0;
            }
            else
                label.Text = amount.ToString();
        }

        private void buttonUnPeso_Click(object sender, EventArgs e) // se ejecuta cuando se presiona el peso
        {
            if(estado == 0) {
                textBoxEstados.Text = "";
                estado = 2;
                textBoxEstados.Text += "Q" + estado + ", ";
            }
            else if(estado == 2) {
                estado = 5;
                textBoxEstados.Text += "Q" + estado + ", ";
            }
            else if(estado == 3) {
                estado = 6;
                textBoxEstados.Text += "Q" + estado + ", ";
            }
            else if(estado == 5) {
                estado = 6;
                textBoxEstados.Text += "Q" + estado + ", ";
            }
            else if(estado == 6) {
                estado = 7;
                textBoxEstados.Text += "Q" + estado + ", ";
            }
            else if(estado == 7) {
                estado = 8;
                textBoxEstados.Text += "Q" + estado + ", ";
            }
            else if(estado == 8) {
                estado = 9;
                textBoxEstados.Text += "Q" + estado + ", ";
            }
            else if(estado == 9) {
                estado = 10;
                textBoxEstados.Text += "Q" + estado + ", ";
            }
            else if(estado == 10) {
                estado = 11;
                textBoxEstados.Text += "Q" + estado + ", ";
            }
            else if(estado == 11) {
                estado = 12;
                textBoxEstados.Text += "Q" + estado + ", ";
            }
            else if(estado == 12) {
                estado = 1;
                textBoxEstados.Text += "Q" + estado;
            }


            amount += 1;

            if(amount >= price) {
                label.Text = amount.ToString();
                Task.Delay(800).Wait();
                amount = 0;
                label.Text = "--";
            }
            else
                label.Text = amount.ToString();
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