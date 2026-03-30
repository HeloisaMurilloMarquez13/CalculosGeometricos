namespace CalculosGeometricos;

public partial class Form1 : Form
{
    ComboBox cmbFiguras;
    ComboBox cmbCalculos;
    TextBox txtResultado;
    Label lblFigura;
    Label lblCalculo;
    Label lblCampo1;
    Label lblCampo2;
    Label lblCampo3;
    Label lblResultado;
    Button btnCalcular;
    TextBox txtCampo1;
    TextBox txtCampo2;
    TextBox txtCampo3;

    public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
    }
    public void InicializarComponentes()
    {
        this.Size = new Size(300, 310);

        //Etiqueta Figura
        lblFigura = new Label();
        lblFigura.Text = "Figura";
        lblFigura.Location = new Point(13, 13);
        lblFigura.Size = new Size(60, 20);
        this.Controls.Add(lblFigura);

        //ComboBox Figuras
        cmbFiguras = new ComboBox();
        cmbFiguras.Items.Add("Cuadrado");
        cmbFiguras.Items.Add("Rectángulo");
        cmbFiguras.Items.Add("Triángulo");
        cmbFiguras.Items.Add("Rombo");
        cmbFiguras.Size = new Size(120, 20);
        cmbFiguras.Location = new Point(13, 30);
        this.Controls.Add(cmbFiguras);

        //Etiqueta Cálculo
        lblCalculo = new Label();
        lblCalculo.Text = "Cálculo";
        lblCalculo.Location = new Point(151, 15);
        lblCalculo.Size = new Size(60, 20);
        this.Controls.Add(lblCalculo);

        //ComboBox Cálculo
        cmbCalculos = new ComboBox();
        cmbCalculos.Items.Add("Área");
        cmbCalculos.Items.Add("Perímetro");
        cmbCalculos.Size = new Size(120, 20);
        cmbCalculos.Location = new Point(151, 30);
        this.Controls.Add(cmbCalculos);

        //Botón Calcular    
        btnCalcular = new Button();
        btnCalcular.Text = "Calcular";
        btnCalcular.AutoSize = true;
        btnCalcular.Location = new Point(151, 200);
        this.Controls.Add(btnCalcular);

        //Label Resultado
        lblResultado = new Label();
        lblResultado.Text = "Resultado: ";
        lblResultado.AutoSize = true;
        lblResultado.Location = new Point(15, 240);
        this.Controls.Add(lblResultado);


        //TextBox Resultado
        txtResultado = new TextBox();
        txtResultado.Size = new Size(200, 30);
        txtResultado.Location = new Point(80, 240);
        this.Controls.Add(txtResultado);

        //Asignar eventos a los ComboBox
        cmbFiguras.SelectedIndexChanged += new EventHandler(cmb_SelectedIndexChanged);
        cmbCalculos.SelectedIndexChanged += new EventHandler(cmb_SelectedIndexChanged);

        //Valores de Campos Genéricos
        //Campos
        lblCampo1 = new Label();
        lblCampo2 = new Label();
        lblCampo3 = new Label();

        lblCampo1.Text = "1";
        lblCampo2.Text = "2";
        lblCampo3.Text = "2";

        lblCampo1.AutoSize = true;
        lblCampo2.AutoSize = true;
        lblCampo3.AutoSize = true;

        lblCampo1.Location = new Point(15, 60);
        lblCampo2.Location = new Point(15, 90);
        lblCampo3.Location = new Point(15, 120);

        lblCampo1.Visible = false;
        lblCampo2.Visible = false;
        lblCampo3.Visible = false;

        this.Controls.Add(lblCampo1);
        this.Controls.Add(lblCampo2);
        this.Controls.Add(lblCampo3);

        //Text
        txtCampo1 = new TextBox();
        txtCampo2 = new TextBox();
        txtCampo3 = new TextBox();
        txtCampo1.Size = new Size(80, 20);
        txtCampo2.Size = new Size(80, 20);
        txtCampo3.Size = new Size(80, 20);
        txtCampo1.Location = new Point(80, 60);
        txtCampo2.Location = new Point(80, 90);
        txtCampo3.Location = new Point(80, 120);

        txtCampo1.Visible = false;
        txtCampo2.Visible = false;
        txtCampo3.Visible = false;

        this.Controls.Add(txtCampo1);
        this.Controls.Add(txtCampo2);
        this.Controls.Add(txtCampo3);

        //Evento Click al boton
        btnCalcular.Click += new EventHandler(btnCalcular_Click);

    }

    private void cmb_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(this.cmbCalculos.SelectedIndex != -1 && this.cmbFiguras.SelectedIndex != -1)
        {
            switch (this.cmbFiguras.SelectedItem)
            {
                case "Cuadrado":
                    if (this.cmbCalculos.SelectedItem == "Perímetro")
                    { 
                        lblCampo1.Text = "Lado";
                        lblCampo1.Visible = true;
                        txtCampo1.Visible = true;
                        lblCampo2.Visible = false;
                        txtCampo2.Visible = false;
                        lblCampo3.Visible = false;
                        txtCampo3.Visible = false;

                    }
                    break;
                case "Triángulo":
                    if (this.cmbCalculos.SelectedItem == "Perímetro")
                    {
                        lblCampo1.Text = "Lado";
                        lblCampo1.Visible = true;
                        txtCampo1.Visible = true;
                        lblCampo2.Visible = false;
                        txtCampo2.Visible = false;
                        lblCampo3.Visible = false;
                        txtCampo3.Visible = false;

                    }

                    break;
               
            }
            
        }

    }
    private void btnCalcular_Click(object sender, EventArgs e)
    {
        if (this.cmbCalculos.SelectedIndex != -1 && this.cmbFiguras.SelectedIndex != -1)
        {
            switch (this.cmbFiguras.SelectedItem)
            {
                case "Cuadrado":
                    if (this.cmbCalculos.SelectedItem == "Perímetro")
                    {
                        double lado = double.Parse(txtCampo1.Text);
                        double perimetro = 4 * lado;
                        txtResultado.Text = perimetro.ToString();
                    }
                    break;
                case "Triángulo":
                    if (this.cmbCalculos.SelectedItem == "Perímetro")
                    {
                        double lado = double.Parse(txtCampo1.Text);
                        double perimetro = 3 * lado;
                        txtResultado.Text = perimetro.ToString();
                    }
                    break;
            }
        }
    }
}
