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
End Class
