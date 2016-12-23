﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.WebsiteBuilder;
    using MixERP.Inventory;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Setup/ItemVariants.cshtml")]
    public partial class _Views_Setup_ItemVariants_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Setup_ItemVariants_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Setup\ItemVariants.cshtml"
  
    ViewBag.Title = "";
    Layout = ViewBag.InventoryLayoutPath;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"ui attached very relaxed padded segment\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"item variant container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui huge grey header\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" id=\"heading\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" data-localize=\"Titles.ItemVariants\"");

WriteLiteral("></span>\r\n            </span>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"ui divider\"");

WriteLiteral("></div>\r\n\r\n        <div");

WriteLiteral(" class=\"ui form\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"four fields\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" data-localize=\"Titles.SelectItem\"");

WriteLiteral("></label>\r\n                    <select");

WriteLiteral(" id=\"ItemSelect\"");

WriteLiteral(" class=\"ui search dropdown\"");

WriteLiteral("></select>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" data-localize=\"Titles.SelectVariant\"");

WriteLiteral("></label>\r\n                    <select");

WriteLiteral(" id=\"VariantSelect\"");

WriteLiteral(" class=\"ui search dropdown\"");

WriteLiteral("></select>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                    <label>&nbsp;</label>\r\n                    <input");

WriteLiteral(" type=\"button\"");

WriteLiteral(" id=\"ShowButton\"");

WriteLiteral(" class=\"ui basic button\"");

WriteLiteral(" data-localize=\"Titles.Show\"");

WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <table" +
"");

WriteLiteral(" id=\"variant-table\"");

WriteLiteral(" class=\"ui small compact stackable form table\"");

WriteLiteral(">\r\n            <thead>\r\n                <tr>\r\n                    <th");

WriteLiteral(" style=\"width: 300px;\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" data-localize=\"Titles.Attribute\"");

WriteLiteral("></span>\r\n                    </th>\r\n                    <th");

WriteLiteral(" style=\"width: 300px;\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" data-localize=\"Titles.Variant\"");

WriteLiteral("></span>\r\n                    </th>\r\n                    <th></th>\r\n             " +
"   </tr>\r\n            </thead>\r\n            <tbody></tbody>\r\n            <tfoot>" +
"\r\n                <tr>\r\n                    <th>\r\n                        <input" +
"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"ItemCodeInputText\"");

WriteLiteral(" maxlength=\"12\"");

WriteLiteral(" data-localized-placeholder=\"Titles.ItemCode\"");

WriteLiteral(" />\r\n                    </th>\r\n                    <th>\r\n                       " +
" <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"ItemNameInputText\"");

WriteLiteral(" maxlength=\"100\"");

WriteLiteral(" data-localized-placeholder=\"Titles.ItemName\"");

WriteLiteral(" />\r\n                    </th>\r\n                </tr>\r\n                <tr>\r\n    " +
"                <th");

WriteLiteral(" colspan=\"2\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"ui basic blue add button\"");

WriteLiteral(" data-localize=\"Titles.Add\"");

WriteLiteral(" onclick=\"addRow();\"");

WriteLiteral(" />\r\n                        <div");

WriteLiteral(" class=\"ui basic buttons\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"ui save button\"");

WriteLiteral(" id=\"SaveButton\"");

WriteLiteral(" data-localize=\"Titles.Save\"");

WriteLiteral(" />\r\n                            <input");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"ui save button\"");

WriteLiteral(" id=\"DeleteButton\"");

WriteLiteral(" data-localize=\"Titles.Delete\"");

WriteLiteral(" />\r\n                        </div>\r\n                    </th>\r\n                <" +
"/tr>\r\n            </tfoot>\r\n        </table>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n<script>" +
"\r\n    var attributes;\r\n    var variants;\r\n    var rowTemplate =\r\n    `<tr>\r\n    " +
"    <td>\r\n            <select class=\"ui search attribute fluid dropdown\">{attrib" +
"utes}</select>\r\n        </td>\r\n        <td>\r\n            <select class=\"ui searc" +
"h variant fluid dropdown\"></select>\r\n        </td>\r\n        <td>\r\n            <d" +
"iv class=\"ui basic buttons\">\r\n                <input type=\"button\" class=\"ui bas" +
"ic delete button\" value=\"Delete\" />\r\n            </div>\r\n        </td>\r\n    </tr" +
">`;\r\n\r\n\r\n\r\n    function bindItems() {\r\n        const url = \"/api/forms/inventory" +
"/items/display-fields\";\r\n        const target = $(\"#ItemSelect\");\r\n        windo" +
"w.ajaxDataBind(url, target, null, null, null, null, \"Key\", \"Value\");\r\n    };\r\n\r\n" +
"    function getAttributes() {\r\n        function request() {\r\n            const " +
"url = \"/api/forms/inventory/attributes/all\";\r\n            return window.getAjaxR" +
"equest(url);\r\n        };\r\n\r\n        const ajax = request();\r\n\r\n        ajax.succ" +
"ess(function (response) {\r\n            attributes = response;\r\n        });\r\n    " +
"};\r\n\r\n    function getVariants() {\r\n        function request() {\r\n            co" +
"nst url = \"/api/forms/inventory/variants/all\";\r\n            return window.getAja" +
"xRequest(url);\r\n        };\r\n\r\n        const ajax = request();\r\n\r\n        ajax.su" +
"ccess(function (response) {\r\n            variants = response;\r\n        });\r\n    " +
"};\r\n\r\n\r\n    $(document).ready(function () {\r\n        bindItems();\r\n        getAt" +
"tributes();\r\n        getVariants();\r\n\r\n        $(\"#ItemSelect\").change(function " +
"() {\r\n            const el = $(this);\r\n            var heading = \"Item Variants\"" +
";\r\n            heading += \" : \" + el.getSelectedText();\r\n\r\n            $(\"#headi" +
"ng\").html(heading);\r\n        });\r\n    });\r\n\r\n    $(\"#ItemSelect\").change(functio" +
"n () {\r\n        function request(itemId) {\r\n            const url = \"/api/forms/" +
"inventory/items/get-where/-1\";\r\n\r\n            const filters = [];\r\n            f" +
"ilters.push(window.getAjaxColumnFilter(\"WHERE\", \"is_variant_of\", \"int\", window.F" +
"ilterConditions.IsEqualTo, itemId));\r\n            const data = JSON.stringify(fi" +
"lters);\r\n\r\n            return window.getAjaxRequest(url, \"POST\", data);\r\n       " +
" };\r\n\r\n        const itemId = $(this).val();\r\n        var target = $(\"#VariantSe" +
"lect\");\r\n        target.dropdown(\"set selected\", \"\");\r\n        target.html(\"\");\r" +
"\n\r\n        if (!itemId) {\r\n            return;\r\n        };\r\n\r\n        const ajax" +
" = request(itemId);\r\n\r\n        ajax.success(function (response) {\r\n            c" +
"onst placeholder = response.length ? \"Select\" : \"None\";\r\n            window.appe" +
"ndOption(target, \"\", placeholder);\r\n\r\n            $.each(response, function () {" +
"\r\n                const key = this[\"ItemId\"];\r\n                const value = thi" +
"s[\"ItemCode\"] + \" (\" + this[\"ItemName\"] + \")\";\r\n                window.appendOpt" +
"ion(target, key, value);\r\n            });\r\n        });\r\n    });\r\n\r\n    function " +
"addRow(attributeId, variantId) {\r\n        function getAttributes() {\r\n          " +
"  var attributeOptions = \"<option val=\'\'>\" + \"Select\" + \"</option>\";\r\n\r\n        " +
"    $.each(attributes, function () {\r\n                attributeOptions += \"<opti" +
"on value=\'\";\r\n                attributeOptions += this.AttributeId;\r\n           " +
"     attributeOptions += \"\'\";\r\n\r\n                if (this.AttributeId === attrib" +
"uteId) {\r\n                    attributeOptions += \" selected\";\r\n                " +
"};\r\n\r\n                attributeOptions += \">\";\r\n                attributeOptions" +
" += this.AttributeCode;\r\n                attributeOptions += \" (\";\r\n            " +
"    attributeOptions += this.AttributeName;\r\n                attributeOptions +=" +
" \")\";\r\n                attributeOptions += \"</option>\";\r\n            });\r\n      " +
"      return attributeOptions;\r\n        };\r\n\r\n        function appendVariants(ta" +
"rget, attributeId, variantId) {\r\n            target.dropdown(\"set selected\", \"\")" +
";\r\n            target.html(\"\");\r\n\r\n            const filtered = window.Enumerabl" +
"e.From(variants).Where(function (x) { return x.AttributeId.toString() === attrib" +
"uteId.toString() }).ToArray();\r\n\r\n            window.appendOption(target, \"\", \"S" +
"elect\");\r\n\r\n            $.each(filtered, function () {\r\n                window.a" +
"ppendOption(target, this.VariantId, this.VariantName);\r\n            });\r\n\r\n     " +
"       if (variantId) {\r\n                setTimeout(function () {\r\n             " +
"       target.dropdown(\"set selected\", variantId);\r\n                }, 1);\r\n    " +
"        };\r\n        };\r\n\r\n        var row = $(rowTemplate.replace(\"{attributes}\"" +
", getAttributes()));\r\n\r\n        $(\"#variant-table tbody\").append(row);\r\n        " +
"window.initalizeDropdowns();\r\n\r\n        row.find(\".attribute select\").change(fun" +
"ction () {\r\n            const el = $(this);\r\n            const target = row.find" +
"(\".variant select\");\r\n            const val = el.val();\r\n\r\n            appendVar" +
"iants(target, val);\r\n        });\r\n\r\n        if (variantId) {\r\n            var ta" +
"rget = row.find(\".variant select\");\r\n            setTimeout(function () {\r\n     " +
"           appendVariants(target, attributeId, variantId);\r\n            }, 1);\r\n" +
"        };\r\n\r\n        $(\"input.delete.button\").unbind().click(function () {\r\n   " +
"         const confirmed = window.confirmAction();\r\n            if (confirmed) {" +
"\r\n                $(this).closest(\"tr\").remove();\r\n            };\r\n        });\r\n" +
"    };\r\n\r\n    function showItem(variantItemId) {\r\n        function request(itemI" +
"d) {\r\n            const url = \"/api/forms/inventory/items/\" + itemId;\r\n         " +
"   return window.getAjaxRequest(url);\r\n        };\r\n\r\n        const ajax = reques" +
"t(variantItemId);\r\n        ajax.success(function (response) {\r\n            $(\"#I" +
"temCodeInputText\").val(response.ItemCode);\r\n            $(\"#ItemNameInputText\")." +
"val(response.ItemName);\r\n        });\r\n    };\r\n\r\n    function cleanUp() {\r\n      " +
"  $(\"#variant-table tbody\").html(\"\");\r\n        $(\"#ItemCodeInputText\").val(\"\");\r" +
"\n        $(\"#ItemNameInputText\").val(\"\");\r\n    };\r\n\r\n    $(\"#ShowButton\").click(" +
"function () {\r\n        function request(variantItemId) {\r\n            const url " +
"= \"/api/forms/inventory/item-variants/get-where/-1\";\r\n            const filters " +
"= [];\r\n            filters.push(window.getAjaxColumnFilter(\"WHERE\", \"item_id\", \"" +
"int\", window.FilterConditions.IsEqualTo, variantItemId));\r\n            const dat" +
"a = JSON.stringify(filters);\r\n\r\n            return window.getAjaxRequest(url, \"P" +
"OST\", data);\r\n        };\r\n\r\n        cleanUp();\r\n\r\n        const variantItemId = " +
"$(\"#VariantSelect\").val();\r\n        if (!variantItemId) {\r\n            return;\r\n" +
"        };\r\n\r\n        showItem(variantItemId);\r\n        const ajax = request(var" +
"iantItemId);\r\n\r\n        ajax.success(function (response) {\r\n            $.each(r" +
"esponse, function () {\r\n                var variantId = this.VariantId;\r\n       " +
"         const attributeId = window.Enumerable.From(variants).Where(function (x)" +
" { return x.VariantId === variantId }).FirstOrDefault().AttributeId;\r\n          " +
"      addRow(attributeId, variantId);\r\n            });\r\n        });\r\n    });\r\n\r\n" +
"    $(\"#SaveButton\").click(function () {\r\n        function request(model) {\r\n   " +
"         const url = \"/dashboard/inventory/setup/item-variants\";\r\n            co" +
"nst data = JSON.stringify(model);\r\n\r\n            return window.getAjaxRequest(ur" +
"l, \"POST\", data);\r\n        };\r\n\r\n        function getDuplicates(items) {\r\n      " +
"      const unique = [];\r\n\r\n            for (var i = 0, len = items.length; i < " +
"len; i++) {\r\n                const item = items[i];\r\n\r\n                if (uniqu" +
"e.indexOf(item) > -1) {\r\n                    return item;\r\n                };\r\n\r" +
"\n                unique.push(item);\r\n            }\r\n\r\n            return null;\r\n" +
"        };\r\n\r\n\r\n\r\n        const attributeIds = $(\".attribute>select\").map(functi" +
"on () { return window.parseInt($(this).val()); }).get();\r\n        const variantI" +
"ds = $(\".variant>select\").map(function () { return window.parseInt($(this).val()" +
"); }).get();\r\n        const itemCode = $(\"#ItemCodeInputText\").val();\r\n        c" +
"onst itemName = $(\"#ItemNameInputText\").val();\r\n\r\n        window.removeDirty($(\"" +
"#ItemCodeInputText\"));\r\n        window.removeDirty($(\"#ItemNameInputText\"));\r\n\r\n" +
"\r\n        if (!attributeIds.length) {\r\n            window.displayMessage(\"Please" +
" select an attribute.\");\r\n            return;\r\n        };\r\n\r\n        if (!itemCo" +
"de) {\r\n            window.displayMessage(\"Please enter a code of the new item va" +
"riant.\");\r\n            window.makeDirty($(\"#ItemCodeInputText\"));\r\n            r" +
"eturn;\r\n        };\r\n\r\n\r\n        if (!itemName) {\r\n            window.displayMess" +
"age(\"Please enter a name for the new item variant.\");\r\n            window.makeDi" +
"rty($(\"#ItemNameInputText\"));\r\n            return;\r\n        };\r\n\r\n\r\n        var " +
"duplicate = getDuplicates(attributeIds);\r\n\r\n        if (duplicate) {\r\n          " +
"  const item = window.Enumerable.From(attributes).Where(function (x) { return x." +
"AttributeId.toString() === duplicate }).FirstOrDefault().AttributeName;\r\n\r\n     " +
"       window.displayMessage(window.stringFormat(\"Cannot create this item becaus" +
"e you must specify a single variant of \\\"{0}\\\" attribute.\", item));\r\n           " +
" return;\r\n        };\r\n\r\n        const model = {\r\n            VariantOf: $(\"#Item" +
"Select\").val(),\r\n            ItemId: $(\"#VariantSelect\").val() || null,\r\n       " +
"     ItemCode: itemCode,\r\n            ItemName: itemName,\r\n            Variants:" +
" variantIds,\r\n            UserId: window.userId\r\n        };\r\n\r\n\r\n        const a" +
"jax = request(model);\r\n\r\n        ajax.success(function () {\r\n            window." +
"displaySuccess();\r\n        });\r\n    });\r\n\r\n    $(\"#DeleteButton\").click(function" +
" () {\r\n        function request(itemId) {\r\n            var url = \"/dashboard/inv" +
"entory/setup/item-variants/{itemId}\";\r\n            url = url.replace(\"{itemId}\"," +
" itemId);\r\n\r\n            return window.getAjaxRequest(url, \"DELETE\");\r\n        }" +
";\r\n\r\n        const confirmed = window.confirmAction();\r\n\r\n        if (!confirmed" +
") {\r\n            return;\r\n        };\r\n\r\n        const variantItemId = $(\"#Varian" +
"tSelect\").val();\r\n\r\n        if (variantItemId) {\r\n            const ajax = reque" +
"st(variantItemId);\r\n\r\n            ajax.success(function () {\r\n                cl" +
"eanUp();\r\n                $(\"#ItemSelect\").trigger(\"change\");\r\n                w" +
"indow.displaySuccess();\r\n            });\r\n        };\r\n    });\r\n\r\n    window.loca" +
"lize();\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591