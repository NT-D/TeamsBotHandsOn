# Bot Framework & LUIS で作る Microsoft Teams 連携ボット ハンズオン
Microsoft Teams と連携する Bot 開発をするための学習用レポジトリです。

お願い：このハンズオンでお気づきの点があればこのレポジトリの **issue** に投稿お願いいたします。このページやソースに対するプルリクエストも歓迎いたします。


## ハンズオンガイド

### ハンズオンの目標
このハンズオンでは、2時間を目安に初級課題の完了を目標とします。

初級課題を終えることにより、Bot Framework を使った Microsoft Teams と連携する Bot を構築することができます。初級課題を終えて時間に余裕のある方は、中級課題として LUIS の設定を行い Bot から 接続させるための API の立ち上げを行い、Bot と連携を行えるようにします。

各課題のリンク先のブログにはサンプルコードがありますので、後からじっくりと取り組んでいただくことができます。逆に、サンプルコードに目を通していただいてから各課題のブログを読んでいただいても構いません。  

### ハンズオンの準備
以下のページを参照して Visual Studio, Bot Framework(Bot Builder SDK), Bot Emulator による開発環境をセットアップします。

[一問一答 Bot の開発 (Getting Started)](https://secretarybotja.wordpress.com/2017/02/12/%E4%B8%80%E5%95%8F%E4%B8%80%E7%AD%94-bot-%E3%81%AE%E9%96%8B%E7%99%BA-getting-started/)

<font size="1">

**2017/05/25補足(Bot Builder SDK)**：最新版の Bot Builder SDK のデフォルトコードでは、`MessageContoroller.cs` の `public async Task<HttpResponseMessage> Post([FromBody]Activity activity)` の中身が `await Conversation.SendAsync(activity, () => new Dialogs.RootDialog());` というシンプルな記述になっており、 `RootDialog.cs` に会話の処理を飛ばすような記述となっています。この準備の段階では、`RootDialog.cs` の存在は忘れていただいて、ブログの内容のまま `MessageContoroller.cs` の `public async Task<HttpResponseMessage> Post([FromBody]Activity activity)` 内の一部を書き換えることで進行可能です。 このデフォルトの`RootDialog.cs`のような書き方は、**初級課題2**の[Dialog を使った”会話”の実装](https://secretarybotja.wordpress.com/2017/02/18/dialog-%E3%82%92%E4%BD%BF%E3%81%A3%E3%81%9F%E4%BC%9A%E8%A9%B1%E3%81%AE%E5%AE%9F%E8%A3%85/)において `await Conversation.SendAsync(activity, () => new MeetingDialog());` という形で使われています。また、**初級課題3**では、Bot の会話処理のルーター的な役割として `RootDialog.cs` がでてきます。

</font>

<font size="1">

**2017/05/25補足(Microsoft Teamsとの連携)**：Microsoft Teams と連携を試していただく際に、会社でお使いの Office 365 の Microsoft Teams では外部アプリの利用が止められている可能性があります。設定箇所は[はじめよう Microsoft Teams 第2回](https://blogs.msdn.microsoft.com/lync_support_team_blog_japan/2016/11/25/start-microsoft-teams-2/)の **“[Microsoft Teams で外部アプリを利用できるようになります] と [外部アプリのサイドローディングを利用できるようになります]”** を確認してください。（設定変更にはOffice 365 の全体管理者が必要です。このハンズオン実施中で変更が難しい場合は、携帯電話があれば10分ほどで取得が可能ですので、30日間使える[Office 365 無料使用版](https://products.office.com/ja-jp/business/office-365-enterprise-e3-business-software)の取得をお勧めいたします。なお、取得するテナントのドメイン "例：abc.onmicrosoft.com" の “abc” の部分は、hackdaysbot20170523など業務とは関係ない適当なものにすることをお勧めいたします。）

</font>

### ハンズオンの Bot 動作例
初級課題と中級課題を終えたときの [Bot の動作例](https://webchat.botframework.com/embed/AppHandle?s=5L1_4PZV9BE.cwA.cmQ.2w7cRmWfiOTrY6T87SvxKGzPugYvaHLG1oGeerWNGy8)です。

（実際に課題を終えたときには、Microsoft Teams 上で動作する Bot が完成します。今回の課題では、Bot Directory を使っていただいているので Web Chat が Channel にありますのでこのような公開もできます。）

## ハンズオン

### 初級課題
Bot Builder SDK でローカルに作成していた Bot を Azure Web Apps にアップロードします。そして、Bot Directory と Channel を使い Bot を Microsoft Teams と連携させます。

Bot の機能としては、チャットインターフェイス上で、ボタンを使ってメインメニューの機能、ホテル・旅行の予約を Bot とのチャットで行う機能を実装します。

サンプルコードでは、`Controllers` と `Dialogs` フォルダにあるファイルが中心となってきますので、そちらを読んでみてください。

1. [作った Bot に Teams 経由で話しかける](https://secretarybotja.wordpress.com/2017/02/18/%E4%BD%9C%E3%81%A3%E3%81%9F-bot-%E3%81%AB-skype-%E7%B5%8C%E7%94%B1%E3%81%A7%E8%A9%B1%E3%81%97%E3%81%8B%E3%81%91%E3%81%A6%E3%81%BF%E3%82%8B/)

2. [Dialog を使った”会話”の実装](https://secretarybotja.wordpress.com/2017/02/18/dialog-%E3%82%92%E4%BD%BF%E3%81%A3%E3%81%9F%E4%BC%9A%E8%A9%B1%E3%81%AE%E5%AE%9F%E8%A3%85/)

3. [複数の話題を扱えるBotを作る](https://secretarybotja.wordpress.com/2017/02/19/%E8%A4%87%E6%95%B0%E3%81%AE%E8%A9%B1%E9%A1%8C%E3%82%92%E6%89%B1%E3%81%88%E3%82%8Bbot%E3%82%92%E4%BD%9C%E3%82%8B/)


**2017/05/26補足(自作したBotを使ってもらう)**： せっかく作ったBotなので他の人にも試してもらいたいと思います。初級課題1の最後に作った Bot を **[Add to Teams] をクリック** という操作で Microsoft Teams チャット画面で使えるようにするのですが、この時のURLを **リンクをコピー** などして Microsoft Teams 使える人に教えると他の人にも試してもらえます。


### 中級課題

はじめに、Microsoft Cogonitive Services の LUIS (Language Understanding Intelligent Service) を利用して、自然言語で Bot とやり取りできる API の準備を行います。

以下の URL に記載されている内容を参考に LUIS のセットアップを行い、入力した自然言語での問いかけへの分析結果が JSON 形式で LUIS から返されることを確認します。

4. [LUISを利用できるようにする](/LUIS/LUIS.md)

次に、上記手順を実施の上、TeamsBotプロジェクトを使ってBot開発をしてください。プロジェクトに[`LuisService.cs`](/TeamsBot/TeamsBot/Services/LuisService.cs)を追加して、 App ID, App Key を埋め込むと使えるようになります。


Microsoft.Cognitive.LUIS を NuGet でインストールします。（[ツール]-[NuGetパッケージマネージャー]-[ソリューションのNuGetパッケージの管理]）

そして、サンプルコードを参考に、[LuisService.cs](TeamsBot/TeamsBot/Services/LuisService.cs)も作成し、 App ID と  App Key を埋め込むと使えるようになります。Publish した LUIS の URL から App ID と App Key を取得する方法は以下を参照。

* App ID : apps/の後ろから?までの文字列
* App Key(Endpoint Key) : subscription-key=の後ろから&までの文字列

LUIS に言葉を教え込んだ(Intents の Utterancesを増やした)のに Bot の動作が変わらない場合は、*Train&Test で Train Application* と *Publish App で Publish* を行ったか確認してみてください。



### 上級課題

Azure ADと連携の実装や、認証情報を使って Bot から Office 365 に Microsoft Graph API 経由で接続します。

5. [Bot に Azure AD 認証/認可を組み込む](https://secretarybotja.wordpress.com/2017/02/25/bot-%E3%81%AB-azure-ad-%E8%AA%8D%E8%A8%BC%E8%AA%8D%E5%8F%AF%E3%82%92%E7%B5%84%E3%81%BF%E8%BE%BC%E3%82%80/)
6. [Bot から Graph API を呼び出す](https://secretarybotja.wordpress.com/2017/02/28/bot-%E3%81%8B%E3%82%89-365-api-%E3%82%92%E5%91%BC%E3%81%B3%E5%87%BA%E3%81%99/)

Azure の検索サービスである Azure Search と、NoSQL Database サービスのDocumentDB と Bot を連携させ Bot に検索機能を実装します。

7. [Botから検索できるようにする](https://secretarybotja.wordpress.com/2017/03/06/bot%e3%81%8b%e3%82%89%e6%a4%9c%e7%b4%a2%e3%81%a7%e3%81%8d%e3%82%8b%e3%82%88%e3%81%86%e3%81%ab%e3%81%99%e3%82%8b/)



## 参考情報

* 今回のハンズオンで触っていただいた Bor Framework とはそもそも何かを把握したい方は、この "[Bot Framework 概要と好きなところ](https://secretarybotja.wordpress.com/2017/02/12/bot-framework-%e6%a6%82%e8%a6%81%e3%81%a8%e5%a5%bd%e3%81%8d%e3%81%aa%e3%81%a8%e3%81%93%e3%82%8d/)" 
にヒントがございます。


* コードの中で変数を活用し会話の状態を保存することができますが、Bot Framework State service という会話の中の状態を保存する機能が実はあります。その概要については "[Bot State Service の用途に迫る!](https://secretarybotja.wordpress.com/2017/02/19/state-service-%E3%81%AE%E7%94%A8%E9%80%94%E3%81%AB%E8%BF%AB%E3%82%8B/)" を読んでみてください。


* 上級課題の先には、Office 365 と実用レベルで連携する Bot の構築が可能です。どんなことができるかは実際に触ってみるのが早いと思います。"[SecretaryBotを雇おう！](https://secretarybotja.wordpress.com/2017/04/10/secretarybot%e3%82%92%e9%9b%87%e3%81%8a%e3%81%86%ef%bc%81/)" と 
"[SecretaryBotがメディアで紹介されました](https://secretarybotja.wordpress.com/2017/04/21/secretarybot%e3%81%8c%e3%83%a1%e3%83%87%e3%82%a3%e3%82%a2%e3%81%a7%e7%b4%b9%e4%bb%8b%e3%81%95%e3%82%8c%e3%81%be%e3%81%97%e3%81%9f/)"のブログには実際に Microsoft Teams から試せる SecreataryBot についての情報が記載されています。この秘書ボットは、Exchange Online の会議スケジュールを作ってくれます。ぜひ触ってみてください！

 
 * このハンズオンで構築した Bot を API とさらに連携してもっとできることを増やしていきましょう！ この "[Computer Vision API](https://azure.microsoft.com/ja-jp/services/cognitive-services/computer-vision/)" では、Cognitive Services のひとつである Computer Vision API のサンプルを試すことができます。Microsoft Teams から Bot に対して画像をアップロードして処理させてみたりなど、Bot の適用範囲を広げることができます。

