namespace CalculadoraPaneles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
        }
        private void Calcular(string operacion)      // AQUÍ comienza el método de la calculadora
        {
            double numero1;
            double numero2;

            if (!double.TryParse(txtNumero1.Text, out numero1) ||
                !double.TryParse(txtNumero2.Text, out numero2))
            {
                MessageBox.Show("Ingresa dos números válidos.");
                return;
            }

            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    break;

                case "*":
                    resultado = numero1 * numero2;
                    break;

                case "/":
                    if (numero2 == 0)
                    {
                        MessageBox.Show("No se puede dividir para cero.");
                        return;
                    }

                    resultado = numero1 / numero2;
                    break;
            }

            textBox1.Text = resultado.ToString();     // AQUÍ termina el método
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calcular("+");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            Calcular("-");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calcular("*");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Calcular("/");
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            textBox1.Clear();
            txtNumero1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
