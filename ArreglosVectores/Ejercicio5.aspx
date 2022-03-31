<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio5.aspx.cs" Inherits="ArreglosVectores.Ejercicio5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 372px;
        }
        .auto-style3 {
            width: 372px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label runat="server" Text="Mostrar vector"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblMostrarVector" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label runat="server" Text="Ceros"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblMostrarCuantosCeros" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label runat="server" Text="Negativos"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblCuantosNegativos" runat="server"></asp:Label>
                    &nbsp;/
                    <asp:Label ID="lblCualesNegativos" runat="server"></asp:Label>
                    &nbsp;/
                    <asp:Label ID="lblSumaNegativos" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label runat="server" Text="Positivos"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblCuantosPositivos" runat="server"></asp:Label>
                    &nbsp;/
                    <asp:Label ID="lblCualesPositivos" runat="server"></asp:Label>
                    &nbsp;/
                    <asp:Label ID="lblSumaPositivos" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btnMostrar" runat="server" OnClick="btnMostrar_Click" Text="Mostrar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
