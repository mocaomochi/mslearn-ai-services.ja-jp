---
title: Azure AI Services 演習
permalink: index.html
layout: home
---

# Azure AI Services 演習
これらの演習は、Microsoft Learn のモジュールをサポートするために設計されています。


{% assign labs = site.pages | where_exp:"page", "page.url contains '/Instructions/Exercises'" %}
{% for activity in labs  %}
- [{{ activity.lab.title }}]({{ site.github.url }}{{ activity.url }})
{% endfor %}
