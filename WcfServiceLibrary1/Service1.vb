' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in both code and config file together.
Imports Microsoft.Web.Services2
Public Class Service1
    Implements IService1

    Public Function GetData(ByVal value As Integer) As String Implements IService1.GetData
        Return String.Format("You entered: {0}", value)
    End Function
    Public Function GetCertificate(ByVal value As String) As String Implements IService1.GetCertificate
        Dim cert As Security.X509.X509Certificate = Nothing
        Dim store As Security.X509.X509CertificateStore = Nothing

        store = Security.X509.X509CertificateStore.LocalMachineStore(Microsoft.Web.Services2.Security.X509.X509CertificateStore.MyStore)
        If Not store.OpenRead() Then Console.WriteLine("Nothing")
        Dim certs As Security.X509.X509CertificateCollection = store.FindCertificateBySubjectString("localhost")

        Return String.Format("certificate is {0}", certs(0).Subject)
    End Function

    Public Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType Implements IService1.GetDataUsingDataContract
        If composite Is Nothing Then
            Throw New ArgumentNullException("composite")
        End If
        If composite.BoolValue Then
            composite.StringValue &= "Suffix"
        End If
        Return composite
    End Function

End Class
