#pragma checksum "C:\Users\UThandapani\source\repos\ToDoList\ToDoList\Views\ToDo\Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "becca69d3bd14c7be35b5102cdb624d4d9deaf6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDo_Read), @"mvc.1.0.view", @"/Views/ToDo/Read.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ToDo/Read.cshtml", typeof(AspNetCore.Views_ToDo_Read))]
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
#line 1 "C:\Users\UThandapani\source\repos\ToDoList\ToDoList\Views\_ViewImports.cshtml"
using ToDoList;

#line default
#line hidden
#line 1 "C:\Users\UThandapani\source\repos\ToDoList\ToDoList\Views\ToDo\Read.cshtml"
using ToDoList.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"becca69d3bd14c7be35b5102cdb624d4d9deaf6d", @"/Views/ToDo/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57829472ded1cf7bde1d515ed88d0e9bc5d97088", @"/Views/_ViewImports.cshtml")]
    public class Views_ToDo_Read : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ToDoList.Models.ToDoModel>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\UThandapani\source\repos\ToDoList\ToDoList\Views\ToDo\Read.cshtml"
  
    ViewBag.Title = "Read";


#line default
#line hidden
            BeginContext(104, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(131, 685, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "becca69d3bd14c7be35b5102cdb624d4d9deaf6d3605", async() => {
                BeginContext(137, 672, true);
                WriteLiteral(@"
    <style>
        table {
            font-family: ""Trebuchet MS"", Arial, Helvetica, sans-serif;
            border-collapse: collapse;
            width: 70%;
        }

        td, th {
            border: 1px solid #ddd;
            text-align: center;
            padding: 8px;
        }

        tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        tr:hover {
            background-color: #b6ff00;
        }

        th {
            padding-top: 12px;
            padding-bottom: 12px;
            text-align: center;
            background-color: #4CAF50;
            color: white;
        }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(816, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(820, 970, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "becca69d3bd14c7be35b5102cdb624d4d9deaf6d5463", async() => {
                BeginContext(826, 215, true);
                WriteLiteral("\r\n    <table>\r\n\r\n        <thead>\r\n            <tr>\r\n                <th>Id</th>\r\n                <th>Title</th>\r\n                <th>Is Done? </th>\r\n                <th colspan=\"2\">Action</th>\r\n            </tr>\r\n\r\n");
                EndContext();
#line 54 "C:\Users\UThandapani\source\repos\ToDoList\ToDoList\Views\ToDo\Read.cshtml"
              

                foreach (var r in (IEnumerable<ToDoModel>)ViewData["ToDo"])
                {

#line default
#line hidden
                BeginContext(1155, 38, true);
                WriteLiteral("            <tr>\r\n                <td>");
                EndContext();
                BeginContext(1194, 4, false);
#line 59 "C:\Users\UThandapani\source\repos\ToDoList\ToDoList\Views\ToDo\Read.cshtml"
               Write(r.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1198, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1226, 7, false);
#line 60 "C:\Users\UThandapani\source\repos\ToDoList\ToDoList\Views\ToDo\Read.cshtml"
               Write(r.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1233, 29, true);
                WriteLiteral("</td>\r\n                <td>\r\n");
                EndContext();
#line 62 "C:\Users\UThandapani\source\repos\ToDoList\ToDoList\Views\ToDo\Read.cshtml"
                     if (r.IsDone == true)
                    {
                        

#line default
#line hidden
                BeginContext(1359, 3, true);
                WriteLiteral("Yes");
                EndContext();
#line 64 "C:\Users\UThandapani\source\repos\ToDoList\ToDoList\Views\ToDo\Read.cshtml"
                                        
                    }
                    else
                    {
                        

#line default
#line hidden
                BeginContext(1473, 2, true);
                WriteLiteral("No");
                EndContext();
#line 68 "C:\Users\UThandapani\source\repos\ToDoList\ToDoList\Views\ToDo\Read.cshtml"
                                       
                    }

#line default
#line hidden
                BeginContext(1507, 43, true);
                WriteLiteral("                </td>\r\n                <td>");
                EndContext();
                BeginContext(1551, 50, false);
#line 71 "C:\Users\UThandapani\source\repos\ToDoList\ToDoList\Views\ToDo\Read.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = r.Id }));

#line default
#line hidden
                EndContext();
                BeginContext(1601, 28, true);
                WriteLiteral(" </td>\r\n                <td>");
                EndContext();
                BeginContext(1630, 54, false);
#line 72 "C:\Users\UThandapani\source\repos\ToDoList\ToDoList\Views\ToDo\Read.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = r.Id }));

#line default
#line hidden
                EndContext();
                BeginContext(1684, 27, true);
                WriteLiteral(" </td>\r\n            </tr>\r\n");
                EndContext();
#line 74 "C:\Users\UThandapani\source\repos\ToDoList\ToDoList\Views\ToDo\Read.cshtml"

                }
                

#line default
#line hidden
                BeginContext(1751, 32, true);
                WriteLiteral("        </thead>\r\n    </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1790, 15, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
            EndContext();
            BeginContext(1921, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ToDoList.Models.ToDoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591