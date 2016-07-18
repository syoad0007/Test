Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.printFrame1.Attributes("src") = "No.aspx"

        Me.printFrame2.Attributes("src") = "No.aspx"

        Me.printFrame4.Attributes("src") = "No.aspx"

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.printFrame1.Attributes("src") = "WebFormPrint1.aspx"


    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        ClientScript.RegisterStartupScript(Me.GetType(), "main1", "alert('1');", True)


        Me.printFrame2.Attributes("src") = "WebFormPrint1.aspx"


    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click





        Me.printFrame4.Attributes("src") = "WebFormPrint2.aspx"
    End Sub
End Class