// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
using Test2;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MyPage")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/AnotherRoute/{id}")]
    public class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Test.MyComponent>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<Test2.MyComponent2>(2);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
