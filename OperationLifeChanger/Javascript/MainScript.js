$(document).ready(function () {
    SetupInfoBlocks();
    SetupEntryPairs();
    SetupBottomButtonLine();
})


function SetupInfoBlocks() {
    $(".infoBlock").each(function (index) {
        $(this).addClass("col-lg-4 col-md-6 col-sm-6 col-xs-12");
    })
}

function SetupEntryPairs() {
    $(".entryPairLarge").each(function (index) {
        $(this).addClass("col-xs-12");
    })

    $(".entryPairMedium").each(function (index) {
        $(this).addClass("col-xs-6");
    })

    $(".entryPairSmall").each(function (index) {
        $(this).addClass("col-xs-4");
    })
}

function SetupBottomButtonLine() {
    $(".bottomButtonLine").each(function (index) {
        $(this).addClass("col-xs-12");
    })
}
