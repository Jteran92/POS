namespace POS
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
            components = new System.ComponentModel.Container();
            Hora = new System.Windows.Forms.Timer(components);
            dataGridProductos = new DataGridView();
            HoraFecha = new Label();
            LogoImagen = new PictureBox();
            AutorLabel = new Label();
            textBoxBuscar = new TextBox();
            labelTotal = new Label();
            labelNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoImagen).BeginInit();
            SuspendLayout();
            // 
            // dataGridProductos
            // 
            dataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProductos.Location = new Point(115, 92);
            dataGridProductos.Name = "dataGridProductos";
            dataGridProductos.RowHeadersVisible = false;
            dataGridProductos.RowTemplate.Height = 25;
            dataGridProductos.Size = new Size(240, 150);
            dataGridProductos.TabIndex = 0;
            // 
            // HoraFecha
            // 
            HoraFecha.AutoSize = true;
            HoraFecha.Location = new Point(126, 40);
            HoraFecha.Name = "HoraFecha";
            HoraFecha.Size = new Size(38, 15);
            HoraFecha.TabIndex = 1;
            HoraFecha.Text = "label1";
            // 
            // LogoImagen
            // 
            LogoImagen.Image = Properties.Resources.adobe_Illustrator_logo_5;
            LogoImagen.Location = new Point(612, 33);
            LogoImagen.Name = "LogoImagen";
            LogoImagen.Size = new Size(100, 50);
            LogoImagen.SizeMode = PictureBoxSizeMode.Zoom;
            LogoImagen.TabIndex = 2;
            LogoImagen.TabStop = false;
            // 
            // AutorLabel
            // 
            AutorLabel.AutoSize = true;
            AutorLabel.Location = new Point(642, 355);
            AutorLabel.Name = "AutorLabel";
            AutorLabel.Size = new Size(133, 15);
            AutorLabel.TabIndex = 3;
            AutorLabel.Text = "Creado por : Jesus Teran";
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(113, 382);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(100, 23);
            textBoxBuscar.TabIndex = 0;
            textBoxBuscar.KeyPress += textBoxBuscar_KeyPress;
            textBoxBuscar.PreviewKeyDown += textBoxBuscar_PreviewKeyDown;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(623, 302);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(56, 15);
            labelTotal.TabIndex = 4;
            labelTotal.Text = "Total $0.0";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(200, 323);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(87, 15);
            labelNombre.TabIndex = 5;
            labelNombre.Text = "Punto de venta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(labelNombre);
            Controls.Add(labelTotal);
            Controls.Add(textBoxBuscar);
            Controls.Add(AutorLabel);
            Controls.Add(LogoImagen);
            Controls.Add(HoraFecha);
            Controls.Add(dataGridProductos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer Hora;
        private DataGridView dataGridProductos;
        private Label HoraFecha;
        private PictureBox LogoImagen;
        private Label AutorLabel;
        private TextBox textBoxBuscar;
        private Label labelTotal;
        private Label labelNombre;
    }
}