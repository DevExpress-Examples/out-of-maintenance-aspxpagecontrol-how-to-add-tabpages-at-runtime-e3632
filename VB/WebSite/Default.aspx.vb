Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxTabControl
Imports DevExpress.Web.ASPxGridView
Imports DevExpress.Web.ASPxEditors

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim pageControl As New ASPxPageControl()
		pageControl.ID = "pageControl"
		Form.Controls.Add(pageControl)
		pageControl.TabPages.Add("Page 1", "Page 1")
		pageControl.TabPages.Add("Page 2", "Page 2")

		Dim grid As New ASPxGridView()
		grid.ID = "grid"
		pageControl.TabPages(0).Controls.Add(grid)
		grid.DataSource = AccessDataSource1
		grid.DataBind()

		Dim txt As New ASPxTextBox()
		txt.ID = "txt"
		txt.Text = "myTextBox"
		pageControl.TabPages(1).Controls.Add(txt)



	End Sub
End Class
