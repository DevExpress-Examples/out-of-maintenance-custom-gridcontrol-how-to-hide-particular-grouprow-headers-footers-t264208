Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace T263441
    Public Class Customer
        Private _firstName As String
        Private _lastName As String
        Private _country As String
        Private _hasChildren As Boolean
        Private _cash As Integer

        Public Sub New()
        End Sub

        Public Property FirstName() As String
            Get
                Return _firstName
            End Get
            Set(ByVal value As String)
                If value <> _firstName Then
                    _firstName = value
                End If
            End Set
        End Property
        Public Property LastName() As String
            Get
                Return _lastName
            End Get
            Set(ByVal value As String)
                If value <> _lastName Then
                    _lastName = value
                End If
            End Set
        End Property

        Public Property Country() As String
            Get
                Return _country
            End Get
            Set(ByVal value As String)
                If value <> _country Then
                    _country = value
                End If
            End Set
        End Property

        Public Property HasChildren() As Boolean
            Get
                Return _hasChildren
            End Get
            Set(ByVal value As Boolean)
                If value <> _hasChildren Then
                    _hasChildren = value
                End If
            End Set
        End Property

        Public Property Cash() As Integer
            Get
                Return _cash
            End Get
            Set(ByVal value As Integer)
                If value <> _cash Then
                    _cash = value
                End If
            End Set
        End Property
    End Class
End Namespace
