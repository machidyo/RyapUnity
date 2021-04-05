# RyapUnity
This is a repository for checking the operation of [Ryap](https://github.com/machidyo/Ryap).
It can also be used as a sample to receive Ryap data in Unity.

<img src="https://user-images.githubusercontent.com/1772636/113173226-22ac7d00-9284-11eb-9c0f-ec699440feef.gif" width=240 />

日本語は[こちら](https://github.com/machidyo/RyapUnity/blob/master/README.jp.md)

## Thanks to AxisOrange 
I am using some of [AxisOrange](https://github.com/naninunenoy/AxisOrange)'s code. I think it is better to use this for reference of connection and code via Bluetooth.

# How to confirm Ryap running
1. git clone
2. Open and run in Unity.

## When SocketException occurs
Sorry, this sample is Japanaese only.
```
SocketException: 接続済みの呼び出し先が一定の時間を過ぎても正しく応答しなかったため、接続できませんでした。または接続済みのホストが応答しなかったため、確立された接続は失敗しました。
```

Please review your Windows firewall settings.

<img src="https://user-images.githubusercontent.com/1772636/111017109-cb3d8e80-83f4-11eb-9332-92aac86aa45c.jpg" width=512 />

# How to include in your Unity project
1. Copy all C# programs under the Scripts folder.
2. Create UDPReciver object in your scene and set port number 22222. Please refer to the hierarchy of this repository Unity project. 
3. Create M5StickC object in your scene. Please refer to the hierarchy of this repository Unity project.
4. Run Unity.
