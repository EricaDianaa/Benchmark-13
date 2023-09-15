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
                Prodotti prodotto1 = new Prodotti("Zaino", "Lorem Ipsum è un testo segnaposto utilizzato nel settore della tipografia e della stampa. Lorem Ipsum è considerato il testo segnaposto standard sin dal sedicesimo secolo, quando un anonimo tipografo prese una cassetta di caratteri e li assemblò per preparare un testo campione. È sopravvissuto non solo a più di cinque secoli, ma anche al passaggio alla videoimpaginazione, pervenendoci sostanzialmente inalterato. Fu reso popolare, negli anni ’60, con la diffusione dei fogli di caratteri trasferibili “Letraset”, che contenevano passaggi del Lorem Ipsum, e più recentemente da software di impaginazione come Aldus PageMaker, che includeva versioni del Lorem Ipsum.", 40.00, "Content/img/Zaino.jpg", 1);
                Prodotti prodotto2 = new Prodotti("Astuccio", "Lorem Ipsum è un testo segnaposto utilizzato nel settore della tipografia e della stampa. Lorem Ipsum è considerato il testo segnaposto standard sin dal sedicesimo secolo, quando un anonimo tipografo prese una cassetta di caratteri e li assemblò per preparare un testo campione. È sopravvissuto non solo a più di cinque secoli, ma anche al passaggio alla videoimpaginazione, pervenendoci sostanzialmente inalterato. Fu reso popolare, negli anni ’60, con la diffusione dei fogli di caratteri trasferibili “Letraset”, che contenevano passaggi del Lorem Ipsum, e più recentemente da software di impaginazione come Aldus PageMaker, che includeva versioni del Lorem Ipsum.", 30.00, "Content/img/Astuccio.jpg", 2);
                Prodotti prodotto3 = new Prodotti("Colori", "Lorem Ipsum è un testo segnaposto utilizzato nel settore della tipografia e della stampa. Lorem Ipsum è considerato il testo segnaposto standard sin dal sedicesimo secolo, quando un anonimo tipografo prese una cassetta di caratteri e li assemblò per preparare un testo campione. È sopravvissuto non solo a più di cinque secoli, ma anche al passaggio alla videoimpaginazione, pervenendoci sostanzialmente inalterato. Fu reso popolare, negli anni ’60, con la diffusione dei fogli di caratteri trasferibili “Letraset”, che contenevano passaggi del Lorem Ipsum, e più recentemente da software di impaginazione come Aldus PageMaker, che includeva versioni del Lorem Ipsum.", 20.50, "Content/img/colori.jpg", 3);
                Prodotti prodotto4 = new Prodotti("Libri", "Lorem Ipsum è un testo segnaposto utilizzato nel settore della tipografia e della stampa. Lorem Ipsum è considerato il testo segnaposto standard sin dal sedicesimo secolo, quando un anonimo tipografo prese una cassetta di caratteri e li assemblò per preparare un testo campione. È sopravvissuto non solo a più di cinque secoli, ma anche al passaggio alla videoimpaginazione, pervenendoci sostanzialmente inalterato. Fu reso popolare, negli anni ’60, con la diffusione dei fogli di caratteri trasferibili “Letraset”, che contenevano passaggi del Lorem Ipsum, e più recentemente da software di impaginazione come Aldus PageMaker, che includeva versioni del Lorem Ipsum.", 70.00, "Content/img/Libri.jpg", 4);
                Prodotti prodotto5 = new Prodotti("Penne", "Lorem Ipsum è un testo segnaposto utilizzato nel settore della tipografia e della stampa. Lorem Ipsum è considerato il testo segnaposto standard sin dal sedicesimo secolo, quando un anonimo tipografo prese una cassetta di caratteri e li assemblò per preparare un testo campione. È sopravvissuto non solo a più di cinque secoli, ma anche al passaggio alla videoimpaginazione, pervenendoci sostanzialmente inalterato. Fu reso popolare, negli anni ’60, con la diffusione dei fogli di caratteri trasferibili “Letraset”, che contenevano passaggi del Lorem Ipsum, e più recentemente da software di impaginazione come Aldus PageMaker, che includeva versioni del Lorem Ipsum.", 15.00, "Content/img/Penne.jpg", 5);
                Prodotti prodotto6 = new Prodotti("Quaderni", "Lorem Ipsum è un testo segnaposto utilizzato nel settore della tipografia e della stampa. Lorem Ipsum è considerato il testo segnaposto standard sin dal sedicesimo secolo, quando un anonimo tipografo prese una cassetta di caratteri e li assemblò per preparare un testo campione. È sopravvissuto non solo a più di cinque secoli, ma anche al passaggio alla videoimpaginazione, pervenendoci sostanzialmente inalterato. Fu reso popolare, negli anni ’60, con la diffusione dei fogli di caratteri trasferibili “Letraset”, che contenevano passaggi del Lorem Ipsum, e più recentemente da software di impaginazione come Aldus PageMaker, che includeva versioni del Lorem Ipsum.", 4.00, "Content/img/quaderni.jpg", 6);

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

            if (!IsPostBack)
            {
  Prod.InnerHtml += $"<div class='card mb-3'><img src='{prod.Image}' class='img-fluid rounded-start' alt='...'>" +
             $"<div class='card-body'>  <h5 class='card-title'>{prod.NomeProdotto}</h5><p class='card-text'>{prod.Descrizione}</p><p class='card-text'>{prod.Prezzo}</p>" +
             $"</div></div>";
            }
          



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
