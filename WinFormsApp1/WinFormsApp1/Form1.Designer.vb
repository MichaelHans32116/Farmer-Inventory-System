﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        unameText = New TextBox()
        passText = New TextBox()
        lgnBtn = New Button()
        sgnText = New LinkLabel()
        lblErrorMessage = New Label()
        SuspendLayout()
        ' 
        ' unameText
        ' 
        unameText.BackColor = SystemColors.Desktop
        unameText.BorderStyle = BorderStyle.FixedSingle
        unameText.Cursor = Cursors.IBeam
        unameText.Font = New Font("League Spartan", 26.2499962F, FontStyle.Bold)
        unameText.ForeColor = Color.White
        unameText.Location = New Point(121, 429)
        unameText.Multiline = True
        unameText.Name = "unameText"
        unameText.Size = New Size(608, 61)
        unameText.TabIndex = 0
        unameText.Text = "Username"
        ' 
        ' passText
        ' 
        passText.BackColor = SystemColors.Desktop
        passText.BorderStyle = BorderStyle.FixedSingle
        passText.Cursor = Cursors.IBeam
        passText.Font = New Font("League Spartan", 26.2499962F, FontStyle.Bold)
        passText.ForeColor = Color.White
        passText.Location = New Point(121, 507)
        passText.Multiline = True
        passText.Name = "passText"
        passText.Size = New Size(608, 61)
        passText.TabIndex = 1
        passText.Text = "Password"
        ' 
        ' lgnBtn
        ' 
        lgnBtn.Cursor = Cursors.Hand
        lgnBtn.Font = New Font("League Spartan ExtraBold", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lgnBtn.ImageAlign = ContentAlignment.BottomCenter
        lgnBtn.Location = New Point(292, 625)
        lgnBtn.Name = "lgnBtn"
        lgnBtn.Size = New Size(260, 70)
        lgnBtn.TabIndex = 3
        lgnBtn.Text = "LOGIN"
        lgnBtn.UseVisualStyleBackColor = True
        ' 
        ' sgnText
        ' 
        sgnText.AutoSize = True
        sgnText.BackColor = Color.Transparent
        sgnText.Cursor = Cursors.Hand
        sgnText.Font = New Font("League Spartan Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sgnText.LinkBehavior = LinkBehavior.NeverUnderline
        sgnText.LinkColor = Color.White
        sgnText.Location = New Point(364, 698)
        sgnText.Name = "sgnText"
        sgnText.Size = New Size(119, 36)
        sgnText.TabIndex = 4
        sgnText.TabStop = True
        sgnText.Text = "or sign in"
        sgnText.VisitedLinkColor = Color.White
        ' 
        ' lblErrorMessage
        ' 
        lblErrorMessage.AutoSize = True
        lblErrorMessage.BackColor = Color.Transparent
        lblErrorMessage.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblErrorMessage.ForeColor = Color.LightSteelBlue
        lblErrorMessage.Location = New Point(197, 580)
        lblErrorMessage.Name = "lblErrorMessage"
        lblErrorMessage.Size = New Size(0, 32)
        lblErrorMessage.TabIndex = 5
        lblErrorMessage.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1924, 981)
        Controls.Add(lblErrorMessage)
        Controls.Add(sgnText)
        Controls.Add(lgnBtn)
        Controls.Add(passText)
        Controls.Add(unameText)
        DoubleBuffered = True
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Entry Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents unameText As TextBox
    Friend WithEvents passText As TextBox
    Friend WithEvents lgnBtn As Button
    Friend WithEvents sgnText As LinkLabel
    Friend WithEvents lblErrorMessage As Label

End Class
