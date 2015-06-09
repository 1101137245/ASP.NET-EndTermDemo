$(document).ready(function () {
    North = '<option value="臺北轉運站">臺北轉運站</option>\n\
                            <option value="三重站">三重站</option>\n\
                            <option value="南崁站">南崁站</option>\n\
                            <option value="中壢站">中壢站</option>\n\
                            <option value="板橋站">板橋站</option>\n\
                            <option value="中和站">中和站</option>\n\
                            <option value="市府轉運站">市府轉運站</option>\n\
                            <option value="三峽站">三峽站</option>\n\
                            <option value="景美站">景美站</option>\n\
                            <option value="三峽站">新店站</option>';
    Taichung = '<option value="豐原站">豐原站</option>\n\
                            <option value="東勢站">東勢站</option>\n\
                            <option value="台中車站">台中車站</option>\n\
                            <option value="水湳站">水湳站</option>\n\
                            <option value="朝馬站">朝馬站</option>';
    Changhua = '<option value="彰化交流道站">彰化交流道站</option>\n\
                            <option value="彰化站">彰化站</option>\n\
                            <option value="員林站">員林站</option>\n\
                            <option value="溪湖站">溪湖站</option>\n\
                            <option value="二林站">二林站</option>';
    Yunlin = '<option value="北港站">北港站</option>\n\
                            <option value="虎尾站">虎尾站</option>\n\
                            <option value="西螺站">西螺站</option>\n\
                            <option value="嘉義轉運站">嘉義轉運站</option>\n\
                            <option value="嘉義北港路站">嘉義北港路站</option>\n\
                            <option value="大林站">大林站</option>';
    South = '<option value="北門站">北門站</option>\n\
                            <option value="鹽行站">鹽行站</option>\n\
                            <option value="新營站">新營站</option>\n\
                            <option value="麻豆站">麻豆站</option>\n\
                            <option value="仁德站">仁德站</option>\n\
                            <option value="中華站">中華站</option>\n\
                            <option value="建國站">建國站</option>\n\
                            <option value="中正站">中正站</option>\n\
                            <option value="楠梓站">楠梓站</option>\n\
                            <option value="岡山站">岡山站</option>\n\
                            <option value="屏東站">屏東站</option>\n\
                            <option value="麟洛站">麟洛站</option>';

    $("#AboardArea").change(function () {
        ChangeStation("Aboard");
    });

    $("#GetoffArea").change(function () {
        ChangeStation("Getoff");

    });
    $("#submit").click(function () {
        AddTicket();
    });


});

function ChangeStation(x) {
    $("#" + x + "Station > *").remove();
    $('<option value="First Option">選擇車站</option>').appendTo("#" + x + "Station");

    switch ($("#" + x + "Area").val()) {
        case "1":
            $(North).appendTo("#" + x + "Station");
            break;
        case "2":
            $(Taichung).appendTo("#" + x + "Station");
            break;
        case "3":
            $(Changhua).appendTo("#" + x + "Station");
            break;
        case "4":
            $(Yunlin).appendTo("#" + x + "Station");
            break;
        case "5":
            $(South).appendTo("#" + x + "Station");
            break;
        default:
            alert("請重新選擇");
            break;

    }


}


function AddTicket() {
    $.ajax({
        url: "http://localhost:1073/api/Course",
        type: 'POST',
        data: {
            Id: "20",
            Name: $("#Name").val(),
            Description: $("#Quantity").val(),
            Date: $("#Date").val(),
            Time: $("#Time").val(),
            Aboard: $("#AboardStation").val(),
            Getoff: $("#GetoffStation").val(),
            Number: "1620",
            Site: "10",
            Price: "500"
        },
        dataType: 'json',
        success: function (data) {
            alert("新增成功   網頁將於2秒後跳轉...");
            location.reload();
            
        },
        error: function () {
            alert("");
        }
    });



}