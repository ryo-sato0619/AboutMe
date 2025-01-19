Imports System.IO
Imports System.Web.Mvc
Imports AboutMe.aboutMe
Imports System.Net
Imports System.Net.Mail
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
