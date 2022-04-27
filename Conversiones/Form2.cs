namespace Conversiones;

public partial class Form2 : Form
{
    private CheckBox bxOpciones;
    private CheckedListBox chOpciones;

    public Form2()
    {
        bxOpciones=new CheckBox();
        chOpciones=new CheckedListBox();
        InitializeComponent();
        InicalizarComponentes();
    }

    public Form2(String seleccion):this(){  
        chOpciones.Size=new Size(400,400);
    
        if(!seleccion.Contains("USD- Dolar estadounidense")){
            chOpciones.Items.Add("USD- Dolar estadounidense");

        }      

        if(!seleccion.Contains("MXN - Peso mexicano")){
            chOpciones.Items.Add("MXN - Peso mexicano");

        } 

        if(!seleccion.Contains("CAD- Dolar canadiense")){
            chOpciones.Items.Add("CAD- Dolar canadiense");

        } 

        if(!seleccion.Contains("EUR- Euro")){
            chOpciones.Items.Add("EUR- Euro");

        } 

        if(!seleccion.Contains("JPY- Yen Japones")){
            chOpciones.Items.Add("JPY- Yen Japones");

        } 

        this.Controls.Add(chOpciones);
    
    }

    public void InicalizarComponentes()
    {
        this.Size=new Size(400,400);
    }

    public string getChecked(){
        string caja="";
        for(int x = 0; x < chOpciones.CheckedItems.Count ; x++) {
             caja = caja + chOpciones.CheckedItems[x].ToString() + ","; 
        } 
        return caja;
    }


}
