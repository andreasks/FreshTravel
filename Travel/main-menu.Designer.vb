<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataDasarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HotelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TLGuideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MakanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArsipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataDasarToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.ArsipToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(992, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataDasarToolStripMenuItem
        '
        Me.DataDasarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PelangganToolStripMenuItem, Me.HotelToolStripMenuItem, Me.BusToolStripMenuItem, Me.TLGuideToolStripMenuItem, Me.MakanToolStripMenuItem})
        Me.DataDasarToolStripMenuItem.Name = "DataDasarToolStripMenuItem"
        Me.DataDasarToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.DataDasarToolStripMenuItem.Text = "Data Dasar"
        '
        'PelangganToolStripMenuItem
        '
        Me.PelangganToolStripMenuItem.Name = "PelangganToolStripMenuItem"
        Me.PelangganToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PelangganToolStripMenuItem.Text = "Pelanggan"
        '
        'HotelToolStripMenuItem
        '
        Me.HotelToolStripMenuItem.Name = "HotelToolStripMenuItem"
        Me.HotelToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HotelToolStripMenuItem.Text = "Hotel"
        '
        'BusToolStripMenuItem
        '
        Me.BusToolStripMenuItem.Name = "BusToolStripMenuItem"
        Me.BusToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BusToolStripMenuItem.Text = "Transportasi"
        '
        'TLGuideToolStripMenuItem
        '
        Me.TLGuideToolStripMenuItem.Name = "TLGuideToolStripMenuItem"
        Me.TLGuideToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TLGuideToolStripMenuItem.Text = "TL dan Guide"
        '
        'MakanToolStripMenuItem
        '
        Me.MakanToolStripMenuItem.Name = "MakanToolStripMenuItem"
        Me.MakanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MakanToolStripMenuItem.Text = "Makan"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'ArsipToolStripMenuItem
        '
        Me.ArsipToolStripMenuItem.Name = "ArsipToolStripMenuItem"
        Me.ArsipToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ArsipToolStripMenuItem.Text = "Arsip"
        '
        'main_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 393)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "main_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "main_menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataDasarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HotelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TLGuideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MakanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArsipToolStripMenuItem As ToolStripMenuItem
End Class
