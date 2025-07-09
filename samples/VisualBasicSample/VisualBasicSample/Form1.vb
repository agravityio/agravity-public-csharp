Imports Agravity.Public.Api
Imports Agravity.Public.Client
Imports AgravityPublicLib

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get collection type from Agravity using the Agravity API (Agravity.Public package) for demonstration purposes.
        Dim agravityUrlProd As String = "<AgravityPublicUrlWithAPIEnding>"
        Dim APIKey As String = "<API-KEY>"

        '.BasePath = Environment.GetEnvironmentVariable("AgravityPublicUrl")
        Dim config As New Configuration With {
            .BasePath = "https://leichtagravitypublic.azurewebsites.net/api/"
        }

        config.ApiKey.Add("x-functions-key", APIKey)

        Dim apiInstance As New PublicCollectionTypeManagementApi(config)

        Dim myCollections As New Dictionary(Of String, String)
        myCollections.Add("<CollectionTypeName>", "<collTypeId>")
        Dim dam = New DAM(agravityUrlProd, APIKey, myCollections)



        'Try
        '    Dim id As String = "<collTypeId>"
        '    ' Beispiel: ID aus einer TextBox holen, falls vorhanden
        '    If Not String.IsNullOrEmpty(TextBox1.Text) Then
        '        id = TextBox1.Text
        '    End If

        '    If Not String.IsNullOrEmpty(id) Then
        '        Try
        '            Dim result = apiInstance.HttpCollectionTypesGetById(id)
        '            If result IsNot Nothing Then
        '                Debug.WriteLine(result)
        '                Return
        '            End If
        '        Catch ex As ApiException
        '            Debug.Print("Exception when calling PublicCollectionTypeManagementApi.HttpCollectionTypesGetById: " & ex.Message)
        '            Debug.Print("Status Code: " & ex.ErrorCode.ToString())
        '            Debug.Print(ex.StackTrace)
        '            MessageBox.Show($"Fehler: {ex.Message}{Environment.NewLine}Status Code: {ex.ErrorCode}")
        '        End Try
        '    Else
        '        Dim result = apiInstance.HttpCollectionTypesGet()
        '        Debug.WriteLine(result)
        '        Return
        '    End If
        'Catch ex As ApiException
        '    Debug.Print("Exception when calling PublicAssetManagementApi.HttpAssetUploadFile: " & ex.Message)
        '    Debug.Print("Status Code: " & ex.ErrorCode.ToString())
        '    Debug.Print(ex.StackTrace)
        '    Return
        'End Try
    End Sub
End Class
