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

    <table class="about-table">
        <tr>
            <th class="about-th"><strong>名前</strong>:</th>
            <td class="about-td">佐藤　涼（さとう　りょう）</td>
        </tr>
        <tr>
            <th class="about-th"><strong>性別</strong>:</th>
            <td class="about-td">男</td>
        </tr>
        <tr>
            <th class="about-th"><strong>生年月日</strong>:</th>
            <td class="about-td">1988年6月19日</td>
        </tr>
        <tr>
            <th class="about-th"><strong>出身地</strong>:</th>
            <td class="about-td">埼玉県</td>
        </tr>
        <tr>
            <th class="about-th"><strong>お仕事</strong>:</th>
            <td class="about-td">
                コンピュータ関連を浅く
                <br>
                ※詳細は関わったスキルページをご覧ください
            </td>
        </tr>
        <tr>
            <th class="about-th"><strong>趣味</strong>:</th>
            <td class="about-td">読書（最近怪しい）、プロレス・格闘技観戦、サッカー</td>
        </tr>
    </table>
</main>
