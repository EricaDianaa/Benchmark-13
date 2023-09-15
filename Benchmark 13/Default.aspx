<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Benchmark_13.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">
        <div class="row">
                <asp:Repeater ID="Mostra" runat="server" ItemType="Benchmark_13.Prodotti">
                  <ItemTemplate> 
                    <div class="col col-sm-6 col-md-4 ">   
                      <div class="card">
                      <img src="<%#Item.Image%>" class="card-img-top w-100 h-25" alt="...">
                          <div class="card-body w-50">
                            <h5 class="card-title "><%#Item.NomeProdotto%></h5>
                             <p class="card-text"><%#Item.Descrizione%></p>
                                      <p class="card-text"><%#Item.Prezzo%>€</p>
                             <a href='Dettagli.aspx?idProdotto=<%#Item.Id %>' class="btn btn-info">Dettagli</a>
                          </div>
                          </div>
                       </div> 
                  </ItemTemplate>
                </asp:Repeater>
            <div id="div1" class="btn" runat="server"></div>
            </div>
       
    </div>

</asp:Content>
