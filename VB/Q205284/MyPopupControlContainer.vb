Imports Microsoft.VisualBasic
Imports DevExpress.XtraBars
Imports System.ComponentModel
Imports DevExpress.XtraBars.Controls
Imports DevExpress.LookAndFeel
Imports System
Imports System.Reflection

Namespace DXSample
	Public Class MyPopupControlContainer
		Inherits PopupControlContainer
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal container As IContainer)
			MyBase.New(container)
		End Sub
		Private temp As UserLookAndFeel
		Protected Overrides Function CreateSubControl(ByVal manager As BarManager) As PopupContainerBarControl
			If temp Is Nothing Then
				temp = New UserLookAndFeel(Me)
			End If
			temp.Assign(LookAndFeel)
			Return MyBase.CreateSubControl(manager)
		End Function
		Protected Overrides Function CreatePopupContainerBarControl(ByVal manager As BarManager) As PopupContainerBarControl
			LookAndFeel.Assign(temp)
			Return MyBase.CreatePopupContainerBarControl(manager)
		End Function
	End Class
End Namespace