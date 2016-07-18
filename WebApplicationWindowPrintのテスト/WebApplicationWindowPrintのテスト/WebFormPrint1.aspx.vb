Public Class WebFormPrint1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Dim cScript As String = "alert('ClientScript');"
        Dim sScript As String = "alert('StartupScript');"



        Dim printScript As String = "self.window.print();"



        ClientScript.RegisterClientScriptBlock(Me.GetType(), "key", cScript, True)
        ClientScript.RegisterStartupScript(Me.GetType(), "key", sScript, True)


        'ClientScript.RegisterStartupScript(Me.GetType(), "key2", printScript, True)

        ClientScript.RegisterClientScriptBlock(Me.GetType(), "key2", printScript, True)


    End Sub

End Class