<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateFood.aspx.cs" Inherits="OperationLifeChanger.Models.CreateFood" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Opret Fødevare</title>
    <link href="../CSS/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="opretFødevareForm" runat="server">
        <div class="container-fluid">
            <div class="jumbotron">
                <h1><asp:Label runat="server" Text="Opret Fødevare" /></h1>
            </div>

            <div class="col-md-4">
                <div class="col-sm-12">
                    <asp:Label runat="server" Text="Navn" cssclass="text-left col-xs-4"/>
                    <asp:TextBox runat="server" ID="fødevareNavnFelt" cssclass="col-xs-8"/>
                </div>
                <br />
                <div class="col-sm-12">
                    <asp:Label runat="server" Text="Protein (samlet)" cssclass="text-left col-xs-4"/>
                    <asp:TextBox runat="server" ID="samletProteinFelt" cssclass="col-xs-8"/>
                </div>
                <br />
                <div class="col-sm-12">
                    <asp:Label runat="server" Text="Kulhydrater (samlet)" cssclass="text-left col-xs-4"/>
                    <asp:TextBox runat="server" ID="samletKulhydratFelt" cssclass="col-xs-8"/>
                </div>
                <br />
                <div class="col-sm-12">
                    <asp:Label runat="server" Text="Fedt (samlet)" cssclass="text-left col-xs-4"/>
                    <asp:TextBox runat="server" ID="samletFedtFelt" cssclass="col-xs-8"/>
                </div>
                <br />
                <div class="col-sm-12">
                    <asp:Label runat="server" Text="Beskrivelse" cssclass="text-left col-xs-4"/>
                    <asp:TextBox runat="server" ID="beskrivelseFelt" TextMode="MultiLine" Height="200px" Width="300px" cssclass="col-xs-8"/>
                </div> 
                <br />                                
            </div>
            <div class="col-sm-8  
            </div>
            </div>
            <div class="col-md-8">
            </div>
            <div class="col-xs-12">
                <asp:Button ID="OpretFødevareKnap" runat="server" Text="Opret" onclick="createFoodButtonClicked"/>
            </div>
        </div>
    </form>
</body>
</html>
