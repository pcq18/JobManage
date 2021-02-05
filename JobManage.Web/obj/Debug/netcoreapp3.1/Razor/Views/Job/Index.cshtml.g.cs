#pragma checksum "D:\AllProject\JobManage\JobManage.Web\Views\Job\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27765d827f84d4098b1470ba1026512f9d84a088"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_Index), @"mvc.1.0.view", @"/Views/Job/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\AllProject\JobManage\JobManage.Web\Views\_ViewImports.cshtml"
using JobManage.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AllProject\JobManage\JobManage.Web\Views\_ViewImports.cshtml"
using JobManage.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27765d827f84d4098b1470ba1026512f9d84a088", @"/Views/Job/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cc6235be068e7494e018c6199e963002269bb41", @"/Views/_ViewImports.cshtml")]
    public class Views_Job_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""layui-list-tool"">
    <span id=""add""><i class=""layui-icon layui-icon-add-1""></i>新增</span>
</div>
<div class=""layui-list-search"">
    <div class=""layui-form"">
        <div class=""layui-inline"">
            <label class=""layui-form-label"">关键字</label>
            <div class=""layui-input-inline"">
                <input type=""text"" id=""searchValue"" placeholder=""请输入描述"" class=""layui-input"">
            </div>
        </div>
        <div class=""layui-inline"">
            <div class=""layui-input-inline"" style=""width:95px"">
                <button class=""layui-btn layui-btn-sm search-btn"" id=""searchBtn"">查  询</button>
            </div>
        </div>
    </div>
</div>
<div>
    <table class=""layui-table"" id=""tableId"" lay-filter=""tableFilter""></table>
</div>

<script type=""text/html"" id=""tableBar"">
    {{#  if(d.Status == '2'){ }}
    <a class=""layui-btn layui-btn-xs"" lay-event=""pause"">暂停</a>
    <a class=""layui-btn layui-btn-xs"" lay-event=""delete"">删除</a>
    {{#  } else if(d.Status == '4') { }}
    <a class");
            WriteLiteral(@"=""layui-btn layui-btn-xs"" lay-event=""recover"">恢复</a>
    <a class=""layui-btn layui-btn-xs"" lay-event=""delete"">删除</a>
    {{#  } else if(d.Status == '7') { }}

    {{#  } else {}}
    后台处理中
    {{#  } }}
</script>

<script type=""text/html"" id=""statusBar"">
    {{#  if(d.Status == '1'){ }}
    待执行
    {{#  } else if(d.Status == '2') { }}
    执行中
    {{#  } else if(d.Status == '3') { }}
    待暂停
    {{#  } else if(d.Status == '4') { }}
    已暂停
    {{#  } else if(d.Status == '5') { }}
    待恢复
    {{#  } else if(d.Status == '6') { }}
    待删除
    {{#  } else if(d.Status == '7') { }}
    已删除
    {{#  } }}
</script>

<script type=""text/javascript"">

    layui.use([""jquery"", ""element"", ""form"", ""table""], function () {
        var element = layui.element;
        var layer = layui.layer;
        var form = layui.form;
        var $ = layui.$;
        var table = layui.table;
        form.render();

        var InitData = function () {
            table.render({
                elem: '#tableId',
                cols: [[
  ");
            WriteLiteral(@"                  { field: 'Group', title: '分组', align: 'left', width: 80 },
                    { field: 'Name', title: '名称', align: 'left', width: 200 },
                    { field: 'CronExpression', title: '执行规则', align: 'center', width: 120 },
                    { field: 'Description', title: '描述', align: 'left', width: 300 },
                    { field: 'RequestUrl', title: '请求Url', align: 'left', width: 200 },
                    { title: '当前状态', align: 'center', width: 100, templet: '#statusBar' },
                    { field: 'NextOpTime', title: '下次执行时间', align: 'center', width: 180 },
                    { field: 'LastOpTime', title: '最后执行时间', align: 'center', width: 180 },
                    { field: 'CreateTime', title: '创建时间', align: 'center', width: 180 },
                    { fixed: 'right', align: 'center', width: 150, toolbar: '#tableBar' }
                ]
                ],
                url: '/job/list',
                where: { SearchValue: $(""#searchValue"").val() },
             ");
            WriteLiteral(@"   method: 'get',
                request: {
                    pageName: 'PageIndex',
                    limitName: 'PageSize'
                },
                response: {
                    statusName: 'statusCode',
                    statusCode: 10000,
                    msgName: 'msg',
                    countName: 'exted',
                    dataName: 'data'
                },
                text: {
                    none: '暂无相关数据'
                },
                page: true,
                limit: 10,
                limits: [10, 15, 25],
            });

            table.on('tool(tableFilter)', function (obj) {
                var data = obj.data;
                var layEvent = obj.event;

                var status = """";
                var opType = """";
                if (layEvent === 'pause') {
                    status = ""3"";
                    opType = ""暂停"";
                }
                else if (layEvent === 'recover') {
                    status = ""5"";
                    o");
            WriteLiteral(@"pType = ""恢复"";
                }
                else if (layEvent === 'delete') {
                    status = ""6"";
                    opType = ""删除"";
                }

                var tips = ""确定要"" + opType + ""该任务？"";
                layer.confirm(tips, function () {
                    JobUpdateStatus(data.Id, status);
                });

            });
        }

        InitData();

        $(""#searchBtn"").click(function () {
            InitData();
        });

        $(""#add"").click(function () {
            $.get(""/job/add"", function (data) {
                layer.open({
                    type: 1,
                    title: '添加任务',
                    area: ['400px', '450px'],
                    shade: 0.6,
                    id: 'jobAddDialog',
                    btn: ['确认', '取消'],
                    btnAlign: 'r',
                    moveType: 1,
                    content: data,
                    yes: function (index) {
                        JobAdd();
                        layer.c");
            WriteLiteral(@"lose(index);
                    }
                });
                form.render();
            });
        });

        var JobAdd = function () {
            $.ajax({
                type: ""post"",
                url: ""/job/add"",
                data: { Group: $(""#groupAdd"").val(), Name: $(""#nameAdd"").val(), CronExpression: $(""#cronExpressionAdd"").val(), Description: $(""#descriptionAdd"").val(), RequestUrl: $(""#requestUrlAdd"").val() },
                dataType: ""json"",
                success: function (jdata) {
                    if (jdata.succ) {
                        location.reload();
                        layer.msg(jdata.msg);
                    }
                    else {
                        layer.msg(jdata.msg);
                    }
                },
                error: function (txtStatus) {
                    alert(txtStatus);
                }
            });
        };

        var JobUpdateStatus = function (id, status) {
            $.ajax({
                type: ""post"",
     ");
            WriteLiteral(@"           url: ""/job/updatestatus"",
                data: { id: id, status: status },
                dataType: ""json"",
                success: function (jdata) {
                    if (jdata.succ) {
                        location.reload();
                        layer.msg(jdata.msg);
                    }
                    else {
                        layer.msg(jdata.msg);
                    }
                },
                error: function (txtStatus) {
                    alert(txtStatus);
                }
            });
        };

    });

</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
