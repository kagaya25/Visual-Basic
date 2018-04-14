﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace PersonServiceReference
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="Person", [Namespace]:="http://schemas.datacontract.org/2004/07/WcfPersonService"),  _
     System.SerializableAttribute()>  _
    Partial Public Class Person
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private FirstNameField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private LastNameField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property FirstName() As String
            Get
                Return Me.FirstNameField
            End Get
            Set
                If (Object.ReferenceEquals(Me.FirstNameField, value) <> true) Then
                    Me.FirstNameField = value
                    Me.RaisePropertyChanged("FirstName")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property LastName() As String
            Get
                Return Me.LastNameField
            End Get
            Set
                If (Object.ReferenceEquals(Me.LastNameField, value) <> true) Then
                    Me.LastNameField = value
                    Me.RaisePropertyChanged("LastName")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="PersonServiceReference.IPersonService")>  _
    Public Interface IPersonService
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IPersonService/GetPersonFullName", ReplyAction:="http://tempuri.org/IPersonService/GetPersonFullNameResponse")>  _
        Function GetPersonFullName(ByVal onePerson As PersonServiceReference.Person) As String
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IPersonServiceChannel
        Inherits PersonServiceReference.IPersonService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class PersonServiceClient
        Inherits System.ServiceModel.ClientBase(Of PersonServiceReference.IPersonService)
        Implements PersonServiceReference.IPersonService
        
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
        
        Public Function GetPersonFullName(ByVal onePerson As PersonServiceReference.Person) As String Implements PersonServiceReference.IPersonService.GetPersonFullName
            Return MyBase.Channel.GetPersonFullName(onePerson)
        End Function
    End Class
End Namespace