#pragma checksum "D:\Dev\BlazorFormGeneratorDemo\VxFormGenerator\FormElement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ce8caad4d5536f2daed0c7b8594fbfa20e11e69"
// <auto-generated/>
#pragma warning disable 1591
namespace VxFormGenerator
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Dev\BlazorFormGeneratorDemo\VxFormGenerator\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dev\BlazorFormGeneratorDemo\VxFormGenerator\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
    public partial class FormElement : FormElementComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "D:\Dev\BlazorFormGeneratorDemo\VxFormGenerator\FormElement.razor"
 if (!string.IsNullOrWhiteSpace(Label))
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "label");
            __builder.AddAttribute(2, "class", "form-control-label");
            __builder.AddAttribute(3, "for", 
#nullable restore
#line 5 "D:\Dev\BlazorFormGeneratorDemo\VxFormGenerator\FormElement.razor"
                                            Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, 
#nullable restore
#line 5 "D:\Dev\BlazorFormGeneratorDemo\VxFormGenerator\FormElement.razor"
                                                 Label

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 6 "D:\Dev\BlazorFormGeneratorDemo\VxFormGenerator\FormElement.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "\r\n");
            __builder.AddContent(7, 
#nullable restore
#line 8 "D:\Dev\BlazorFormGeneratorDemo\VxFormGenerator\FormElement.razor"
 CreateComponent(FieldIdentifier)

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591