namespace WinFormsVarias
{
    partial class Form2
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
            textBoxNameForma2 = new TextBox();
            BotonRegresar = new Button();
            textBoxNumero = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 41);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "FORMA 2";
            // 
            // textBoxNameForma2
            // 
            textBoxNameForma2.Enabled = false;
            textBoxNameForma2.Location = new Point(201, 101);
            textBoxNameForma2.Name = "textBoxNameForma2";
            textBoxNameForma2.Size = new Size(254, 27);
            textBoxNameForma2.TabIndex = 1;
            // 
            // BotonRegresar
            // 
            BotonRegresar.Location = new Point(277, 206);
            BotonRegresar.Name = "BotonRegresar";
            BotonRegresar.Size = new Size(94, 29);
            BotonRegresar.TabIndex = 2;
            BotonRegresar.Text = "Regresar";
            BotonRegresar.UseVisualStyleBackColor = true;
            BotonRegresar.Click += BotonRegresar_Click;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Enabled = false;
            textBoxNumero.Location = new Point(201, 134);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(125, 27);
            textBoxNumero.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(491, 50);
            label2.Name = "label2";
            label2.Size = new Size(238, 20);
            label2.TabIndex = 6;
            label2.Text = "OSCAR DE JESUS GUILLEN IBARRA";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.HollowKnight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBoxNumero);
            Controls.Add(BotonRegresar);
            Controls.Add(textBoxNameForma2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNameForma2;
        private Button BotonRegresar;
        private TextBox textBoxNumero;
        private Label label2;
    }
}