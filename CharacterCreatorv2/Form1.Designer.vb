<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        creatortabs = New TabControl()
        TabRuleSets = New TabPage()
        PnlFifthOpt = New Panel()
        clbChosenBooks = New CheckedListBox()
        clbSources = New CheckedListBox()
        clbAccessories = New CheckedListBox()
        clbAdventures = New CheckedListBox()
        btnThirdPartyAcc = New Button()
        cbGeneric = New CheckBox()
        cbAllFifth = New CheckBox()
        btnSourcesReset = New Button()
        PnlEditionOpt = New Panel()
        rbSecond = New RadioButton()
        rbThird = New RadioButton()
        rbFourth = New RadioButton()
        rbFifth = New RadioButton()
        LblEditionOpt = New Label()
        TabStatsDetails = New TabPage()
        TabRacesTemplates = New TabPage()
        TabClasses = New TabPage()
        TabSkills = New TabPage()
        TabFeats = New TabPage()
        TabEquipItems = New TabPage()
        PnlOptions = New Panel()
        btnSheets = New Button()
        BtnOptions = New Button()
        BtnSave = New Button()
        BtnSaveAs = New Button()
        BtnLoad = New Button()
        BtnHelp = New Button()
        creatortabs.SuspendLayout()
        TabRuleSets.SuspendLayout()
        PnlFifthOpt.SuspendLayout()
        PnlEditionOpt.SuspendLayout()
        PnlOptions.SuspendLayout()
        SuspendLayout()
        ' 
        ' creatortabs
        ' 
        creatortabs.Controls.Add(TabRuleSets)
        creatortabs.Controls.Add(TabStatsDetails)
        creatortabs.Controls.Add(TabRacesTemplates)
        creatortabs.Controls.Add(TabClasses)
        creatortabs.Controls.Add(TabSkills)
        creatortabs.Controls.Add(TabFeats)
        creatortabs.Controls.Add(TabEquipItems)
        creatortabs.Location = New Point(160, 2)
        creatortabs.Margin = New Padding(3, 4, 3, 4)
        creatortabs.Name = "creatortabs"
        creatortabs.SelectedIndex = 0
        creatortabs.Size = New Size(1269, 1009)
        creatortabs.TabIndex = 0
        ' 
        ' TabRuleSets
        ' 
        TabRuleSets.Controls.Add(PnlFifthOpt)
        TabRuleSets.Controls.Add(PnlEditionOpt)
        TabRuleSets.Location = New Point(4, 27)
        TabRuleSets.Margin = New Padding(3, 4, 3, 4)
        TabRuleSets.Name = "TabRuleSets"
        TabRuleSets.Padding = New Padding(3, 4, 3, 4)
        TabRuleSets.Size = New Size(1261, 978)
        TabRuleSets.TabIndex = 0
        TabRuleSets.Text = "Rule Sets"
        TabRuleSets.UseVisualStyleBackColor = True
        ' 
        ' PnlFifthOpt
        ' 
        PnlFifthOpt.BorderStyle = BorderStyle.FixedSingle
        PnlFifthOpt.Controls.Add(clbChosenBooks)
        PnlFifthOpt.Controls.Add(clbSources)
        PnlFifthOpt.Controls.Add(clbAccessories)
        PnlFifthOpt.Controls.Add(clbAdventures)
        PnlFifthOpt.Controls.Add(btnThirdPartyAcc)
        PnlFifthOpt.Controls.Add(cbGeneric)
        PnlFifthOpt.Controls.Add(cbAllFifth)
        PnlFifthOpt.Controls.Add(btnSourcesReset)
        PnlFifthOpt.Location = New Point(6, 64)
        PnlFifthOpt.Name = "PnlFifthOpt"
        PnlFifthOpt.Size = New Size(911, 907)
        PnlFifthOpt.TabIndex = 1
        ' 
        ' clbChosenBooks
        ' 
        clbChosenBooks.CheckOnClick = True
        clbChosenBooks.FormattingEnabled = True
        clbChosenBooks.Location = New Point(470, 71)
        clbChosenBooks.Name = "clbChosenBooks"
        clbChosenBooks.Size = New Size(415, 823)
        clbChosenBooks.Sorted = True
        clbChosenBooks.TabIndex = 15
        ' 
        ' clbSources
        ' 
        clbSources.CheckOnClick = True
        clbSources.FormattingEnabled = True
        clbSources.Items.AddRange(New Object() {"Acquisitions Incorporated - AcqInc", "Eberron: Rising from the Last War - Eber", "Explorer's Guide to Wildemount - Expl", "Guildmasters' Guide to Ravnica - Guild", "Mythic Odysseys of Theros - Mythic", "Planescape: Adventures in the Multiverse - Planescape", "Spelljammer: Adventures in Space - Spell", "Strixhaven: A Curriculum of Chaos - Strix", "Sword Coats Adventurer's Guide - Sword", "Van Richten's Guide to Ravenloft - Van"})
        clbSources.Location = New Point(23, 93)
        clbSources.Name = "clbSources"
        clbSources.Size = New Size(364, 214)
        clbSources.TabIndex = 14
        ' 
        ' clbAccessories
        ' 
        clbAccessories.CheckOnClick = True
        clbAccessories.FormattingEnabled = True
        clbAccessories.Items.AddRange(New Object() {"Bigby Presents: Glory of the Giants - Bigby", "Fizban's Treasury of Dragons - Fizban", "Mordenkainen's Tome of Foes - MordToF", "Mordenkainen Presents: Monsters of the Multiverse - MordMotM", "Rick and Morty Basic Rules - RnM", "Tasha's Cauldron of Everything - Tasha", "The Book of Many Things - BoMT", "Volo's Guide to Monsters - Volos", "Xanathar's Guide to Everything - Xanathar"})
        clbAccessories.Location = New Point(23, 396)
        clbAccessories.Name = "clbAccessories"
        clbAccessories.Size = New Size(364, 193)
        clbAccessories.TabIndex = 14
        ' 
        ' clbAdventures
        ' 
        clbAdventures.CheckOnClick = True
        clbAdventures.FormattingEnabled = True
        clbAdventures.Items.AddRange(New Object() {"Hoard of the Dragon Queen - HotDQ", "The Rise of Tiamat - RoT", "Tyranny of Dragons Re-Release - ToD", "Princes of the Apocalypse - PotA ", "Out of the Abyss - OotA", "Curse of Strahd - CoS", "Storm King's Thunder - SKT", "Tales from the Yawning Portal - TFtYP", "Tomb of Annihilation - ToA", "Waterdeep: Dragon Heist - WDH", "Waterdeep: Dungeon of the Mad Mage - WDotMM", "Stranger Things: The Hunt for Thessalhydra - StrT", "Ghost of Saltmarsh - GoS", "Baldur's Gate: Descent into Avernus - DiA", "Icewind Dale: Rime of the Frostmaiden - RotF", "Candlekeep Mysteries - CM", "The Wild Beyond The Witchlight - WBtW", "Critical Role: Call of the Netherdeep - CotN", "Journeys Through the Radiant Citadel - JTtRC", "Dragons of Stormwreck Isle - DoSI", "Dragonlance: Shadow of the Dragon Queen - DL", "Keys From the Golden Vault - KftGV", "Phandelver and Below: The Shattered Obelisk - Phan"})
        clbAdventures.Location = New Point(23, 676)
        clbAdventures.Name = "clbAdventures"
        clbAdventures.Size = New Size(364, 193)
        clbAdventures.TabIndex = 13
        ' 
        ' btnThirdPartyAcc
        ' 
        btnThirdPartyAcc.Font = New Font("Comic Sans MS", 6F, FontStyle.Regular, GraphicsUnit.Point)
        btnThirdPartyAcc.Location = New Point(302, 359)
        btnThirdPartyAcc.Name = "btnThirdPartyAcc"
        btnThirdPartyAcc.Size = New Size(85, 31)
        btnThirdPartyAcc.TabIndex = 12
        btnThirdPartyAcc.Text = "Show / Hide Third Party Accessories"
        btnThirdPartyAcc.UseVisualStyleBackColor = True
        ' 
        ' cbGeneric
        ' 
        cbGeneric.AutoSize = True
        cbGeneric.Location = New Point(305, 18)
        cbGeneric.Name = "cbGeneric"
        cbGeneric.Size = New Size(94, 22)
        cbGeneric.TabIndex = 11
        cbGeneric.Text = "Generic 5E"
        cbGeneric.UseVisualStyleBackColor = True
        ' 
        ' cbAllFifth
        ' 
        cbAllFifth.AutoSize = True
        cbAllFifth.Location = New Point(96, 18)
        cbAllFifth.Name = "cbAllFifth"
        cbAllFifth.Size = New Size(169, 22)
        cbAllFifth.TabIndex = 12
        cbAllFifth.Text = "All 5th Edition Settings"
        cbAllFifth.UseVisualStyleBackColor = True
        ' 
        ' btnSourcesReset
        ' 
        btnSourcesReset.Location = New Point(570, 2)
        btnSourcesReset.Name = "btnSourcesReset"
        btnSourcesReset.Size = New Size(134, 51)
        btnSourcesReset.TabIndex = 2
        btnSourcesReset.Text = "Reset Sourcebook Choices"
        btnSourcesReset.UseVisualStyleBackColor = True
        ' 
        ' PnlEditionOpt
        ' 
        PnlEditionOpt.Controls.Add(rbSecond)
        PnlEditionOpt.Controls.Add(rbThird)
        PnlEditionOpt.Controls.Add(rbFourth)
        PnlEditionOpt.Controls.Add(rbFifth)
        PnlEditionOpt.Controls.Add(LblEditionOpt)
        PnlEditionOpt.Location = New Point(344, 7)
        PnlEditionOpt.Name = "PnlEditionOpt"
        PnlEditionOpt.Size = New Size(573, 51)
        PnlEditionOpt.TabIndex = 0
        ' 
        ' rbSecond
        ' 
        rbSecond.AutoSize = True
        rbSecond.Location = New Point(469, 16)
        rbSecond.Name = "rbSecond"
        rbSecond.Size = New Size(96, 22)
        rbSecond.TabIndex = 4
        rbSecond.TabStop = True
        rbSecond.Text = "2nd Edition"
        rbSecond.UseVisualStyleBackColor = True
        ' 
        ' rbThird
        ' 
        rbThird.AutoSize = True
        rbThird.Location = New Point(348, 16)
        rbThird.Name = "rbThird"
        rbThird.Size = New Size(115, 22)
        rbThird.TabIndex = 3
        rbThird.TabStop = True
        rbThird.Text = "3 / 3.5 Edition"
        rbThird.UseVisualStyleBackColor = True
        ' 
        ' rbFourth
        ' 
        rbFourth.AutoSize = True
        rbFourth.Location = New Point(249, 16)
        rbFourth.Name = "rbFourth"
        rbFourth.Size = New Size(93, 22)
        rbFourth.TabIndex = 2
        rbFourth.TabStop = True
        rbFourth.Text = "4th Edition"
        rbFourth.UseVisualStyleBackColor = True
        ' 
        ' rbFifth
        ' 
        rbFifth.AutoSize = True
        rbFifth.Location = New Point(150, 16)
        rbFifth.Name = "rbFifth"
        rbFifth.Size = New Size(93, 22)
        rbFifth.TabIndex = 1
        rbFifth.TabStop = True
        rbFifth.Text = "5th Edition"
        rbFifth.UseVisualStyleBackColor = True
        ' 
        ' LblEditionOpt
        ' 
        LblEditionOpt.AutoSize = True
        LblEditionOpt.Location = New Point(13, 18)
        LblEditionOpt.Name = "LblEditionOpt"
        LblEditionOpt.Size = New Size(131, 18)
        LblEditionOpt.TabIndex = 0
        LblEditionOpt.Text = "Select Your Edition:"
        ' 
        ' TabStatsDetails
        ' 
        TabStatsDetails.Location = New Point(4, 24)
        TabStatsDetails.Margin = New Padding(3, 4, 3, 4)
        TabStatsDetails.Name = "TabStatsDetails"
        TabStatsDetails.Padding = New Padding(3, 4, 3, 4)
        TabStatsDetails.Size = New Size(1261, 981)
        TabStatsDetails.TabIndex = 1
        TabStatsDetails.Text = "Stats / Details"
        TabStatsDetails.UseVisualStyleBackColor = True
        ' 
        ' TabRacesTemplates
        ' 
        TabRacesTemplates.Location = New Point(4, 24)
        TabRacesTemplates.Name = "TabRacesTemplates"
        TabRacesTemplates.Size = New Size(1261, 981)
        TabRacesTemplates.TabIndex = 2
        TabRacesTemplates.Text = "Races / Templates"
        TabRacesTemplates.UseVisualStyleBackColor = True
        ' 
        ' TabClasses
        ' 
        TabClasses.Location = New Point(4, 24)
        TabClasses.Name = "TabClasses"
        TabClasses.Size = New Size(1261, 981)
        TabClasses.TabIndex = 3
        TabClasses.Text = "Classes"
        TabClasses.UseVisualStyleBackColor = True
        ' 
        ' TabSkills
        ' 
        TabSkills.Location = New Point(4, 24)
        TabSkills.Name = "TabSkills"
        TabSkills.Size = New Size(1261, 981)
        TabSkills.TabIndex = 4
        TabSkills.Text = "Skills"
        TabSkills.UseVisualStyleBackColor = True
        ' 
        ' TabFeats
        ' 
        TabFeats.Location = New Point(4, 24)
        TabFeats.Name = "TabFeats"
        TabFeats.Size = New Size(1261, 981)
        TabFeats.TabIndex = 5
        TabFeats.Text = "Feats"
        TabFeats.UseVisualStyleBackColor = True
        ' 
        ' TabEquipItems
        ' 
        TabEquipItems.Location = New Point(4, 24)
        TabEquipItems.Name = "TabEquipItems"
        TabEquipItems.Size = New Size(1261, 981)
        TabEquipItems.TabIndex = 6
        TabEquipItems.Text = "Equipment / Items "
        TabEquipItems.UseVisualStyleBackColor = True
        ' 
        ' PnlOptions
        ' 
        PnlOptions.Controls.Add(btnSheets)
        PnlOptions.Controls.Add(BtnOptions)
        PnlOptions.Controls.Add(BtnSave)
        PnlOptions.Controls.Add(BtnSaveAs)
        PnlOptions.Controls.Add(BtnLoad)
        PnlOptions.Controls.Add(BtnHelp)
        PnlOptions.Location = New Point(4, 29)
        PnlOptions.Name = "PnlOptions"
        PnlOptions.Size = New Size(158, 279)
        PnlOptions.TabIndex = 1
        ' 
        ' btnSheets
        ' 
        btnSheets.Location = New Point(24, 191)
        btnSheets.Name = "btnSheets"
        btnSheets.Size = New Size(111, 48)
        btnSheets.TabIndex = 5
        btnSheets.Text = "Character Sheet"
        btnSheets.UseVisualStyleBackColor = True
        ' 
        ' BtnOptions
        ' 
        BtnOptions.Location = New Point(42, 124)
        BtnOptions.Name = "BtnOptions"
        BtnOptions.Size = New Size(75, 29)
        BtnOptions.TabIndex = 4
        BtnOptions.Text = "Options"
        BtnOptions.TextAlign = ContentAlignment.TopCenter
        BtnOptions.UseVisualStyleBackColor = True
        ' 
        ' BtnSave
        ' 
        BtnSave.AutoSize = True
        BtnSave.Location = New Point(36, 22)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(87, 28)
        BtnSave.TabIndex = 3
        BtnSave.Text = "Quick Save"
        BtnSave.UseVisualStyleBackColor = True
        ' 
        ' BtnSaveAs
        ' 
        BtnSaveAs.AutoSize = True
        BtnSaveAs.Location = New Point(31, 56)
        BtnSaveAs.Name = "BtnSaveAs"
        BtnSaveAs.Size = New Size(97, 28)
        BtnSaveAs.TabIndex = 2
        BtnSaveAs.Text = "Save As New"
        BtnSaveAs.UseVisualStyleBackColor = True
        ' 
        ' BtnLoad
        ' 
        BtnLoad.AutoSize = True
        BtnLoad.Location = New Point(24, 90)
        BtnLoad.Name = "BtnLoad"
        BtnLoad.Size = New Size(111, 28)
        BtnLoad.TabIndex = 1
        BtnLoad.Text = "Load Character"
        BtnLoad.UseVisualStyleBackColor = True
        ' 
        ' BtnHelp
        ' 
        BtnHelp.Location = New Point(42, 158)
        BtnHelp.Name = "BtnHelp"
        BtnHelp.Size = New Size(75, 27)
        BtnHelp.TabIndex = 0
        BtnHelp.Text = "Help"
        BtnHelp.TextAlign = ContentAlignment.TopCenter
        BtnHelp.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1770, 1061)
        Controls.Add(PnlOptions)
        Controls.Add(creatortabs)
        Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        creatortabs.ResumeLayout(False)
        TabRuleSets.ResumeLayout(False)
        PnlFifthOpt.ResumeLayout(False)
        PnlFifthOpt.PerformLayout()
        PnlEditionOpt.ResumeLayout(False)
        PnlEditionOpt.PerformLayout()
        PnlOptions.ResumeLayout(False)
        PnlOptions.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents creatortabs As TabControl
    Friend WithEvents TabRuleSets As TabPage
    Friend WithEvents TabStatsDetails As TabPage
    Friend WithEvents TabRacesTemplates As TabPage
    Friend WithEvents TabClasses As TabPage
    Friend WithEvents TabSkills As TabPage
    Friend WithEvents TabFeats As TabPage
    Friend WithEvents TabEquipItems As TabPage
    Friend WithEvents PnlEditionOpt As Panel
    Friend WithEvents LblEditionOpt As Label
    Friend WithEvents rbSecond As RadioButton
    Friend WithEvents rbThird As RadioButton
    Friend WithEvents rbFourth As RadioButton
    Friend WithEvents rbFifth As RadioButton
    Friend WithEvents PnlOptions As Panel
    Friend WithEvents BtnHelp As Button
    Friend WithEvents BtnOptions As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnSaveAs As Button
    Friend WithEvents BtnLoad As Button
    Friend WithEvents PnlFifthOpt As Panel
    Friend WithEvents cbAllFifth As CheckBox
    Friend WithEvents cbGeneric As CheckBox
    Friend WithEvents btnSourcesReset As Button
    Friend WithEvents btnThirdPartyAcc As Button
    Friend WithEvents btnSheets As Button
    Friend WithEvents clbAccessories As CheckedListBox
    Friend WithEvents clbAdventures As CheckedListBox
    Friend WithEvents clbSources As CheckedListBox
    Friend WithEvents clbChosenBooks As CheckedListBox
End Class
