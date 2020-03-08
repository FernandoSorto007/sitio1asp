<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="notasweb.inicio" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">     
    <div class="container">
         <h1>Bienvenido Notas<asp:Label ID="lblnombre" runat="server" Visible="False"></asp:Label></h1>
         <asp:GridView ID="GridView1" runat="server" Width="675px"></asp:GridView>
    </div>  
    <br />
</asp:Content>