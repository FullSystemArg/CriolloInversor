Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim links As System.Windows.Forms.HtmlElementCollection
        links = WebBrowser1.Document.GetElementsByTagName("google")
        TextBox2.Text = links.ToString
    End Sub
End Class
