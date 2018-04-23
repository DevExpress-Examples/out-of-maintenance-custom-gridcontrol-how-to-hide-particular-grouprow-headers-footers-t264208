Imports DevExpress.Data
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace T263441
    Public Class MyDataController
        Inherits CurrencyDataController

        Protected Overrides Sub BuildVisibleIndexes()
            MyBase.BuildVisibleIndexes()
            If GroupedColumnCount = 0 Then
                Return
            End If
            Dim indexes(VisibleIndexes.Count - 1) As Integer
            VisibleIndexes.CopyTo(indexes, 0)
            VisibleIndexes.Clear()
            For Each rowHandle As Integer In indexes
                If IsGroupRowHandle(rowHandle) AndAlso Me.GetGroupRowValue(rowHandle).ToString() = String.Empty Then
                    ExpandRow(rowHandle) 'Auto expand  the empty group row
                    Continue For
                End If
                VisibleIndexes.Add(rowHandle)
            Next rowHandle
        End Sub
    End Class
End Namespace
