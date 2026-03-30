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
        this.BackColor = Color.FloralWhite;
        this.Font = new Font("MV Boli", 12, FontStyle.Bold);
        this.Size = new Size(450, 500);

        //Etiqueta Figura
        lblFigura = new Label();
        lblFigura.Text = "Figura";
        lblFigura.Location = new Point(30, 10);
        lblFigura.AutoSize = true;
        this.Controls.Add(lblFigura);

        //ComboBox Figuras
        cmbFiguras = new ComboBox();
        cmbFiguras.Items.Add("Cuadrado");
        cmbFiguras.Items.Add("Rectángulo");
        cmbFiguras.Items.Add("Triángulo");
        cmbFiguras.Items.Add("Rombo");
        cmbFiguras.Size = new Size(170, 30);
        cmbFiguras.Location = new Point(30, 50);
        this.Controls.Add(cmbFiguras);

        //Etiqueta Cálculo
        lblCalculo = new Label();
        lblCalculo.Text = "Cálculo";
        lblCalculo.Location = new Point(240, 10);
        lblCalculo.AutoSize = true;
        this.Controls.Add(lblCalculo);

        //ComboBox Cálculo
        cmbCalculos = new ComboBox();
        cmbCalculos.Items.Add("Área");
        cmbCalculos.Items.Add("Perímetro");
        cmbCalculos.Size = new Size(160, 30);
        cmbCalculos.Location = new Point(220, 50);
        this.Controls.Add(cmbCalculos);

        //Botón Calcular    
        btnCalcular = new Button();
        btnCalcular.Text = "Calcular";
        btnCalcular.AutoSize = true;
        btnCalcular.Location = new Point(140, 270);
        this.Controls.Add(btnCalcular);

        //Label Resultado
        lblResultado = new Label();
        lblResultado.Text = "Resultado: ";
        lblResultado.AutoSize = true;
        lblResultado.Location = new Point(25, 340);
        this.Controls.Add(lblResultado);


        //TextBox Resultado
        //txtResultado.Font = new Font("MV Boli", 12, FontStyle.Regular);
        txtResultado = new TextBox();
        txtResultado.Size = new Size(185, 25);
        txtResultado.Location = new Point(160, 335);
        this.Controls.Add(txtResultado);

        //Asignar eventos a los ComboBox
        cmbFiguras.SelectedIndexChanged += new EventHandler(cmb_SelectedIndexChanged);
        cmbCalculos.SelectedIndexChanged += new EventHandler(cmb_SelectedIndexChanged);

        //Valores de Campos Genéricos
        //Campos
        lblCampo1 = new Label();
        lblCampo2 = new Label();
        lblCampo3 = new Label();

        lblCampo1.Text = "";
        lblCampo2.Text = "";
        lblCampo3.Text = "";

        lblCampo1.AutoSize = true;
        lblCampo2.AutoSize = true;
        lblCampo3.AutoSize = true;

        lblCampo1.Location = new Point(25, 110);
        lblCampo2.Location = new Point(25, 160);
        lblCampo3.Location = new Point(25, 210);

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
        txtCampo1.Location = new Point(220, 105);
        txtCampo2.Location = new Point(220, 155);
        txtCampo3.Location = new Point(220, 205);

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
        //Limpiar campos y resultado al cambiar selección
        txtCampo1.Text = "";
        txtCampo2.Text = "";
        txtCampo3.Text = "";

        if (this.cmbCalculos.SelectedIndex != -1 && this.cmbFiguras.SelectedIndex != -1)
        {
            switch (this.cmbFiguras.SelectedItem)
            {
                case "Cuadrado":
                    //Para que el fondo se vea azulito al seleccionar el cuadrado
                    this.BackColor = Color.LightBlue;
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
                    else
                    {
                        lblCampo1.Text = "Lado";
                        lblCampo1.Visible = true;
                        txtCampo1.Visible = true;

                    }
                    break;
                case "Triángulo":
                    //Para que el fondo se vea verdoso al seleccionar el triángulo
                    this.BackColor = Color.LightGreen;
                    if (this.cmbCalculos.SelectedItem == "Perímetro")
                    {
                        lblCampo1.Text = "Lado 1:";
                        lblCampo1.Visible = true;
                        txtCampo1.Visible = true;
                        lblCampo2.Text = "Lado 2:";
                        lblCampo2.Visible = true;
                        txtCampo2.Visible = true;
                        lblCampo3.Text = "Lado 3:";
                        lblCampo3.Visible = true;
                        txtCampo3.Visible = true;

                    }
                    else
                    {
                        lblCampo1.Text = "Altura";
                        lblCampo1.Visible = true;
                        lblCampo2.Text = "Base";
                        lblCampo2.Visible = true;
                        txtCampo1.Visible = true;
                        txtCampo2.Visible = true;
                        lblCampo3.Visible = false;
                        txtCampo3.Visible = false;

                    }

                    break;
                case "Rectángulo":
                    //Para que el fondo se vea rosadito al seleccionar el rectángulo
                    this.BackColor = Color.LightCoral;
                    if (this.cmbCalculos.SelectedItem == "Perímetro")
                    {
                        lblCampo1.Text = "Lado 1:";
                        lblCampo2.Text = "Lado 2";
                        lblCampo1.Visible = true;
                        txtCampo1.Visible = true;
                        lblCampo2.Visible = true;
                        txtCampo2.Visible = true;
                        lblCampo3.Visible = false;
                        txtCampo3.Visible = false;
                    }
                    else
                    {
                        lblCampo1.Text = "Base: ";
                        lblCampo2.Text = "Altura: ";
                        lblCampo1.Visible = true;
                        lblCampo2.Visible = true;
                        txtCampo1.Visible = true;
                        txtCampo2.Visible = true;
                        lblCampo3.Visible = false;
                        txtCampo3.Visible = false;
                    }
                    break;

                case "Rombo":
                    this.BackColor = Color.LightYellow;
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
                    else
                    {
                        lblCampo1.Text = "Diagonal Mayor";
                        lblCampo2.Text = "Diagonal Menor";
                        lblCampo1.Visible = true;
                        txtCampo1.Visible = true;
                        lblCampo2.Visible = true;
                        txtCampo2.Visible = true;
                        lblCampo3.Visible = false;
                        txtCampo3.Visible = false;
                    }
                    break;
            }

        }

    }
    private void btnCalcular_Click(object sender, EventArgs e)
    {
        try
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
                        else
                        {
                            double lado = double.Parse(txtCampo1.Text);
                            double resultado = lado * lado;
                            txtResultado.Text = resultado.ToString();

                        }

                        break;
                    case "Triángulo":
                        if (this.cmbCalculos.SelectedItem == "Perímetro")
                        {
                            double lado1 = double.Parse(txtCampo1.Text);
                            double lado2 = double.Parse(txtCampo2.Text);
                            double lado3 = double.Parse(txtCampo3.Text);
                            double perimetro = lado1 + lado2 + lado3;
                            txtResultado.Text = perimetro.ToString();
                        }
                        else
                        {
                            double altura = double.Parse(txtCampo1.Text);
                            double baseTriangulo = double.Parse(txtCampo2.Text);
                            double resultado = (baseTriangulo * altura) / 2;
                            txtResultado.Text = resultado.ToString();
                        }
                        break;

                    case "Rectángulo":
                        if (this.cmbCalculos.SelectedItem == "Perímetro")
                        {
                            double lado1 = double.Parse(txtCampo1.Text);
                            double lado2 = double.Parse(txtCampo2.Text);
                            double perimetro = 2 * (lado1 + lado2);
                            txtResultado.Text = perimetro.ToString();
                        }
                        else
                        {
                            double lado1 = double.Parse(txtCampo1.Text);
                            double lado2 = double.Parse(txtCampo2.Text);
                            double resultado = lado1 * lado2;
                            txtResultado.Text = resultado.ToString();
                        }
                        break;

                    case "Rombo":
                        if (this.cmbCalculos.SelectedItem == "Perímetro")
                        {
                            double lado = double.Parse(txtCampo1.Text);
                            double perimetro = 4 * lado;
                            txtResultado.Text = perimetro.ToString();
                        }
                        else
                        {
                            double diagonalMayor = double.Parse(txtCampo1.Text);
                            double diagonalMenor = double.Parse(txtCampo2.Text);
                            double resultado = (diagonalMayor * diagonalMenor) / 2;
                            txtResultado.Text = resultado.ToString();
                        }
                        break;
                }
            }
        } catch (Exception ex) {
            MessageBox.Show("¡Cuidado! Asegúrate de ingresar valores numéricos válidos. Detalles del error: " + ex.Message, "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
}
