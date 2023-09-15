using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Benchmark_13
{
    public partial class Default : System.Web.UI.Page
    {
       
        public static List<Prodotti>ListProdotti=new List<Prodotti>();


        protected void Page_Load(object sender, EventArgs e)
        {   ListProdotti.Clear();
            if(!IsPostBack)
            {
            Prodotti prodotto1 = new Prodotti("Zaino","Comodo e leggero perfetto per la scuola",40.00,"Content/img/Zaino.jpg",1);
            Prodotti prodotto2 = new Prodotti("Astuccio", "All'interno troverai tutto il necessario", 30.00, "Content/img/Astuccio.jpg",2);
            Prodotti prodotto3 = new Prodotti("Colori", "Set 12 colori craiola", 20.50, "Content/img/colori.jpg", 3);
            Prodotti prodotto4 = new Prodotti("Libri", "Libri italiano,matematica,scenze 2°media", 70.00, "Content/img/Libri.jpg", 4);
            Prodotti prodotto5 = new Prodotti("Penne", "set penne blu, rosse e verdi", 15.00, "Content/img/Penne.jpg", 5);
            Prodotti prodotto6 = new Prodotti("Quaderni", "Quaderni colorbook", 4.00, "Content/img/quaderni.jpg",6);

            ListProdotti.Add(prodotto1);
            ListProdotti.Add(prodotto2);
            ListProdotti.Add(prodotto3);
            ListProdotti.Add(prodotto4);
            ListProdotti.Add(prodotto5);
            ListProdotti.Add(prodotto6);
            }
         
            Mostra.DataSource = ListProdotti;
            Mostra.DataBind();

        }
    }

    public class Prodotti
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string NomeProdotto { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }

        public Prodotti() { }
        public Prodotti(string nomeProdotto, string descrizione, double prezzo, string image, int id)
        {
            NomeProdotto = nomeProdotto;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Image = image;
            Id = id;
        }
    }
} 
