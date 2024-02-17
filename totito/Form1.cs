namespace totito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string jugador = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if (jugador == "")
            {
                jugador = button1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (jugador == "")
            {
                jugador = button2.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (jugador != "")
            {
                button3.Text = jugador;
                if (jugador == button1.Text)
                {
                    jugador = button2.Text;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (jugador != "")
            {
                button3.Text = jugador;
                if (jugador == button1.Text)
                {
                    jugador = button2.Text;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (jugador != "")
            {
                button3.Text = jugador;
                if (jugador == button1.Text)
                {
                    jugador = button2.Text;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (jugador != "")
            {
                button3.Text = jugador;
                if (jugador == button1.Text)
                {
                    jugador = button2.Text;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (jugador != "")
            {
                button3.Text = jugador;
                if (jugador == button1.Text)
                {
                    jugador = button2.Text;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (jugador != "")
            {
                button3.Text = jugador;
                if (jugador == button1.Text)
                {
                    jugador = button2.Text;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (jugador != "")
            {
                button3.Text = jugador;
                if (jugador == button1.Text)
                {
                    jugador = button2.Text;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (jugador != "")
            {
                button3.Text = jugador;
                if (jugador == button1.Text)
                {
                    jugador = button2.Text;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (jugador != "")
            {
                button3.Text = jugador;
                if (jugador == button1.Text)
                {
                    jugador = button2.Text;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            jugador = "";

        }
    }
}
