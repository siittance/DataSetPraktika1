﻿#pragma checksum "..\..\StranicaClient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3ECC930527FD5733AAD8312FB1CA8B1304BA51D04A7AE0FAE7D9D9418D38963B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DataSetPrakt1;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace DataSetPrakt1 {
    
    
    /// <summary>
    /// StranicaClient
    /// </summary>
    public partial class StranicaClient : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\StranicaClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tekstik;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\StranicaClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridDataClients;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\StranicaClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Familia;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\StranicaClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Imya;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\StranicaClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Otchestvo;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\StranicaClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Email;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\StranicaClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhoneNumber;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DataSetPrakt1;component/stranicaclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StranicaClient.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tekstik = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.GridDataClients = ((System.Windows.Controls.DataGrid)(target));
            
            #line 31 "..\..\StranicaClient.xaml"
            this.GridDataClients.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.GridDataPets_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 32 "..\..\StranicaClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.p);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 33 "..\..\StranicaClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ydal);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 34 "..\..\StranicaClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.dobav);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 35 "..\..\StranicaClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.izmen);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Familia = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Imya = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.Otchestvo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.Email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.PhoneNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
