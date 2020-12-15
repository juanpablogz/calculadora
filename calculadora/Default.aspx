<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="default.aspx.cs" Inherits="Calculadora" %>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Calculadora en C# By juan pablo gomez zapata AIEP</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div style="z-index: 101; left: 11px; width: 8px; position: absolute; top: 20px;
            height: 216px">
            <table>
                <tr>
                    <td align="right" colspan="6">
                        <asp:TextBox ID="txtresultado" runat="server" ForeColor="Blue"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                    </td>
                    <td style="width: 17px">
                    </td>
                    <td style="width: 19px">
                    </td>
                    <td style="width: 22px">
                    </td>
                    <td style="width: 18px">
                    </td>
                    <td style="width: 9px">
                        <asp:Button ID="btnborrar" runat="server" OnClick="btnborrar_Click" Text="Borrar" /></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                    </td>
                    <td style="width: 17px">
                        <asp:Button ID="btnsiete" runat="server" OnClick="btnsiete_Click" Text="7" /></td>
                    <td style="width: 19px">
                        <asp:Button ID="btnocho" runat="server" OnClick="btnocho_Click" Text="8" /></td>
                    <td style="width: 22px">
                        <asp:Button ID="btnnueve" runat="server" OnClick="btnnueve_Click" Text="9" /></td>
                    <td style="width: 18px">
                        <asp:Button ID="btndividir" runat="server" Text="/" OnClick="btndividir_Click" /></td>
                    <td style="width: 9px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 100px">
                    </td>
                    <td style="width: 17px">
                        <asp:Button ID="btncuatro" runat="server" OnClick="btncuatro_Click" Text="4" /></td>
                    <td style="width: 19px">
                        <asp:Button ID="btncinco" runat="server" OnClick="btncinco_Click" Text="5" /></td>
                    <td style="width: 22px">
                        <asp:Button ID="btnseis" runat="server" OnClick="btnseis_Click" Text="6" /></td>
                    <td style="width: 18px">
                        <asp:Button ID="btnmultiplicar" runat="server" Text="*" OnClick="btnmultiplicar_Click" /></td>
                    <td style="width: 9px">
                        <asp:Button ID="btnraizcuadrada" runat="server" OnClick="btnraizcuadrada_Click" Text="sqrl" /></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                    </td>
                    <td style="width: 17px">
                        <asp:Button ID="btnuno" runat="server" OnClick="btnuno_Click" Text="1" /></td>
                    <td style="width: 19px">
                        <asp:Button ID="btndos" runat="server" OnClick="btndos_Click" Text="2" /></td>
                    <td style="width: 22px">
                        <asp:Button ID="btntres" runat="server" OnClick="btntres_Click" Text="3" /></td>
                    <td style="width: 18px">
                        <asp:Button ID="btnrestar" runat="server" Text="-" OnClick="btnrestar_Click" /></td>
                    <td style="width: 9px">
                        <asp:Button ID="btnexponencial" runat="server" OnClick="btnexponencial_Click" Text="1/x" /></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                    </td>
                    <td style="width: 17px">
                        <asp:Button ID="btncero" runat="server" OnClick="btncero_Click" Text="0" /></td>
                    <td style="width: 19px">
                    </td>
                    <td style="width: 22px">
                        <asp:Button ID="btncoma" runat="server" OnClick="btncoma_Click" Text="," /></td>
                    <td style="width: 18px">
                        <asp:Button ID="btnsumar" runat="server" OnClick="btnsumar_Click" Text="+" /></td>
                    <td style="width: 9px">
                        <asp:Button ID="btnigual" runat="server" OnClick="btnigual_Click" Text="=" /></td>
                </tr>
            </table>
            </div>
    
    </div>
    </form>
</body>
</html>