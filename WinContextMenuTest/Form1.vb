Public Class Form1
    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Me.MenuItemDinamic.DropDownItems.Clear()

        For Each item In Me.TextBox1.Text.Split(Environment.NewLine )
            Dim menuItem = Me.MenuItemDinamic.DropDownItems.Add(item)
            'menuItem.AutoSize = True
            'menuItem.AutoToolTip = False
            'menuItem.Height = 22
            'menuItem.Width = 120
            menuItem.TextAlign = ContentAlignment.MiddleCenter
            menuItem.TextDirection = ToolStripTextDirection.Horizontal
        Next

        ContextMenuStrip1.Update()

        e.Cancel = False
    End Sub
End Class
