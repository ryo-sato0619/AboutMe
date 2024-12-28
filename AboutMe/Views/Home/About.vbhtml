@Code
    ViewData("Title") = "About"
End Code

<main aria-labelledby="title">
    <h2>@ViewData("Message")</h2>

    <div class="container">
        <div class="into">
            <div class="info-box">
                <div class="info-row">
                    <div class="info-column">
                        <p class="info-item"><strong>名前</strong>: 佐藤　涼（さとう　りょう）</p>
                        <p class="info-item"><strong>性別</strong>: 男</p>
                        <p class="info-item"><strong>生年月日</strong>: 1988年6月19日</p>
                        <p class="info-item"><strong>出身地</strong>: 埼玉県</p>
                        <div class="info-item-large">
                            <p><strong>お仕事</strong>: コンピュータに関わるアレコレ</p>
                            <p class="info-detail">※詳細は関わったスキルページをご覧ください</p>
                        </div>
                        <p class="info-item"><strong>趣味</strong>: 読書（最近怪しい）、プロレス・格闘技観戦、サッカー</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>
