<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Dettagli.aspx.cs" Inherits="Benchmark_13.Dettagli" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       
    <div class="border bg-white">
  <div id="Prod" runat="server">

    </div>
        <asp:Button ID="Button1" CssClass="btn btn-info" runat="server" Text="Aggiungi al carello" OnClick="Button1_Click"/>

    </div>

       <%-- <asp:Repeater ID="Mostra3" runat="server" ItemType="Benchmark_13.Dettagli">
      <ItemTemplate> 
        <div class="col ">   
          <div class="card" style="width: 18rem;">
          <img src="<%#Item.Image%>" class="card-img-top w-75" alt="...">
              <div class="card-body w-100">
                <h5 class="card-title"><%#Item.NomeProdotto%></h5>
                 <p class="card-text"><%#Item.Descrizione%></p>
                          <p class="card-text"><%#Item.Prezzo%>€</p>
                 <a href='Dettagli.aspx?idProdotto=<%#Item.Id %>' class="btn btn-info">Dettagli</a>
              </div>
              </div>
           </div> 
      </ItemTemplate>
    </asp:Repeater>--%>

</asp:Content>
