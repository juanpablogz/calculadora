using System;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
//
using System.Collections.Generic;


public partial class Calculadora : System.Web.UI.Page
{
    //------------Variables------------

    //Suma
    public static string su;
    public static int suma;

    //Resta
    public static string res;
    public static int restar;

    //Multiplicación
    public static string mul;
    public static int multiplicar;

    //División
    public static string div;
    public static int division;

    //Igual
    public static string igu;
    public static int igual;

    //Total
    public static int total;

    //Raiz Cuadrada
    public static double raiz;

    //Exponenciación
    public static double expo;

    //---------------------------------

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Cero
    protected void btncero_Click(object sender, EventArgs e)
    {
        this.txtresultado.Text += 0;
    }

    //Uno
    protected void btnuno_Click(object sender, EventArgs e)
    {
        this.txtresultado.Text += 1;
    }

    //Dos
    protected void btndos_Click(object sender, EventArgs e)
    {
        this.txtresultado.Text += 2;
    }

    //Tres
    protected void btntres_Click(object sender, EventArgs e)
    {
        this.txtresultado.Text += 3;
    }

    //Cuatro
    protected void btncuatro_Click(object sender, EventArgs e)
    {
        this.txtresultado.Text += 4;
    }

    //Cinco
    protected void btncinco_Click(object sender, EventArgs e)
    {
        this.txtresultado.Text += 5;
    }

    //Seis
    protected void btnseis_Click(object sender, EventArgs e)
    {
        this.txtresultado.Text += 6;
    }

    //Siete
    protected void btnsiete_Click(object sender, EventArgs e)
    {
        this.txtresultado.Text += 7;
    }

    //Ocho
    protected void btnocho_Click(object sender, EventArgs e)
    {
        this.txtresultado.Text += 8;
    }

    //Nueve
    protected void btnnueve_Click(object sender, EventArgs e)
    {
        this.txtresultado.Text += 9;
    }

    //Coma(,)
    protected void btncoma_Click(object sender, EventArgs e)
    {
        this.txtresultado.Text += ",";
    }

    //Sumar
    protected void btnsumar_Click(object sender, EventArgs e)
    {
        su = this.txtresultado.Text;
        suma = Convert.ToInt32(su);
        this.txtresultado.Text = "";
    }

    //Igual
    protected void btnigual_Click(object sender, EventArgs e)
    {
        igu = this.txtresultado.Text;
        igual = Convert.ToInt32(igu);
        this.txtresultado.Text = "";
        if (suma > 0)
        {
            total = suma + igual;
            this.txtresultado.Text = Convert.ToString(total);

            borra();
        }
        else
        if (restar > 0)
        {
            total = restar - igual;
            this.txtresultado.Text = Convert.ToString(total);

            borra();
        }
        else
        if (multiplicar > 0)
        {
            total = multiplicar * igual;
            this.txtresultado.Text = Convert.ToString(total);

            borra();
        }
        else
        if (division > 0)
        {
            total = division / igual;
            this.txtresultado.Text = Convert.ToString(total);

            borra();
        }
    }

    //Raiz Cuadrada
    protected void btnraizcuadrada_Click(object sender, EventArgs e)
    {
        raiz = Convert.ToDouble(this.txtresultado.Text);
        this.txtresultado.Text = "";
        this.txtresultado.Text = Convert.ToString(Math.Sqrt(raiz));
    }

    //Restar
    protected void btnrestar_Click(object sender, EventArgs e)
    {
        res = this.txtresultado.Text;
        restar = Convert.ToInt32(res);
        this.txtresultado.Text = "";
    }

    //Borrar
    protected void btnborrar_Click(object sender, EventArgs e)
    {
        borra();

        this.txtresultado.Text = null;
    }

    //Multiplicación
    protected void btnmultiplicar_Click(object sender, EventArgs e)
    {
        mul = this.txtresultado.Text;
        multiplicar = Convert.ToInt32(mul);
        this.txtresultado.Text = "";
    }

    //Dividir
    protected void btndividir_Click(object sender, EventArgs e)
    {
        div = this.txtresultado.Text;
        division = Convert.ToInt32(div);
        this.txtresultado.Text = "";
    }

    //Exponencial
    protected void btnexponencial_Click(object sender, EventArgs e)
    {
        expo = Convert.ToDouble(this.txtresultado.Text);
        this.txtresultado.Text = "";
        this.txtresultado.Text = Convert.ToString(Math.Pow(1, expo));
    }

    //Procedimiento para Borrar las variables
    public void borra()
    {
        //Suma
        su = null;
        suma = 0;

        //Resta
        res = null;
        restar = 0;

        //Multiplicación
        mul = null;
        multiplicar = 0;

        //División
        div = null;
        division = 0;

        //Igual
        igu = null;
        igual = 0;

        //Total
        total = 0;

        //Raiz Cuadrada
        raiz = 0;
    }
}