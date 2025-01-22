---
lab:
    title: 'ラボ環境のセットアップ'
    module: 'Setup'
---

# ラボ環境のセットアップ

演習はホストされたラボ環境で実行されることを目的としています。ご自身のコンピューターで実行したい場合は、以下のソフトウェアをインストールすることで可能です。ただし、ご自身の環境を使用する場合、予期しないダイアログや動作が生じる可能性があります。ローカルの構成では様々な環境のバリエーションがあるため、このコースを開発したチームはご自身の環境で発生すた問題をサポートすることはできませんのでご了承ください。

> **注意**: 以下の手順は Windows 11 用です。Linux または MacOS も使用できますが、選択したOSによってラボの手順を調整する必要があるかもしれません。

### ベースとなるOS (Windows 11)

#### Windows 11

Windows 11 をインストールし、すべてのアップデートを適用してください。

#### Edge

[Edge (Chromium)](https://microsoft.com/edge)ブラウザをインストールしてください。

### .NET Core SDK

1. https://dotnet.microsoft.com/download からダウンロードしてインストールしてください (.NET Core SDK をダウンロードしてください - ランタイムだけではありません)。このコースのラボを自分のマシンで実行する場合、.NET 8.0 をインストールする必要があります。

### C++ 再配布可能パッケージ

1. https://aka.ms/vs/16/release/vc_redist.x64.exe から Visual C++ 再頒布可能パッケージ (x64) をダウンロードしてインストールしてください。

### Node.JS

1. https://nodejs.org/ja/download/ から最新のLTSバージョンをダウンロードしてください
2. デフォルトのオプションを使用してインストールしてください

### Python (および必要なパッケージ)

1. https://docs.conda.io/en/latest/miniconda.html からバージョン3.11をダウンロードしてください。
2. セットアップを実行してインストールしてください。
**重要**: MinicondaをPATH変数に追加し、MinicondaをデフォルトのPython環境として登録するオプションを選択してください。
3. インストール後、Anacondaプロンプトを開き、以下のコマンドを入力してパッケージをインストールしてください:

```
pip install flask requests python-dotenv pylint matplotlib pillow
pip install --upgrade numpy
```
### Azure CLI

1. https://docs.microsoft.com/ja-jp/cli/azure/install-azure-cli?view=azure-cli-latest からダウンロードしてください。
2. デフォルトのオプションを使用してインストールしてください。

### Git

1. https://git-scm.com/download.html からダウンロードしてインストールしてください。デフォルトのオプションを使用してください。

### Visual Studio Code (および拡張機能)

1. https://code.visualstudio.com/Download からダウンロードしてください。
2. デフォルトのオプションを使用してインストールしてください。
3. インストール後、Visual Studio Code を起動し、**拡張機能** タブ (CTRL+SHIFT+X) で以下の Microsoft 製拡張機能を検索してインストールしてください。
    - Python
    - C#
    - Azure Functions
    - PowerShell
