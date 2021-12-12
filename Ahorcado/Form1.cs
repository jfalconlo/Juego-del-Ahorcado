using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Ahorcado
{
    public partial class Form1 : Form
    {
        ArrayList palabras = new ArrayList();
        public String palabraResulta = null;
        char[] ArrayPalabra;
        char[] ArrayAsteriscos;
        int contador = 2;
        int puntosJ1 = 0;
        int puntosJ2 = 0;
        int vidas = 0;


        public Form1()
        {
            InitializeComponent();
            rellenarComboBox();
            textBoxPalabra.Text = "";

        }

        public void rellenarComboBox()
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("palabras.xml");

            foreach (XmlNode n1 in doc.DocumentElement.ChildNodes)
            {

                comboBox.Items.Add(n1.Name);

            }
        }


        private void buscarPalabrasXML(String Categoria)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("palabras.xml");

            foreach (XmlNode n1 in doc.DocumentElement.ChildNodes)
            {
                if (n1.Name == Categoria)
                {
                    foreach (XmlNode n2 in n1.ChildNodes)
                    {

                        foreach (XmlNode n3 in n2.ChildNodes)
                        {
                            palabras.Add(n3.Value);
                        }

                    }
                }
            }
        }

        private void clickJugar(object sender, EventArgs e)
        {
            palabras.Clear();


            if (comboBox.SelectedItem == null)
            {
                MessageBox.Show("Por Favor, Seleccione una categoria de Palabras", "Error en la Seleccion de Palabras",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSolucionarPalabra.Enabled = false;
            }
            else
            {
                labelJug1.Text = "Jugador 1: " + puntosJ1 + "P";
                labelJug2.Text = "Jugador 2: " + puntosJ2 + "P";
                vidas = 0;
                comboBox.Enabled = false;
                timer.Enabled = true;
                txtVidas.Visible = true;
                txtVidas.Text = ("VIDAS " + vidas + "/5");
                fotoAhorcado.Image = System.Drawing.Image.FromFile("1.png");
                EnableBTN(true);
                btnSolucionarPalabra.Enabled = true;
                if (btnUnJugador.Checked)
                {
                    labelJug1.Visible = true;
                    labelJug2.Visible = false;
                }
                else
                {
                    labelJug1.Visible = true;
                    labelJug2.Visible = true;
                    InfoTurnos.Visible = true;
                }

                EnableBTN(true);
                buscarPalabrasXML(comboBox.Text);

                int nAleatorio;

                do
                {
                    Random rnd = new Random();
                    nAleatorio = rnd.Next(0, palabras.Count);

                    palabraResulta = (palabras[nAleatorio] + "").ToUpper();
                } while (palabraResulta == textBoxPalabra.Text);
                ArrayPalabra = palabraResulta.ToCharArray();

                textBoxPalabra.Text = "";
                ArrayAsteriscos = new char[ArrayPalabra.Length];

                for (int i = 0; i < ArrayAsteriscos.Length; i++)
                {
                    ArrayAsteriscos[i] = '*';
                }
                textBoxPalabra.Text = new string(ArrayAsteriscos);

                botonJugar.Enabled = false;
                groupBox1.Enabled = false;
            }
        }

        private void clickSolucionarPalabra(object sender, EventArgs e)
        {
            if (palabraResulta == null)
            {
                MessageBox.Show("Antes de poder resolver la palabra debera darle a jugar", "No se puede mostrar la palabra resuelta",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ComprobarPalabra comprobarPalabra = new ComprobarPalabra();
                comprobarPalabra.ShowDialog();

                if (comprobarPalabra.DialogResult == DialogResult.OK)
                {
                    if (comprobarPalabra.textBoxComprobarPalabra.Text.ToUpper() == palabraResulta)
                    {
                        textBoxPalabra.Text = comprobarPalabra.textBoxComprobarPalabra.Text.ToUpper();

                        MessageBox.Show("La palabra introducida es correcta", "Palabra Valida",
    MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (btnDosJugadores.Checked)
                        {
                            if (contador % 2 == 0)
                            {
                                puntosJ1 = puntosJ1 + 10;
                                labelJug1.Text = "Jugador 1: " + puntosJ1 + "P";
                            }
                            else
                            {
                                puntosJ2 = puntosJ2 + 10;
                                labelJug2.Text = "Jugador 2: " + puntosJ2 + "P";
                            }
                        }
                        else
                        {
                            puntosJ1 = puntosJ1 + 10;
                        }

                        labelJug1.Text = "Jugador 1: " + puntosJ1 + "P";
                        botonJugar.Enabled = true;
                        EnableBTN(false);
                        groupBox1.Enabled = true;
                        btnSolucionarPalabra.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("La palabra introducida no es correcta", "Palabra no valida",
MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (btnDosJugadores.Checked)
                        {
                            if (contador % 2 == 0)
                            {
                                puntosJ1 = puntosJ1 - 5;
                                labelJug1.Text = "Jugador 1: " + puntosJ1 + "P";
                                vidas=5;
                                
                            }
                            else
                            {
                                puntosJ2 = puntosJ2 - 5;
                                labelJug2.Text = "Jugador 2: " + puntosJ2 + "P";
                                vidas=5;

                            }
                        }
                        else { 
                            puntosJ1 = puntosJ1 - 5;
                            labelJug1.Text = "Jugador 1: " + puntosJ1 + "P";
                            vidas = 5;


                        }
                        txtVidas.Text = ("VIDAS " + "5/5");
                        fotoAhorcado.Image = System.Drawing.Image.FromFile("5.png");
                    }
                }
            }

        }

        public void comprobarLetra(char LETRA)
        {
            if (vidas < 5)
            {

                for (int i = 0; i < ArrayPalabra.Length; i++)
                {
                    if (ArrayPalabra[i] == LETRA)
                    {
                        ArrayAsteriscos[i] = ArrayPalabra[i];

                        if (btnDosJugadores.Checked)
                        {
                            if (contador % 2 == 0)
                            {
                                puntosJ1 = puntosJ1 + 2;
                            }
                            else
                            {
                                puntosJ2 = puntosJ2 + 2;
                            }
                        }
                        else
                        {
                            puntosJ1 = puntosJ1 + 2;
                        }
                    }
                }

                if (!palabraResulta.Contains(LETRA))
                {
                    if (btnDosJugadores.Checked)
                    {
                        if (contador % 2 == 0)
                        {
                            vidas++;
                            txtVidas.Text = ("VIDAS " + vidas + "/5");
                            fotoAhorcado.Image = System.Drawing.Image.FromFile(vidas + ".png");
                            puntosJ1 = puntosJ1 - 1;
                        }
                        else
                        {
                            vidas++;
                            txtVidas.Text = ("VIDAS " + vidas + "/5");
                            fotoAhorcado.Image = System.Drawing.Image.FromFile(vidas + ".png");
                            puntosJ2 = puntosJ2 - 1;
                        }
                    }
                    else
                    {
                        vidas++;
                        txtVidas.Text = ("VIDAS " + vidas + "/5");
                        fotoAhorcado.Image = System.Drawing.Image.FromFile(vidas + ".png");
                        puntosJ1 = puntosJ1 - 1;
                    }
                }
                textBoxPalabra.Text = "";
                textBoxPalabra.Text = new string(ArrayAsteriscos);

                labelJug1.Text = "Jugador 1: " + puntosJ1 + "P";
                labelJug2.Text = "Jugador 2: " + puntosJ2 + "P";


                string palabraAsteriscos = new string(ArrayAsteriscos);

                if (palabraAsteriscos == palabraResulta)
                {

                    EnableBTN(false);

                    if (btnDosJugadores.Checked == true)
                    {
                        if (contador % 2 == 0)
                        {
                            puntosJ1 = puntosJ1 + 10;
                            labelJug1.Text = "Jugador 1: " + puntosJ1 + "P";
                        }
                        else
                        {
                            puntosJ2 = puntosJ2 + 10;
                            labelJug2.Text = "Jugador 2: " + puntosJ2 + "P";
                        }
                    }
                    else
                    {
                        puntosJ1 = puntosJ1 + 10;
                    }

                    labelJug1.Text = "Jugador 1: " + puntosJ1 + "P";
                    botonJugar.Enabled = true;
                    groupBox1.Enabled = true;
                    btnSolucionarPalabra.Enabled = false;
                }

                contador++;

                if (btnDosJugadores.Checked)
                {
                    if (contador % 2 == 0)
                    {
                        InfoTurnos.Text = "Turno del Jugador 1";
                    }
                    else
                    {
                        InfoTurnos.Text = "Turno del Jugador 2";

                    }



                }
            }
        }

        private void btnUnJugador_CheckedChanged(object sender, EventArgs e)
        {

            puntosJ1 = 0;
            puntosJ2 = 0;
            labelJug1.Text = "Jugador 1: " + puntosJ1 + "P";
            labelJug2.Text = "Jugador 2: " + puntosJ2 + "P";
            labelJug2.Visible = false;
            InfoTurnos.Visible = false;
            EnableBTN(true);

        }

        private void btnDosJugadores_CheckedChanged(object sender, EventArgs e)
        {

            puntosJ1 = 0;
            puntosJ2 = 0;
            labelJug1.Text = "Jugador 1: " + puntosJ1 + "P";
            labelJug2.Text = "Jugador 2: " + puntosJ2 + "P";
            labelJug2.Visible = true;
            EnableBTN(true);
        }

        private void comprobar(object sender, EventArgs e)
        {
            if (vidas == 5)
            {
                timer.Enabled = false;
                EnableBTN(false);
                DialogResult result = MessageBox.Show("La Partida ha finalizado, Recuerda si quieres volver dale click a Jugar", "FINAL DE LA PARTIDA",
MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    btnSolucionarPalabra.Enabled = false;
                    comboBox.Enabled = true;
                    puntosJ1 = 0;
                    puntosJ2 = 0;
                    vidas = 0;
                    botonJugar.Enabled = true;
                    groupBox1.Enabled = true;

                }
            }
        }

        public void EnableBTN(Boolean estado)
        {
            btnA.Enabled = estado;
            btnB.Enabled = estado;
            btnC.Enabled = estado;
            btnD.Enabled = estado;
            btnE.Enabled = estado;
            btnF.Enabled = estado;
            btnG.Enabled = estado;
            btnH.Enabled = estado;
            btnI.Enabled = estado;
            btnJ.Enabled = estado;
            btnK.Enabled = estado;
            btnL.Enabled = estado;
            btnM.Enabled = estado;
            btnN.Enabled = estado;
            btnÑ.Enabled = estado;
            btnO.Enabled = estado;
            btnP.Enabled = estado;
            btnQ.Enabled = estado;
            btnR.Enabled = estado;
            btnS.Enabled = estado;
            btnT.Enabled = estado;
            btnU.Enabled = estado;
            btnV.Enabled = estado;
            btnW.Enabled = estado;
            btnX.Enabled = estado;
            btnY.Enabled = estado;
            btnZ.Enabled = estado;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('A');
                btnA.Enabled = false;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('B');
                btnB.Enabled = false;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('C');
                btnC.Enabled = false;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('D');
                btnD.Enabled = false;
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('E');
                btnE.Enabled = false;
            }
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('F');
                btnF.Enabled = false;
            }
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('G');
                btnG.Enabled = false;
            }
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('H');
                btnH.Enabled = false;
            }
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('I');
                btnI.Enabled = false;
            }
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
                comprobarLetra('J');
            btnJ.Enabled = false;
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('K');
                btnK.Enabled = false;
            }
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('L');
                btnL.Enabled = false;
            }

        }

        private void btnM_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('M');
                btnM.Enabled = false;
            }

        }

        private void btnN_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('N');
                btnN.Enabled = false;
            }

        }

        private void btnÑ_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('Ñ');
                btnÑ.Enabled = false;
            }

        }

        private void btnO_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('O');
                btnO.Enabled = false;
            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('P');
                btnP.Enabled = false;
            }
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('Q');
                btnQ.Enabled = false;
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('R');
                btnR.Enabled = false;
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('S');
                btnS.Enabled = false;
            }
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('T');
                btnT.Enabled = false;
            }
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('U');
                btnU.Enabled = false;
            }
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('V');
                btnV.Enabled = false;
            }
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('W');
                btnW.Enabled = false;
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('X');
                btnX.Enabled = false;
            }
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('Y');
                btnY.Enabled = false;
            }
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            if (palabraResulta != null)
            {
                comprobarLetra('Z');
                btnZ.Enabled = false;
            }
        }
    }
}
