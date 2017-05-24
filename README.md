# ハンズオン：Bot Framework & LUIS で作る Microsoft Teams 連携ボット
Microsoft Teams と連携するBot開発をするための学習用レポジトリです。


## ハンズオンガイド

### ハンズオンの目標
今回のハンズオンでは、2時間を目安に初級課題の完了を目標とします。

初級課題を終えることにより、Bot Framework を使い Microsoft Teams と連携する Bot を構築することができます。初級課題を終えて時間に余裕のある方は、Bot と LUIS を API 経由で連携させ、Bot が自然言語に対応する機能を実装します。

各課題のリンク先のブログにはサンプルコードがありますので、たとえ時間名に終わらなくても、後からじっくりと取り組むことができます。


### ハンズオンの準備
以下のページを参照して Visual Studio, Bot Framework, Bot Emulator による開発環境をセットアップします。

[一問一答 Bot の開発 (Getting Started)](https://secretarybotja.wordpress.com/2017/02/12/%E4%B8%80%E5%95%8F%E4%B8%80%E7%AD%94-bot-%E3%81%AE%E9%96%8B%E7%99%BA-getting-started/)

### 初級課題
Bot Builder SDK を Azure Web Apps にアップロードして、Microsoft Teamsと連携する Bot を構築します。

チャットインターフェイス上で、ボタンを使ってメインメニューを実現し、ホテル・旅行の予約を Bot とのチャットで行う機能と、自然言語でのQA機能を実装します。
1. [作った Bot に Teams 経由で話しかける](https://secretarybotja.wordpress.com/2017/02/18/%E4%BD%9C%E3%81%A3%E3%81%9F-bot-%E3%81%AB-skype-%E7%B5%8C%E7%94%B1%E3%81%A7%E8%A9%B1%E3%81%97%E3%81%8B%E3%81%91%E3%81%A6%E3%81%BF%E3%82%8B/)

2. [Dialog を使った”会話”の実装](https://secretarybotja.wordpress.com/2017/02/18/dialog-%E3%82%92%E4%BD%BF%E3%81%A3%E3%81%9F%E4%BC%9A%E8%A9%B1%E3%81%AE%E5%AE%9F%E8%A3%85/)

3. [複数の話題を扱えるBotを作る](https://secretarybotja.wordpress.com/2017/02/19/%E8%A4%87%E6%95%B0%E3%81%AE%E8%A9%B1%E9%A1%8C%E3%82%92%E6%89%B1%E3%81%88%E3%82%8Bbot%E3%82%92%E4%BD%9C%E3%82%8B/)


### 中級課題

Microsoft コグニティブサービスの LUIS を利用して、自然言語でBotとやり取りできるようにします。以下のURLに記載されている内容をもとに LUIS のセットアップと Bot への組み込みを行います。

4. [LUISを利用できるようにする](/LUIS/LUIS.md)

<<<<<<< HEAD
>>>>>>> cf2048f5c4ec61657839c37bdf0b1a274ed78f3c

### 上級課題

Azure ADと連携の実装や、認証情報を使って Bot から Office 365 に Microsoft Graph API 経由で接続します。

5. [Bot に Azure AD 認証/認可を組み込む](https://secretarybotja.wordpress.com/2017/02/25/bot-%E3%81%AB-azure-ad-%E8%AA%8D%E8%A8%BC%E8%AA%8D%E5%8F%AF%E3%82%92%E7%B5%84%E3%81%BF%E8%BE%BC%E3%82%80/)
6. [Bot から Graph API を呼び出す](https://secretarybotja.wordpress.com/2017/02/28/bot-%E3%81%8B%E3%82%89-365-api-%E3%82%92%E5%91%BC%E3%81%B3%E5%87%BA%E3%81%99/)
7. [Botから検索できるようにする](https://secretarybotja.wordpress.com/2017/03/06/bot%e3%81%8b%e3%82%89%e6%a4%9c%e7%b4%a2%e3%81%a7%e3%81%8d%e3%82%8b%e3%82%88%e3%81%86%e3%81%ab%e3%81%99%e3%82%8b/)

- - -



### 参考情報

今回のハンズオンで触っていただいた Bor Framework とはそもそも何かを把握したい方は、以下のページを参照していただくとそのヒントがあるかもしません。

[Bot Framework 概要と好きなところ](https://secretarybotja.wordpress.com/2017/02/12/bot-framework-%e6%a6%82%e8%a6%81%e3%81%a8%e5%a5%bd%e3%81%8d%e3%81%aa%e3%81%a8%e3%81%93%e3%82%8d/)


 コードの中で変数を活用し会話の状態を保存することができますが、Bot Framework State service という会話の中の状態を保存する機能が実はあります。その概要については以下のページを読んでみてください。

[Bot State Service の用途に迫る!](https://secretarybotja.wordpress.com/2017/02/19/state-service-%E3%81%AE%E7%94%A8%E9%80%94%E3%81%AB%E8%BF%AB%E3%82%8B/)


上級課題の先には、Office 365 と実用範囲で連携する Bot の構築が可能です。以下の2つのブログには実際に Microsoft Teams から試せる SecreataryBot についての情報が記載されています。興味があれば触ってみてください。

[SecretaryBotを雇おう！](https://secretarybotja.wordpress.com/2017/04/10/secretarybot%e3%82%92%e9%9b%87%e3%81%8a%e3%81%86%ef%bc%81/)

[SecretaryBotがメディアで紹介されました](https://secretarybotja.wordpress.com/2017/04/21/secretarybot%e3%81%8c%e3%83%a1%e3%83%87%e3%82%a3%e3%82%a2%e3%81%a7%e7%b4%b9%e4%bb%8b%e3%81%95%e3%82%8c%e3%81%be%e3%81%97%e3%81%9f/)


