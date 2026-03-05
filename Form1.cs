namespace PruebaWinForms
{
    public partial class Form1 : Form
    {
        public int Count { get; set; }
        public Form1()
        {
            InitializeComponent();
            Count = 0;
            InicializarBoton();
        }
        private void InicializarBoton()
        {
            Button btnMostrarEtiquta = new Button();
            btnMostrarEtiquta.Text = "Mostrar";
            btnMostrarEtiquta.Size = new Size(500, 250);
            btnMostrarEtiquta.Location = new Point(50, 150);
            btnMostrarEtiquta.Click += Mostrar_Etiqueta;
            btnMostrarEtiquta.Click += btnContar_Click;
            this.Controls.Add(btnMostrarEtiquta);

        }
        private void Mostrar_Etiqueta(object sender, EventArgs e)
        {
            Label lblEtiqueta = new Label();
            lblEtiqueta.ForeColor = Color.Red;
            lblEtiqueta.Text = "Soy una etiqueta";
            lblEtiqueta.Size = new Size(100, 50);
            lblEtiqueta.Location = new Point(400, 50);
            this.Controls.Add(lblEtiqueta);
        }
        private void btnContar_Click(object sender, EventArgs e)
        {
            Count++;
            btnContar.Text = Count.ToString();
        }
    }
}
