﻿

#pragma checksum "C:\Users\Dalpat\Desktop\TrackMyTrip\TrackMyTrip\Pages\AddTrip.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "08A8DFCA93F502D027E40A7547C12C45"
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
    partial class AddTrip : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 67 "..\..\Pages\AddTrip.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.cmb_transpotation_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 81 "..\..\Pages\AddTrip.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.Border_Tapped;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


