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
            txtTelegrama = new RichTextBox();
            txtPrecio = new TextBox();
            label1 = new Label();
            label2 = new Label();
            chkUrgente = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(33, 53);
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(738, 211);
            txtTelegrama.TabIndex = 0;
            txtTelegrama.Text = "";
            txtTelegrama.UseWaitCursor = true;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(139, 342);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 21);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 2;
            label1.Text = "Texto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 333);
            label2.Name = "label2";
            label2.Size = new Size(87, 32);
            label2.TabIndex = 3;
            label2.Text = "Coste:";
            // 
            // chkUrgente
            // 
            chkUrgente.AutoSize = true;
            chkUrgente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkUrgente.Location = new Point(35, 270);
            chkUrgente.Name = "chkUrgente";
            chkUrgente.Size = new Size(85, 25);
            chkUrgente.TabIndex = 4;
            chkUrgente.Text = "Urgente";
            chkUrgente.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(546, 310);
            button1.Name = "button1";
            button1.Size = new Size(225, 80);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(chkUrgente);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrecio);
            Controls.Add(txtTelegrama);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtTelegrama;
        private TextBox txtPrecio;
        private Label label1;
        private Label label2;
        private CheckBox chkUrgente;
        private Button button1;
    }
}
