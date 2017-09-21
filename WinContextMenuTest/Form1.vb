Public Class Form1
    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Me.MenuItemDinamic.DropDownItems.Clear()

        For Each item In Me.TextBox1.Text.Split(Environment.NewLine)
            Me.MenuItemDinamic.DropDownItems.Add(item.Replace(vbLf, String.Empty))
        Next

        ContextMenuStrip1.Update()

        e.Cancel = False
    End Sub
End Class
