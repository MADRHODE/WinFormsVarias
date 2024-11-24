namespace WinFormsVarias
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
            label1 = new Label();
            BotonFormulario2 = new Button();
            BotonFormulario3 = new Button();
            textBoxNombre = new TextBox();
            BotonSalir = new Button();
            textBoxNumero = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 29);
            label1.Name = "label1";
            label1.Size = new Size(178, 20);
            label1.TabIndex = 0;
            label1.Text = "PANEL DE FORMULARIOS";
            // 
            // BotonFormulario2
            // 
            BotonFormulario2.Location = new Point(57, 78);
            BotonFormulario2.Name = "BotonFormulario2";
            BotonFormulario2.Size = new Size(141, 59);
            BotonFormulario2.TabIndex = 1;
            BotonFormulario2.Text = "Formulario 2";
            BotonFormulario2.UseVisualStyleBackColor = true;
            BotonFormulario2.Click += BotonFormulario2_Click;
            // 
            // BotonFormulario3
            // 
            BotonFormulario3.Location = new Point(484, 78);
            BotonFormulario3.Name = "BotonFormulario3";
            BotonFormulario3.Size = new Size(128, 59);
            BotonFormulario3.TabIndex = 2;
            BotonFormulario3.Text = "Formulario 3";
            BotonFormulario3.UseVisualStyleBackColor = true;
            BotonFormulario3.Click += BotonFormulario3_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(29, 157);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Ingresa tu nombre";
            textBoxNombre.Size = new Size(294, 27);
            textBoxNombre.TabIndex = 3;
            textBoxNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // BotonSalir
            // 
            BotonSalir.Location = new Point(138, 232);
            BotonSalir.Name = "BotonSalir";
            BotonSalir.Size = new Size(158, 72);
            BotonSalir.TabIndex = 4;
            BotonSalir.Text = "Salir";
            BotonSalir.UseVisualStyleBackColor = true;
            BotonSalir.Click += BotonSalir_Click;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(461, 157);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.PlaceholderText = "Ingresa un numero";
            textBoxNumero.Size = new Size(161, 27);
            textBoxNumero.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(411, 216);
            label2.Name = "label2";
            label2.Size = new Size(238, 20);
            label2.TabIndex = 6;
            label2.Text = "OSCAR DE JESUS GUILLEN IBARRA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.HollowKnight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBoxNumero);
            Controls.Add(BotonSalir);
            Controls.Add(textBoxNombre);
            Controls.Add(BotonFormulario3);
            Controls.Add(BotonFormulario2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BotonFormulario2;
        private Button BotonFormulario3;
        private TextBox textBoxNombre;
        private Button BotonSalir;
        private TextBox textBoxNumero;
        private Label label2;
    }
}
