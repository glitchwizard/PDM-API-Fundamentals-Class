Imports EPDM.Interop.epdm
Imports EPDM.Interop.EPDMResultCode

Public Class StandAloneForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles VaultButton.Click
        'Declare an IEdmVault5 interface object
        Dim vault As IEdmVault5
        'Create an instance of IEdmVault5 interface object
        vault = New EdmVault5()

        'Check to see if we're logged in to a vault
        Debug.Print("We are" + IIf(vault.IsLoggedIn, "", " not") + " logged into a vault")

        'Display the Solidworks PDM Professional version
        Dim VerMajor As Integer
        Dim VerMinor As Integer
        vault.GetVersion(VerMajor, VerMinor)
        MsgBox("Solidworks PDM Professional Version is " + VerMajor.ToString() + "." + VerMinor.ToString())
    End Sub

    Private Sub StandAloneForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vault As IEdmVault8 = New EdmVault5
        Dim Views() As EdmViewInfo = {}
        vault.GetVaultViews(Views, False)
        VaultsComboBox.Items.Clear()
        For Each View As EdmViewInfo In Views
            VaultsComboBox.Items.Add(View.mbsVaultName)
        Next
        If VaultsComboBox.Items.Count > 0 Then
            VaultsComboBox.Text = VaultsComboBox.Items(0)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

        'Declare and create an instance of IEdmVault5 object
        Dim vault As IEdmVault5 = New EdmVault5()

        'Log in to the selected Vault as the current user
        vault.LoginAuto(VaultsComboBox.Text, Me.Handle.ToInt32())

        'Check to see if we're logged into a vault
        MsgBox("We are" + IIf(vault.IsLoggedIn, "", " not") + " logged into a vault.")

        'Display the vault name
        MsgBox("The vault name is """ + vault.Name + """.")

        'Diplay the path of the vault view folder
        MsgBox("The path of the vault view folder is """ + vault.RootFolderPath + """.")

    End Sub

    Private Sub Hresult_Click(sender As Object, e As EventArgs) Handles HresultButton.Click
        'Declare and create an instance of IEdmVault5 object
        Dim vault As IEdmVault5 = New EdmVault5()

        Try
            'Verify that the installed version of Solidworks
            'PDM Pro meets our minimum needs
            vault.VerifyVersion(29, 0)
        Catch ex As Runtime.InteropServices.COMException
            'We will get here if VerifyVersion dosn't return S_OK
            Select Case ex.ErrorCode
                Case EdmResultErrorCodes_e.E_EDM_UNSUPPORTED_PROGRAM_VERSION
                    MessageBox.Show("The installed program is at a version level that is lower than the specified version.")
                Case Else
                    MessageBox.Show("HRESULT = 0x" + ex.ErrorCode.ToString("X") + vbCrLf + ex.Message)
            End Select
        End Try
    End Sub

End Class
