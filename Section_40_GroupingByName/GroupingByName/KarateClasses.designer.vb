﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="CRUDKarate")>  _
Partial Public Class KarateClassesDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertMember(instance As Member)
    End Sub
  Partial Private Sub UpdateMember(instance As Member)
    End Sub
  Partial Private Sub DeleteMember(instance As Member)
    End Sub
  Partial Private Sub InsertPayment(instance As Payment)
    End Sub
  Partial Private Sub UpdatePayment(instance As Payment)
    End Sub
  Partial Private Sub DeletePayment(instance As Payment)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.GroupingByName.My.MySettings.Default.CRUDKarateConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Days() As System.Data.Linq.Table(Of Day)
		Get
			Return Me.GetTable(Of Day)
		End Get
	End Property
	
	Public ReadOnly Property Schedules() As System.Data.Linq.Table(Of Schedule)
		Get
			Return Me.GetTable(Of Schedule)
		End Get
	End Property
	
	Public ReadOnly Property Instructors() As System.Data.Linq.Table(Of Instructor)
		Get
			Return Me.GetTable(Of Instructor)
		End Get
	End Property
	
	Public ReadOnly Property Members() As System.Data.Linq.Table(Of Member)
		Get
			Return Me.GetTable(Of Member)
		End Get
	End Property
	
	Public ReadOnly Property Payments() As System.Data.Linq.Table(Of Payment)
		Get
			Return Me.GetTable(Of Payment)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Days")>  _
Partial Public Class Day
	
	Private _num As System.Nullable(Of Short)
	
	Private _name As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_num", DbType:="SmallInt")>  _
	Public Property num() As System.Nullable(Of Short)
		Get
			Return Me._num
		End Get
		Set
			If (Me._num.Equals(value) = false) Then
				Me._num = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_name", DbType:="NVarChar(4)")>  _
	Public Property name() As String
		Get
			Return Me._name
		End Get
		Set
			If (String.Equals(Me._name, value) = false) Then
				Me._name = value
			End If
		End Set
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Schedule")>  _
Partial Public Class Schedule
	
	Private _ID As System.Nullable(Of Integer)
	
	Private _Day As Short
	
	Private _Time As Date
	
	Private _Instructor_Id As Integer
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", DbType:="Int")>  _
	Public Property ID() As System.Nullable(Of Integer)
		Get
			Return Me._ID
		End Get
		Set
			If (Me._ID.Equals(value) = false) Then
				Me._ID = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Day", DbType:="SmallInt NOT NULL")>  _
	Public Property Day() As Short
		Get
			Return Me._Day
		End Get
		Set
			If ((Me._Day = value)  _
						= false) Then
				Me._Day = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Time", DbType:="SmallDateTime NOT NULL")>  _
	Public Property Time() As Date
		Get
			Return Me._Time
		End Get
		Set
			If ((Me._Time = value)  _
						= false) Then
				Me._Time = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Instructor_Id", DbType:="Int NOT NULL")>  _
	Public Property Instructor_Id() As Integer
		Get
			Return Me._Instructor_Id
		End Get
		Set
			If ((Me._Instructor_Id = value)  _
						= false) Then
				Me._Instructor_Id = value
			End If
		End Set
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Instructors")>  _
Partial Public Class Instructor
	
	Private _ID As System.Nullable(Of Short)
	
	Private _Last_Name As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", DbType:="SmallInt")>  _
	Public Property ID() As System.Nullable(Of Short)
		Get
			Return Me._ID
		End Get
		Set
			If (Me._ID.Equals(value) = false) Then
				Me._ID = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Last_Name", DbType:="NVarChar(30) NOT NULL", CanBeNull:=false)>  _
	Public Property Last_Name() As String
		Get
			Return Me._Last_Name
		End Get
		Set
			If (String.Equals(Me._Last_Name, value) = false) Then
				Me._Last_Name = value
			End If
		End Set
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Members")>  _
Partial Public Class Member
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As Short
	
	Private _Last_Name As String
	
	Private _First_Name As String
	
	Private _Phone As String
	
	Private _Date_Joined As System.Nullable(Of Date)
	
	Private _Payments As EntitySet(Of Payment)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As Short)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnLast_NameChanging(value As String)
    End Sub
    Partial Private Sub OnLast_NameChanged()
    End Sub
    Partial Private Sub OnFirst_NameChanging(value As String)
    End Sub
    Partial Private Sub OnFirst_NameChanged()
    End Sub
    Partial Private Sub OnPhoneChanging(value As String)
    End Sub
    Partial Private Sub OnPhoneChanged()
    End Sub
    Partial Private Sub OnDate_JoinedChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnDate_JoinedChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Payments = New EntitySet(Of Payment)(AddressOf Me.attach_Payments, AddressOf Me.detach_Payments)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", DbType:="SmallInt NOT NULL", IsPrimaryKey:=true)>  _
	Public Property ID() As Short
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Last_Name", DbType:="NVarChar(30) NOT NULL", CanBeNull:=false)>  _
	Public Property Last_Name() As String
		Get
			Return Me._Last_Name
		End Get
		Set
			If (String.Equals(Me._Last_Name, value) = false) Then
				Me.OnLast_NameChanging(value)
				Me.SendPropertyChanging
				Me._Last_Name = value
				Me.SendPropertyChanged("Last_Name")
				Me.OnLast_NameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_First_Name", DbType:="NVarChar(30) NOT NULL", CanBeNull:=false)>  _
	Public Property First_Name() As String
		Get
			Return Me._First_Name
		End Get
		Set
			If (String.Equals(Me._First_Name, value) = false) Then
				Me.OnFirst_NameChanging(value)
				Me.SendPropertyChanging
				Me._First_Name = value
				Me.SendPropertyChanged("First_Name")
				Me.OnFirst_NameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Phone", DbType:="NVarChar(30)")>  _
	Public Property Phone() As String
		Get
			Return Me._Phone
		End Get
		Set
			If (String.Equals(Me._Phone, value) = false) Then
				Me.OnPhoneChanging(value)
				Me.SendPropertyChanging
				Me._Phone = value
				Me.SendPropertyChanged("Phone")
				Me.OnPhoneChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Date_Joined", DbType:="SmallDateTime")>  _
	Public Property Date_Joined() As System.Nullable(Of Date)
		Get
			Return Me._Date_Joined
		End Get
		Set
			If (Me._Date_Joined.Equals(value) = false) Then
				Me.OnDate_JoinedChanging(value)
				Me.SendPropertyChanging
				Me._Date_Joined = value
				Me.SendPropertyChanged("Date_Joined")
				Me.OnDate_JoinedChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Member_Payment", Storage:="_Payments", ThisKey:="ID", OtherKey:="Member_Id")>  _
	Public Property Payments() As EntitySet(Of Payment)
		Get
			Return Me._Payments
		End Get
		Set
			Me._Payments.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_Payments(ByVal entity As Payment)
		Me.SendPropertyChanging
		entity.Member = Me
	End Sub
	
	Private Sub detach_Payments(ByVal entity As Payment)
		Me.SendPropertyChanging
		entity.Member = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Payments")>  _
Partial Public Class Payment
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As Integer
	
	Private _Member_Id As Short
	
	Private _Payment_Date As Date
	
	Private _Amount As Decimal
	
	Private _Member As EntityRef(Of Member)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnMember_IdChanging(value As Short)
    End Sub
    Partial Private Sub OnMember_IdChanged()
    End Sub
    Partial Private Sub OnPayment_DateChanging(value As Date)
    End Sub
    Partial Private Sub OnPayment_DateChanged()
    End Sub
    Partial Private Sub OnAmountChanging(value As Decimal)
    End Sub
    Partial Private Sub OnAmountChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Member = CType(Nothing, EntityRef(Of Member))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID() As Integer
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Member_Id", DbType:="SmallInt NOT NULL")>  _
	Public Property Member_Id() As Short
		Get
			Return Me._Member_Id
		End Get
		Set
			If ((Me._Member_Id = value)  _
						= false) Then
				If Me._Member.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnMember_IdChanging(value)
				Me.SendPropertyChanging
				Me._Member_Id = value
				Me.SendPropertyChanged("Member_Id")
				Me.OnMember_IdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Payment_Date", DbType:="SmallDateTime NOT NULL")>  _
	Public Property Payment_Date() As Date
		Get
			Return Me._Payment_Date
		End Get
		Set
			If ((Me._Payment_Date = value)  _
						= false) Then
				Me.OnPayment_DateChanging(value)
				Me.SendPropertyChanging
				Me._Payment_Date = value
				Me.SendPropertyChanged("Payment_Date")
				Me.OnPayment_DateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Amount", DbType:="Money NOT NULL")>  _
	Public Property Amount() As Decimal
		Get
			Return Me._Amount
		End Get
		Set
			If ((Me._Amount = value)  _
						= false) Then
				Me.OnAmountChanging(value)
				Me.SendPropertyChanging
				Me._Amount = value
				Me.SendPropertyChanged("Amount")
				Me.OnAmountChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Member_Payment", Storage:="_Member", ThisKey:="Member_Id", OtherKey:="ID", IsForeignKey:=true)>  _
	Public Property Member() As Member
		Get
			Return Me._Member.Entity
		End Get
		Set
			Dim previousValue As Member = Me._Member.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Member.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Member.Entity = Nothing
					previousValue.Payments.Remove(Me)
				End If
				Me._Member.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Payments.Add(Me)
					Me._Member_Id = value.ID
				Else
					Me._Member_Id = CType(Nothing, Short)
				End If
				Me.SendPropertyChanged("Member")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
