namespace CalculosGeometricos;
//Ejercicio Windows Forms Calculos Geométricos: Área y Perímetro
//Nombre: Heloisa del Carmen Murillo Márquez
//Semestre: 4to Semestre
//Grupo: 4A
//Fecha: 1° Abril de 2026
//Descripción: Este programa permite al usuario seleccionar una figura geométrica (cuadrado, triángulo, rectángulo
//,rombo, círculo, trapecio, pentágono, hexágono o paralelogramo) y un cálculo (área o perímetro).

public partial class Form1 : Form
{
    //Declaración
    ComboBox cmbFiguras;
    ComboBox cmbCalculos;
    TextBox txtResultado, txtCampo1, txtCampo2, txtCampo3, txtCampo4;
    Label lblFigura, lblCalculo, lblCampo1, lblCampo2, lblCampo3, lblCampo4, lblResultado;
    Button btnCalcular;

    public Form1()
    {
        InicializarComponentes();
    }
    public void InicializarComponentes()
    {
        this.BackColor = Color.FloralWhite;
        this.Font = new Font("Ink Free", 12, FontStyle.Bold);
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
        cmbFiguras.Items.Add("Círculo");
        cmbFiguras.Items.Add("Trapecio");
        cmbFiguras.Items.Add("Pentágono");
        cmbFiguras.Items.Add("Hexágono");
        cmbFiguras.Items.Add("Paralelogramo");
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
        lblCampo4 = new Label();

        lblCampo1.Text = "";
        lblCampo2.Text = "";
        lblCampo3.Text = "";
        lblCampo4.Text = "";

        lblCampo1.AutoSize = true;
        lblCampo2.AutoSize = true;
        lblCampo3.AutoSize = true;
        lblCampo4.AutoSize = true;

        lblCampo1.Location = new Point(25, 110);
        lblCampo2.Location = new Point(25, 160);
        lblCampo3.Location = new Point(25, 210);
        lblCampo4.Location = new Point(25, 260);

        lblCampo1.Visible = false;
        lblCampo2.Visible = false;
        lblCampo3.Visible = false;
        lblCampo4.Visible = false;

        this.Controls.Add(lblCampo1);
        this.Controls.Add(lblCampo2);
        this.Controls.Add(lblCampo3);
        this.Controls.Add(lblCampo4);

        //Text
        txtCampo1 = new TextBox();
        txtCampo2 = new TextBox();
        txtCampo3 = new TextBox();
        txtCampo4 = new TextBox();
        txtCampo1.Size = new Size(80, 20);
        txtCampo2.Size = new Size(80, 20);
        txtCampo3.Size = new Size(80, 20);
        txtCampo4.Size = new Size(80, 20);
        txtCampo1.Location = new Point(220, 105);
        txtCampo2.Location = new Point(220, 155);
        txtCampo3.Location = new Point(220, 205);
        txtCampo4.Location = new Point(220, 255);

        txtCampo1.Visible = false;
        txtCampo2.Visible = false;
        txtCampo3.Visible = false;
        txtCampo4.Visible = false;

        this.Controls.Add(txtCampo1);
        this.Controls.Add(txtCampo2);
        this.Controls.Add(txtCampo3);
        this.Controls.Add(txtCampo4);

        //Evento Click al boton
        btnCalcular.Click += new EventHandler(btnCalcular_Click);

    }

    //Evento para mostrar campos según la figura y el cálculo seleccionado
    private void cmb_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Limpiar campos y resultado al cambiar selección
        txtCampo1.Text = "";
        txtCampo2.Text = "";
        txtCampo3.Text = "";
        txtCampo4.Text = "";
        txtResultado.Text = "";

        lblCampo1.Visible = false;
        lblCampo2.Visible = false;
        lblCampo3.Visible = false;
        lblCampo4.Visible = false;
        txtCampo1.Visible = false;
        txtCampo2.Visible = false;
        txtCampo3.Visible = false;
        txtCampo4.Visible = false;

        //Verificar que se haya seleccionado una figura y un cálculo antes de mostrar campos
        if (this.cmbCalculos.SelectedIndex != -1 && this.cmbFiguras.SelectedIndex != -1)
        {
            //Mostrar campos según la figura y el cálculo seleccionado
            switch (this.cmbFiguras.SelectedItem)
            {
              
                case "Cuadrado":
                    //Para que el fondo se vea azulito al seleccionar el cuadrado
                    this.BackColor = Color.LightBlue;
                    lblCampo1.Text = "Lado";
                    lblCampo1.Visible = true;
                    txtCampo1.Visible = true;
                    break;

                case "Triángulo":
                    //Para que el fondo se vea verdoso al seleccionar el triángulo
                    this.BackColor = Color.LightGreen;
                    if (this.cmbCalculos.SelectedItem == "Perímetro")
                    {
                        lblCampo1.Text = "Lado 1:";
                        lblCampo2.Text = "Lado 2:";
                        lblCampo3.Text = "Lado 3:";
                        lblCampo1.Visible = true;
                        lblCampo2.Visible = true;
                        lblCampo3.Visible = true;
                        txtCampo1.Visible = true;
                        txtCampo2.Visible = true;
                        txtCampo3.Visible = true;
                    }
                    else
                    {
                        lblCampo1.Text = "Altura: ";
                        lblCampo2.Text = "Base: ";
                        lblCampo1.Visible = true;
                        lblCampo2.Visible = true;
                        txtCampo1.Visible = true;
                        txtCampo2.Visible = true;
                    }
                    break;

                case "Rectángulo":
                    //Para que el fondo se vea rosadito al seleccionar el rectángulo
                    this.BackColor = Color.LightCoral;
                    lblCampo1.Text = this.cmbCalculos.SelectedItem == "Perímetro" ? "Lado 1:" : "Base: ";
                    lblCampo2.Text = this.cmbCalculos.SelectedItem == "Perímetro" ? "Lado 2:" : "Altura: ";
                    lblCampo1.Visible = true;
                    lblCampo2.Visible = true;
                    txtCampo1.Visible = true;
                    txtCampo2.Visible = true;
                    break;

                case "Rombo":
                    //Para que el fondo se vea amarillito al seleccionar el rombo
                    this.BackColor = Color.LightYellow;
                    if (this.cmbCalculos.SelectedItem == "Perímetro")
                    {
                        lblCampo1.Text = "Lado:";
                        lblCampo1.Visible = true;
                        txtCampo1.Visible = true;
                    }
                    else
                    {
                        lblCampo1.Text = "Diagonal Mayor";
                        lblCampo2.Text = "Diagonal Menor";
                        lblCampo1.Visible = true;
                        lblCampo2.Visible = true;
                        txtCampo1.Visible = true;
                        txtCampo2.Visible = true;
                    }
                    break;

                case "Círculo":
                    //Para que el fondo se vea rosadito al seleccionar el círculo
                    this.BackColor = Color.LightPink;
                    lblCampo1.Text = "Radio:";
                    lblCampo1.Visible = true;
                    txtCampo1.Visible = true;
                    break;

                case "Trapecio":
                    //Para que el fondo se vea azulito al seleccionar el trapecio
                    this.BackColor = Color.LightSkyBlue;
                    if (this.cmbCalculos.SelectedItem == "Perímetro")
                    {
                        lblCampo1.Text = "Lado 1:";
                        lblCampo2.Text = "Lado 2:";
                        lblCampo3.Text = "Lado 3:";
                        lblCampo4.Text = "Lado 4:";
                        lblCampo1.Visible = true;
                        lblCampo2.Visible = true;
                        lblCampo3.Visible = true;
                        lblCampo4.Visible = true;
                        txtCampo1.Visible = true;
                        txtCampo2.Visible = true;
                        txtCampo3.Visible = true;
                        txtCampo4.Visible = true;
                    }
                    else
                    {
                        lblCampo1.Text = "Base Mayor:";
                        lblCampo2.Text = "Base Menor:";
                        lblCampo3.Text = "Altura:";
                        lblCampo1.Visible = true;
                        lblCampo2.Visible = true;
                        lblCampo3.Visible = true;
                        txtCampo1.Visible = true;
                        txtCampo2.Visible = true;
                        txtCampo3.Visible = true;
                    }
                    break;

                case "Pentágono":
                    //Para que el fondo se vea anaranjadito al seleccionar el pentágono
                    this.BackColor = Color.LightSalmon;
                    if (this.cmbCalculos.SelectedItem == "Perímetro")
                    {
                        lblCampo1.Text = "Lado:";
                        lblCampo1.Visible = true;
                        txtCampo1.Visible = true;
                    }
                    else
                    {
                        lblCampo1.Text = "Apotema:";
                        lblCampo2.Text = "Lado:";
                        lblCampo1.Visible = true;
                        lblCampo2.Visible = true;
                        txtCampo1.Visible = true;
                        txtCampo2.Visible = true;
                    }
                    break;

                case "Hexágono":
                    //Para que el fondo se vea azulito al seleccionar el hexágono
                    this.BackColor = Color.LightSteelBlue;
                    if (this.cmbCalculos.SelectedItem == "Perímetro")
                    {
                        lblCampo1.Text = "Lado:";
                        lblCampo1.Visible = true;
                        txtCampo1.Visible = true;
                    }
                    else
                    {
                        lblCampo1.Text = "Apotema:";
                        lblCampo2.Text = "Lado:";
                        lblCampo1.Visible = true;
                        lblCampo2.Visible = true;
                        txtCampo1.Visible = true;
                        txtCampo2.Visible = true;
                    }
                    break;
                  
                case "Paralelogramo":
                    //Para que el fondo se vea azulito al seleccionar el paralelogramo
                    this.BackColor = Color.LightCyan;
                    if (this.cmbCalculos.SelectedItem == "Perímetro")
                    {
                        lblCampo1.Text = "Lado 1";
                        lblCampo2.Text = "Lado 2";
                    }
                    else
                    {
                        lblCampo1.Text = "Base:";
                        lblCampo2.Text = "Altura:";
                    }
                    lblCampo1.Visible = true;
                    lblCampo2.Visible = true;
                    txtCampo1.Visible = true;
                    txtCampo2.Visible = true;
                    break;
            }
        }
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
        //Validación de entrada para asegurarse de que se ingresen valores numéricos válidos
        try
        {
            //Verificar que se haya seleccionado una figura y un cálculo antes de intentar calcular
            if (this.cmbCalculos.SelectedIndex != -1 && this.cmbFiguras.SelectedIndex != -1)
            {
                //Realizar cálculos según la figura y el cálculo seleccionado
                switch (this.cmbFiguras.SelectedItem)
                {
                    //Cálculos para el cuadrado
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
                            double area = lado * lado;
                            txtResultado.Text = area.ToString();
                        }
                        break;
                    //Cálculos para el triángulo
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
                            double area = (baseTriangulo * altura) / 2;
                            txtResultado.Text = area.ToString();
                        }
                        break;
                    //Cálculos para el rectángulo
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
                    //Cálculos para el rombo
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
                    //Cálculos para el círculo
                    case "Círculo":
                        if (this.cmbCalculos.SelectedItem == "Perímetro")
                        {
                            double radio = double.Parse(txtCampo1.Text);
                            double perimetro = 2 * Math.PI * radio;
                            txtResultado.Text = perimetro.ToString();
                        }
                        else
                        {
                            double radio = double.Parse(txtCampo1.Text);
                            double area = Math.PI * radio * radio;
                            txtResultado.Text = area.ToString();
                        }
                        break;
                    //Cálculos para el trapecio
                    case "Trapecio":
                        if (this.cmbCalculos.SelectedItem == "Perímetro")
                        {
                            double lado1 = double.Parse(txtCampo1.Text);
                            double lado2 = double.Parse(txtCampo2.Text);
                            double lado3 = double.Parse(txtCampo3.Text);
                            double lado4 = double.Parse(txtCampo4.Text);
                            double perimetro = lado1 + lado2 + lado3 + lado4;
                            txtResultado.Text = perimetro.ToString();
                        }
                        else
                        {
                            double baseMayor = double.Parse(txtCampo1.Text);
                            double baseMenor = double.Parse(txtCampo2.Text);
                            double altura = double.Parse(txtCampo3.Text);
                            double area = ((baseMayor + baseMenor) / 2) * altura;
                            txtResultado.Text = area.ToString();
                        }
                        break;
                    //Cálculos para el pentágono    
                    case "Pentágono":
                        if (this.cmbCalculos.SelectedItem == "Perímetro")
                        {
                            double lado = double.Parse(txtCampo1.Text);
                            double perimetro = 5 * lado;
                            txtResultado.Text = perimetro.ToString();
                        }
                        else
                        {
                            double apotema = double.Parse(txtCampo1.Text);
                            double lado = double.Parse(txtCampo2.Text);
                            double perimetro = 5 * lado;
                            double area = (perimetro * apotema) / 2;
                            txtResultado.Text = area.ToString();
                        }
                        break;
                    //Cálculos para el hexágono
                    case "Hexágono":
                        if (this.cmbCalculos.SelectedItem == "Perímetro")
                        {
                            double lado = double.Parse(txtCampo1.Text);
                            double perimetro = 6 * lado;
                            txtResultado.Text = perimetro.ToString();
                        }
                        else
                        {
                            double apotema = double.Parse(txtCampo1.Text);
                            double lado = double.Parse(txtCampo2.Text);
                            double perimetro = 6 * lado;
                            double area = (perimetro * apotema) / 2;
                            txtResultado.Text = area.ToString();
                        }
                        break;
                    //Cálculos para el paralelogramo
                    case "Paralelogramo":
                        if (this.cmbCalculos.SelectedItem == "Perímetro")
                        {
                            double lado1 = double.Parse(txtCampo1.Text);
                            double lado2 = double.Parse(txtCampo2.Text);
                            double perimetro = 2 * (lado1 + lado2);
                            txtResultado.Text = perimetro.ToString();
                        }
                        else
                        {
                            double baseParalelogramo = double.Parse(txtCampo1.Text);
                            double altura = double.Parse(txtCampo2.Text);
                            double area = baseParalelogramo * altura;
                            txtResultado.Text = area.ToString();
                        }
                        break;
                }
            }
        }
        //Manejo de excepciones para capturar errores de formato al ingresar datos no numéricos
        catch (Exception ex)
        {
            //Mostrar un mensaje de error al usuario indicando que se deben ingresar valores numéricos válidos
            MessageBox.Show("¡Cuidado! Asegúrate de ingresar valores numéricos válidos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}