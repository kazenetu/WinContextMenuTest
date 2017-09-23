Public Class Form1
    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Me.MenuItemDinamic.DropDownItems.Clear()

        For Each item In Me.TextBox1.Text.Split(Environment.NewLine)
            Me.MenuItemDinamic.DropDownItems.Add(item.Replace(vbLf, String.Empty), Nothing, AddressOf MenuItemDinamic_Click)
        Next

        ContextMenuStrip1.Update()

        e.Cancel = False
    End Sub

    ''' <summary>
    ''' 静的メニュアイテムクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MenuItemStatic_Click(sender As Object, e As EventArgs) Handles MenuItemStatic.Click
        MessageBox.Show("静的メニューアイテムのクリック")
    End Sub

    ''' <summary>
    ''' 動的メニュアイテムクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MenuItemDinamic_Click(sender As Object, e As EventArgs)
        Dim item As ToolStripDropDownItem = CType(sender, ToolStripDropDownItem)

        MessageBox.Show(String.Format("動的メニューアイテム[{0}]のクリック", item))
    End Sub
End Class
