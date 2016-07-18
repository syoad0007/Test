Public Class WebFormPrint2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Dim cScript As String = "alert('ClientScript222');"
        Dim sScript As String = "alert('StartupScript222');"



        Dim printScript As String = "self.window.print();"


        ClientScript.RegisterStartupScript(Me.GetType(), "key2", printScript, True)

        ClientScript.RegisterClientScriptBlock(Me.GetType(), "key", cScript, True)
        ClientScript.RegisterStartupScript(Me.GetType(), "key", sScript, True)



    End Sub

End Class