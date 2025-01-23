Imports Npgsql
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports AboutMe.aboutMe

Public Class ContactRepository
    Private connectionString As String

    Public Sub New(ByVal filePath As String)
        Me.connectionString = GetConnectionString(filePath, "ConnectionStrings:PostgreSqlConnection")
    End Sub

    Public Sub SaveContact(ByVal model As ContactFormModel)
        Using connection As New NpgsqlConnection(connectionString)
            connection.Open()
            Using command As New NpgsqlCommand("INSERT INTO inquiry_history (user_name, email_address, inquiry_details, time_stamp) VALUES (@Name, @Email, @Message, @TimeStamp)", connection)
                command.Parameters.AddWithValue("@Name", model.user_name)
                command.Parameters.AddWithValue("@Email", model.email_address)
                command.Parameters.AddWithValue("@Message", model.inquiry_details)
                command.Parameters.AddWithValue("@TimeStamp", DateTime.Now)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Function GetConnectionString(ByVal filePath As String, ByVal key As String) As String
        Try
            If Not System.IO.File.Exists(filePath) Then
                Throw New FileNotFoundException("設定ファイルが見つかりません: " & filePath)
            End If
            Dim json As String = System.IO.File.ReadAllText(filePath)
            Dim jObject As JObject = JObject.Parse(json)
            Dim connectionString As String = jObject.SelectToken(key.Replace(":", "."))?.ToString()

            If connectionString Is Nothing Then
                Throw New Exception("接続文字列が見つかりません: " & key)
            End If

            Return connectionString
        Catch ex As Exception
            Throw New Exception("設定ファイルの読み込みに失敗しました: " & ex.Message)
        End Try
    End Function
End Class

