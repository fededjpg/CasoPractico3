<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebServiceLibros.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Libros</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-BmbxuPwQa2lc/FVzBcNJ7UAyJxM6wuqIj61tLrc4wSX0szH/Ev+nYRRuWlolflfl" crossorigin="anonymous" />

</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="ShowDataGridViewLibros" runat="server" CssClass="table table-striped text-center"   BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>

         <asp:Panel runat="server" CssClass="text-center">
            Id: <asp:TextBox runat="server" ID="textBoxId" ></asp:TextBox>
             <asp:Button CssClass="btn btn-success btn-sm" Text="Get->" ID="btnGetOneBook" runat="server" OnClick="btnGetOneBook_Click" />
                   
            <br />
                Titulo: <asp:TextBox  runat="server" ID="textBoxTitulo"></asp:TextBox>
            <br />
                Autor: <asp:TextBox runat="server" ID="textBoxAutor"></asp:TextBox>
            <br />
                Precio: <asp:TextBox runat="server" ID="textBoxPrecio"></asp:TextBox>
            <br />
                Año de Publicacion: <asp:TextBox runat="server" ID="textBoxFecha"></asp:TextBox>
            <br />
            <asp:Button CssClass="btn btn-primary btn-sm" runat="server" Text="Agregar" ID="btnAgregar" OnClick="btnAgregar_Click" />
            <asp:Button CssClass="btn btn-warning btn-sm" runat="server"  Text="Actualizar" ID="btnActualizar" OnClick="btnActualizar_Click"/>
            <asp:Button CssClass="btn btn-danger btn-sm" ID="BtnDElete" runat="server" Text="Eliminar Libro" OnClick="BtnDElete_Click" />
        </asp:Panel>
    </form>
</body>
</html>
