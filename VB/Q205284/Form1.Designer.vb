Imports Microsoft.VisualBasic
Imports System
Namespace Q205284
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.bar2 = New DevExpress.XtraBars.Bar()
			Me.bar3 = New DevExpress.XtraBars.Bar()
			Me.dropDownButton1 = New DevExpress.XtraEditors.DropDownButton()
			Me.dropDownButton2 = New DevExpress.XtraEditors.DropDownButton()
			Me.myPopupControlContainer1 = New DXSample.MyPopupControlContainer(Me.components)
			Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myPopupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.myPopupControlContainer1.SuspendLayout()
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1, Me.bar2, Me.bar3})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.MainMenu = Me.bar2
			Me.barManager1.MaxItemId = 0
			Me.barManager1.StatusBar = Me.bar3
			' 
			' bar1
			' 
			Me.bar1.BarName = "Tools"
			Me.bar1.DockCol = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.Text = "Tools"
			' 
			' bar2
			' 
			Me.bar2.BarName = "Main menu"
			Me.bar2.DockCol = 0
			Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar2.OptionsBar.MultiLine = True
			Me.bar2.OptionsBar.UseWholeRow = True
			Me.bar2.Text = "Main menu"
			' 
			' bar3
			' 
			Me.bar3.BarName = "Status bar"
			Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
			Me.bar3.DockCol = 0
			Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
			Me.bar3.OptionsBar.AllowQuickCustomization = False
			Me.bar3.OptionsBar.DrawDragBorder = False
			Me.bar3.OptionsBar.UseWholeRow = True
			Me.bar3.Text = "Status bar"
			' 
			' dropDownButton1
			' 
			Me.dropDownButton1.DropDownControl = Me.myPopupControlContainer1
			Me.dropDownButton1.Location = New System.Drawing.Point(12, 55)
			Me.dropDownButton1.Name = "dropDownButton1"
			Me.dropDownButton1.Size = New System.Drawing.Size(135, 23)
			Me.dropDownButton1.TabIndex = 4
			Me.dropDownButton1.Text = "dropDownButton1"
			' 
			' dropDownButton2
			' 
			Me.dropDownButton2.Location = New System.Drawing.Point(153, 55)
			Me.dropDownButton2.Name = "dropDownButton2"
			Me.dropDownButton2.Size = New System.Drawing.Size(135, 23)
			Me.dropDownButton2.TabIndex = 5
			Me.dropDownButton2.Text = "dropDownButton2"
			' 
			' myPopupControlContainer1
			' 
			Me.myPopupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.myPopupControlContainer1.Controls.Add(Me.simpleButton2)
			Me.myPopupControlContainer1.Controls.Add(Me.simpleButton1)
			Me.myPopupControlContainer1.Controls.Add(Me.memoEdit1)
			Me.myPopupControlContainer1.Location = New System.Drawing.Point(12, 84)
			Me.myPopupControlContainer1.LookAndFeel.SkinName = "Money Twins"
			Me.myPopupControlContainer1.LookAndFeel.UseDefaultLookAndFeel = False
			Me.myPopupControlContainer1.Manager = Me.barManager1
			Me.myPopupControlContainer1.Name = "myPopupControlContainer1"
			Me.myPopupControlContainer1.Size = New System.Drawing.Size(200, 133)
			Me.myPopupControlContainer1.TabIndex = 6
			Me.myPopupControlContainer1.Visible = False
			' 
			' memoEdit1
			' 
			Me.memoEdit1.Location = New System.Drawing.Point(3, 4)
			Me.memoEdit1.MenuManager = Me.barManager1
			Me.memoEdit1.Name = "memoEdit1"
			Me.memoEdit1.Size = New System.Drawing.Size(194, 96)
			Me.memoEdit1.TabIndex = 0
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(3, 106)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "simpleButton1"
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(122, 106)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton2.TabIndex = 2
			Me.simpleButton2.Text = "simpleButton2"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(646, 406)
			Me.Controls.Add(Me.myPopupControlContainer1)
			Me.Controls.Add(Me.dropDownButton2)
			Me.Controls.Add(Me.dropDownButton1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myPopupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.myPopupControlContainer1.ResumeLayout(False)
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private barManager1 As DevExpress.XtraBars.BarManager
		Private bar1 As DevExpress.XtraBars.Bar
		Private bar2 As DevExpress.XtraBars.Bar
		Private bar3 As DevExpress.XtraBars.Bar
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private dropDownButton2 As DevExpress.XtraEditors.DropDownButton
		Private dropDownButton1 As DevExpress.XtraEditors.DropDownButton
		Private myPopupControlContainer1 As DXSample.MyPopupControlContainer
		Private simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
	End Class
End Namespace

