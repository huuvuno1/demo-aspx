<%@ Page Title="" Language="C#" MasterPageFile="~/Common.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="demooo.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyCommon" runat="server">

    <form action="Login.aspx" method="post">
        <p>
            username: <input name="username" /> 
        </p>
        <p>
            password: <input name="password" /> 
        </p>
        <p>
            <input type="submit" value="Gui" /> 
        </p>
    </form>
</asp:Content>
