Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace T263441
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			Dim customers = GetCustomers()
			Me.gridControl1.DataSource = New BindingList(Of Customer)(customers)
			gridView1.ExpandAllGroups()

		End Sub

		Public Function GetCustomers() As IList(Of Customer)
			Dim customers As IList(Of Customer) = New List(Of Customer)()

			customers.Add(New Customer() With {.FirstName = "Charlotte", .LastName = "Cooper", .Country = "UK", .Cash = 1200, .HasChildren = True})
			customers.Add(New Customer() With {.FirstName = "Shelley", .LastName = "Burke", .Country = "Germany", .Cash = 1233, .HasChildren = True})
			customers.Add(New Customer() With {.FirstName = "Regina", .LastName = "Murphy", .Country = "Italy", .Cash = 632, .HasChildren = True})
			customers.Add(New Customer() With {.FirstName = "Yoshi", .LastName = "Nagase", .Country = "Italy", .Cash = 1242, .HasChildren = False})
			customers.Add(New Customer() With {.FirstName = "Mayumi", .LastName = "Ohno", .Country = "Sweden", .Cash = 234, .HasChildren = True})
			customers.Add(New Customer() With {.FirstName = "Nancy", .LastName = "Davolio", .Country = "USA", .Cash = 5432, .HasChildren = True})
			customers.Add(New Customer() With {.FirstName = "Andrew", .LastName = "Fuller", .Country = "USA", .Cash = 2342, .HasChildren = False})
			customers.Add(New Customer() With {.FirstName = "Janet", .LastName = "Leverling", .Country = "USA", .Cash = 1412, .HasChildren = True})
			customers.Add(New Customer() With {.FirstName = "Steven", .LastName = "Buchanan", .Country = "", .Cash = 1645, .HasChildren = True})
			customers.Add(New Customer() With {.FirstName = "Michael", .LastName = "Suyama", .Country = "Germany", .Cash = 1465, .HasChildren = True})
			customers.Add(New Customer() With {.FirstName = "Robert", .LastName = "King", .Country = "Sweden", .Cash = 1941, .HasChildren = True})
			customers.Add(New Customer() With {.FirstName = "Laura", .LastName = "Callahan", .Country = "Sweden", .Cash = 1489, .HasChildren = False})
			customers.Add(New Customer() With {.FirstName = "Anne", .LastName = "Dodsworth", .Country = "UK", .Cash = 1945, .HasChildren = True})
			Return customers
		End Function
	End Class
End Namespace
