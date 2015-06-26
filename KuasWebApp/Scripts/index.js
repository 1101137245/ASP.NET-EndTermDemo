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
                            <option value="新店站">新店站</option>';
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
    $("#GetoffStation,#AboardStation").change(function () {
        ChangeClass();
    });

    $("#select-choice-a,#select-choice-b,#select-choice-c,#select-choice-d").change(function () {
        changeTimeselect();
    });
    $("#submit").click(function () {
        AddTicket();
        window.location = "../Views/Index.html";

    });
    $("#clear").click(function () {
        window.location = "../Views/Index.html";
    })




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
function ChangeClass() {
    $.ajax({
        url: "../data/data.aspx",
        type: 'GET',
        data: {

        },
        dataType: 'json',
        success: function (data) {
            UpdataClass(data);

        },
        error: function () {
            console.log("Class can not fetch");
        }
    });
}
function UpdataClass(data) {
    var AboardStation = $("#AboardStation").val();
    var GetoffStation = $("#GetoffStation").val();
    var Class1, Class2, Class3, Class4, Price, Number;
    var Class1H = 0, Class1M = 0, Class1T, Class2H = 6, Class2M = 0, Class2T, Class3H = 12, Class3M = 0, Class3T, Class4H = 18, Class4M = 0, Class4T;
    for (var i = 0; i < data.length; i++) {
        if ((data[i].Aboard == AboardStation && data[i].Getoff == GetoffStation) ||
            (data[i].Getoff == AboardStation && data[i].Aboard == GetoffStation)) {
            Class1 = parseInt(data[i].Class1);
            Class2 = parseInt(data[i].Class2);
            Class3 = parseInt(data[i].Class3);
            Class4 = parseInt(data[i].Class4);
            Price = parseInt(data[i].Price);
            Number = data[i].Number;
            $("#Number").val(Number);

            $("#Price").val(Price);
            for (var w = 0; w < (360 / Class1) ; w++) {

                if (Class1M + Class1 >= 120) {
                    Class1H++;
                    Class1M = Class1M + (Class1 - 60);
                    do {
                        Class1H++;
                        Class1M = Class1M - 60;
                    } while (Class1M >= 60)

                } else if (Class1M + Class1 >= 60 && Class1M + Class1 < 120) {
                    Class1H++;
                    Class1M = Class1M + (Class1 - 60);
                } else {
                    Class1M = Class1M + Class1;
                }

                if (Class1H < 10 && Class1M < 10) {
                    Class1T = "0" + Class1H + ":0" + Class1M;
                } else {
                    if (Class1H < 10 && Class1M > 9) {
                        Class1T = "0" + Class1H + ":" + Class1M;
                    } if (Class1H > 9 && Class1M < 10) {
                        Class1T = Class1H + ":0" + Class1M;
                    } else {
                        Class1T = Class1H + ":" + Class1M;
                    }
                }

                var content = '<option value="' + Class1T + '">' + Class1T + '</option>';
                $(content).appendTo($("#select-choice-a"));

            }
            $("#select-choice-a").selectmenu("refresh");

            for (var x = 0; x < (360 / Class2) ; x++) {

                if (Class2M + Class2 >= 120) {
                    Class2H++;
                    Class2M = Class2M + (Class2 - 60);
                    do {
                        Class2H++;
                        Class2M = Class2M - 60;
                    } while (Class2M >= 60)

                } else if (Class2M + Class2 >= 60 && Class2M + Class2 < 120) {
                    Class2H++;
                    Class2M = Class2M + (Class2 - 60);
                } else {
                    Class2M = Class2M + Class2;
                }

                if (Class2H < 10 && Class2M < 10) {
                    Class2T = "0" + Class2H + ":0" + Class2M;
                } else {
                    if (Class2H < 10 && Class2M > 9) {
                        Class2T = "0" + Class2H + ":" + Class2M;
                    } if (Class2H > 9 && Class2M < 10) {
                        Class2T = Class2H + ":0" + Class2M;
                    } else {
                        Class2T = Class2H + ":" + Class2M;
                    }
                }

                var content = '<option value="' + Class2T + '">' + Class2T + '</option>';
                $(content).appendTo($("#select-choice-b"));

            }
            $("#select-choice-b").selectmenu("refresh");

            for (var y = 0; y < (360 / Class3) ; y++) {

                if (Class3M + Class3 >= 120) {
                    Class3H++;
                    Class3M = Class3M + (Class3 - 60);
                    do {
                        Class3H++;
                        Class3M = Class3M - 60;
                    } while (Class3M >= 60)

                } else if (Class3M + Class3 >= 60 && Class3M + Class3 < 120) {
                    Class3H++;
                    Class3M = Class3M + (Class3 - 60);
                } else {
                    Class3M = Class3M + Class3;
                }

                if (Class3H < 10 && Class3M < 10) {
                    Class3T = "0" + Class3H + ":0" + Class3M;
                } else {
                    if (Class3H < 10 && Class3M > 9) {
                        Class3T = "0" + Class3H + ":" + Class3M;
                    } if (Class3H > 9 && Class3M < 10) {
                        Class3T = Class3H + ":0" + Class3M;
                    } else {
                        Class3T = Class3H + ":" + Class3M;
                    }
                }

                var content = '<option value="' + Class3T + '">' + Class3T + '</option>';
                $(content).appendTo($("#select-choice-c"));

            }
            $("#select-choice-c").selectmenu("refresh");

            for (var x = 0; x < (360 / Class4) ; x++) {

                if (Class4M + Class4 >= 120) {
                    Class4H++;
                    Class4M = Class4M + (Class4 - 60);
                    do {
                        Class4H++;
                        Class4M = Class4M - 60;
                    } while (Class4M >= 60)

                } else if (Class4M + Class4 >= 60 && Class4M + Class4 < 120) {
                    Class4H++;
                    Class4M = Class4M + (Class4 - 60);
                } else {
                    Class4M = Class4M + Class4;
                }

                if (Class4H < 10 && Class4M < 10) {
                    Class4T = "0" + Class4H + ":0" + Class4M;
                } else {
                    if (Class4H < 10 && Class4M > 9) {
                        Class4T = "0" + Class4H + ":" + Class4M;
                    } if (Class4H > 9 && Class4M < 10) {
                        Class4T = Class4H + ":0" + Class4M;
                    } else {
                        Class4T = Class4H + ":" + Class4M;
                    }
                }

                var content = '<option value="' + Class4T + '">' + Class4T + '</option>';
                $(content).appendTo($("#select-choice-d"));

            }
            $("#select-choice-d").selectmenu("refresh");

        }
    }
}

function AddTicket() {
    $.ajax({
        url: "/api/Ticket",
        type: 'POST',
        data: {
            Id: $("#Phone").val() + $("#Date").val()+$("#Time").val(),
            Name: $("#Name").val(),
            Quantity: $("#Quantity").val(),
            Date: $("#Date").val(),
            Time: $("#Time").val(),
            Aboard: $("#AboardStation").val(),
            Getoff: $("#GetoffStation").val(),
            Number: $("#Number").val(),
            Phone: $("#Phone").val(),
            Price: $("#Price").val() * $("#Quantity").val()
        },
        dataType: 'json',
        success: function (data) {
            SuccessAdd();
            location.reload();

        },
        error: function () {
            alert("無法新增!");
        }
    });



}
function SuccessAdd() {

    $("#addialog").kendoWindow({
        animation: {
            open: {
                duration: 250, effects: "fade:in"
            },
            close: {
                duration: 250, effects: "fade:out"
            }
        },
        visible: false,
        open: false,
        title: "", width: "40%", top: "40%"
    });
    var dialog = $("#addialog").data("kendoWindow");
    dialog.center();

    $("#addialog").data("kendoWindow").open();

}


function changeTimeselect() {
    var time1 = $("#select-choice-a").val();
    var time2 = $("#select-choice-b").val()
    var time3 = $("#select-choice-c").val()
    var time4 = $("#select-choice-d").val()
    if (time1 != "0"&& $("#Time").val()=="") {
        $("#Time").val(time1);
        $("#select-choice-b,#select-choice-c,#select-choice-d").selectmenu("disable");
    }
    if (time2 != "0" && $("#Time").val() == "") {
        $("#Time").val(time2);
        $("#select-choice-a,#select-choice-c,#select-choice-d").selectmenu("disable");
    }
    if (time3 != "0"&& $("#Time").val()=="") {
        $("#Time").val(time3);
        $("#select-choice-b,#select-choice-a,#select-choice-d").selectmenu("disable");
    }
    if (time4 != "0" && $("#Time").val() == "") {
        $("#Time").val(time4);
        $("#select-choice-b,#select-choice-c,#select-choice-a").selectmenu("disable");
    }

}