// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TaxPayersMRA.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\_Imports.razor"
using TaxPayersMRA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\_Imports.razor"
using TaxPayersMRA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\_Imports.razor"
using TaxPayersMRA.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\_Imports.razor"
using TaxPayersMRA.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\_Imports.razor"
using TaxPayersMRA.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\Pages\Index - Copy.razor"
using TaxPayersMRA.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmptyLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\Pages\Index - Copy.razor"
       

    private string result = string.Empty;

    private LoginInfo loginInfo = new LoginInfo();

    protected override async Task OnInitializedAsync()
    {

    }

    protected async Task HandleValidSubmit()
    {
        try
        {
            await LoginAsync();
        }
        catch (Exception e)
        {
            System.Diagnostics.Debug.WriteLine(e);
        }
    }

    protected async Task LoginAsync()
    {
        var authResult = await TaxPayerService.AuthenticateUserAsync(loginInfo);

        if (authResult == null)
        {
            result = "Incorrect username or password";
        }
        else
        {
            if (authResult.Authenticated)
            {
                SessionManager.SetLoginResponse(authResult);
                NavManager.NavigateTo("/tax_payers");
            }
            else
            {
                result = "Incorrect username or password";
            }
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SessionManager SessionManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TaxPayerService TaxPayerService { get; set; }
    }
}
#pragma warning restore 1591
