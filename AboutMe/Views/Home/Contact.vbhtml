@ModelType AboutMe.aboutMe.ContactFormModel

@Code
    ViewData("Title") = "Contact"
End Code

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewData("Title")</title>
    <link rel="stylesheet" href="~/Content/Styles.css">
</head>

<main aria-labelledby="title">
    <div Class="alert alert-success">
           @ViewData("Message")
    </div>

    <p>お問い合わせ事項がありましたら、お問い合わせください</p>
    <p>「名前」は全角で記入してください</p>
    <p>「メールアドレス」の入力が無い場合にはご返答が出来かねてしまいます</p>

    @Using Html.BeginForm("Contact", "Home", FormMethod.Post)
        @<div>
            @Html.LabelFor(Function(model As AboutMe.aboutMe.ContactFormModel) model.Name, "名前")
            @Html.TextBoxFor(Function(model As AboutMe.aboutMe.ContactFormModel) model.Name, New With {.class = "contact-control", .required = "required"})
        </div>
        @<div>
            @Html.LabelFor(Function(model As AboutMe.aboutMe.ContactFormModel) model.Email, "E-mail")
            @Html.TextBoxFor(Function(model As AboutMe.aboutMe.ContactFormModel) model.Email, New With {.class = "contact-control", .required = "required", .type = "email"})
        </div>
        @<div>
            @Html.LabelFor(Function(model As AboutMe.aboutMe.ContactFormModel) model.Message, "内容")
            @Html.TextAreaFor(Function(model As AboutMe.aboutMe.ContactFormModel) model.Message, New With {.class = "contact-control", .required = "required"})
        </div>
        @<div>
            <input type="submit" value="送信" class="btn btn-primary" />
        </div>
    End Using

    <address>
        <strong>メールアドレス :   </strong>   <a href="mailto:Support@example.com">ryos1988j19@gmail.com</a><br />
    </address>
</main>