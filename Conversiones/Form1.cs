namespace Conversiones;

public partial class Form1 : Form
{
    private Label lblMoneda;

    private ComboBox cmMoneda;
    private Label lblMonto;
    private TextBox txtMonto;

    private Label lblConversiones;

    private Button btnCalcular;

    private Label LblAmericano;

    private Label LblMexicano;

    private Label LblCanadiense;

    private Label LblEuro;

    private Label LblJapones;

    private TextBox resultadoAmericano;

    private TextBox resultadoMexicano;

    private TextBox resultadoCanadiense;

    private TextBox resultadoEuro;

    private TextBox resultadoJapones;


    public Form1()
    {
        lblMoneda=new Label();
        cmMoneda=new ComboBox();
        lblMonto=new Label();
        txtMonto=new TextBox();
        lblConversiones=new Label();
        btnCalcular=new Button();
        LblAmericano=new Label();
        LblMexicano=new Label();
        LblCanadiense=new Label();
        LblEuro=new Label();
        LblJapones=new Label();
        resultadoAmericano=new TextBox();
        resultadoMexicano=new TextBox();
        resultadoCanadiense=new TextBox();
        resultadoEuro=new TextBox();
        resultadoJapones=new TextBox();
        InitializeComponent();
        InicializarComponentes();

    }

    public void InicializarComponentes()
    {
        this.Size=new Size(400,600);
        lblMoneda.Text="Moneda";
        lblMonto.Text="Monto";
        lblConversiones.Text="Conversiones";
        lblMoneda.Location=new Point(10,10);
        cmMoneda.Size=new Size(180,20);
        cmMoneda.Items.Add("USD- Dolar estadounidense");
        LblAmericano.Text=("USD- Dolar estadounidense");
        cmMoneda.Items.Add("MXN - Peso mexicano");
        LblMexicano.Text="MXN - Peso mexicano";
        cmMoneda.Items.Add("CAD- Dolar canadiense");
        LblCanadiense.Text="CAD- Dolar canadiense";
        cmMoneda.Items.Add("EUR- Euro");
        LblEuro.Text="EUR- Euro";
        cmMoneda.Items.Add("JPY- Yen Japones");
        LblJapones.Text="JPY- Yen Japones";
        cmMoneda.Location=new Point(10,40);
        lblMonto.Location=new Point(200,10);
        txtMonto.Size=new Size(160,20);
        txtMonto.Location=new Point(200,40);
        lblConversiones.Location=new Point(25,200);
        btnCalcular.Text="Calcular";
        btnCalcular.Size=new Size(160,30);
        btnCalcular.Location=new Point(200,90);
        btnCalcular.Click+=new EventHandler(btnCalcular_Click); 

        this.Controls.Add(lblMoneda);
        this.Controls.Add(cmMoneda);
        this.Controls.Add(lblMonto);
        this.Controls.Add(txtMonto);
        this.Controls.Add(btnCalcular);
        this.Controls.Add(lblConversiones);

    
    }
    private void btnCalcular_Click(object? sender, EventArgs e)
    {
        removerConversiones();
        double monto=0;
        try{
            monto=Double.Parse(txtMonto.Text);

        }catch (Exception)
        {

        }
        
        if (cmMoneda.SelectedItem != null && monto!=0)
        {
            Form2 nuevoFormulario = new Form2(cmMoneda.SelectedItem.ToString());
            nuevoFormulario.ShowDialog();
            string seleccionados = nuevoFormulario.getChecked();
            string[] seleccionadosList = seleccionados.Split(",");
            int xtexto = 25;
            int ytexto = 225;
            int xcaja = 200;
            int ycaja = 225;
            if (seleccionadosList.Contains("USD- Dolar estadounidense"))
            {
                CalcularAmericano(xtexto, ytexto, xcaja, ycaja, cmMoneda.SelectedItem.ToString(), txtMonto.Text);
                ytexto = ytexto + 60;
                ycaja = ycaja + 60;

            }

            if (seleccionadosList.Contains("MXN - Peso mexicano"))
            {
                CalcularMexicano(xtexto, ytexto, xcaja, ycaja,cmMoneda.SelectedItem.ToString(), txtMonto.Text);
                ytexto = ytexto + 60;
                ycaja = ycaja + 60;

            }

            if (seleccionadosList.Contains("CAD- Dolar canadiense"))
            {
                CalcularCanadiense(xtexto, ytexto, xcaja, ycaja,cmMoneda.SelectedItem.ToString(), txtMonto.Text);
                ytexto = ytexto + 60;
                ycaja = ycaja + 60;

            }

            if (seleccionadosList.Contains("EUR- Euro"))
            {
                CalcularEuro(xtexto, ytexto, xcaja, ycaja,cmMoneda.SelectedItem.ToString(), txtMonto.Text);
                ytexto = ytexto + 60;
                ycaja = ycaja + 60;

            }

            if (seleccionadosList.Contains("JPY- Yen Japones"))
            {
                CalcularJapones(xtexto, ytexto, xcaja, ycaja,cmMoneda.SelectedItem.ToString(), txtMonto.Text);
                ytexto = ytexto + 60;
                ycaja = ycaja + 60;

            }



        }
    }

    private void CalcularJapones(int xtexto, int ytexto, int xcaja, int ycaja,string calcular,string monto)
    {
        double cantidad=Double.Parse(monto);
        double resultado=0;
        LblJapones.Location = new Point(xtexto, ytexto);
        resultadoJapones.Location = new Point(xcaja, ycaja);
        this.Controls.Add(LblJapones);
        this.Controls.Add(resultadoJapones);
        if(calcular.Contains("USD- Dolar estadounidense")){
            resultado=cantidad*113.05;

        }
        if(calcular.Contains("MXN - Peso mexicano")){
            resultado=(cantidad/21.23)*113.05;

        }
        if(calcular.Contains("CAD- Dolar canadiense")){
            resultado=(cantidad/1.28)*113.05;

        }
        if(calcular.Contains("EUR- Euro")){
            resultado=(cantidad/.89)*113.05;

        }
        resultadoJapones.Text="¥"+resultado.ToString();
    }

    private void CalcularEuro(int xtexto, int ytexto, int xcaja, int ycaja,string calcular,string monto)
    {
        double cantidad=Double.Parse(monto);
        double resultado=0;
        LblEuro.Location = new Point(xtexto, ytexto);
        resultadoEuro.Location = new Point(xcaja, ycaja);
        this.Controls.Add(LblEuro);
        this.Controls.Add(resultadoEuro);
         if(calcular.Contains("USD- Dolar estadounidense")){
            resultado=cantidad*.89;

        }
        if(calcular.Contains("MXN - Peso mexicano")){
            resultado=(cantidad/21.23)*.89;

        }
        if(calcular.Contains("CAD- Dolar canadiense")){
            resultado=(cantidad/1.28)*.89;

        }
        if(calcular.Contains("JPY- Yen Japones")){
            resultado=(cantidad/113.05)*.89;

        }
        resultadoEuro.Text="€"+resultado.ToString();
    }

    private void CalcularCanadiense(int xtexto, int ytexto, int xcaja, int ycaja,string calcular,string monto)
    {
        double cantidad=Double.Parse(monto);
        double resultado=0;
        LblCanadiense.Location = new Point(xtexto, ytexto);
        resultadoCanadiense.Location = new Point(xcaja, ycaja);
        this.Controls.Add(LblCanadiense);
        this.Controls.Add(resultadoCanadiense);
        if(calcular.Contains("USD- Dolar estadounidense")){
            resultado=cantidad*1.28;

        }
        if(calcular.Contains("MXN - Peso mexicano")){
            resultado=(cantidad/21.23)*1.28;

        }
        if(calcular.Contains("EUR- Euro")){
            resultado=(cantidad/.89)*1.28;

        }
        if(calcular.Contains("JPY- Yen Japones")){
            resultado=(cantidad/113.05)*1.28;

        }
        resultadoCanadiense.Text="$"+resultado.ToString();
    }

    private void CalcularMexicano(int xtexto, int ytexto, int xcaja, int ycaja,string calcular,string monto)
    {
        double cantidad=Double.Parse(monto);
        double resultado=0;
        LblMexicano.Location = new Point(xtexto, ytexto);
        resultadoMexicano.Location = new Point(xcaja, ycaja);
        this.Controls.Add(LblMexicano);
        this.Controls.Add(resultadoMexicano);
        if(calcular.Contains("USD- Dolar estadounidense")){
            resultado=cantidad*21.23;

        }
        if(calcular.Contains("CAD- Dolar canadiense")){
            resultado=(cantidad/1.28)*21.23;

        }
        if(calcular.Contains("EUR- Euro")){
            resultado=(cantidad/.89)*21.23;

        }
        if(calcular.Contains("JPY- Yen Japones")){
            resultado=(cantidad/113.05)*21.23;

        }
        resultadoMexicano.Text="$"+resultado.ToString();
    }

    private void removerConversiones()
    {
        this.Controls.Remove(LblAmericano);
        this.Controls.Remove(resultadoAmericano);
        this.Controls.Remove(LblMexicano);
        this.Controls.Remove(resultadoMexicano);
        this.Controls.Remove(LblCanadiense);
        this.Controls.Remove(resultadoCanadiense);
        this.Controls.Remove(LblEuro);
        this.Controls.Remove(resultadoEuro);
        this.Controls.Remove(LblJapones);
        this.Controls.Remove(resultadoJapones);
    }

    private void CalcularAmericano(int xtexto, int ytexto, int xcaja, int ycaja, string calcular,string monto)
    {
        double cantidad=Double.Parse(monto);
        double resultado=0;
        LblAmericano.Location = new Point(xtexto, ytexto);
        resultadoAmericano.Location = new Point(xcaja, ycaja);
        this.Controls.Add(LblAmericano);
        this.Controls.Add(resultadoAmericano);
        if(calcular.Contains("MXN - Peso mexicano")){
            resultado=cantidad/21.23;

        }
        if(calcular.Contains("CAD- Dolar canadiense")){
            resultado=cantidad/1.28;

        }
        if(calcular.Contains("EUR- Euro")){
            resultado=cantidad/.89;

        }
        if(calcular.Contains("JPY- Yen Japones")){
            resultado=cantidad/113.05;

        }
        resultadoAmericano.Text="$"+resultado.ToString();
    }
}
