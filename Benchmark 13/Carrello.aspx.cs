using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Benchmark_13
{
    public partial class Carrello : System.Web.UI.Page
    {
        public static List<Prodotti> ListProdotto = new List<Prodotti>();
        public static List<Prodotti> ListCarrello = new List<Prodotti>();
        protected void Page_Load(object sender, EventArgs e)
        {
            int idProdotto = (Convert.ToInt16(Request.QueryString["idProdotto"]));
         

            if (Session["ListaCarrello"] != null)
            {
                Session["NewList"] = Session["ListaCarrello"];
                ListCarrello = (List<Prodotti>)Session["NewList"];
                Session["ListaCarrello"] = null;

                Mostra1.DataSource = ListCarrello;
                Mostra1.DataBind();
            }
        }

        protected void Rimuovi_Click(object sender, EventArgs e)
        {
            int idProdotto = (Convert.ToInt16(Request.QueryString["idProdotto"]));
            Prodotti prod = new Prodotti();
            for (int i = 0; i < ListCarrello.Count; i++)
            {
                if (ListCarrello[i].Id == idProdotto)
                {
                   ListCarrello.RemoveAt(i);
                }
            }


        }

        protected void RimuoviTutto_Click(object sender, EventArgs e)
        {
            ListCarrello.Clear();
        }
    }
    public class CarrelloProdotti
        {
            public Prodotti Prod { get; set; }
        }
}