@Code
    ViewData("Title") = "About"
End Code

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewData("Title")</title>
    <link rel="stylesheet" href="~/Content/Styles.css">
</head>

<main aria-labelledby="title">
    <h2>@ViewData("Message")</h2>

    <div class="about-container">
        <div class="into">
            <div class="about-info-box">
                <div class="about-info-row">
                    <div class="info-column">
                        <p class="about-info-item"><strong>名前</strong>: 佐藤　涼（さとう　りょう）</p>
                        <p class="about-info-item"><strong>性別</strong>: 男</p>
                        <p class="about-info-item"><strong>生年月日</strong>: 1988年6月19日</p>
                        <p class="about-info-item"><strong>出身地</strong>: 埼玉県</p>
                        <div class="about-info-item-large">
                            <p><strong>お仕事</strong>: コンピュータに関わるアレコレ</p>
                            <p class="about-info-detail">※詳細は関わったスキルページをご覧ください</p>
                        </div>
                        <p class="about-info-item"><strong>趣味</strong>: 読書（最近怪しい）、プロレス・格闘技観戦、サッカー</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>
