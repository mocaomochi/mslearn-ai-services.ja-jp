---
title: Azure AI Services 演習
permalink: index.html
layout: home
---

# Azure AI Services 演習
これらの演習は、Microsoft Learn のモジュールをサポートするために設計されています。

この演習ガイドは、Microsoftの公式なコースウェア「AI-102 Microsoft Azure AI ソリューションの設計と実装」の演習手順書を CODE; Without Barriers 用に @mocaomochi が手を加え改良したものです。

以下のよう特徴があります。
- 各ステップのスクリーンショットを多く取り入れています。
- 動作確認済みのコードも記載しています。そのままコピー&ペーストすれば動かせるはずです。
- 日本語の素材を使った場合の演習も試せるようにしてあります。
- 生成AIでは日本語のプロンプトに対応しています。

個人の裁量で手を加えたものですので、Microsoft社公認ではありませんのでご了承ください。
間違いや翻訳ミスなどもあるかもしれませんが、その点はご容赦ください。見つけた場合はGitHubのリポジトリからコメントをいただけると幸いです。
少しでも皆様の学習者のお役に立つのであれば幸いです。

@mocaomochi (Toshimi Hatanaka)


{% assign labs = site.pages | where_exp:"page", "page.url contains '/Instructions/Exercises'" %}
{% for activity in labs  %}
- [{{ activity.lab.title }}]({{ site.github.url }}{{ activity.url }})
{% endfor %}
