#pragma checksum "D:\AllProject\JobManage\JobManage.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c89a1cbdf5325b3ef2ba448fb3b7b1b97520f17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c89a1cbdf5325b3ef2ba448fb3b7b1b97520f17", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cc6235be068e7494e018c6199e963002269bb41", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "D:\AllProject\JobManage\JobManage.Web\Views\Home\Index.cshtml"
  
    Layout = "_LayoutHome";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""layui-layout layui-layout-admin"">
    <div class=""layui-header"">
        <div class=""layui-logo"" style=""color:#fff"">任务管理平台</div>
    </div>

    <div class=""layui-side layui-bg-black"">
        <div class=""layui-side-scroll"">
            <!-- 左侧导航区域（可配合layui已有的垂直导航） -->
            <ul class=""layui-nav layui-nav-tree"" lay-filter=""menus"" id=""menus"">
                <li class=""layui-nav-item"">
                    <a");
            BeginWriteAttribute("class", " class=\"", 462, "\"", 470, 0);
            EndWriteAttribute();
            WriteLiteral(@" href=""javascript:;"">任务管理</a>
                    <dl class=""layui-nav-child"">
                        <dd data-id=""job"" data-value=""定时任务"" data-src=""/job""><a href=""javascript:;"">定时任务</a></dd>
                        <dd data-id=""jobrunlog"" data-value=""执行日志"" data-src=""/jobrunlog""><a href=""javascript:;"">执行日志</a></dd>
                    </dl>
                </li>
            </ul>
        </div>
    </div>

    <div class=""layui-body"" style=""bottom:0px !important;"">
        <div class=""layui-tab layui-tab-brief"" id=""tabMenus"" lay-filter=""tabMenu"" style=""margin:0px"" lay-allowClose=""true"">
            <ul class=""layui-tab-title"">
                <li class=""layui-this"" lay-id=""job"">定时任务</li>
            </ul>

            <div class=""layui-tab-content"" style=""padding:0px !important;"">
                <div class=""layui-tab-item layui-show"">
                    <iframe id=""iframe_job"" framespacing=""0"" frameborder=""0"" scrolling=""auto"" style=""width: 100%; ""></iframe>
                </div>
            </div>
        ");
            WriteLiteral(@"</div>
    </div>
</div>

<script type=""text/javascript"">

    layui.use([""jquery"", ""element""], function () {
        var $ = layui.$;
        var element = layui.element;

        $(""#iframe_job"").attr(""src"", ""/job"");
        SetIframeHeight(""job"");

        //触发事件
        var active = {
            //在这里给active绑定几项事件，后面可通过active调用这些事件
            tabAdd: function (id, name) {
                element.tabAdd('tabMenu', {
                    title: name,
                    content: '',
                    id: id
                })
            },
            tabChange: function (id) {
                element.tabChange('tabMenu', id); //根据传入的id传入到指定的tab项
            },
            tabDelete: function (id) {
                element.tabDelete(""tabMenu"", id);//删除
            }
        };

        //菜单点击时间
        $(""#menus dd"").bind(""click"", function () {
            var dd = $(this);
            if ($(""#tabMenus li[lay-id='"" + dd.attr(""data-id"") + ""']"").length > 0) {
                active.tabChange(dd.attr(""data");
            WriteLiteral(@"-id""));
            }
            else {
                active.tabAdd(dd.attr(""data-id""), dd.attr(""data-value""));
                active.tabChange(dd.attr(""data-id""));
            }

            var src = dd.attr(""data-src"");
            var id = dd.attr(""data-id"");
            var iframeId = ""iframe_"" + id;
            var _html = '<iframe id=""' + iframeId + '"" src=""' + src + '"" framespacing=""0"" frameborder=""0"" scrolling=""auto"" style=""width: 100%; height: 100%;""></iframe>';
            $("".layui-tab-content .layui-show"").html(_html);

            SetIframeHeight(id);
        });

        //设置iframe高度
        function SetIframeHeight(id) {
            var h1 = document.documentElement.clientHeight - 110;
            document.getElementById(""iframe_"" + id).style.height = h1 + ""px"";
        }

        var isShow = true; //定义一个标志位
        $('.kit-side-fold').click(function () {
            //选择出所有的span，并判断是不是hidden
            $('.layui-nav-item span').each(function () {
                if ($(this).is(':hidden'");
            WriteLiteral(@")) {
                    $(this).show();
                } else {
                    $(this).hide();
                }
            });
            //判断isshow的状态
            if (isShow) {
                $('.layui-side.layui-bg-black').width(60); //设置宽度
                $('.kit-side-fold i').css('margin-right', '70%'); //修改图标的位置
                //将footer和body的宽度修改
                $('.layui-body').css('left', 60 + 'px');
                $('.layui-footer').css('left', 60 + 'px');
                //将二级导航栏隐藏
                $('dd span').each(function () {
                    $(this).hide();
                });
                //修改标志位
                isShow = false;
            } else {
                $('.layui-side.layui-bg-black').width(200);
                $('.kit-side-fold i').css('margin-right', '10%');
                $('.layui-body').css('left', 200 + 'px');
                $('.layui-footer').css('left', 200 + 'px');
                $('dd span').each(function () {
                    $(this).show();
      ");
            WriteLiteral("          });\n                isShow = true;\n            }\n        });\n\n    });\n\n</script>\n\n\n");
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
