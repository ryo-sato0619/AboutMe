Imports System.IO
Imports System.Web.Mvc
Imports AboutMe.aboutMe
Imports System.Net
Imports Npgsql
Imports Newtonsoft.Json.Linq
Public Class HomeController
    Inherits System.Web.Mvc.Controller


    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "自己紹介ページ"
        Return View()
    End Function

    Function Certification() As ActionResult
        ViewData("Message") = "保有資格ページ"
        Return View()
    End Function

    Function Skil() As ActionResult
        ViewData("Message") = "関わったスキルページ"
        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "お問い合わせページ"

        Return View()
    End Function

    <HttpPost>
    Function Contact(ByVal model As ContactFormModel) As ActionResult
        If ModelState.IsValid Then
            ' ここでデータ処理を行う（ファイルに）保存
            Dim filePath As String = Server.MapPath("~/App_Data/ContactForms.txt")
            Using writer As New StreamWriter(filePath, True)
                writer.WriteLine($"Name: {model.Name}, Email: {model.Email}, Message: {model.Message}")
            End Using
            ViewData("Message") = "お問い合わせありがとうございます"
            Return RedirectToAction("Contact")
        End If
        Return View(model)
    End Function

End Class

Namespace Controllers
    Public Class ContactController
        Inherits Controller

        ' POST: Contact
        <HttpPost>
        Function Contact(ByVal model As ContactFormModel) As ActionResult
            If ModelState.IsValid Then
                ' データベースにデータを保存
                Dim connectionString As String = GetConnectionString(Server.MapPath("~/appsettings.json"), "ConnectionStrings:PostgreSqlConnection")
                Using connection As New NpgsqlConnection(connectionString)
                    connection.Open()
                    Using command As New NpgsqlCommand("INSERT INTO ContactForms (Name, Email, Message) VALUES (@Name, @Email, @Message)", connection)
                        command.Parameters.AddWithValue("@Name", model.Name)
                        command.Parameters.AddWithValue("@Email", model.Email)
                        command.Parameters.AddWithValue("@Message", model.Message)
                        command.ExecuteNonQuery()
                    End Using
                End Using
                ViewData("Message") = "お問い合わせありがとうございます"
                Return RedirectToAction("Contact")
            End If
            Return View(model)
        End Function

        ' 設定ファイルから接続文字列を取得
        Private Function GetConnectionString(ByVal filePath As String, ByVal key As String) As String
            Try
                If Not System.IO.File.Exists(filePath) Then
                    Throw New FileNotFoundException("設定ファイルが見つかりません: " & filePath)
                End If
                Dim json As String = System.IO.File.ReadAllText(filePath)
                Dim jObject As JObject = jObject.Parse(json)
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
End Namespace