﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    
    #line 2 "..\..\Areas\Admin\Views\User\Info.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Net;
    
    #line 3 "..\..\Areas\Admin\Views\User\Info.cshtml"
    using System.Reflection;
    
    #line default
    #line hidden
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
    using NewLife;
    using NewLife.Cube;
    
    #line 6 "..\..\Areas\Admin\Views\User\Info.cshtml"
    using NewLife.Cube.Entity;
    
    #line default
    #line hidden
    using NewLife.Reflection;
    using NewLife.Web;
    
    #line 4 "..\..\Areas\Admin\Views\User\Info.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\Admin\Views\User\Info.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/User/Info.cshtml")]
    public partial class _Areas_Admin_Views_User_Info_cshtml : System.Web.Mvc.WebViewPage<XCode.Membership.IUser>
    {
        public _Areas_Admin_Views_User_Info_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 7 "..\..\Areas\Admin\Views\User\Info.cshtml"
  
    var fact = EntityFactory.CreateOperate(ViewData.ModelMetadata.ModelType);
    var user = Model as IUser;

    var ms = NewLife.Web.OAuthConfig.Current.Items.Where(e => !e.AppID.IsNullOrEmpty()).ToList();
    var binds = ViewBag.Binds as IList<UserConnect>;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n");

            
            #line 17 "..\..\Areas\Admin\Views\User\Info.cshtml"
            
            
            #line default
            #line hidden
            
            #line 17 "..\..\Areas\Admin\Views\User\Info.cshtml"
             if (ViewBag.StatusMessage != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"alert alert-success alert-dismissible text-center\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close\"");

WriteLiteral(" data-dismiss=\"alert\"");

WriteLiteral(" aria-label=\"Close\"");

WriteLiteral("><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&times;</span></button>\r\n                    <strong>");

            
            #line 21 "..\..\Areas\Admin\Views\User\Info.cshtml"
                       Write(ViewBag.StatusMessage);

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n                </div>\r\n");

            
            #line 23 "..\..\Areas\Admin\Views\User\Info.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 24 "..\..\Areas\Admin\Views\User\Info.cshtml"
             using (Html.BeginForm("Info", null, new { id = Model[fact.Unique.Name] }))
            {
                
            
            #line default
            #line hidden
            
            #line 26 "..\..\Areas\Admin\Views\User\Info.cshtml"
           Write(Html.ValidationSummary());

            
            #line default
            #line hidden
            
            #line 26 "..\..\Areas\Admin\Views\User\Info.cshtml"
                                         

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n\r\n                    <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">名称</label>\r\n                    <div");

WriteLiteral(" class=\"input-group col-md-6\"");

WriteLiteral(">\r\n                        <input");

WriteAttribute("value", Tuple.Create(" value=\"", 1259), Tuple.Create("\"", 1277)
            
            #line 31 "..\..\Areas\Admin\Views\User\Info.cshtml"
, Tuple.Create(Tuple.Create("", 1267), Tuple.Create<System.Object, System.Int32>(user.Name
            
            #line default
            #line hidden
, 1267), false)
);

WriteLiteral(" class=\"col-xs-12 col-sm-8 col-md-6 col-lg-4\"");

WriteLiteral(" disabled=\"disabled\"");

WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">密码</label>\r\n                    <div");

WriteLiteral(" class=\"input-group col-md-6\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 37 "..\..\Areas\Admin\Views\User\Info.cshtml"
                   Write(Html.ForEditor("Password"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">显示名</label>\r\n                    <div");

WriteLiteral(" class=\"input-group col-md-6\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 43 "..\..\Areas\Admin\Views\User\Info.cshtml"
                   Write(Html.ForEditor("DisplayName"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 44 "..\..\Areas\Admin\Views\User\Info.cshtml"
                   Write(Html.ForDescription("DisplayName"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">性别</label>\r\n                    <div");

WriteLiteral(" class=\"input-group col-md-6\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 50 "..\..\Areas\Admin\Views\User\Info.cshtml"
                   Write(Html.ForEditor("Sex", user.Sex));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 51 "..\..\Areas\Admin\Views\User\Info.cshtml"
                   Write(Html.ForDescription("Sex"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">邮件</label>\r\n                    <div");

WriteLiteral(" class=\"input-group col-md-6\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 57 "..\..\Areas\Admin\Views\User\Info.cshtml"
                   Write(Html.ForEditor("Mail"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">手机</label>\r\n                    <div");

WriteLiteral(" class=\"input-group col-md-6\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 63 "..\..\Areas\Admin\Views\User\Info.cshtml"
                   Write(Html.ForEditor("Mobile"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">代码</label>\r\n                    <div");

WriteLiteral(" class=\"input-group col-md-6\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 69 "..\..\Areas\Admin\Views\User\Info.cshtml"
                   Write(Html.ForEditor("Code"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 70 "..\..\Areas\Admin\Views\User\Info.cshtml"
                   Write(Html.ForDescription("Code"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">角色</label>\r\n                    <div");

WriteLiteral(" class=\"input-group col-md-2\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 76 "..\..\Areas\Admin\Views\User\Info.cshtml"
                   Write(user.RoleName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">登录次数</label>\r\n                    <div");

WriteLiteral(" class=\"input-group col-md-2\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 82 "..\..\Areas\Admin\Views\User\Info.cshtml"
                   Write(user.Logins);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">最后登录</label>\r\n                    <div");

WriteLiteral(" class=\"input-group col-md-2\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 88 "..\..\Areas\Admin\Views\User\Info.cshtml"
                   Write(user.LastLogin.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">最后登录IP</label>\r\n                    <div");

WriteLiteral(" class=\"input-group col-md-6\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 94 "..\..\Areas\Admin\Views\User\Info.cshtml"
                   Write(user.LastLoginIP);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");

            
            #line 97 "..\..\Areas\Admin\Views\User\Info.cshtml"
                if (ms.Count > 0)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">第三方绑定</label>\r\n                        <div");

WriteLiteral(" class=\"input-group col-md-6\"");

WriteLiteral(">\r\n                            <ul>\r\n");

            
            #line 103 "..\..\Areas\Admin\Views\User\Info.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 103 "..\..\Areas\Admin\Views\User\Info.cshtml"
                                 foreach (var mi in ms)
                                {
                                    var uc = binds.FirstOrDefault(e => e.Enable && e.Provider.EqualIgnoreCase(mi.Name));
                                    if (uc != null)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <li>\r\n                                   " +
"         <span>");

            
            #line 109 "..\..\Areas\Admin\Views\User\Info.cshtml"
                                             Write(mi.Name);

            
            #line default
            #line hidden
WriteLiteral("（已绑定）</span> \r\n                                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5014), Tuple.Create("\"", 5042)
, Tuple.Create(Tuple.Create("", 5021), Tuple.Create<System.Object, System.Int32>(Href("~/Sso/UnBind/")
, 5021), false)
            
            #line 110 "..\..\Areas\Admin\Views\User\Info.cshtml"
, Tuple.Create(Tuple.Create("", 5034), Tuple.Create<System.Object, System.Int32>(mi.Name
            
            #line default
            #line hidden
, 5034), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 5043), Tuple.Create("\"", 5064)
, Tuple.Create(Tuple.Create("", 5051), Tuple.Create("取消绑定", 5051), true)
            
            #line 110 "..\..\Areas\Admin\Views\User\Info.cshtml"
       , Tuple.Create(Tuple.Create(" ", 5055), Tuple.Create<System.Object, System.Int32>(mi.Name
            
            #line default
            #line hidden
, 5056), false)
);

WriteLiteral(">取消绑定</a>\r\n                                        </li>\r\n");

            
            #line 112 "..\..\Areas\Admin\Views\User\Info.cshtml"
                                    }
                                    else
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <li>\r\n                                   " +
"         <span>");

            
            #line 116 "..\..\Areas\Admin\Views\User\Info.cshtml"
                                             Write(mi.Name);

            
            #line default
            #line hidden
WriteLiteral("（未绑定）</span>\r\n                                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5407), Tuple.Create("\"", 5433)
, Tuple.Create(Tuple.Create("", 5414), Tuple.Create<System.Object, System.Int32>(Href("~/Sso/Bind/")
, 5414), false)
            
            #line 117 "..\..\Areas\Admin\Views\User\Info.cshtml"
, Tuple.Create(Tuple.Create("", 5425), Tuple.Create<System.Object, System.Int32>(mi.Name
            
            #line default
            #line hidden
, 5425), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 5434), Tuple.Create("\"", 5453)
, Tuple.Create(Tuple.Create("", 5442), Tuple.Create("绑定", 5442), true)
            
            #line 117 "..\..\Areas\Admin\Views\User\Info.cshtml"
   , Tuple.Create(Tuple.Create(" ", 5444), Tuple.Create<System.Object, System.Int32>(mi.Name
            
            #line default
            #line hidden
, 5445), false)
);

WriteLiteral(">去绑定</a>\r\n                                        </li>\r\n");

            
            #line 119 "..\..\Areas\Admin\Views\User\Info.cshtml"
                                    }
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </ul>\r\n                        </div>\r\n              " +
"      </div>\r\n");

            
            #line 124 "..\..\Areas\Admin\Views\User\Info.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"clearfix form-actions\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"control-label col-md-4\"");

WriteLiteral("></label>\r\n                    <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-success btn-sm\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-save\"");

WriteLiteral(" )\"></i><strong>保存</strong></button>\r\n                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-danger btn-sm\"");

WriteLiteral(" onclick=\"history.go(-1);\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-remove\"");

WriteLiteral("></i><strong>取消</strong></button>\r\n                </div>\r\n");

            
            #line 130 "..\..\Areas\Admin\Views\User\Info.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
