'Imports Microsoft.Web.Services2
Imports System.Security.Cryptography.X509Certificates
Imports Microsoft.Web.Services3.Security.X509
Imports System.Security.Cryptography
Imports System.Text

Module Module1

    Sub Main()
        'Console.WriteLine(vbCrLf & "Exists Certs Name and Location")
        'Console.WriteLine("------ ----- -------------------------")

        'For Each storeLocation As StoreLocation In _
        '        CType([Enum].GetValues(GetType(StoreLocation)), StoreLocation())

        '    For Each storeName As StoreName In _
        '            CType([Enum].GetValues(GetType(StoreName)), StoreName())

        '        Dim store As New X509Store(storeName, storeLocation)

        '        Try
        '            store.Open(OpenFlags.OpenExistingOnly)
        '            Console.WriteLine("Yes    {0,4}  {1}, {2}", _
        '                store.Certificates.Count, store.Name, store.Location)
        '        Catch e As CryptographicException
        '            Console.WriteLine("No           {0}, {1}", _
        '                store.Name, store.Location)
        '        End Try
        '    Next

        '    Console.WriteLine()
        'Next

        'Dim cer As X509Certificate2 = getCertificate()
        'Dim cert As X509Certificate = Nothing
        'Dim store As X509CertificateStore = Nothing

        'store = Security.X509.X509CertificateStore.LocalMachineStore(Microsoft.Web.Services2.Security.X509.X509CertificateStore.MyStore)
        'If Not store.OpenRead() Then Console.WriteLine("Nothing")
        'Dim certs As Security.X509.X509CertificateCollection = store.FindCertificateBySubjectName("CN=localhost")
        Dim store As X509Store = New X509Store(StoreName.My, StoreLocation.CurrentUser)
        store.Open(OpenFlags.OpenExistingOnly)
        Dim certs As X509Certificate2 = (From cc In store.Certificates.Find(X509FindType.FindBySubjectName, "Tao Zhou (Pactera Technologies)", False)).FirstOrDefault

        'Dim c As X509Certificate2 = certs
        Dim r() As Byte
        r = X509Util.GetKeyIdentifier(certs)
        Dim identifier As String = ""
        For Each b As Byte In r
            identifier += Conversion.Hex(b)
        Next
        Dim h As Char() = {"0"c, "1"c, "2"c, "3"c, "4"c, "5"c, _
     "6"c, "7"c, "8"c, "9"c, "A"c, "B"c, _
     "C"c, "D"c, "E"c, "F"c}
        Dim c As Char() = New Char(r.Length * 2 - 1) {}
        For i As Integer = 0 To r.Length - 1
            c(i * 2 + 0) = h(r(i) >> 4)
            c(i * 2 + 1) = h(r(i) And &HF)
        Next
        Dim keyIdentifier As New String(c)

        Dim certs3 As X509Certificate2Collection = store.Certificates.Find(X509FindType.FindBySubjectKeyIdentifier, "BD2C9AE7CDD2ECECC8AB1E540A2A7BBC4ABC11B8", False)

        Dim certs2 As X509Certificate2 = (From cc In store.Certificates.Find(X509FindType.FindBySubjectKeyIdentifier, keyIdentifier, False)).FirstOrDefault
        Console.WriteLine(Bytes_To_String2(r))
    End Sub
    Private Function Bytes_To_String2(ByVal bytes_Input As Byte()) As String
        Dim strTemp As New StringBuilder(bytes_Input.Length * 2)
        For Each b As Byte In bytes_Input
            strTemp.Append(Conversion.Hex(b))
        Next
        Return strTemp.ToString()
    End Function
    Function BinToHex(ByVal BinNum As String) As String
        Dim BinLen As Integer
        Dim HexNum As Object
        BinLen = Len(BinNum)
        If BinNum.Length > 0 Then
            Select Case (BinNum.Length)
                Case 1
                    If BinNum.Length > 8 Then
                        Console.WriteLine("The Hex number is: ", BinNum.Length)
                    Else
                        Console.WriteLine("Hex number is: ", HexNum.Length)
                    End If
            End Select
        End If
        BinToHex = Hex(HexNum)
    End Function
    Private Function getCertificate() As X509Certificate2
        Dim clientStore As X509Store = New X509Store(StoreName.My, StoreLocation.CurrentUser)
        Try
            Dim cert2 As X509Certificate2 = (From c In clientStore.Certificates.Find(X509FindType.FindBySubjectName, "CN=Tao Zhou (Pactera Technologies)", False)).FirstOrDefault
            Return cert2
        Catch ex As Exception
            Throw ex
        Finally
            clientStore.Close()
        End Try
    End Function
End Module
