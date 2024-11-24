namespace WinFormsVarias
{
    partial class Form3
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
            label1 = new Label();
            textBoxNumero = new TextBox();
            BotonRegresar = new Button();
            richTextBoxTabla = new RichTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(321, 50);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "FORMULARIO 3";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Enabled = false;
            textBoxNumero.Location = new Point(308, 94);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(125, 27);
            textBoxNumero.TabIndex = 1;
            // 
            // BotonRegresar
            // 
            BotonRegresar.Location = new Point(636, 41);
            BotonRegresar.Name = "BotonRegresar";
            BotonRegresar.Size = new Size(94, 29);
            BotonRegresar.TabIndex = 2;
            BotonRegresar.Text = "Regresar";
            BotonRegresar.UseVisualStyleBackColor = true;
            BotonRegresar.Click += BotonRegresar_Click_1;
            // 
            // richTextBoxTabla
            // 
            richTextBoxTabla.Location = new Point(298, 143);
            richTextBoxTabla.Name = "richTextBoxTabla";
            richTextBoxTabla.Size = new Size(164, 237);
            richTextBoxTabla.TabIndex = 4;
            richTextBoxTabla.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 45);
            label2.Name = "label2";
            label2.Size = new Size(238, 20);
            label2.TabIndex = 5;
            label2.Text = "OSCAR DE JESUS GUILLEN IBARRA";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(richTextBoxTabla);
            Controls.Add(BotonRegresar);
            Controls.Add(textBoxNumero);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNumero;
        private Button BotonRegresar;
        private RichTextBox richTextBoxTabla;
        private Label label2;
    }
}