Imports MODI
Imports System.IO
Partial Class VB
    Inherits System.Web.UI.Page
    Protected Sub Upload(sender As Object, e As EventArgs)
        Dim filePath As String = Server.MapPath("~/Uploads/" + Path.GetFileName(FileUpload1.PostedFile.FileName))
        FileUpload1.SaveAs(filePath)
        Dim extractText As String = Me.ExtractTextFromImage(filePath)
        lblText.Text = extractText.Replace(Environment.NewLine, "<br />")
    End Sub

    Private Function ExtractTextFromImage(filePath As String) As String
        Dim modiDocument As New Document()
        modiDocument.Create(filePath)
        modiDocument.OCR(MiLANGUAGES.miLANG_ENGLISH)
        Dim modiImage As MODI.Image = TryCast(modiDocument.Images(0), MODI.Image)
        Dim extractedText As String = modiImage.Layout.Text
        modiDocument.Close()
        Return extractedText
    End Function
End Class

