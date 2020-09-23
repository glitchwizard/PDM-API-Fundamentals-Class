Imports EPDM.Interop.epdm
Public Class StandAloneForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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


End Class
