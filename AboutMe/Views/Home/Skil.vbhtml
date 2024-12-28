@Code
    ViewData("Title") = "Skil"
End Code

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewData("Title")</title>
    <link rel="stylesheet" href="~/Content/Styles.css">
</head>

<main aria-labelledby="title">
    <h2>@ViewData("Message")</h2>
    <p>経験月数は累計で、2024年12月現在の内容です。</p>

    <div class="skills-container">
        <div class="skill-item">
            <p><strong>Excel VBA</strong>: 24ヶ月</p>
        </div>
        <div class="skill-item">
            <p><strong>Access VBA</strong>: 24ヶ月</p>
        </div>
        <div class="skill-item">
            <p><strong>VB.NET</strong>: 3ヶ月</p>
        </div>
    </div>
</main>

