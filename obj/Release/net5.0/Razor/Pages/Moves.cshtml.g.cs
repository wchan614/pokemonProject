#pragma checksum "C:\Users\rou\Desktop\Trios\C#\pokemonProject\Pages\Moves.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8856b028aced98c68c2421835c88548cc6631b4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(pokemonProject.Pages.Pages_Moves), @"mvc.1.0.razor-page", @"/Pages/Moves.cshtml")]
namespace pokemonProject.Pages
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
#line 1 "C:\Users\rou\Desktop\Trios\C#\pokemonProject\Pages\_ViewImports.cshtml"
using pokemonProject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8856b028aced98c68c2421835c88548cc6631b4e", @"/Pages/Moves.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c91a812f31b77159d7be90e24dc6c1506abd01c0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Moves : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\rou\Desktop\Trios\C#\pokemonProject\Pages\Moves.cshtml"
  
    ViewData["Moves"] = "Moves";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div>\r\n    <div id=\"pokemonResult\">\r\n        <div class=\"pokemonInfo\" style=\"text-align: center;\">\r\n            <h1>\r\n                ");
#nullable restore
#line 13 "C:\Users\rou\Desktop\Trios\C#\pokemonProject\Pages\Moves.cshtml"
           Write(Model.move.Name.ToUpper().Replace("-"," "));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h1>\r\n            <div>\r\n");
#nullable restore
#line 16 "C:\Users\rou\Desktop\Trios\C#\pokemonProject\Pages\Moves.cshtml"
                 foreach(var text in Model.move.FlavorTextEntries){
                    if(text.Language.Name == "en") {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\rou\Desktop\Trios\C#\pokemonProject\Pages\Moves.cshtml"
                    Write(text.FlavorText);

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\rou\Desktop\Trios\C#\pokemonProject\Pages\Moves.cshtml"
                                          
                        break;
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <br>\r\n            <div>\r\n                TYPE: ");
#nullable restore
#line 25 "C:\Users\rou\Desktop\Trios\C#\pokemonProject\Pages\Moves.cshtml"
                 Write(Model.move.Type.Name.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                CATAGORY: ");
#nullable restore
#line 28 "C:\Users\rou\Desktop\Trios\C#\pokemonProject\Pages\Moves.cshtml"
                     Write(Model.move.DamageClass.Name.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                POWER: ");
#nullable restore
#line 31 "C:\Users\rou\Desktop\Trios\C#\pokemonProject\Pages\Moves.cshtml"
                   Write(Convert.ToBoolean(Model.move.Power) ? Model.move.Power: "None");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ACCURACY: ");
#nullable restore
#line 34 "C:\Users\rou\Desktop\Trios\C#\pokemonProject\Pages\Moves.cshtml"
                      Write(Convert.ToBoolean(Model.move.Accuracy) ? Model.move.Accuracy: "100");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                PP: ");
#nullable restore
#line 37 "C:\Users\rou\Desktop\Trios\C#\pokemonProject\Pages\Moves.cshtml"
               Write(Model.move.Pp);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                PRIORITY: ");
#nullable restore
#line 40 "C:\Users\rou\Desktop\Trios\C#\pokemonProject\Pages\Moves.cshtml"
                     Write(Model.move.Priority);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                TARGET: ");
#nullable restore
#line 43 "C:\Users\rou\Desktop\Trios\C#\pokemonProject\Pages\Moves.cshtml"
                   Write(Model.move.Target.Name.ToUpper().Replace("-", " "));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>


    </div>
</div>
<div id=""pokemonResultExtra"">
    <div class=""pkmnResultExtraBox"">
        <div class=""pkmnResultBoxesDynamic"">
             <div class=""pkmnResultTitle"" style=""margin-bottom: 10px;"">Pokemon Able To Learn</div>
");
#nullable restore
#line 54 "C:\Users\rou\Desktop\Trios\C#\pokemonProject\Pages\Moves.cshtml"
              foreach (var pkmn in Model.move.LearnedByPokemon) {
                if (Model.isValidPokemon(pkmn.Name)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"moveForm\">\r\n                        <div class=\"moveFormButton\">\r\n");
#nullable restore
#line 58 "C:\Users\rou\Desktop\Trios\C#\pokemonProject\Pages\Moves.cshtml"
                              string link = "./Pokemon?id=" + pkmn.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 1893, "\"", 1905, 1);
#nullable restore
#line 59 "C:\Users\rou\Desktop\Trios\C#\pokemonProject\Pages\Moves.cshtml"
WriteAttributeValue("", 1900, link, 1900, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 59 "C:\Users\rou\Desktop\Trios\C#\pokemonProject\Pages\Moves.cshtml"
                                       Write(pkmn.Name.ToUpper().Replace("-"," "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 62 "C:\Users\rou\Desktop\Trios\C#\pokemonProject\Pages\Moves.cshtml"
                }
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    window.addEventListener(\'load\',(event)=> {\r\n        lockMinWidth();\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MovesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MovesModel>)PageContext?.ViewData;
        public MovesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
