
namespace QR
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
            this.components = new System.ComponentModel.Container();
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TextQR = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.PanelQR = new System.Windows.Forms.Panel();
            this.LeerQR = new System.Windows.Forms.Button();
            this.BoxTraduccion = new System.Windows.Forms.TextBox();
            this.SubirImagen = new System.Windows.Forms.Button();
            this.ImagenCarga = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.Location = new System.Drawing.Point(90, 417);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(223, 41);
            this.ButtonGenerate.TabIndex = 0;
            this.ButtonGenerate.Text = "Generar";
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TextQR
            // 
            this.TextQR.Location = new System.Drawing.Point(49, 350);
            this.TextQR.Multiline = true;
            this.TextQR.Name = "TextQR";
            this.TextQR.Size = new System.Drawing.Size(324, 48);
            this.TextQR.TabIndex = 3;
            // 
            // PanelQR
            // 
            this.PanelQR.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelQR.Location = new System.Drawing.Point(49, 28);
            this.PanelQR.Name = "PanelQR";
            this.PanelQR.Size = new System.Drawing.Size(324, 295);
            this.PanelQR.TabIndex = 4;
            // 
            // LeerQR
            // 
            this.LeerQR.Location = new System.Drawing.Point(634, 357);
            this.LeerQR.Name = "LeerQR";
            this.LeerQR.Size = new System.Drawing.Size(223, 41);
            this.LeerQR.TabIndex = 6;
            this.LeerQR.Text = "Traducir";
            this.LeerQR.UseVisualStyleBackColor = true;
            this.LeerQR.Click += new System.EventHandler(this.LeerQR_Click);
            // 
            // BoxTraduccion
            // 
            this.BoxTraduccion.Location = new System.Drawing.Point(580, 417);
            this.BoxTraduccion.Multiline = true;
            this.BoxTraduccion.Name = "BoxTraduccion";
            this.BoxTraduccion.Size = new System.Drawing.Size(324, 123);
            this.BoxTraduccion.TabIndex = 7;
            // 
            // SubirImagen
            // 
            this.SubirImagen.Location = new System.Drawing.Point(910, 28);
            this.SubirImagen.Name = "SubirImagen";
            this.SubirImagen.Size = new System.Drawing.Size(63, 56);
            this.SubirImagen.TabIndex = 8;
            this.SubirImagen.Text = "Cargar";
            this.SubirImagen.UseVisualStyleBackColor = true;
            this.SubirImagen.Click += new System.EventHandler(this.SubirImagen_Click);
            // 
            // ImagenCarga
            // 
            this.ImagenCarga.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ImagenCarga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImagenCarga.Location = new System.Drawing.Point(580, 28);
            this.ImagenCarga.Name = "ImagenCarga";
            this.ImagenCarga.Size = new System.Drawing.Size(324, 295);
            this.ImagenCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenCarga.TabIndex = 9;
            this.ImagenCarga.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 572);
            this.Controls.Add(this.ImagenCarga);
            this.Controls.Add(this.SubirImagen);
            this.Controls.Add(this.BoxTraduccion);
            this.Controls.Add(this.LeerQR);
            this.Controls.Add(this.PanelQR);
            this.Controls.Add(this.TextQR);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ButtonGenerate);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "QRGenerate";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenCarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TextQR;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel PanelQR;
        private System.Windows.Forms.Button LeerQR;
        private System.Windows.Forms.TextBox BoxTraduccion;
        private System.Windows.Forms.Button SubirImagen;
        private System.Windows.Forms.PictureBox ImagenCarga;
    }
}

