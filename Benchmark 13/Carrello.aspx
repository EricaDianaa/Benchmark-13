<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="Benchmark_13.Carrello" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <div class="container">
     <div class="row">
             <asp:Repeater ID="Mostra1" runat="server" ItemType="Benchmark_13.Prodotti">
               <ItemTemplate> 
                 <div class="col col-sm-6 col-md-4 col-lg-3 ">   
                   <div class="card" style="width: 18rem;">
                   <img src="<%#Item.Image%>" class="card-img-top w-50" alt="...">
                       <div class="card-body w-50">
                         <h5 class="card-title"><%#Item.NomeProdotto%></h5>
                          <p class="card-text"><%#Item.Descrizione%></p>
                           <p class="card-text"><%#Item.Prezzo%>€</p>
                           <asp:Button ID="Rimuovi" runat="server" Text="Rimuovi"  OnClick="Rimuovi_Click" />
                           <p class="d-none" id="p" runat="server"><%#Item.Id %></p>
                       </div>
                       </div>
                    </div> 
               </ItemTemplate>
             </asp:Repeater>
           <asp:Button ID="RimuoviTutto" runat="server" Text="Rimuovi tutto" OnClick="RimuoviTutto_Click"/>
         <div id="div1" class="btn" runat="server"></div>  
         </div>
    
 </div>
</asp:Content>
