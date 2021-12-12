
namespace Ahorcado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnUnJugador = new System.Windows.Forms.RadioButton();
            this.btnDosJugadores = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonJugar = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btnSolucionarPalabra = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnÑ = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.labelJug1 = new System.Windows.Forms.Label();
            this.labelJug2 = new System.Windows.Forms.Label();
            this.fotoAhorcado = new System.Windows.Forms.PictureBox();
            this.InfoTurnos = new System.Windows.Forms.Label();
            this.textBoxPalabra = new System.Windows.Forms.TextBox();
            this.txtVidas = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoAhorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Name = "label1";
            // 
            // btnUnJugador
            // 
            resources.ApplyResources(this.btnUnJugador, "btnUnJugador");
            this.btnUnJugador.Name = "btnUnJugador";
            this.btnUnJugador.TabStop = true;
            this.btnUnJugador.UseVisualStyleBackColor = true;
            this.btnUnJugador.CheckedChanged += new System.EventHandler(this.btnUnJugador_CheckedChanged);
            // 
            // btnDosJugadores
            // 
            resources.ApplyResources(this.btnDosJugadores, "btnDosJugadores");
            this.btnDosJugadores.Name = "btnDosJugadores";
            this.btnDosJugadores.TabStop = true;
            this.btnDosJugadores.UseVisualStyleBackColor = true;
            this.btnDosJugadores.CheckedChanged += new System.EventHandler(this.btnDosJugadores_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.btnUnJugador);
            this.groupBox1.Controls.Add(this.btnDosJugadores);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // botonJugar
            // 
            this.botonJugar.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.botonJugar, "botonJugar");
            this.botonJugar.ForeColor = System.Drawing.Color.White;
            this.botonJugar.Name = "botonJugar";
            this.botonJugar.UseVisualStyleBackColor = false;
            this.botonJugar.Click += new System.EventHandler(this.clickJugar);
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.DimGray;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox, "comboBox");
            this.comboBox.ForeColor = System.Drawing.Color.SeaShell;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Name = "comboBox";
            // 
            // btnSolucionarPalabra
            // 
            this.btnSolucionarPalabra.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnSolucionarPalabra, "btnSolucionarPalabra");
            this.btnSolucionarPalabra.ForeColor = System.Drawing.Color.White;
            this.btnSolucionarPalabra.Name = "btnSolucionarPalabra";
            this.btnSolucionarPalabra.UseVisualStyleBackColor = false;
            this.btnSolucionarPalabra.Click += new System.EventHandler(this.clickSolucionarPalabra);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnA, "btnA");
            this.btnA.ForeColor = System.Drawing.Color.White;
            this.btnA.Name = "btnA";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnB, "btnB");
            this.btnB.ForeColor = System.Drawing.Color.White;
            this.btnB.Name = "btnB";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnD, "btnD");
            this.btnD.ForeColor = System.Drawing.Color.White;
            this.btnD.Name = "btnD";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnC, "btnC");
            this.btnC.ForeColor = System.Drawing.Color.White;
            this.btnC.Name = "btnC";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnE, "btnE");
            this.btnE.ForeColor = System.Drawing.Color.White;
            this.btnE.Name = "btnE";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnF, "btnF");
            this.btnF.ForeColor = System.Drawing.Color.White;
            this.btnF.Name = "btnF";
            this.btnF.UseVisualStyleBackColor = false;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnG, "btnG");
            this.btnG.ForeColor = System.Drawing.Color.White;
            this.btnG.Name = "btnG";
            this.btnG.UseVisualStyleBackColor = false;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnH
            // 
            this.btnH.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnH, "btnH");
            this.btnH.ForeColor = System.Drawing.Color.White;
            this.btnH.Name = "btnH";
            this.btnH.UseVisualStyleBackColor = false;
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btnJ
            // 
            this.btnJ.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnJ, "btnJ");
            this.btnJ.ForeColor = System.Drawing.Color.White;
            this.btnJ.Name = "btnJ";
            this.btnJ.UseVisualStyleBackColor = false;
            this.btnJ.Click += new System.EventHandler(this.btnJ_Click);
            // 
            // btnI
            // 
            this.btnI.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnI, "btnI");
            this.btnI.ForeColor = System.Drawing.Color.White;
            this.btnI.Name = "btnI";
            this.btnI.UseVisualStyleBackColor = false;
            this.btnI.Click += new System.EventHandler(this.btnI_Click);
            // 
            // btnK
            // 
            this.btnK.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnK, "btnK");
            this.btnK.ForeColor = System.Drawing.Color.White;
            this.btnK.Name = "btnK";
            this.btnK.UseVisualStyleBackColor = false;
            this.btnK.Click += new System.EventHandler(this.btnK_Click);
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnL, "btnL");
            this.btnL.ForeColor = System.Drawing.Color.White;
            this.btnL.Name = "btnL";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnM, "btnM");
            this.btnM.ForeColor = System.Drawing.Color.White;
            this.btnM.Name = "btnM";
            this.btnM.UseVisualStyleBackColor = false;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnN
            // 
            this.btnN.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnN, "btnN");
            this.btnN.ForeColor = System.Drawing.Color.White;
            this.btnN.Name = "btnN";
            this.btnN.UseVisualStyleBackColor = false;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnO
            // 
            this.btnO.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnO, "btnO");
            this.btnO.ForeColor = System.Drawing.Color.White;
            this.btnO.Name = "btnO";
            this.btnO.UseVisualStyleBackColor = false;
            this.btnO.Click += new System.EventHandler(this.btnO_Click);
            // 
            // btnÑ
            // 
            this.btnÑ.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnÑ, "btnÑ");
            this.btnÑ.ForeColor = System.Drawing.Color.White;
            this.btnÑ.Name = "btnÑ";
            this.btnÑ.UseVisualStyleBackColor = false;
            this.btnÑ.Click += new System.EventHandler(this.btnÑ_Click);
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnP, "btnP");
            this.btnP.ForeColor = System.Drawing.Color.White;
            this.btnP.Name = "btnP";
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnQ
            // 
            this.btnQ.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnQ, "btnQ");
            this.btnQ.ForeColor = System.Drawing.Color.White;
            this.btnQ.Name = "btnQ";
            this.btnQ.UseVisualStyleBackColor = false;
            this.btnQ.Click += new System.EventHandler(this.btnQ_Click);
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnR, "btnR");
            this.btnR.ForeColor = System.Drawing.Color.White;
            this.btnR.Name = "btnR";
            this.btnR.UseVisualStyleBackColor = false;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnS, "btnS");
            this.btnS.ForeColor = System.Drawing.Color.White;
            this.btnS.Name = "btnS";
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnU
            // 
            this.btnU.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnU, "btnU");
            this.btnU.ForeColor = System.Drawing.Color.White;
            this.btnU.Name = "btnU";
            this.btnU.UseVisualStyleBackColor = false;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnT, "btnT");
            this.btnT.ForeColor = System.Drawing.Color.White;
            this.btnT.Name = "btnT";
            this.btnT.UseVisualStyleBackColor = false;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnV
            // 
            this.btnV.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnV, "btnV");
            this.btnV.ForeColor = System.Drawing.Color.White;
            this.btnV.Name = "btnV";
            this.btnV.UseVisualStyleBackColor = false;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // btnW
            // 
            this.btnW.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnW, "btnW");
            this.btnW.ForeColor = System.Drawing.Color.White;
            this.btnW.Name = "btnW";
            this.btnW.UseVisualStyleBackColor = false;
            this.btnW.Click += new System.EventHandler(this.btnW_Click);
            // 
            // btnY
            // 
            this.btnY.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnY, "btnY");
            this.btnY.ForeColor = System.Drawing.Color.White;
            this.btnY.Name = "btnY";
            this.btnY.UseVisualStyleBackColor = false;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnX, "btnX");
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Name = "btnX";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnZ
            // 
            this.btnZ.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btnZ, "btnZ");
            this.btnZ.ForeColor = System.Drawing.Color.White;
            this.btnZ.Name = "btnZ";
            this.btnZ.UseVisualStyleBackColor = false;
            this.btnZ.Click += new System.EventHandler(this.btnZ_Click);
            // 
            // labelJug1
            // 
            resources.ApplyResources(this.labelJug1, "labelJug1");
            this.labelJug1.BackColor = System.Drawing.Color.Transparent;
            this.labelJug1.ForeColor = System.Drawing.Color.White;
            this.labelJug1.Name = "labelJug1";
            // 
            // labelJug2
            // 
            resources.ApplyResources(this.labelJug2, "labelJug2");
            this.labelJug2.BackColor = System.Drawing.Color.Transparent;
            this.labelJug2.ForeColor = System.Drawing.Color.White;
            this.labelJug2.Name = "labelJug2";
            // 
            // fotoAhorcado
            // 
            this.fotoAhorcado.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.fotoAhorcado, "fotoAhorcado");
            this.fotoAhorcado.Name = "fotoAhorcado";
            this.fotoAhorcado.TabStop = false;
            // 
            // InfoTurnos
            // 
            resources.ApplyResources(this.InfoTurnos, "InfoTurnos");
            this.InfoTurnos.BackColor = System.Drawing.Color.Transparent;
            this.InfoTurnos.ForeColor = System.Drawing.Color.White;
            this.InfoTurnos.Name = "InfoTurnos";
            // 
            // textBoxPalabra
            // 
            this.textBoxPalabra.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.textBoxPalabra, "textBoxPalabra");
            this.textBoxPalabra.ForeColor = System.Drawing.Color.White;
            this.textBoxPalabra.Name = "textBoxPalabra";
            this.textBoxPalabra.ReadOnly = true;
            // 
            // txtVidas
            // 
            resources.ApplyResources(this.txtVidas, "txtVidas");
            this.txtVidas.BackColor = System.Drawing.Color.Transparent;
            this.txtVidas.ForeColor = System.Drawing.SystemColors.Control;
            this.txtVidas.Name = "txtVidas";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.comprobar);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVidas);
            this.Controls.Add(this.textBoxPalabra);
            this.Controls.Add(this.InfoTurnos);
            this.Controls.Add(this.fotoAhorcado);
            this.Controls.Add(this.labelJug2);
            this.Controls.Add(this.labelJug1);
            this.Controls.Add(this.btnZ);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnÑ);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnJ);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnSolucionarPalabra);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.botonJugar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoAhorcado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton btnUnJugador;
        private System.Windows.Forms.RadioButton btnDosJugadores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonJugar;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button btnSolucionarPalabra;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnÑ;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Label labelJug1;
        private System.Windows.Forms.Label labelJug2;
        private System.Windows.Forms.PictureBox fotoAhorcado;
        private System.Windows.Forms.Label InfoTurnos;
        private System.Windows.Forms.TextBox textBoxPalabra;
        private System.Windows.Forms.Label txtVidas;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label2;
    }
}

