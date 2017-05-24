# Microsoft Teams Bot HandsOn
Microsoft Teams と連携するBot開発をするための学習用レポジトリです。


## ハンズオンガイド

### ハンズオンの目標
今回のハンズオンでは、2時間の持ち時間の中で初級課題の完了を目標とします。

### ハンズオンの準備
[一問一答 Bot の開発 (Getting Started)](https://secretarybotja.wordpress.com/2017/02/12/%E4%B8%80%E5%95%8F%E4%B8%80%E7%AD%94-bot-%E3%81%AE%E9%96%8B%E7%99%BA-getting-started/)

### 初級課題
Bot Builder SDK を Azure Web Apps にアップロードして、Microsoft Teamsと連携する Bot を構築します。チャットインターフェイス上で、ボタンを使ってメインメニューを実現し、ホテル・旅行の予約を Bot とのチャットで行う機能と、自然言語でのQA機能を実装します。
1. [作った Bot に Teams 経由で話しかける](https://secretarybotja.wordpress.com/2017/02/18/%E4%BD%9C%E3%81%A3%E3%81%9F-bot-%E3%81%AB-skype-%E7%B5%8C%E7%94%B1%E3%81%A7%E8%A9%B1%E3%81%97%E3%81%8B%E3%81%91%E3%81%A6%E3%81%BF%E3%82%8B/)

2. [Dialog を使った”会話”の実装](https://secretarybotja.wordpress.com/2017/02/18/dialog-%E3%82%92%E4%BD%BF%E3%81%A3%E3%81%9F%E4%BC%9A%E8%A9%B1%E3%81%AE%E5%AE%9F%E8%A3%85/)

3. [複数の話題を扱えるBotを作る](https://secretarybotja.wordpress.com/2017/02/19/%E8%A4%87%E6%95%B0%E3%81%AE%E8%A9%B1%E9%A1%8C%E3%82%92%E6%89%B1%E3%81%88%E3%82%8Bbot%E3%82%92%E4%BD%9C%E3%82%8B/)

<<<<<<< HEAD

### 中級課題

LUISを利用して自然言語でBotとやり取りできるようにします。以下のURLと、このREADMEの下の方にある設定および資料を参考にしてください。

4. [LUISを利用できるようにする](/LUIS/LUIS.md)

### 上級課題
>>>>>>> cf2048f5c4ec61657839c37bdf0b1a274ed78f3c

Azure ADと連携の実装や、認証情報を使って Bot から Office 365 に Microsoft Graph API 経由で接続します。

1. [Bot に Azure AD 認証/認可を組み込む](https://secretarybotja.wordpress.com/2017/02/25/bot-%E3%81%AB-azure-ad-%E8%AA%8D%E8%A8%BC%E8%AA%8D%E5%8F%AF%E3%82%92%E7%B5%84%E3%81%BF%E8%BE%BC%E3%82%80/)
2. [Bot から Graph API を呼び出す](https://secretarybotja.wordpress.com/2017/02/28/bot-%E3%81%8B%E3%82%89-365-api-%E3%82%92%E5%91%BC%E3%81%B3%E5%87%BA%E3%81%99/)




---
## 中級課題4のLUISのIntent

### Microsoft Teamsのチャット機能のQA
Intent：AskHowto

Botユーザーの入力例：Teamsのチャット機能がよくわかりません

Botで提示するURL：[Microsoft Teams のクイック スタート](https://support.office.com/ja-jp/article/Microsoft-Teams-%25E3%2581%25AE%25E3%2582%25AF%25E3%2582%25A4%25E3%2583%2583%25E3%2582%25AF-%25E3%2582%25B9%25E3%2582%25BF%25E3%2583%25BC%25E3%2583%2588-422bf3aa-9ae8-46f1-83a2-e65720e1a34d?ui=ja-JP&rs=ja-JP&ad=JP#ID0EAABAAA=最初のステップ)

### Microsoft Teamsの新機能のQA
Intent：AskNewInfo

Botユーザーの入力例：Teamsの新機能が知りたい

Botで提示するURL：[Microsoft Teams のリリース ノート](https://support.office.com/ja-jp/article/Microsoft-Teams-%E3%81%AE%E3%83%AA%E3%83%AA%E3%83%BC%E3%82%B9-%E3%83%8E%E3%83%BC%E3%83%88-d7092a6d-c896-424c-b362-a472d5f105de)




- - -



### 参考情報
[Bot State Service の用途に迫る!](https://secretarybotja.wordpress.com/2017/02/19/state-service-%E3%81%AE%E7%94%A8%E9%80%94%E3%81%AB%E8%BF%AB%E3%82%8B/)
