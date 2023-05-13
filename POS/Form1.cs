namespace POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HoraFecha.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            HoraFecha.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
            LogoImagen.Width = this.Width;
            LogoImagen.Location = new Point(Top, Top);
            labelNombre.Location = new Point();
            HoraFecha.Location = new Point(Left, (this.Height - HoraFecha.Height));
            AutorLabel.Location = new Point((this.Width - AutorLabel.Width), (this.Height - AutorLabel.Height));
            dataGridProductos.Location = new Point((10), (LogoImagen.Height));
            dataGridProductos.Width = this.Width - 20;
            dataGridProductos.Height = (this.Height / 8) * 5;
            dataGridProductos.Columns.Add("Cantidad", "Cantidad");
            dataGridProductos.Columns[0].HeaderCell.Style.Font = new Font("Arial", 20F);
            dataGridProductos.Columns[0].Width = ((dataGridProductos.Width) / 100) * 10;
            dataGridProductos.Columns.Add("Nombre", "Nombre");
            dataGridProductos.Columns[1].HeaderCell.Style.Font = new Font("Arial", 20F);
            dataGridProductos.Columns[1].Width = ((dataGridProductos.Width) / 2);
            dataGridProductos.Columns.Add("Precio", "Precio");
            dataGridProductos.Columns[2].HeaderCell.Style.Font = new Font("Arial", 20F);
            dataGridProductos.Columns[2].Width = ((dataGridProductos.Width) / 100) * 20;
            dataGridProductos.Columns.Add("Total", "Total");
            dataGridProductos.Columns[3].HeaderCell.Style.Font = new Font("Arial", 20F);
            dataGridProductos.Columns[3].Width = ((dataGridProductos.Width) / 100) * 20;
            dataGridProductos.ReadOnly = true;
            dataGridProductos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            textBoxBuscar.Location = new Point((10), this.Height - HoraFecha.Height - textBoxBuscar.Height);
            textBoxBuscar.Width = this.Width - 20;
            textBoxBuscar.TabIndex = 0;
            textBoxBuscar.AcceptsTab = true;
            labelTotal.Location = new Point((this.Width / 4) * 3, (this.Height / 8) * 7);
            labelTotal.Font = new Font("Arial", 20F);

        }

        private void textBoxBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                MessageBox.Show(textBoxBuscar.Text);
            }
        }

        private void textBoxBuscar_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true;
            }
        }
    }
}
