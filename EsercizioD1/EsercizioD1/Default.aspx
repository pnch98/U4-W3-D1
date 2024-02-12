<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EsercizioD1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>

            <asp:Button ID="Button1" runat="server" Text="Show name" OnClick="ShowName" class="btn btn-primary mb-2" />
            <p id="parag" runat="server"></p>

    </main>

</asp:Content>
