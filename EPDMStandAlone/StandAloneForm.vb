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
End Class
