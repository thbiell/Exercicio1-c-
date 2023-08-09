namespace Exercicio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            txtHomens = new TextBox();
            txtMulheres = new TextBox();
            txtCriancas = new TextBox();
            lblCarne = new Label();
            lblFarofa = new Label();
            lblCerveja = new Label();
            lblRefri = new Label();
            lblGelo = new Label();
            lblSalada = new Label();
            lblCarvao = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 366);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtHomens
            // 
            txtHomens.BackColor = SystemColors.InactiveCaption;
            txtHomens.Location = new Point(12, 297);
            txtHomens.Name = "txtHomens";
            txtHomens.Size = new Size(75, 23);
            txtHomens.TabIndex = 1;
            txtHomens.Text = "Homens";
            txtHomens.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMulheres
            // 
            txtMulheres.BackColor = SystemColors.InactiveCaption;
            txtMulheres.Location = new Point(12, 317);
            txtMulheres.Name = "txtMulheres";
            txtMulheres.Size = new Size(75, 23);
            txtMulheres.TabIndex = 2;
            txtMulheres.Text = "Mulheres";
            txtMulheres.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCriancas
            // 
            txtCriancas.BackColor = SystemColors.InactiveCaption;
            txtCriancas.Location = new Point(12, 337);
            txtCriancas.Name = "txtCriancas";
            txtCriancas.Size = new Size(75, 23);
            txtCriancas.TabIndex = 3;
            txtCriancas.Text = "Crianças";
            txtCriancas.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCarne
            // 
            lblCarne.AutoSize = true;
            lblCarne.BackColor = SystemColors.GradientInactiveCaption;
            lblCarne.Location = new Point(192, 170);
            lblCarne.Name = "lblCarne";
            lblCarne.Size = new Size(38, 15);
            lblCarne.TabIndex = 4;
            lblCarne.Text = "Carne";
            // 
            // lblFarofa
            // 
            lblFarofa.AutoSize = true;
            lblFarofa.BackColor = SystemColors.GradientInactiveCaption;
            lblFarofa.Location = new Point(192, 252);
            lblFarofa.Name = "lblFarofa";
            lblFarofa.Size = new Size(40, 15);
            lblFarofa.TabIndex = 9;
            lblFarofa.Text = "Farofa";
            // 
            // lblCerveja
            // 
            lblCerveja.AutoSize = true;
            lblCerveja.BackColor = SystemColors.GradientInactiveCaption;
            lblCerveja.Location = new Point(192, 300);
            lblCerveja.Name = "lblCerveja";
            lblCerveja.Size = new Size(49, 15);
            lblCerveja.TabIndex = 10;
            lblCerveja.Text = "Cerveja:";
            // 
            // lblRefri
            // 
            lblRefri.AutoSize = true;
            lblRefri.BackColor = SystemColors.GradientInactiveCaption;
            lblRefri.Location = new Point(192, 345);
            lblRefri.Name = "lblRefri";
            lblRefri.Size = new Size(34, 15);
            lblRefri.TabIndex = 11;
            lblRefri.Text = "Refri:";
            // 
            // lblGelo
            // 
            lblGelo.AutoSize = true;
            lblGelo.BackColor = SystemColors.GradientInactiveCaption;
            lblGelo.Location = new Point(192, 387);
            lblGelo.Name = "lblGelo";
            lblGelo.Size = new Size(37, 15);
            lblGelo.TabIndex = 12;
            lblGelo.Text = "Gelo: ";
            // 
            // lblSalada
            // 
            lblSalada.AutoSize = true;
            lblSalada.BackColor = SystemColors.GradientInactiveCaption;
            lblSalada.Location = new Point(192, 208);
            lblSalada.Name = "lblSalada";
            lblSalada.Size = new Size(47, 15);
            lblSalada.TabIndex = 13;
            lblSalada.Text = "Salada: ";
            // 
            // lblCarvao
            // 
            lblCarvao.AutoSize = true;
            lblCarvao.BackColor = SystemColors.GradientInactiveCaption;
            lblCarvao.Location = new Point(12, 101);
            lblCarvao.Name = "lblCarvao";
            lblCarvao.Size = new Size(47, 15);
            lblCarvao.TabIndex = 14;
            lblCarvao.Text = "Carvão:";
            lblCarvao.UseMnemonic = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(546, 450);
            Controls.Add(lblCarvao);
            Controls.Add(lblSalada);
            Controls.Add(lblGelo);
            Controls.Add(lblRefri);
            Controls.Add(lblCerveja);
            Controls.Add(lblFarofa);
            Controls.Add(lblCarne);
            Controls.Add(txtCriancas);
            Controls.Add(txtMulheres);
            Controls.Add(txtHomens);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Exercicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtHomens;
        private TextBox txtMulheres;
        private TextBox txtCriancas;
        private Label lblCarne;
        private Label lblFarofa;
        private Label lblCerveja;
        private Label lblRefri;
        private Label lblGelo;
        private Label lblSalada;
        private Label lblCarvao;
    }
}