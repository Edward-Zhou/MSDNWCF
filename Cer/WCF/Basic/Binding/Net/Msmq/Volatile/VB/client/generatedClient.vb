﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



Namespace Microsoft.ServiceModel.Samples
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://Microsoft.ServiceModel.Samples", ConfigurationName:="Microsoft.ServiceModel.Samples.IStockTicker")>  _
    Public Interface IStockTicker
        
        <System.ServiceModel.OperationContractAttribute(IsOneWay:=true, Action:="http://Microsoft.ServiceModel.Samples/IStockTicker/StockTick")>  _
        Sub StockTick(ByVal symbol As String, ByVal price As Single)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Public Interface IStockTickerChannel
        Inherits Microsoft.ServiceModel.Samples.IStockTicker, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Partial Public Class StockTickerClient
        Inherits System.ServiceModel.ClientBase(Of Microsoft.ServiceModel.Samples.IStockTicker)
        Implements Microsoft.ServiceModel.Samples.IStockTicker
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Sub StockTick(ByVal symbol As String, ByVal price As Single) Implements Microsoft.ServiceModel.Samples.IStockTicker.StockTick
            MyBase.Channel.StockTick(symbol, price)
        End Sub
    End Class
End Namespace
