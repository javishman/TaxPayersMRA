#pragma checksum "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\Pages\EditTaxPayer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83e8fb461e4d8dde6268ddb294d28bd437697d05"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\Pages\EditTaxPayer.razor"
using TaxPayersMRA.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit_tax_payer")]
    public partial class EditTaxPayer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-md-10");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 9 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\Pages\EditTaxPayer.razor"
     if (result != string.Empty)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "p");
            __builder.AddAttribute(5, "class", "alert alert-danger");
            __builder.AddContent(6, 
#nullable restore
#line 11 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\Pages\EditTaxPayer.razor"
                                       result

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 12 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\Pages\EditTaxPayer.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-md-6 m-auto");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\Pages\EditTaxPayer.razor"
                          taxPayer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\Pages\EditTaxPayer.razor"
                                                    HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(19);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n\r\n            ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "\r\n                ");
                __builder2.AddMarkupContent(24, "<label>Email address</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(25);
                __builder2.AddAttribute(26, "id", "name");
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\Pages\EditTaxPayer.razor"
                                                  taxPayer.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => taxPayer.Email = __value, taxPayer.Email))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => taxPayer.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "\r\n                ");
                __builder2.AddMarkupContent(36, "<label>TPIN</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(37);
                __builder2.AddAttribute(38, "id", "name");
                __builder2.AddAttribute(39, "class", "form-control");
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\Pages\EditTaxPayer.razor"
                                                  taxPayer.TPIN

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => taxPayer.TPIN = __value, taxPayer.TPIN))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => taxPayer.TPIN));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.AddMarkupContent(47, "\r\n                ");
                __builder2.AddMarkupContent(48, "<label>Business Certificate Number</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(49);
                __builder2.AddAttribute(50, "id", "name");
                __builder2.AddAttribute(51, "class", "form-control");
                __builder2.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\Pages\EditTaxPayer.razor"
                                                  taxPayer.BusinessCertificateNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => taxPayer.BusinessCertificateNumber = __value, taxPayer.BusinessCertificateNumber))));
                __builder2.AddAttribute(54, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => taxPayer.BusinessCertificateNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n            ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group");
                __builder2.AddMarkupContent(59, "\r\n                ");
                __builder2.AddMarkupContent(60, "<label>Business Registration Date</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(61);
                __builder2.AddAttribute(62, "id", "name");
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\Pages\EditTaxPayer.razor"
                                                  taxPayer.BusinessRegistrationDate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => taxPayer.BusinessRegistrationDate = __value, taxPayer.BusinessRegistrationDate))));
                __builder2.AddAttribute(66, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => taxPayer.BusinessRegistrationDate));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n            ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-group");
                __builder2.AddMarkupContent(71, "\r\n                ");
                __builder2.AddMarkupContent(72, "<label>Physical Location</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(73);
                __builder2.AddAttribute(74, "id", "name");
                __builder2.AddAttribute(75, "class", "form-control");
                __builder2.AddAttribute(76, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\Pages\EditTaxPayer.razor"
                                                  taxPayer.PhysicalLocation

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => taxPayer.PhysicalLocation = __value, taxPayer.PhysicalLocation))));
                __builder2.AddAttribute(78, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => taxPayer.PhysicalLocation));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n            ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "form-group");
                __builder2.AddMarkupContent(83, "\r\n                ");
                __builder2.AddMarkupContent(84, "<label>Mobile Number</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(85);
                __builder2.AddAttribute(86, "id", "name");
                __builder2.AddAttribute(87, "class", "form-control");
                __builder2.AddAttribute(88, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\Pages\EditTaxPayer.razor"
                                                  taxPayer.MobileNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => taxPayer.MobileNumber = __value, taxPayer.MobileNumber))));
                __builder2.AddAttribute(90, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => taxPayer.MobileNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n            ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "form-group");
                __builder2.AddMarkupContent(95, "\r\n                ");
                __builder2.AddMarkupContent(96, "<label>Trading Name</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(97);
                __builder2.AddAttribute(98, "id", "name");
                __builder2.AddAttribute(99, "class", "form-control");
                __builder2.AddAttribute(100, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\Pages\EditTaxPayer.razor"
                                                  taxPayer.TradingName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => taxPayer.TradingName = __value, taxPayer.TradingName))));
                __builder2.AddAttribute(102, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => taxPayer.TradingName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(103, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n            ");
                __builder2.AddMarkupContent(105, "<button type=\"submit\" class=\"btn btn-primary\">Edit Tax Payer</button>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(106, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\Kol\source\repos\TaxPayersMRA\TaxPayersMRA\Pages\EditTaxPayer.razor"
       

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
            await EditTaxPayerAsync();
        }
        catch (Exception e)
        {
            System.Diagnostics.Debug.WriteLine(e);
        }
    }

    protected async Task EditTaxPayerAsync()
    {
        try
        {

            var edited = await TaxPayerService.EditTaxPayerAsync(taxPayer);

            if (edited)
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
