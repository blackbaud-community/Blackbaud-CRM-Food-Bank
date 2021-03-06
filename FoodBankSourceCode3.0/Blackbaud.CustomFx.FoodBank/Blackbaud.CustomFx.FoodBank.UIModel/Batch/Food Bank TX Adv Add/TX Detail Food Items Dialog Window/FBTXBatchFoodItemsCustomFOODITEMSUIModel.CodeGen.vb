﻿Option Strict On
Option Explicit On
Option Infer On

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by BBUIModelLibrary
'     Version:  2.93.1563.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
''' <summary>
''' Represents the UI model for the 'FBTXBatchFoodItemsCustomFOODITEMS' data form
''' </summary>
Partial Public Class [FBTXBatchFoodItemsCustomFOODITEMSUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.UIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _fooditemid As Global.Blackbaud.AppFx.UIModeling.Core.SimpleDataListField(Of Guid)
    Private WithEvents _fooditemamount As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
    Private WithEvents _quantity As Global.Blackbaud.AppFx.UIModeling.Core.IntegerField

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.1563.0")> _
    Public Sub New()
        MyBase.New()

        _fooditemid = New Global.Blackbaud.AppFx.UIModeling.Core.SimpleDataListField(Of Guid)
        _fooditemamount = New Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        _quantity = New Global.Blackbaud.AppFx.UIModeling.Core.IntegerField

        '
        '_fooditemid
        '
        _fooditemid.Name = "FOODITEMID"
        _fooditemid.Caption = "Food item"
        _fooditemid.SimpleDataListID = New Guid("bd0f0cc1-cc60-42e2-b592-f000b4fdfbf4")
        Me.Fields.Add(_fooditemid)
        '
        '_fooditemamount
        '
        _fooditemamount.Name = "FOODITEMAMOUNT"
        _fooditemamount.Caption = "Amount"
        Me.Fields.Add(_fooditemamount)
        '
        '_quantity
        '
        _quantity.Name = "QUANTITY"
        _quantity.Caption = "Quantity"
        Me.Fields.Add(_quantity)

		OnCreated()

    End Sub
    
    ''' <summary>
    ''' Food item
    ''' </summary>
    <System.ComponentModel.Description("Food item")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.1563.0")> _
    Public ReadOnly Property [FOODITEMID]() As Global.Blackbaud.AppFx.UIModeling.Core.SimpleDataListField(Of Guid)
        Get
            Return _fooditemid
        End Get
    End Property
    
    ''' <summary>
    ''' Amount
    ''' </summary>
    <System.ComponentModel.Description("Amount")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.1563.0")> _
    Public ReadOnly Property [FOODITEMAMOUNT]() As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        Get
            Return _fooditemamount
        End Get
    End Property
    
    ''' <summary>
    ''' Quantity
    ''' </summary>
    <System.ComponentModel.Description("Quantity")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "2.93.1563.0")> _
    Public ReadOnly Property [QUANTITY]() As Global.Blackbaud.AppFx.UIModeling.Core.IntegerField
        Get
            Return _quantity
        End Get
    End Property
    
End Class
