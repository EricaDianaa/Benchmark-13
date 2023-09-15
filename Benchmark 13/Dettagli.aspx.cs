using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Benchmark_13
{
    public partial class Dettagli : System.Web.UI.Page
    {
       public static List<Prodotti> ListProdotto = new List<Prodotti>();
        public static List<Prodotti> ListCart = new List<Prodotti>();
        public static List<Prodotti> Lista = new List<Prodotti>();

   
        protected void Page_Load(object sender, EventArgs e)
        {

            ListProdotto.Clear();
            if (!IsPostBack)
            {
                Prodotti prodotto1 = new Prodotti("Zaino", "Comodo e leggero perfetto per la scuola", 40.00, "Content/img/Zaino.jpg", 1);
                Prodotti prodotto2 = new Prodotti("Astuccio", "All'interno troverai tutto il necessario", 30.00, "Content/img/Astuccio.jpg", 2);
                Prodotti prodotto3 = new Prodotti("Colori", "Set 12 colori craiola", 20.50, "Content/img/colori.jpg", 3);
                Prodotti prodotto4 = new Prodotti("Libri", "Libri italiano,matematica,scenze 2°media", 70.00, "Content/img/Libri.jpg", 4);
                Prodotti prodotto5 = new Prodotti("Penne", "set penne blu, rosse e verdi", 15.00, "Content/img/Penne.jpg", 5);
                Prodotti prodotto6 = new Prodotti("Quaderni", "Quaderni colorbook", 4.00, "Content/img/quaderni.jpg", 6);

                ListProdotto.Add(prodotto1);
                ListProdotto.Add(prodotto2);
                ListProdotto.Add(prodotto3);
                ListProdotto.Add(prodotto4);
                ListProdotto.Add(prodotto5);
                ListProdotto.Add(prodotto6);
            }

            int idProdotto = (Convert.ToInt16(Request.QueryString["idProdotto"]));

            Prodotti prod = new Prodotti();

            foreach (Prodotti item in ListProdotto)
            {
                if (item.Id == idProdotto)
                {
                     prod = item;
                }
            }
           
            ListCart.Add(prod);


           
            
            Prodotti prod1 = new Prodotti(prod.NomeProdotto, prod.Descrizione, prod.Prezzo, prod.Image, prod.Id);
            // < a href = 'Carrello.aspx?idProdotto={idProdotto}' class='btn btn-primary'>Aggiungi al Carrello</a>
            Lista.Add(prod1);
            //Mostra3.DataSource = Lista;
            //Mostra3.DataBind();

            Prod.InnerHtml += $"<div class='card' style='width: 18rem;'><img src='{prod.Image}' class='card-img-top' alt='...'>" +
             $"<div class='card-body'>  <h5 class='card-title'>{prod.NomeProdotto}</h5><p class='card-text'>{prod.Prezzo}</p>" +
             $"<a href='' class='btn btn-primary'>Aggiungi al Carrello</a> </div></div>";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Session["ListaCarrello"] = ListCart;
            int idprodotto = (Convert.ToInt16(Request.QueryString["idprodotto"]));

            //Prodotti prod = new Prodotti();
            //foreach (Prodotti item in ListCart)
            //{

            //    if (item.Id == idprodotto)
            //    {
            //        prod = item;

            //    }
            //}
            //Carrello.ListCarrello.Add(prod);
            //ListCart.Add(prod);

        }

    }


    }
