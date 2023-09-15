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
            if (!IsPostBack)
            {
              if (Session["ListaCarrello"] != null)
             {
                Session["NewList"] = Session["ListaCarrello"];
                ListCarrello = (List<Prodotti>)Session["NewList"];
                Session["ListaCarrello"] = null;

                Mostra1.DataSource = ListCarrello;
                Mostra1.DataBind();
            }
            }
            int idProdotto = (Convert.ToInt16(Request.QueryString["idProdotto"]));
         

           
        }

        protected void Rimuovi_Click(object sender, EventArgs e)
        {
            int idProdotto = (Convert.ToInt16(Request.QueryString["idProdotto"]));
            Prodotti prod = new Prodotti();
           Button button=(sender as  Button);
            int id = Convert.ToInt32(button.CommandArgument);

            foreach (Prodotti item in ListCarrello)
            {
                if (item.Id == id)
                {
                    ListCarrello.Remove(item);
                    break;
                }
            }
        }

        protected void RimuoviTutto_Click(object sender, EventArgs e)
        {
            ListCarrello.Clear();
            Response.Redirect("Carrello.aspx");
        }
    }
    public class CarrelloProdotti
        {
            public Prodotti Prod { get; set; }
        }
}