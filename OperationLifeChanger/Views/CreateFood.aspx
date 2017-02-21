<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateFood.aspx.cs" Inherits="OperationLifeChanger.Models.CreateFood" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Opret Fødevare</title>    
    <script src="../Javascript/bootstrap_scripts/jquery-3.1.1.min.js"></script>
    <link href="../CSS/bootstrap.css" rel="stylesheet" />
    <link href="../CSS/MainStyling.css" rel="stylesheet" />
    <script src="../Javascript/MainScript.js"></script>
</head>
<body>
    <form id="opretFødevareForm" runat="server">
        <div class="container-fluid">
            <div class="jumbotron">
                <h1><asp:Label runat="server" Text="Opret Fødevare" /></h1>
            </div>

            <div class="infoBlock">
                <h2><asp:Label runat="server" Text="Overordnet" /></h2>
                
                <div class="entryPairLarge">
                    <asp:Label runat="server" Text="Navn" cssclass="text-left col-sm-4 col-xs-12"/>
                    <asp:TextBox runat="server" ID="fødevareNavnFelt" cssclass="col-sm-8 col-xs-12"/>
                </div>
                
                <div class="entryPairLarge">
                    <asp:Label runat="server" Text="Beskrivelse" cssclass="text-left col-sm-4 col-xs-12"/>
                    <asp:TextBox runat="server" ID="beskrivelseFelt" TextMode="MultiLine" Height="100px" style="resize:none;" cssclass="col-sm-8 col-xs-12"/>
                </div>   
            </div>

            <div class="protein infoBlock">
                <h2><asp:Label runat="server" Text="Protein" /></h2>                
                
                <div class="entryPairMedium">
                    <asp:Label runat="server" Text="Protein (samlet)" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="samletProteinFelt" cssclass="col-sm-4 col-xs-12"/>
                </div>
            </div>

            <div class="kulhydrat infoBlock">
                <h2><asp:Label runat="server" Text="Kulhydrat" /></h2>
                <div class="entryPairMedium">
                    <asp:Label runat="server" Text="Kulhydrater (samlet)" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="samletKulhydratFelt" cssclass="col-sm-4 col-xs-12"/>
                </div>
                <div class="entryPairMedium">
                    <asp:Label runat="server" Text="Heraf sukkerarter" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="sukkerarterFelt" cssclass="col-sm-4 col-xs-12"/>
                </div>
                <div class="entryPairMedium">
                    <asp:Label runat="server" Text="Fibre" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="FifreFelt" cssclass="col-sm-4 col-xs-12"/>
                </div>
            </div>

            <div class="fedt infoBlock">
                <h2><asp:Label runat="server" Text="Fedt" /></h2>
                <div class="entryPairMedium">
                    <asp:Label runat="server" Text="Fedt (samlet)" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="samletFedtFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairMedium">
                    <asp:Label runat="server" Text="Mættet fedt" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="MættetFedtFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairMedium">
                    <asp:Label runat="server" Text="Flerumættet fedtsyrer" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="FlerFedtFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairMedium">
                    <asp:Label runat="server" Text="Enkeltumættet fedtsyrer" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="EnkeltFedtFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
            </div>
            <div class="vitaminer infoBlock">
                <h2><asp:Label runat="server" Text="Vitaminer" /></h2>
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="A" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="VitaminAFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="B1" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="VitaminB1Felt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="B2" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="ViatminB2Felt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="B3" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="ViatminB3Felt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="B5" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="ViatminB5Felt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="B6" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="ViatminB6Felt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="B7" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="ViatminB7Felt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="B9" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="ViatminB9Felt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="B12" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="ViatminB12Felt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="C" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="ViatminCFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="D" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="ViatminDFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="E" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="ViatminEFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="K" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="ViatminKFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
            </div>
            <div class="mineraler infoBlock">
                <h2><asp:Label runat="server" Text="Mineraler" /></h2>
            </div>

            <div class="bottomButtonLine">
                <asp:Button ID="OpretFødevareKnap" runat="server" Text="Opret" onclick="createFoodButtonClicked"/>
            </div>
        </div>
    </form>
</body>
</html>
