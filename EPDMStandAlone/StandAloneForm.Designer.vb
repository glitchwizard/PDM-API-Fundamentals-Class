<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StandAloneForm
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
        Me.VaultButton = New System.Windows.Forms.Button()
        Me.VaultsComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.HresultButton = New System.Windows.Forms.Button()
        Me.VersionButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'VaultButton
        '
        Me.VaultButton.Location = New System.Drawing.Point(69, 29)
        Me.VaultButton.Name = "VaultButton"
        Me.VaultButton.Size = New System.Drawing.Size(148, 40)
        Me.VaultButton.TabIndex = 0
        Me.VaultButton.Text = "Vault"
        Me.VaultButton.UseVisualStyleBackColor = True
        '
        'VaultsComboBox
        '
        Me.VaultsComboBox.FormattingEnabled = True
        Me.VaultsComboBox.Location = New System.Drawing.Point(68, 120)
        Me.VaultsComboBox.Name = "VaultsComboBox"
        Me.VaultsComboBox.Size = New System.Drawing.Size(151, 21)
        Me.VaultsComboBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select Preferred Vault View"
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(70, 180)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(147, 36)
        Me.LoginButton.TabIndex = 3
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'HresultButton
        '
        Me.HresultButton.Location = New System.Drawing.Point(66, 227)
        Me.HresultButton.Name = "HresultButton"
        Me.HresultButton.Size = New System.Drawing.Size(154, 31)
        Me.HresultButton.TabIndex = 4
        Me.HresultButton.Text = "HRESULT"
        Me.HresultButton.UseVisualStyleBackColor = True
        '
        'VersionButton
        '
        Me.VersionButton.Location = New System.Drawing.Point(59, 269)
        Me.VersionButton.Name = "VersionButton"
        Me.VersionButton.Size = New System.Drawing.Size(168, 29)
        Me.VersionButton.TabIndex = 5
        Me.VersionButton.Text = "Version"
        Me.VersionButton.UseVisualStyleBackColor = True
        '
        'StandAloneForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 450)
        Me.Controls.Add(Me.VersionButton)
        Me.Controls.Add(Me.HresultButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VaultsComboBox)
        Me.Controls.Add(Me.VaultButton)
        Me.Name = "StandAloneForm"
        Me.Text = "Stand Alone"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VaultButton As Button
    Friend WithEvents VaultsComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginButton As Button
    Friend WithEvents HresultButton As Button
    Friend WithEvents VersionButton As Button
End Class
