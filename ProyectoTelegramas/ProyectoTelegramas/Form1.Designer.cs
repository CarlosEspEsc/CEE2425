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
            txtPrecio = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Ordinario = new RadioButton();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(29, 50);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(668, 208);
            txtTelegrama.TabIndex = 0;
            // 
            // Calcular
            // 
            Calcular.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Calcular.Location = new Point(491, 285);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(206, 91);
            Calcular.TabIndex = 1;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += btnCalcularPrecio_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(118, 334);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(148, 42);
            txtPrecio.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 4;
            label1.Text = "Texto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(24, 334);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 5;
            label2.Text = "Coste:";
            // 
            // Ordinario
            // 
            Ordinario.AutoSize = true;
            Ordinario.Location = new Point(29, 285);
            Ordinario.Name = "Ordinario";
            Ordinario.Size = new Size(75, 19);
            Ordinario.TabIndex = 6;
            Ordinario.TabStop = true;
            Ordinario.Text = "Ordinario";
            Ordinario.UseVisualStyleBackColor = true;
            Ordinario.CheckedChanged += Ordinario_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(148, 285);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 19);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Urgente";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 409);
            Controls.Add(radioButton2);
            Controls.Add(Ordinario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrecio);
            Controls.Add(Calcular);
            Controls.Add(txtTelegrama);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTelegrama;
        private Button Calcular;
        private TextBox txtPrecio;
        private Label label1;
        private Label label2;
        private readonly EventHandler textBox2_TextChanged;
        private RadioButton Ordinario;
        private RadioButton radioButton2;
    }
}
