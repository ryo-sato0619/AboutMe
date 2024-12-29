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


    <table class="skill-table" border="1">
        <tbody>
            <tr>
                <th class="skill-caption">言語</th>
                <td class="skill-caption"></td>
            </tr>
            <tr>
                <th class="skill-th"> <p><strong>Excel VBA</strong>:</p></th>
                <td class="skill-td">24ヶ月</td>
            </tr>
            <tr>
                <th class="skill-th"> <p><strong>Access VBA</strong>:</p></th>
                <td class="skill-td">24ヶ月</td>
            </tr>
            <tr>
                <th class="skill-th"> <p><strong>VB.NET</strong>:</p></th>
                <td class="skill-td">3ヶ月</td>
            </tr>
        </tbody>
    </table>
    <table class="skill-table" border="1">
        <tbody>
            <tr>
                <th class="skill-caption">DB</th>
                <td class="skill-caption"></td>
            </tr>
            <tr>
                <th class="skill-th"><p><strong>PostgreSQL</strong>:</p></th>
                <td class="skill-td">3ヶ月</td>
            </tr>
        </tbody>
    </table>
    <table class="skill-table" border="1">
        <tbody>
            <tr>
                <th class="skill-caption">OS</th>
                <td class="skill-caption"></td>
            </tr>
            <tr>
                <th class="skill-th"><p><strong>Windows</strong>:</p></th>
                <td class="skill-td">24ヶ月</td>
            </tr>
        </tbody>
    </table>
</main>

