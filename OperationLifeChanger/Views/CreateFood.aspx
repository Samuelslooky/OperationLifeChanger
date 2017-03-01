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
            <div class="col-xs-12">
                <asp:Label runat="server" Text="Kalorier: " Font-Size="30px"/>
                <asp:Label runat="server" ID="KalorierPr100Felt" Text="0,0" Font-Size="25px"/>
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
                    <asp:Label runat="server" Text="Protein (samlet)" cssclass="text-left col-sm-6 col-xs-12"/>
                    <asp:TextBox runat="server" ID="samletProteinFelt" cssclass="col-sm-4 col-xs-10" OnTextChanged="beregnKalorier"/>
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
                    <asp:TextBox runat="server" ID="VitaminB2Felt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="B3" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="VitaminB3Felt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="B5" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="VitaminB5Felt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="B6" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="VitaminB6Felt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="B7" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="VitaminB7Felt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="B9" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="VitaminB9Felt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="B12" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="VitaminB12Felt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="C" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="VitaminCFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="D" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="VitaminDFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="E" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="VitaminEFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="K" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="VitaminKFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
            </div>
            <div class="mineraler infoBlock">
                <h2><asp:Label runat="server" Text="Mineraler" /></h2>
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="Calcium" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="CalciumFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="Jod" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="JodFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="Jern" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="JernFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="Magnesium" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="MagnesiumFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="Fosfor" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="FosforFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="Kobber" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="KobberFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="Mangan" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="ManganFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="Krom" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="KromFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="Molybdæn" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="MolybdænFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
                <div class="entryPairSmall">
                    <asp:Label runat="server" Text="Zink" cssclass="text-left col-sm-8 col-xs-12"/>
                    <asp:TextBox runat="server" ID="ZinkFelt" cssclass="col-sm-4 col-xs-12"/>
                </div> 
            </div>

            <div class="bottomButtonLine">
                <asp:Button ID="OpretFødevareKnap" runat="server" Text="Opret" onclick="createFoodButtonClicked"/>
            </div>
        </div>
    </form>
</body>
</html>
