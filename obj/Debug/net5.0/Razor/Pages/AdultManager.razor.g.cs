#pragma checksum "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "803909335d78780a46fadb51b7c89fc74fb4f609"
// <auto-generated/>
#pragma warning disable 1591
namespace HandIn1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\brezn\RiderProjects\DNP\HandIn1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\brezn\RiderProjects\DNP\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\brezn\RiderProjects\DNP\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\brezn\RiderProjects\DNP\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\brezn\RiderProjects\DNP\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\brezn\RiderProjects\DNP\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\brezn\RiderProjects\DNP\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\brezn\RiderProjects\DNP\HandIn1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\brezn\RiderProjects\DNP\HandIn1\_Imports.razor"
using HandIn1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\brezn\RiderProjects\DNP\HandIn1\_Imports.razor"
using HandIn1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
using System.Security.Authentication.ExtendedProtection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
using HandIn1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
using LoginExample.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
using Microsoft.VisualBasic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AdultManager")]
    public partial class AdultManager : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, " Filter by First name: ");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "text");
            __builder.AddAttribute(4, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
                                                          (arg) => FilterByUserFirstName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "style", "width:30rem");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "p");
            __builder.AddContent(8, " Filter by Last name: ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
                                                            (arg) => FilterByUserLastName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "style", "width:30rem");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
 if (_adults_to_show == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<p><em>Loading...</em></p>");
#nullable restore
#line 23 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
}
else if (!_adults_to_show.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "<p><em>No items exist at the moment, add sum digga</em></p>");
#nullable restore
#line 29 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
}
else
    {
       

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table");
            __builder.OpenElement(17, "thead");
            __builder.OpenElement(18, "tr");
            __builder.AddMarkupContent(19, "<th>ID</th>\r\n                ");
            __builder.AddMarkupContent(20, "<th>First name</th>\r\n                ");
            __builder.AddMarkupContent(21, "<th>Last Name</th>\r\n                ");
            __builder.AddMarkupContent(22, "<th>Hair Color</th>\r\n                ");
            __builder.AddMarkupContent(23, "<th>Eye Color</th>\r\n                ");
            __builder.AddMarkupContent(24, "<th>Age</th>\r\n                ");
            __builder.AddMarkupContent(25, "<th>Weight</th>\r\n                ");
            __builder.AddMarkupContent(26, "<th>Height</th>\r\n                ");
            __builder.AddMarkupContent(27, "<th>Sex</th>\r\n                ");
            __builder.AddMarkupContent(28, "<th>Job Title</th>\r\n                ");
            __builder.AddMarkupContent(29, "<th>Salary</th>\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(30);
            __builder.AddAttribute(31, "Policy", "SecurityLevel1");
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(33, "<th>Delete</th>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            \r\n            ");
            __builder.OpenElement(35, "tbody");
#nullable restore
#line 54 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
             foreach (var adult in _adults_to_show)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "tr");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 58 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
                         adult.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 59 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
                         adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 60 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
                         adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 61 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
                         adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 62 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
                         adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "td");
            __builder.AddContent(53, 
#nullable restore
#line 63 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
                         adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.OpenElement(55, "td");
            __builder.AddContent(56, 
#nullable restore
#line 64 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
                         adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#nullable restore
#line 65 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
                         adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.OpenElement(61, "td");
            __builder.AddContent(62, 
#nullable restore
#line 66 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
                         adult.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.OpenElement(64, "td");
            __builder.AddContent(65, 
#nullable restore
#line 67 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
                         adult.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                    ");
            __builder.OpenElement(67, "td");
            __builder.AddContent(68, 
#nullable restore
#line 68 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
                         adult.JobTitle.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                    \r\n                  ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(70);
            __builder.AddAttribute(71, "Policy", "SecurityLevel1");
            __builder.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(73, "td");
                __builder2.OpenElement(74, "button");
                __builder2.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
                                            () => RemoveAdult(adult.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(76, "<i class=\"oi oi-trash\" style=\"color: red\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 77 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 80 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\brezn\RiderProjects\DNP\HandIn1\Pages\AdultManager.razor"
       
    private IList<Models.Adult> _all_adults;
    private IList<Models.Adult> _adults_to_show;

    private string first_name_filter;
    private string last_name_filter;
    
    protected override async Task OnInitializedAsync()
    {
        _all_adults = IAdultAdapter.getAllAdults();
        _adults_to_show = new List<Adult>(_all_adults);
        
    }


    private void FilterByUserFirstName(ChangeEventArgs changeEventArgs)
    {
        first_name_filter = null;
        try
        {
            first_name_filter = changeEventArgs.Value.ToString();
        }
        catch (Exception e)
        {
    // ignored
        }
        
        ExecuteFilter();
    }
    
    private void FilterByUserLastName(ChangeEventArgs changeEventArgs)
    {
        last_name_filter = null;
        try
        {
            last_name_filter = changeEventArgs.Value.ToString();
        }
        catch (Exception e)
        {
    // ignored
        }
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
       
        
            _adults_to_show = _all_adults.Where(adult => (StringChainMatch(first_name_filter, adult.FirstName))&&(StringChainMatch(last_name_filter, adult.LastName))).ToList();
    }
   
    
    private void RemoveAdult(int adultID)
    {
       
        
            Adult adultToDelete = _all_adults.First(adult => adult.Id == adultID);
            IAdultAdapter.Delete(adultToDelete);
            _all_adults.Remove(adultToDelete);
            _adults_to_show.Remove(adultToDelete);
        
        
       
    }

    private bool StringChainMatch(string a, string b) //This method is responsible for making sure that filtering is not going to be done on exact match basis but instead on a string chain basis
    {
        if (a == null)
        {
            return true;
        }
        
       a= a.ToLower();
       a= a.Trim();
       b= b.ToLower();
       b= b.Trim();
        
        for (int i = 0; i < a.Length; i++)
        {
            try
            {
                if (a[i]!=b[i])
                {
                    return false;
                }
            }
            catch (IndexOutOfRangeException e)
            {
                return false;
            }
           
            
        }
        return true;
    }
    
        
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultAdapter IAdultAdapter { get; set; }
    }
}
#pragma warning restore 1591