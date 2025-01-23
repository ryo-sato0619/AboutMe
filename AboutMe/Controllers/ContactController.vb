Imports System.Web.Mvc
Imports AboutMe.aboutMe
Imports Npgsql
Imports Newtonsoft.Json.Linq
Imports System.IO

Namespace Controllers
    Public Class ContactController
        Inherits System.Web.Mvc.Controller

        Private repository As ContactRepository

        ' POST: Contact/SubmitContact
        <HttpPost>
        Function SubmitContact(ByVal model As ContactFormModel) As ActionResult
            If ModelState.IsValid Then
                Dim repository As New ContactRepository(Server.MapPath("~/appsettings.json"))
                ' データベースにデータを保存
                repository.SaveContact(model)
                ViewData("Message") = "お問い合わせありがとうございます"
                Return RedirectToAction("Contact", "Home")
            End If
            Return View("Contact", model)
        End Function
    End Class
End Namespace
