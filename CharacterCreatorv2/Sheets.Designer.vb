<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sheets
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
        Panel1 = New Panel()
        CheckedListBox1 = New CheckedListBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(CheckedListBox1)
        Panel1.Location = New Point(53, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(900, 656)
        Panel1.TabIndex = 0
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.CheckOnClick = True
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Items.AddRange(New Object() {"Hoard of the Dragon Queen - HotDQ", "The Rise of Tiamat - RoT", "Tyranny of Dragons Re-Release - ToD", "Princes of the Apocalypse - PotA ", "Out of the Abyss - OotA", "Curse of Strahd - CoS", "Storm King's Thunder - SKT", "Tales from the Yawning Portal - TFtYP", "Tomb of Annihilation - ToA", "Waterdeep: Dragon Heist - WDH", "Waterdeep: Dungeon of the Mad Mage - WDotMM", "Stranger Things: The Hunt for Thessalhydra - StrT", "Ghost of Saltmarsh - GoS", "Baldur's Gate: Descent into Avernus - DiA", "Icewind Dale: Rime of the Frostmaiden - RotF", "Candlekeep Mysteries - CM", "The Wild Beyond The Witchlight - WBtW", "Critical Role: Call of the Netherdeep - CotN", "Journeys Through the Radiant Citadel - JTtRC", "Dragons of Stormwreck Isle - DoSI", "Dragonlance: Shadow of the Dragon Queen - DL", "Keys From the Golden Vault - KftGV", "Phandelver and Below: The Shattered Obelisk - Phan"})
        CheckedListBox1.Location = New Point(28, 64)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(272, 202)
        CheckedListBox1.TabIndex = 0
        ' 
        ' Sheets
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1308, 799)
        Controls.Add(Panel1)
        Name = "Sheets"
        Text = "Sheets"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckedListBox1 As CheckedListBox
End Class
