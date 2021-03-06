# RyapUnity
[Ryap](https://github.com/machidyo/Ryap) の動作確認をするためのリポジトリです。  
Unity で Ryap のデータを受け取るサンプルとしても利用できます。

<img src="https://user-images.githubusercontent.com/1772636/113173226-22ac7d00-9284-11eb-9c0f-ec699440feef.gif" width=240 />

## AxisOrange ありがとうございます
[AxisOrange](https://github.com/naninunenoy/AxisOrange) のコードを一部流用させてもらっています。 Bluetooth 経由での接続やコードの参考はこちらを利用されるのがよいかと思います。

# 利用方法
1. git clone
2. Unity で起動

## SocketException が発生する場合
```
SocketException: 接続済みの呼び出し先が一定の時間を過ぎても正しく応答しなかったため、接続できませんでした。または接続済みのホストが応答しなかったため、確立された接続は失敗しました。
```

Windows firewall の設定を見直してみてください。

<img src="https://user-images.githubusercontent.com/1772636/111017109-cb3d8e80-83f4-11eb-9332-92aac86aa45c.jpg" width=512 />

# 自分の Unity プロジェクトに取り込みたい場合
1. Scripts フォルダ配下にあるすべてのプログラムをコピーしてください。
2. シーンに UDPReciever を作ってください。ポート番号は 22222 に設定します。このリポジトリのヒエラルキーを参考にしてください。
3. シーンに M5StickC を作ってください。このリポジトリのヒエラルキーを参考にしてください。
4. Unity を実行します。
