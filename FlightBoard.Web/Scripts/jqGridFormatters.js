
//function activeFormatter(cellvalue, options, rowObject) {
//    // alert("[DEBUG] cell formatter invoked");
//    if (cellvalue == true)
//        return "<img src='/Content/images/icon_tick_active.png' alt='" + cellvalue + "' title='" + cellvalue + "' />";
//    else if (cellvalue == false)
//        return "<img src='/Content/images/icon_tick_inactive.png' alt='" + cellvalue + "' title='" + cellvalue + "' />";
//    else
//        return "<img src='/Content/images/exclamation.png' alt='" + cellvalue + "' title='" + cellvalue + "' />";
//}


function textFormatter(cellValue, options, rowObject) {

    return "<a href='#' title='" + rowObject[6] + "'>" + cellValue + "</a>";
}

function nullFormatter(cellValue, options, rowObject) {
   // alert(cellValue);
    if (cellValue != null) {
        return cellValue;
    }
    else {
        return "NULL";
    }


}

function actionsformater(cellValue, options, rowObject) {

    return "<a href='#' title='" + rowObject[4] + "'>" + cellValue + "</a>";
}

function FormatHistory(cellValue, options, rowObject) {
    alert(rowObject[5]);
    ShowItem(rowObject[5])
}



