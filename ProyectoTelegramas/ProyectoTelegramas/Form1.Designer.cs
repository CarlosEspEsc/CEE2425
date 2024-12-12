namespace ProyectoTelegramas
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
            txtTelegrama = new TextBox();
            Calcular = new Button();
            chkUrgente = new CheckBox();
            txtPrecio = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(73, 57);
            txtTelegrama.Margin = new Padding(3, 4, 3, 4);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(763, 276);
            txtTelegrama.TabIndex = 0;
            // 
            // Calcular
            // 
            Calcular.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Calcular.Location = new Point(601, 388);
            Calcular.Margin = new Padding(3, 4, 3, 4);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(235, 93);
            Calcular.TabIndex = 1;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += btnCalcularPrecio_Click;
            // 
            // chkUrgente
            // 
            chkUrgente.AutoSize = true;
            chkUrgente.Font = new Font("Segoe UI", 15F);
            chkUrgente.Location = new Point(73, 375);
            chkUrgente.Margin = new Padding(3, 4, 3, 4);
            chkUrgente.MaximumSize = new Size(300, 200);
            chkUrgente.MinimumSize = new Size(150, 50);
            chkUrgente.Name = "chkUrgente";
            chkUrgente.Size = new Size(150, 50);
            chkUrgente.TabIndex = 2;
            chkUrgente.Text = "Urgente?";
            chkUrgente.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(203, 446);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(168, 54);
            txtPrecio.TabIndex = 3;
            //txtPrecio.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(73, 25);
            label1.Name = "label1";
            label1.Size = new Size(81, 35);
            label1.TabIndex = 4;
            label1.Text = "Texto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(93, 446);
            label2.Name = "label2";
            label2.Size = new Size(88, 35);
            label2.TabIndex = 5;
            label2.Text = "Coste:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrecio);
            Controls.Add(chkUrgente);
            Controls.Add(Calcular);
            Controls.Add(txtTelegrama);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTelegrama;
        private Button Calcular;
        private CheckBox chkUrgente;
        private TextBox txtPrecio;
        private Label label1;
        private Label label2;
        private readonly EventHandler textBox2_TextChanged;
    }
}
