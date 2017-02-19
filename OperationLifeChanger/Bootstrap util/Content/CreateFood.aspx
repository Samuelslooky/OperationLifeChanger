<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateFood.aspx.cs" Inherits="OperationLifeChanger.Models.CreateFood" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Opret Fødevare</title>
    <link href="/CSS/MainStyling.css" rel="stylesheet" type="text/css" runat="server"/>
</head>
<body>
    <form id="opretFødevareForm" runat="server">
        <div>
            <h1><asp:Label runat="server" Text="Opret Fødevare" /></h1>
        </div>

        <div ID="beskrivelseKolonne">
            <asp:Literal runat="server" Text="Navn" /><br /><br />
            <asp:Literal runat="server" Text="Protein (samlet)" /><br /><br />
            <asp:Literal runat="server" Text="Kulhydrater (samlet)" /><br /><br />
            <asp:Literal runat="server" Text="Fedt (samlet)" /><br /><br />
            <asp:Literal runat="server" Text="Beskrivelse" /><br /><br />
        </div>

        <div id="udfyldningsKolonne">
            <asp:TextBox runat="server" ID="fødevareNavnFelt"/><br /><br />
            <asp:TextBox runat="server" ID="samletProteinFelt" /><br /><br />
            <asp:TextBox runat="server" ID="samletKulhydratFelt" /><br /><br />
            <asp:TextBox runat="server" ID="samletFedtFelt" /><br /><br />
            <asp:TextBox runat="server" ID="beskrivelseFelt" TextMode="MultiLine" Height="200px" Width="300px"/><br /><br />
        </div>

        <div id="knapperDiv">
            <asp:Button ID="OpretFødevareKnap" runat="server" Text="Opret" onclick="createFoodButtonClicked"/>
        </div>
    </form>
</body>
</html>
