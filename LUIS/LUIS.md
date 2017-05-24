# ここで理解できること
LUIS アプリを作成する方法をマスターします。

## 今回作成するLUIS App

ユーザーの問い合わせを「最新情報を知りたい」「How to を知りたい」に分類します。
- 例: Teamsのことを知りたい -> 最新情報を知りたいに分類
- 例: Teamsの使い方がわからない -> How to を知りたい

## 前提条件
- Microsoft Azure が利用できること。アカウントを持っていない方は[ここ](https://azure.microsoft.com/ja-jp/free/)から無償評価用アカウントを作成してください。
- HTTP GET を使って REST API を呼ぶことができる(自分のプログラム、もしくは、[POST MAN](https://chrome.google.com/webstore/detail/postman/fhbjgbiflinjbdggehcddcbncdddomop?hl=en)のようなツールを活用)
- 組織アカウント(Office 365のアカウント)、もしくは、[Microsoft Account](https://www.microsoft.com/ja-jp/msaccount/default.aspx)を持っている。

## フィードバック&フォローアップ
### LUIS について
- 不明点や詳細は[このドキュメント](https://docs.microsoft.com/ja-jp/azure/cognitive-services/LUIS/home)を参照してください。
- 新機能がほしい場合には[User Voice](https://cognitive.uservoice.com/forums/551524-luis)からアイディアを投稿したり、投票してください。
- プログラム開発時に困ったときは[Stack Over flow](https://stackoverflow.com/questions/tagged/luishttps://stackoverflow.com/questions/tagged/luis)を使ってコミュニティと解決をしてみてください。
- よくある FAQ は[こちら](https://docs.microsoft.com/ja-jp/azure/cognitive-services/LUIS/luis-resources-faq)

### このドキュメントについて
- ドキュメントに抜け漏れや間違いがあれば[issue](https://github.com/NT-D/TeamsBotHandsOn/issues)を発行してください。
- 可能であれば[Pull request](https://github.com/NT-D/TeamsBotHandsOn/pulls)をしてみんなの読むこのドキュメントにContributeしていただけますと幸いです。

## 用語集
- Intent : 文章の意図 (Teamsのことが知りたい -> Intent は最新情報を知りたい)
- Entity : 文章の重要ワード (Teamsのことが知りたい) -> Entity は Teams
Intent, Entityは独自に設定可能で、下記手順で解説します。

## LUISのキー作成と登録
1. [このドキュメント](https://docs.microsoft.com/ja-jp/azure/cognitive-services/LUIS/AzureIbizaSubscription)を参照してLUISのキーを作成します。Bot呼び出し時にも利用するのでメモ帳等にメモしておいてください。
2. [LUIS](https://www.luis.ai)のページへアクセスします。
3. 右上の [Sign in]ボタンをクリック後サインインします。
4. 初回アクセスの方はウェルカム画面が表示されるので内容を確認してみてください。
5. [My Keys]をクリックします。
![StartKeyRegist](Images/StartKeyRegist.png)
6. [Add a new key]をクリックしてキー登録を始めます。この画面で表示される API Keyは今回使わないので無視してください。
![ClickAddNew](Images/ClickAddNew.png)
7. Azureで取得したLUISのキーを入力後、[Save]ボタンをクリックして保存します。
![InsertKey](Images/InsertKey.png)
8. 完了するとキー一覧に、先ほどセットしたキーが表示されます。登録はこれで完了です。
![CompleteKeyRegist](Images/CompleteKeyRegist.png)
9. 次の手順へ進むために[My apps]をクリックしておいてください。

## LUIS アプリの作成
1. [New App]をクリックします。
![1NewApp](Images/1NewApp.png)
2. 画面のように設定後、[Create]をクリックします。
![2CreateApp](Images/2CreateApp.png)
3. App Id が表示されるのでメモ帳等にコピーしておいてください。Bot作成時に使います。[Intents]をクリックします。
![3SelectIntent](Images/3SelectIntent.png)
4. [Add Intent]をクリックします。
![4AddIntent](Images/4AddIntent.png)
5. 好きなIntent名を付けれます(Bot呼び出し時に使います)。今回は`AskHowto`としてください。[Save]します。
![5AddHowto](Images/5AddHowto.png)
6. LUISに学習させる例文を入力します。今回は `Teamsのチャット機能がよくわかりません。`と入力して、[Enter]キーを押します。
![6AddUtterances](Images/6AddUtterances.png)
7. 自分が認識させたい例文をいくつか打ち込み、[Save]ボタンをクリックします。
![7SaveUtterances](Images/7SaveUtterances.png)
8. 次に Entityを登録します。[Entities]をクリックします。
![8AddEntities](Images/8AddEntities.png)
9. [Add custom entity]をクリックします。
![9AddEntity](Images/9AddEntity.png)
10. 好きなEntity名を付けれます。これもBotからの呼び出し時に使います。今回は`ProductName`と設定し、[Save]をクリックします。
![10AddProductName](Images/10AddProductName.png)
11. [Intents]をクリック後、[AskHoto]Intentをクリックします。
![11SelectHowto](Images/11SelectHowto.png)
12. 図のように`teams`を選択するとEntityを選択する画面が出るので、`ProductName`を割り当てましょう。
![12SetEntity](Images/12SetEntity.png)
13. 以下のようにEntityが割り当てられます。
![13SetEntities](Images/13SetEntities.png)
14. ほかの例文にも割り当て後、[Save]をクリックして保存します。
![14SetEntities](Images/14SetEntities.png)
15. `AskNewinfo`というIntentを先ほどと同じように作成し、例文をいくつか入力します。
![15AddAskNewInfoIntent](Images/15AddAskNewInfoIntent.png)
16. 同じようにEntityを割り当てて[Save]をクリックします。
![16AddAskNewInfoIntent](Images/16AddAskNewInfoIntent.png)
17. LUISをトレーニングして、賢くしましょう。[Train & Test]をクリックします。
![17TrainTest](Images/17TrainTest.png)
18. [Train Application]をクリックします。先ほど設定したIntentやEntityをここで学習し、入力した例文をBotから渡された時にはきちんと分類できるようになっています。
![18Train](Images/18Train.png)
19. APIとして発行して、外部から利用できるようにします。[Puboish App]をクリックします。
![19Publish](Images/19Publish.png)
20. 最初に登録したキーを割り当てて、[Publish]をクリックします。
![20Publish](Images/20Publish.png)
21. APIが発行されて`https://westus.api.cognitive.microsoft.com/luis/v2.0/apps/<App Id>?subscription-key=<キーの値>&timezoneOffset=0&verbose=true&q=`のようなエンドポイントが作成されます。
![21CopyEntpoint](Images/21CopyEntpoint.png)
22. プログラム、もしくは、POST MANのようなツールで、`https://westus.api.cognitive.microsoft.com/luis/v2.0/apps/<App Id>?subscription-key=<キーの値>&timezoneOffset=0&verbose=true&q=Teamsの最新情報を知りたい`というHTTP GET通信をすると、JSONが返ってきます。
![22CallRestAPI](Images/22CallRestAPI.png)
以下のように Intent は AskNewinfo、Entityの種類はProductNameで、抜き出したProductNameはteamsであることがわかります。このjsonの情報を使ってBot側で条件分岐のロジックを組んでいきます。
```json
{
  "query": "Teamsの最新情報を知りたい",
  "topScoringIntent": {
    "intent": "AskNewinfo",
    "score": 0.999995232
  },
  "intents": [
    {
      "intent": "AskNewinfo",
      "score": 0.999995232
    },
    {
      "intent": "None",
      "score": 0.06656056
    },
    {
      "intent": "AskHowto",
      "score": 0.032098107
    }
  ],
  "entities": [
    {
      "entity": "teams",
      "type": "ProductName",
      "startIndex": 0,
      "endIndex": 4,
      "score": 0.9551347
    }
  ]
}
```