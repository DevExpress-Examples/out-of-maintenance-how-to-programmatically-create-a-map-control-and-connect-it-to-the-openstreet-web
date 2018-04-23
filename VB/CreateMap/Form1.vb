Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace CreateMap
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create a map control.
			Dim map As New MapControl()

			' Specify the map position on the form           
			map.Dock = DockStyle.Fill

			' Create a layer.
			Dim layer As New ImageTilesLayer()
			map.Layers.Add(layer)

			' Create a data provider.
			Dim provider As New OpenStreetMapDataProvider()
			layer.DataProvider = provider

			' Specify the map zoom level and center point 
			map.ZoomLevel = 2
			map.CenterPoint = New GeoPoint(38, -100)

			' Add the map control to the window.
			Me.Controls.Add(map)
		End Sub
	End Class
End Namespace
