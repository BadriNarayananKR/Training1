Public Class _default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Write("Hello! Welcome to DevOps Training on " & Today.Date)
    End Sub

End Class