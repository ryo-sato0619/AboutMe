@ModelType AboutMe.aboutMe.ContactFormModel

@Code
    ViewData("Title") = "Contact"
End Code

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewData("Title")</title>
    <link rel="stylesheet" href="~/Content/Styles2.css">
</head>

<main aria-labelledby="title">
    <div Class="alert alert-success">
           @ViewData("Message")
    </div>

    <p>お問い合わせ事項がありましたら、お問い合わせください</p>
    <p>「名前」は全角で記入してください</p>
    <p>「E-mail」の入力が無い場合にはご返答が出来かねてしまいます</p>

    @Using Html.BeginForm("Contact", "Home", FormMethod.Post)
    @<table class="contact-table">
    <tr>
        <th>@Html.LabelFor(Function(model As AboutMe.aboutMe.ContactFormModel) model.Name, "名前", New With {.Class = "contact-title-control"})</th>
        <td>@Html.TextBoxFor(Function(model As AboutMe.aboutMe.ContactFormModel) model.Name, New With {.class = "contact-control", .required = "required"})</td>
    </tr>
    <tr>
        <th>@Html.LabelFor(Function(model As AboutMe.aboutMe.ContactFormModel) model.Email, "E-mail", New With {.Class = "contact-title-control"})</th>
        <td>@Html.TextBoxFor(Function(model As AboutMe.aboutMe.ContactFormModel) model.Email, New With {.class = "contact-control", .required = "required", .type = "email"})</td>
    </tr>
    <tr>
        <th>@Html.LabelFor(Function(model As AboutMe.aboutMe.ContactFormModel) model.Message, "内容", New With {.Class = "contact-title-control"})</th>
        <td>@Html.TextAreaFor(Function(model As AboutMe.aboutMe.ContactFormModel) model.Message, New With {.class = "contact-control content-textarea", .required = "required"})</td>
    </tr>
    <tr>
        <td colspan="2">
            <input type="submit" value="送信" class="btn btn-primary" />
        </td>
    </tr>
    </table>
    End Using

    <address>
        <strong>メールアドレス :   </strong>   <a href="mailto:Support@example.com">ryos1988j19@gmail.com</a><br />
    </address>
</main>