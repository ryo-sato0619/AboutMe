@Code
    ViewData("Title") = "skill"
End Code

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewData("Title")</title>
    <link rel="stylesheet" href="~/Content/Styles.css">
</head>

<main aria-labelledby="title">
    <h2>@ViewData("Message")</h2>
    <p>2024年12月現在の内容です。</p>


    <table class="skill-table" border="1">
        <tbody>
            <tr>
                <th class="skill-caption"> <p><strong>資格名</strong></p></th>
                <td class="skill-caption">取得年月日</td>
                <td class="skill-caption">関連言語、スキル等</td>
            </tr>
            <tr>
                <th class="skill-th"> <p><strong>Excel VBA ベーシック</strong>:</p></th>
                <td class="skill-td">2020年12年月</td>
                <td class="skill-td">Excel VBA</td>
            </tr>
            <tr>
                <th class="skill-th"> <p><strong>Linuc レベル1取得</strong>:</p></th>
                <td class="skill-td">2023年9月</td>
                <td class="skill-td">Linux</td>
            </tr>
            <tr>
                <th class="skill-th"> <p><strong>Google サイバーセキュリティ</strong>:</p></th>
                <td class="skill-td">2024年7月</td>
                <td class="skill-td">セキュリティ、Linux、Python</td>
            </tr>
        </tbody>
    </table>
</main>

