﻿#pragma checksum "C:\Users\panth\Documents\CompSci\Visual C# II\Final Project\DataCollector\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D5E23E04A8B957B2F4EB63D6BFFA201D8B99855D361804EE93AB7FB8245CDFA0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataCollector
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 23
                {
                    this.recentMeasurementTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // MainPage.xaml line 24
                {
                    this.recentMeasurementTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // MainPage.xaml line 25
                {
                    this.historyListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 5: // MainPage.xaml line 38
                {
                    this.inchesRadioButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.inchesRadioButton).Checked += this.inchesRadioButton_Checked;
                }
                break;
            case 6: // MainPage.xaml line 39
                {
                    this.centimetersRadioButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.centimetersRadioButton).Checked += this.centimetersRadioButton_Checked;
                }
                break;
            case 7: // MainPage.xaml line 40
                {
                    this.collectToggleButton = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.collectToggleButton).Checked += this.collectToggleButton_Checked;
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.collectToggleButton).Unchecked += this.collectToggleButton_Unchecked;
                }
                break;
            case 8: // MainPage.xaml line 41
                {
                    this.displayHistoryToggleButton = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.displayHistoryToggleButton).Checked += this.displayHistoryToggleButton_Checked;
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.displayHistoryToggleButton).Unchecked += this.displayHistoryToggleButton_Unchecked;
                }
                break;
            case 9: // MainPage.xaml line 42
                {
                    this.descriptionTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // MainPage.xaml line 53
                {
                    this.convertedMeasurementTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11: // MainPage.xaml line 54
                {
                    this.conversionTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // MainPage.xaml line 55
                {
                    this.unitsTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // MainPage.xaml line 56
                {
                    this.jellyfishImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 14: // MainPage.xaml line 26
                {
                    this.listViewHeader = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

