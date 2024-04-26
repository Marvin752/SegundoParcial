namespace EventosDelegados
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
            ButtonDele = new Button();
            Botontele = new Button();
            Imagenpro = new PictureBox();
            Mostrarlabel = new Label();
            ((System.ComponentModel.ISupportInitialize)Imagenpro).BeginInit();
            SuspendLayout();
            // 
            // ButtonDele
            // 
            ButtonDele.Location = new Point(58, 366);
            ButtonDele.Name = "ButtonDele";
            ButtonDele.Size = new Size(94, 29);
            ButtonDele.TabIndex = 0;
            ButtonDele.Text = "Click Me";
            ButtonDele.UseVisualStyleBackColor = true;
            ButtonDele.Click += ButtonDele_Click;
            ButtonDele.MouseHover += Pasarboton1;
            // 
            // Botontele
            // 
            Botontele.Location = new Point(567, 366);
            Botontele.Name = "Botontele";
            Botontele.Size = new Size(94, 29);
            Botontele.TabIndex = 1;
            Botontele.Text = "Click Me";
            Botontele.UseVisualStyleBackColor = true;
            Botontele.Click += Botontele_Click;
            Botontele.MouseHover += PasarBoton2;
            // 
            // Imagenpro
            // 
            Imagenpro.Location = new Point(31, 25);
            Imagenpro.Name = "Imagenpro";
            Imagenpro.Size = new Size(705, 301);
            Imagenpro.SizeMode = PictureBoxSizeMode.StretchImage;
            Imagenpro.TabIndex = 2;
            Imagenpro.TabStop = false;
            Imagenpro.Click += Imagenpro_Click;
            Imagenpro.MouseLeave += Quitarfoto;
            Imagenpro.MouseHover += Pasarfoto;
            // 
            // Mostrarlabel
            // 
            Mostrarlabel.AutoSize = true;
            Mostrarlabel.Font = new Font("Segoe UI", 12F);
            Mostrarlabel.Location = new Point(328, 367);
            Mostrarlabel.Name = "Mostrarlabel";
            Mostrarlabel.Size = new Size(53, 28);
            Mostrarlabel.TabIndex = 3;
            Mostrarlabel.Text = "Hola";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Mostrarlabel);
            Controls.Add(Imagenpro);
            Controls.Add(Botontele);
            Controls.Add(ButtonDele);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Imagenpro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonDele;
        private Button Botontele;
        private PictureBox Imagenpro;
        private Label Mostrarlabel;
    }
}
