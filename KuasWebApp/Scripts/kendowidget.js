$(document).ready(function () {

    $("#refresh").click(function () {
        location.reload();
    });


    var UrlBase = "/";
    $("#grid").kendoGrid({
        dataSource: {

            dataType: "jsonp",
            transport: {
                read: {
                    url: UrlBase + "api/Ticket",
                    contentType: "application/json; charset=utf-8",
                    type: "GET"
                },
                create: {
                    url: UrlBase + "api/Ticket",
                    contentType: "application/json; charset=utf-8",
                    type: "POST"
                },
                update: {
                    url: UrlBase + "api/Ticket",
                    contentType: "application/json; charset=utf-8",
                    type: "PUT"
                },
                destroy: {
                    url: UrlBase + "api/Ticket",
                    contentType: "application/json; charset=utf-8",
                    type: "DELETE"
                },
                parameterMap: function (data, operation) {
                    if (operation !== "read") {
                        return kendo.stringify(data);
                    }
                }
            },
            schema: {
                model: {
                    id: "Id",
                    fields: {
                       // Id: { type: "string", editable: true, nullable: false },
                        Name: { type: "string", editable: true, nullable: false },
                        Date: { type: "string", editable: true, nullable: false },
                        Time: { type: "string", editable: true, nullable: false },
                        Aboard: { type: "string", editable: true, nullable: false },
                        Getoff: { type: "string", editable: true, nullable: false },
                        Number: { type: "string", editable: true, nullable: false },
                        Phone: { type: "string", editable: true, nullable: false },
                        Quantity: { type: "string", editable: true },
                        Price: { type: "string", editable: true, nullable: false }
                    }
                }
            }

        },
        
        sortable: true,
        scrollable: false,
        sortable: true,
        filterable: false,

        editable: {
            confirmation: function (e) {
                return "確定刪除 " + "," + e.Name + "?";
            },
            mode: "inline"
        },
        toolbar: [{
            type: "button",
            name: "create",
            text: "新增"
        }],
        pageable: false,
        columns: [
         //   { field: "Id", title: "編號", width: "5px" },
            { field: "Name", title: "姓名", width: "40px" },
            { field: "Phone", title: "手機", width: "40px" },
            { field: "Date", title: "日期", width: "40px" },
            { field: "Time", title: "時間", width: "40px" },
            { field: "Aboard", title: "上車站", width: "40px" },
            { field: "Getoff", title: "下車站", width: "40px" },
            { field: "Number", title: "車次", width: "40px" },
            { field: "Quantity", title: "數量", width: "40px" },          
            { field: "Price", title: "價格", width: "40px" },

            {
                command: [{
                    title: "",
                    name: "edit",
                    text: {
                        edit: "修改",
                        update: "新增",
                        cancel: "取消",
                    }
                }, {
                    name: "destroy",
                    text: "刪除"
                }],
                width: "40px", title: "Command",
            },


        ]
    });

    $("#Customersearchsubmit").click(function () {
        var phone = $("#customerphone").val();

        $.ajax({
            url: "/api/Ticket/Name/" + phone,
            type: 'GET',
            data: {
            },
            dataType: 'json',
            success: function (data) {
                if (data == null) {
                    alert("找不到辣!");
                }
                else {
                    getkendoGrid();
                }

            },
            error: function () {
        
            }
        });

        function getkendoGrid() {
        $("#grid2").kendoGrid({
            dataSource: {
                dataType: "jsonp",
                transport: {
                    read: {
                        url: UrlBase + "api/Ticket/Name/" + phone,
                        contentType: "application/json; charset=utf-8",
                        type: "GET"
                    },
                    parameterMap: function (data, operation) {
                        if (operation !== "read") {
                            return kendo.stringify(data);
                        }
                    }
                },
                schema: {
                    model: {
                        id: "Id",
                        fields: {
                   //         Id: { type: "string", editable: true, nullable: false },
                            Name: { type: "string", editable: true, nullable: false },
                            Phone: { type: "string", editable: true, nullable: false },
                            Quantity: { type: "string", editable: true },
                            Date: { type: "string", editable: true, nullable: false },
                            Time: { type: "string", editable: true, nullable: false },
                            Aboard: { type: "string", editable: true, nullable: false },
                            Getoff: { type: "string", editable: true, nullable: false },
                            Number: { type: "string", editable: true, nullable: false },                         
                            Price: { type: "string", editable: true, nullable: false }
                        }
                    }
                }

            },
            height: 300,
            sortable: true,
            scrollable: false,
            columns: [
            //    { field: "Id", title: "編號", width: "5px" },
                { field: "Name", title: "姓名", width: "40px" },
                { field: "Date", title: "日期", width: "40px" },
                { field: "Time", title: "時間", width: "40px" },
                { field: "Aboard", title: "上車站", width: "40px" },
                { field: "Getoff", title: "下車站", width: "40px" },
                { field: "Number", title: "車次", width: "40px" },
                { field: "Quantity", title: "數量", width: "40px" },
                { field: "Phone", title: "手機", width: "40px" },
                { field: "Price", title: "價格", width: "40px" },


            ]
            });
            window.location = "../Views/Index.html#Customersearch";
        }




    });
   

});