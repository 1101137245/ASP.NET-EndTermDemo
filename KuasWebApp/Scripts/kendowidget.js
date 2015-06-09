﻿$(document).ready(function () {
    var UrlBase = "/";
    $("#grid").kendoGrid({
        dataSource: {

            dataType: "jsonp",
            transport: {
                read: {
                    url: UrlBase + "api/Course",
                    contentType: "application/json; charset=utf-8",
                    type: "GET"
                },
                create: {
                    url: UrlBase + "api/Course",
                    contentType: "application/json; charset=utf-8",
                    type: "POST"
                },
                update: {
                    url: UrlBase + "api/Course",
                    contentType: "application/json; charset=utf-8",
                    type: "PUT"
                },
                destroy: {
                    url: UrlBase + "api/Course",
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
                        Id: { type: "string", editable: true, nullable: false },
                        Name: { type: "string", editable: true, nullable: false },
                        Description: { type: "string", editable: true },
                        Date: { type: "string", editable: true, nullable: false },
                        Time: { type: "string", editable: true, nullable: false },
                        Aboard: { type: "string", editable: true, nullable: false },
                        Getoff: { type: "string", editable: true, nullable: false },
                        Number: { type: "string", editable: true, nullable: false },
                        Site: { type: "string", editable: true, nullable: false },
                        Price: { type: "string", editable: true, nullable: false }
                    }
                }
            }

        },
        height: 400,
        sortable: true,
        scrollable: false,
        sortable: true,
        filterable: false,

        editable: {
            confirmation: function (e) {
                return "確定刪除編號 " + e.Id + "," + e.Name + "?";
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
            { field: "Id", title: "編號", width: "5px" },
            { field: "Name", title: "姓名", width: "40px" },
            { field: "Date", title: "日期", width: "40px" },
            { field: "Time", title: "時間", width: "40px" },
            { field: "Aboard", title: "上車站", width: "40px" },
            { field: "Getoff", title: "下車站", width: "40px" },
            { field: "Number", title: "車次", width: "40px" },
            { field: "Description", title: "數量", width: "40px" },
            { field: "Site", title: "座位", width: "40px" },
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

});