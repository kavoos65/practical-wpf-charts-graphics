﻿#pragma checksum "..\..\PieChart.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3A4113287C50185464E2A6EECDAD295A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Specialized2DChartControl;
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


namespace Specialized2DChartControlTest {
    
    
    /// <summary>
    /// PieChart
    /// </summary>
    public partial class PieChart : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\PieChart.xaml"
        internal System.Windows.Controls.Grid rootGrid;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\PieChart.xaml"
        internal Specialized2DChartControl.PieControl myPieChart;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Specialized2DChartControlTest;component/piechart.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PieChart.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.rootGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 6 "..\..\PieChart.xaml"
            this.rootGrid.SizeChanged += new System.Windows.SizeChangedEventHandler(this.rootGrid_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.myPieChart = ((Specialized2DChartControl.PieControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}