Imports System.Net
Public Class Form1
    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint
        TextBox1.Text = "http://www."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(TextBox1.Text)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.GoHome()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.ShowSaveAsDialog()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            WebBrowser1.Navigate(TextBox1.Text)

        End If
    End Sub

    Private Sub ΕκτύπωσηToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΕκτύπωσηToolStripMenuItem.Click
        WebBrowser1.ShowPrintDialog()
    End Sub

    Private Sub ΙδιότητεςToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΙδιότητεςToolStripMenuItem.Click
        WebBrowser1.ShowPropertiesDialog()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Button1.Text = WebBrowser1.DocumentTitle

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebBrowser1.GoBack()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WebBrowser1.GoForward()

    End Sub

    Private Sub ΈξοδοςToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΈξοδοςToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub ΒοήθειαΕφαρμογήςToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΒοήθειαΕφαρμογήςToolStripMenuItem.Click
        MessageBox.Show("Δώστε στην πλατφόρμα το όνομα της ιστοσελίδας που αναζητάτε.
                          Η χρησιμότητα των κουμπιών είναι: αναζήτηση δίπλα από το χώρο κειμένου και
                            το κουμπί refresh για ανανέωση της ιστοσελίδας.Υπάρχουν
                             επίσης, κουμπιά αποθήκευσης,αρχικής 
                            σελίδας καθώς και το δεξί και αριστερό βέλος που σας μεταβιβάζουν μία σελίδα
                            πίσω ή μπροστά, αντίστοιχα!")
    End Sub
End Class
