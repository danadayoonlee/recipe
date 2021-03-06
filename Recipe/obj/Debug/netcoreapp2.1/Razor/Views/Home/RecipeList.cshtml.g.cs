#pragma checksum "C:\Users\User\Desktop\301034178 (Cuisine-Dayoon cuisine)\Recipe\Views\Home\RecipeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4052c825cd1c0dd90bc8658802da9b0c42f067e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RecipeList), @"mvc.1.0.view", @"/Views/Home/RecipeList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/RecipeList.cshtml", typeof(AspNetCore.Views_Home_RecipeList))]
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
#line 2 "C:\Users\User\Desktop\301034178 (Cuisine-Dayoon cuisine)\Recipe\Views\_ViewImports.cshtml"
using RecipeSystem.Models;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\301034178 (Cuisine-Dayoon cuisine)\Recipe\Views\_ViewImports.cshtml"
using RecipeSystem.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4052c825cd1c0dd90bc8658802da9b0c42f067e0", @"/Views/Home/RecipeList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65afb9d12d071741948f2fdb32f73be562d9fabb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RecipeList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeAndCuisineViewModel>
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
#line 2 "C:\Users\User\Desktop\301034178 (Cuisine-Dayoon cuisine)\Recipe\Views\Home\RecipeList.cshtml"
  
    ViewBag.Title = "Recipe List";

#line default
#line hidden
            BeginContext(77, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(106, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34d9add8a8bc4fd894b0fec6932a7c4f", async() => {
                BeginContext(112, 61, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n");
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
            BeginContext(180, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(182, 1662, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bc45b8279a14494bac90c39110ec403", async() => {
                BeginContext(188, 624, true);
                WriteLiteral(@"
    <div class=""wrapper"">
        <h2>Recipe List</h2>
        <table class=""table"">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Cuisine</th>
                    <th>Introduction</th>
                    <th>Ingredients</th>
                    <th>Brief directions</th>
                    <th>Cooking time</th>
                    <th>Level of difficulty</th>
                    <th>Vegetarian</th>
                    <th>Allergy-free</th>
                    <th>Posting time</th>
                </tr>
            </thead>
            <tbody>
");
                EndContext();
#line 31 "C:\Users\User\Desktop\301034178 (Cuisine-Dayoon cuisine)\Recipe\Views\Home\RecipeList.cshtml"
                 foreach (Recipe r in Model.Recipes)
                {

#line default
#line hidden
                BeginContext(885, 54, true);
                WriteLiteral("                    <tr>\r\n                        <td>");
                EndContext();
                BeginContext(940, 68, false);
#line 34 "C:\Users\User\Desktop\301034178 (Cuisine-Dayoon cuisine)\Recipe\Views\Home\RecipeList.cshtml"
                       Write(Html.ActionLink(r.Name, "ViewRecipe", new { recipeId = r.RecipeID }));

#line default
#line hidden
                EndContext();
                BeginContext(1008, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 35 "C:\Users\User\Desktop\301034178 (Cuisine-Dayoon cuisine)\Recipe\Views\Home\RecipeList.cshtml"
                         foreach (Cuisine c in Model.Cuisines)
                        {
                            

#line default
#line hidden
#line 37 "C:\Users\User\Desktop\301034178 (Cuisine-Dayoon cuisine)\Recipe\Views\Home\RecipeList.cshtml"
                             if (c.CuisineType == r.Cuisine.CuisineType)
                            {

#line default
#line hidden
                BeginContext(1211, 36, true);
                WriteLiteral("                                <td>");
                EndContext();
                BeginContext(1248, 13, false);
#line 39 "C:\Users\User\Desktop\301034178 (Cuisine-Dayoon cuisine)\Recipe\Views\Home\RecipeList.cshtml"
                               Write(c.CuisineType);

#line default
#line hidden
                EndContext();
                BeginContext(1261, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 40 "C:\Users\User\Desktop\301034178 (Cuisine-Dayoon cuisine)\Recipe\Views\Home\RecipeList.cshtml"
                            }

#line default
#line hidden
#line 40 "C:\Users\User\Desktop\301034178 (Cuisine-Dayoon cuisine)\Recipe\Views\Home\RecipeList.cshtml"
                             
                        }

#line default
#line hidden
                BeginContext(1326, 28, true);
                WriteLiteral("                        <td>");
                EndContext();
                BeginContext(1355, 14, false);
#line 42 "C:\Users\User\Desktop\301034178 (Cuisine-Dayoon cuisine)\Recipe\Views\Home\RecipeList.cshtml"
                       Write(r.Introduction);

#line default
#line hidden
                EndContext();
                BeginContext(1369, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1405, 13, false);
#line 43 "C:\Users\User\Desktop\301034178 (Cuisine-Dayoon cuisine)\Recipe\Views\Home\RecipeList.cshtml"
                       Write(r.Ingredients);

#line default
#line hidden
                EndContext();
                BeginContext(1418, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1454, 12, false);
#line 44 "C:\Users\User\Desktop\301034178 (Cuisine-Dayoon cuisine)\Recipe\Views\Home\RecipeList.cshtml"
                       Write(r.Directions);

#line default
#line hidden
                EndContext();
                BeginContext(1466, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1502, 6, false);
#line 45 "C:\Users\User\Desktop\301034178 (Cuisine-Dayoon cuisine)\Recipe\Views\Home\RecipeList.cshtml"
                       Write(r.Time);

#line default
#line hidden
                EndContext();
                BeginContext(1508, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1544, 12, false);
#line 46 "C:\Users\User\Desktop\301034178 (Cuisine-Dayoon cuisine)\Recipe\Views\Home\RecipeList.cshtml"
                       Write(r.Difficulty);

#line default
#line hidden
                EndContext();
                BeginContext(1556, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1593, 27, false);
#line 47 "C:\Users\User\Desktop\301034178 (Cuisine-Dayoon cuisine)\Recipe\Views\Home\RecipeList.cshtml"
                        Write(r.Vegetarian ? "Yes" : "No");

#line default
#line hidden
                EndContext();
                BeginContext(1621, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1658, 24, false);
#line 48 "C:\Users\User\Desktop\301034178 (Cuisine-Dayoon cuisine)\Recipe\Views\Home\RecipeList.cshtml"
                        Write(r.Allergy ? "Yes" : "No");

#line default
#line hidden
                EndContext();
                BeginContext(1683, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1719, 13, false);
#line 49 "C:\Users\User\Desktop\301034178 (Cuisine-Dayoon cuisine)\Recipe\Views\Home\RecipeList.cshtml"
                       Write(r.PostingTime);

#line default
#line hidden
                EndContext();
                BeginContext(1732, 34, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n");
                EndContext();
#line 51 "C:\Users\User\Desktop\301034178 (Cuisine-Dayoon cuisine)\Recipe\Views\Home\RecipeList.cshtml"
                }

#line default
#line hidden
                BeginContext(1785, 52, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
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
            BeginContext(1844, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeAndCuisineViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
