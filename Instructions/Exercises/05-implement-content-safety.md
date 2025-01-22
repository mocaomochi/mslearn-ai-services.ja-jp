---
lab:
    title: 'Azure AI Content Safety での責任ある AI の使用'
    module: 'Module 2 - Azure AI サービスの使用を開始する'
---

# Azure AI Content Safety の実装

この演習では、Content Safety リソースをプロビジョニングし、Azure AI Studio でリソースをテストし、コードでリソースをテストします。

## *Content Safety* リソースをプロビジョニングする

まだ持っていない場合は、Azure サブスクリプションに **Content Safety** リソースをプロビジョニングする必要があります。

1. `https://portal.azure.com` で Azure ポータルを開き、Azure サブスクリプションに関連付けられている Microsoft アカウントでサインインします。
2. **リソースの作成** を選択します。
3. 検索フィールドに **Content Safety** と入力し、結果から **Azure AI Content Safety** の下にある **作成** を選択します。

    ![Search Azure AI Content Safery](./img/Search_Azure_AI_Content_Safety.png)

4. 次の設定を使用してリソースをプロビジョニングします：
    - **サブスクリプション**: *あなたの Azure サブスクリプション*。
    - **リソースグループ**: *既存のリソースグループを選択するか、新しいリソースグループを作成*。
    - **リージョン**: **East US** を選択。
    - **名前**: *一意の名前を入力*。
    - **価格レベル**: **F0** (*無料*) または F0 が利用できない場合は **S** (*標準*) を選択。

    ![Create Azure AI Content Safety](./img/create-azure-content-safety.png)

5. **確認および作成** を選択し、次に **作成** を選択してリソースをプロビジョニングします。
6. デプロイが完了するのを待ち、リソースに移動します。
7. 左側のナビゲーションバーで **アクセス制御** を選択し、次に **+ 追加** および **ロールの割り当ての追加** を選択します。

    ![Assign Role](./img/content-safety-assign-role.png) 

8. 下にスクロールして **Cognitive Services User** ロールを選択し、**次へ** を選択します。

    ![Select Congnitive User Role](./img/select-cognitive-services-user.png)

9. このロールに自分のアカウントを追加し、**レビューと割り当て** を選択します。

    ![Add an user](./img/add-an-user-to-assigned-role.png)

10. 左側のナビゲーションバーで **リソース管理** を選択し、**キーとエンドポイント** を選択します。後でキーをコピーできるようにこのページを開いたままにしておきます。

    ![Key and Endpoint](./img/content-safety-key-endpoint.png)

## Azure AI Content Safety プロンプトシールドの使用

この演習では、Azure AI Studio を使用して、Content Safety プロンプトシールドを2つのサンプル入力でテストします。1つはユーザープロンプトをシミュレートし、もう1つは潜在的に安全でないテキストが埋め込まれたドキュメントをシミュレートします。

1. 別のブラウザタブで [Azure AI Studio](https://ai.azure.com/explore/contentsafety) の Content Safety ページを開き、サインインします。
1. **適度なテキストコンテンツ** の中の **試してみる** を選択します。

   ![Text Contents Moderation](./img/text-contents-moderation.png)

2. **適度なテキストコンテンツ** ページで、**Azure AI サービス** の下に先ほど作成した Content Safety リソースを選択します。
3. 
   ![Select your contents safety resource](./img/select-your-azure-ai-content-safety-resource.png)

4. **1つの文に複数のリスクカテゴリがあります** を選択し、ドキュメントテキストの潜在的な問題を確認します。

   ![Multi Risk Category in a sentence](./img/multi-risk-category-in-a-sentence.png) 

5. **テストを実行** を選択し、結果を確認します。

   ![Run Test](./img/Run-Test.png)

6. 必要に応じてしきい値レベルを変更し、再度 **テストを実行** を選択します。
7. Content Safety のページに戻り **保護されたマテリアルの検出-テキスト用** を選択します。

   ![Select protected materials for text](./img/select-protected-material-for-text.png)

8. **保護された歌詞** を選択し、これが公開された歌の歌詞であることを確認します。

   ![Protected Lyrics](./img/Protected-Lyrics.png)

9. **テストを実行** を選択し、結果を確認します。
10. Content Safetyのページに戻り **適度な画像コンテンツ** を選択します。

   ![Select image content moderation](./img/select-image-content-moderation.png)

11. **自傷行為のコンテンツ** を選択します。

   ![Select self-harm content](./img/select-self-harm-content.png)

12. AI Studio ではすべての画像がデフォルトでぼかされていることに注意してください。また、サンプルの性的コンテンツは非常に軽度であることも認識しておいてください。
13. **テストを実行** を選択し、結果を確認します。
14. Content Safetyのページに戻り **プロンプトシールド** を選択します。

   ![Select Prompt Shield](./img/select-prompt-shield.png)

15. **プロンプトシールド** ページで、**Azure AI サービス** の下に先ほど作成した Content Safety リソースを選択します。
16. **プロンプト & ドキュメント攻撃コンテンツ** を選択し、ユーザープロンプトとドキュメントテキストの潜在的な問題を確認します。

   ![Select prompt and document attack content](./img/select-prompt-and-document-attack-content.png)

17. **テストを実行** を選択します。
18. **結果を表示** で、ユーザープロンプトとドキュメントの両方で Jailbreak 攻撃が検出されたことを確認します。
    
    ![Result Jailbreak](./img/result-jailbreak.png)

    > [!TIP]
    > AI Studio にはすべてのサンプルのコードが用意されています。

19. **次のステップ**の下にある**コードの表示**メニューを選択し、**コードの表示**ボタンを選択します。**サンプルコード**ウィンドウが表示されます。
20. 下向き矢印を使ってPythonまたはC#を選び、**コピー**を選択してサンプルコードをクリップボードにコピーします。
21. **サンプルコード**画面を閉じます。

    ![Sample Code](./img/sample-code.png)

    ### アプリケーションの設定

    これから、C# または Python でアプリケーションを作成します。

#### C#

##### 事前準備
* [Visual Studio Code](https://code.visualstudio.com/) をインストールします。対応しているプラットフォームについては[こちら](https://code.visualstudio.com/docs/supporting/requirements#_platforms)を確認してください。
* この演習では、ターゲットフレームワークとして [.NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) を使用します。
* Visual Studio Code に [C# 拡張機能](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) をインストールします。
* 必要に応じ、Visual Studio Code を日本語化してください。
  

  > Visual Studio Codeを日本語化する方法
  >  1. Visual Studio Code を起動します。
  >  2. 左下の歯車アイコン（設定）をクリックします。
  >  3. 「Command Palette...」を選択します。
  >  4. 「Configure Display Language」と入力し、Enter キーを押します。
  >  5. 言語リストが表示されるので、「Japanese」を選択します。
  >  6. 再起動を促すメッセージが表示されるので、「Restart」をクリックします。
  >  7. Visual Studio Code が再起動し、日本語化されます。


##### セットアップ

Visual Studio Code を演習のために準備するには、次の手順を実行します。

1. Visual Studio Code を起動し、エクスプローラービューで **.NET プロジェクトを作成** をクリックし、**コンソールアプリ** を選択します。

   ![Create Dot Net Project](./img/create-dot-net-project.png)

2. コンピューター上のフォルダーを選択し、プロジェクトに名前を付けます。**プロジェクトを作成します** を選択します。もし警告メッセージが表示されたら内容を確認します。

   ![Name the new project](./img/name-new-project.png)

   ![Create a project](./img/create-a-project.png)

3. エクスプローラー ペインで、ソリューション エクスプローラーを展開し、**Program.cs** を選択します。

   ![Open Program.cs](./img/open-program-cs.png)

4. **実行** -> **デバッグなしで実行** を選択してプロジェクトをビルドおよび実行します。
5. ソリューション エクスプローラーで、C# プロジェクトを右クリックし、**NuGetパッケージを追加** を選択します。

   ![Add NuGet Package](./img/add-nuget-package.png)

   > ここで .Net 8.0 SDKのインストールを要求された場合は、OSに適したSDKのパッケージを選択してインストールしてください。
6. **Azure.AI.TextAnalytics** を検索し、最新バージョンを選択します。

   ![Search Azure.AI.TextAnalytics package](./img/search-azure-ai-textanalytics-package.png)

7. 2つ目の NuGet パッケージ **Microsoft.Extensions.Configuration.Json** を検索し、バージョン**8.0.1** を選択します。プロジェクトファイルには、2つの NuGet パッケージがリストされているはずです。
   
   ![Search Microsoft.Extention.Configuration.Json](./img/search-microsoft-extension-configutaion-package.png)
   
   ![Project File](./img/cs-project-file.png)


##### コードを追加する

1. **Program.cs** ファイルの中身を全て削除し、先ほどコピーしたC#のサンプルコードをコピーします。
1. *Replace with your own subscription _key and endpoint* のコメント行を見つけます。
1. Azure ポータルで、キーとエンドポイントのページからキーの1つ（1または2）をコピーし、この値で **<your_subscription_key>** を置き換えます。
1. Azure ポータルで、エンドポイントをコピーし、この値で **<your_endpoint_value>** を置き換えます。
2.  **Azure AI Studio** で、**User prompt** の値をコピーし、この値で **<test_user_prompt>** を置き換えます。
3. **<this_is_a_document_source>** までスクロールし、この行のコードを削除します。
4. **Azure AI Studio** で、**Document** の値をコピーします。
5. **<this_is_another_document_source>** までスクロールし、ドキュメントの値を貼り付けます。
6. **実行** -> **デバッグなしで実行** を選択し、攻撃が検出されたことを確認します。
   
   実行結果
   
   ![Prompt & document attack content result](./img/prompt-document-attack-detected-result.png)

#### Python

##### 事前準備

* [Visual Studio Code](https://code.visualstudio.com/) をインストールします。対応しているプラットフォームについては[こちら](https://code.visualstudio.com/docs/supporting/requirements#_platforms)を確認してください。
* Visual Studio Code に [Python 拡張機能](https://marketplace.visualstudio.com/items?itemName=ms-python.python) をインストールします。
* [requests モジュール](https://pypi.org/project/requests/) をインストールします。
* 必要に応じ、Visual Studio Code を日本語化してください。

##### セットアップ

1. **.py** 拡張子の新しい Python ファイルを作成し、適切な名前を付けます。
2. 先ほどコピーしたPythonのサンプルコードを貼り付けます。
3. *Replace with your own subscription _key and endpoint* というタイトルのセクションまでスクロールします。
4. Azure ポータルで、キーとエンドポイントのページからキーの1つ（1または2）をコピーし、この値で **<your_subscription_key>** を置き換えます。
5. Azure ポータルで、エンドポイントをコピーし、この値で **<your_endpoint_value>** を置き換えます。
6. **Azure AI Studio** で、**User prompt** の値をコピーし、この値で **<test_user_prompt>** を置き換えます。
7. **<this_is_a_document_source>** までスクロールし、この行のコードを削除します。
8. **Azure AI Studio** で、**Document** の値をコピーします。
9. **<this_is_another_document_source>** までスクロールし、ドキュメントの値を貼り付けます。
10. ファイルの統合ターミナルからプログラムを実行します。例：

    - `python .¥prompt-shield.py`

11. 攻撃が検出されたことを確認します。
    実行結果
    ![Python results](./img/python-result.png)
12. 必要に応じて、異なるテストコンテンツやドキュメントの値で実験してみてください。

