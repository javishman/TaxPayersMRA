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
#line 3 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\Pages\DeleteTaxPayer.razor"
using TaxPayersMRA.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/delete_tax_payer")]
    public partial class DeleteTaxPayer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\Pages\DeleteTaxPayer.razor"
       

    private string result = string.Empty;

    private TaxPayer taxPayer = new TaxPayer();

    protected override async Task OnInitializedAsync()
    {
        InitTaxPayer();
    }

    private void InitTaxPayer()
    {
        var loginResponse = SessionManager.GetLoginResponse();

        if (loginResponse.UserDetails != null)
        {
            taxPayer.Username = $"{loginResponse.UserDetails.Username}";
        }

        taxPayer = SessionManager.GetTaxPayer();
        SessionManager.Remove();
    }

    protected async Task HandleValidSubmit()
    {
        try
        {
            await DeleteTaxPayerAsync();
        }
        catch (Exception e)
        {
            System.Diagnostics.Debug.WriteLine(e);
        }
    }

    protected async Task DeleteTaxPayerAsync()
    {
        try
        {

            var deleted = await TaxPayerService.DeleteTaxPayerAsync(taxPayer);

            if (deleted)
            {
                taxPayer = new TaxPayer();
                NavManager.NavigateTo("/tax_payers");
            }
        }
        catch (Exception e)
        {
            System.Diagnostics.Debug.WriteLine(e);
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
