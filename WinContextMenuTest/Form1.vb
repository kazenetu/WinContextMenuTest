Public Class Form1

    ''' <summary>
    ''' メニューアイテムのインスタンスとテキスト情報
    ''' </summary>
    Private menuItemTexts As New Dictionary(Of ToolStripMenuItem, String)

    ''' <summary>
    ''' ウィンドウ初回表示イベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        ' メニューアイテムのインスタンスとテキストを格納
        For Each menuItem As ToolStripMenuItem In Me.ContextMenuStrip1.Items
            menuItemTexts.Add(menuItem, menuItem.Text)
        Next

    End Sub

    ''' <summary>
    ''' コンテキストメニューの表示イベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Me.MenuItemDinamic.DropDownItems.Clear()

        For Each item In Me.TextBox1.Text.Split(Environment.NewLine)
            Me.MenuItemDinamic.DropDownItems.Add(item.Replace(vbLf, String.Empty), Nothing, AddressOf MenuItemDinamic_Click)
        Next

        ' ダミー用メニューアイテムを非表示
        Me.MenuItemLongText.Visible = False

        ' メニューアイテムとテキストを設定
        For Each menuItem As ToolStripMenuItem In Me.ContextMenuStrip1.Items
            If menuItem.Available Then
                menuItem.Text = menuItemTexts(menuItem)
            Else
                menuItem.Text = String.Empty
            End If
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
