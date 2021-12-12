namespace Ahorcado
{
    partial class ComprobarPalabra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprobarPalabra));
            this.textBoxComprobarPalabra = new System.Windows.Forms.TextBox();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxComprobarPalabra
            // 
            this.textBoxComprobarPalabra.Location = new System.Drawing.Point(96, 84);
            this.textBoxComprobarPalabra.Name = "textBoxComprobarPalabra";
            this.textBoxComprobarPalabra.Size = new System.Drawing.Size(280, 20);
            this.textBoxComprobarPalabra.TabIndex = 0;
            // 
            // btnComprobar
            // 
            this.btnComprobar.BackColor = System.Drawing.Color.Transparent;
            this.btnComprobar.Location = new System.Drawing.Point(190, 125);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(93, 42);
            this.btnComprobar.TabIndex = 1;
            this.btnComprobar.Text = "Comprobar";
            this.btnComprobar.UseVisualStyleBackColor = false;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese la Palabra";
            // 
            // ComprobarPalabra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(473, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComprobar);
            this.Controls.Add(this.textBoxComprobarPalabra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComprobarPalabra";
            this.Text = "Comprobar Palabra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxComprobarPalabra;
    }
}