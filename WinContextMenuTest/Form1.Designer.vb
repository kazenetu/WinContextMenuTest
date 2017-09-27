<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuItemDinamic = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemStatic = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemLongText = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemChangeDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 42)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(229, 224)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Test1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "テスト2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "1.改行を入れてコンテキストメニューに表示するキーワードを入力"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemDinamic, Me.MenuItemStatic, Me.MenuItemLongText, Me.MenuItemChangeDisplay})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(195, 114)
        '
        'MenuItemDinamic
        '
        Me.MenuItemDinamic.Name = "MenuItemDinamic"
        Me.MenuItemDinamic.Size = New System.Drawing.Size(194, 22)
        Me.MenuItemDinamic.Text = "動的メニュー"
        '
        'MenuItemStatic
        '
        Me.MenuItemStatic.Name = "MenuItemStatic"
        Me.MenuItemStatic.Size = New System.Drawing.Size(194, 22)
        Me.MenuItemStatic.Text = "静的メニュー"
        '
        'MenuItemLongText
        '
        Me.MenuItemLongText.Name = "MenuItemLongText"
        Me.MenuItemLongText.Size = New System.Drawing.Size(194, 22)
        Me.MenuItemLongText.Text = "すごい長いメニューアイテム"
        '
        'MenuItemChangeDisplay
        '
        Me.MenuItemChangeDisplay.Name = "MenuItemChangeDisplay"
        Me.MenuItemChangeDisplay.Size = New System.Drawing.Size(194, 22)
        Me.MenuItemChangeDisplay.Text = "表示切替"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 370)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuItemDinamic As ToolStripMenuItem
    Friend WithEvents MenuItemStatic As ToolStripMenuItem
    Friend WithEvents MenuItemLongText As ToolStripMenuItem
    Friend WithEvents MenuItemChangeDisplay As ToolStripMenuItem
End Class
