﻿

#pragma checksum "C:\Users\Dalpat\Desktop\TrackMyTrip\TrackMyTrip\Pages\Additem.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AC917F80BA5E3E3D1809011D96F81811"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrackMyTrip.Pages
{
    partial class Additem : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 119 "..\..\Pages\Additem.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btn_post_hotel_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 107 "..\..\Pages\Additem.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btn_post_photo_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 29 "..\..\Pages\Additem.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.btn_photo_Tapped;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 52 "..\..\Pages\Additem.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.btn_hotel_Tapped;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

