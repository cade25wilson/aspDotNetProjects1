#pragma checksum "C:\Users\New Owner\OneDrive\Documents\aspDotNetProjects\BlazorServerSignalRApp\BlazorServerSignalRApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaf3ac2803f15c09945719e89180f0bccd30aa7f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerSignalRApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\New Owner\OneDrive\Documents\aspDotNetProjects\BlazorServerSignalRApp\BlazorServerSignalRApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\New Owner\OneDrive\Documents\aspDotNetProjects\BlazorServerSignalRApp\BlazorServerSignalRApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\New Owner\OneDrive\Documents\aspDotNetProjects\BlazorServerSignalRApp\BlazorServerSignalRApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\New Owner\OneDrive\Documents\aspDotNetProjects\BlazorServerSignalRApp\BlazorServerSignalRApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\New Owner\OneDrive\Documents\aspDotNetProjects\BlazorServerSignalRApp\BlazorServerSignalRApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\New Owner\OneDrive\Documents\aspDotNetProjects\BlazorServerSignalRApp\BlazorServerSignalRApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\New Owner\OneDrive\Documents\aspDotNetProjects\BlazorServerSignalRApp\BlazorServerSignalRApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\New Owner\OneDrive\Documents\aspDotNetProjects\BlazorServerSignalRApp\BlazorServerSignalRApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\New Owner\OneDrive\Documents\aspDotNetProjects\BlazorServerSignalRApp\BlazorServerSignalRApp\_Imports.razor"
using BlazorServerSignalRApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\New Owner\OneDrive\Documents\aspDotNetProjects\BlazorServerSignalRApp\BlazorServerSignalRApp\_Imports.razor"
using BlazorServerSignalRApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\New Owner\OneDrive\Documents\aspDotNetProjects\BlazorServerSignalRApp\BlazorServerSignalRApp\Pages\Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.OpenElement(2, "label");
            __builder.AddMarkupContent(3, "\r\n    User:\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\New Owner\OneDrive\Documents\aspDotNetProjects\BlazorServerSignalRApp\BlazorServerSignalRApp\Pages\Index.razor"
                  userInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userInput = __value, userInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "form-group");
            __builder.OpenElement(10, "label");
            __builder.AddMarkupContent(11, "\r\n    Message:\r\n    ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "size", "50");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\New Owner\OneDrive\Documents\aspDotNetProjects\BlazorServerSignalRApp\BlazorServerSignalRApp\Pages\Index.razor"
                  messageInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => messageInput = __value, messageInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\New Owner\OneDrive\Documents\aspDotNetProjects\BlazorServerSignalRApp\BlazorServerSignalRApp\Pages\Index.razor"
                  Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "disabled", 
#nullable restore
#line 18 "C:\Users\New Owner\OneDrive\Documents\aspDotNetProjects\BlazorServerSignalRApp\BlazorServerSignalRApp\Pages\Index.razor"
                                    !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n<hr>\r\n\r\n\r\n");
            __builder.OpenElement(22, "ul");
            __builder.AddAttribute(23, "id", "messagesList");
#nullable restore
#line 24 "C:\Users\New Owner\OneDrive\Documents\aspDotNetProjects\BlazorServerSignalRApp\BlazorServerSignalRApp\Pages\Index.razor"
   foreach (var message in messages)
  {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "li");
            __builder.AddContent(25, 
#nullable restore
#line 26 "C:\Users\New Owner\OneDrive\Documents\aspDotNetProjects\BlazorServerSignalRApp\BlazorServerSignalRApp\Pages\Index.razor"
         message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\New Owner\OneDrive\Documents\aspDotNetProjects\BlazorServerSignalRApp\BlazorServerSignalRApp\Pages\Index.razor"
  }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\New Owner\OneDrive\Documents\aspDotNetProjects\BlazorServerSignalRApp\BlazorServerSignalRApp\Pages\Index.razor"
       
  private HubConnection hubConnection;
  private List<string> messages = new List<string>();
  private string userInput;
  private string messageInput;

  protected override async Task OnInitializedAsync()
  {
    hubConnection = new HubConnectionBuilder()
        .WithUrl(NavigationManager.ToAbsoluteUri("/chathub"))
        .Build();

    hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
    {
      var encodedMsg = $"{user}: {message}";
      messages.Add(encodedMsg);
      StateHasChanged();
    });

    await hubConnection.StartAsync();
  }

  async Task Send() =>
      await hubConnection.SendAsync("SendMessage", userInput, messageInput);

  public bool IsConnected =>
      hubConnection.State == HubConnectionState.Connected;

  public async ValueTask DisposeAsync()
  {
    if (hubConnection is not null)
    {
      await hubConnection.DisposeAsync();
    }
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
