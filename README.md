#EclairCueMaker

## 概要
EclairCueMakerは、アニメーション再生などの処理を時間差をつけて実行させることにより、UIアニメーションや、カットシーン作成などを行えるUnity用ツールです。タイムライン上で視覚的に編集することができます。

## 注意点
EclairCueMakerはあくまでアニメーション再生などの「合図」を出すだけであり、EclairCueMaker単体でアニメーションを行うことはできません。
## 用語の定義
### Cue
時間差をつけて実行される「合図」です。`Cue`が保持している情報は以下の通りです。
* 直前の`Cue`からの待機時間
* キューを出す対象となるGameObject
* そのGameObjectにアタッチされた`CueEvent`の中のどれを実行するか
* `CueEvent`ごとのパラメーター

### CueEvent
`Cue`が実行された際に起こる動作です。あらかじめ数種類が用意されており、いずれかを対象のゲームオブジェクトにアタッチして使用します。実体は`CueEventBase`を継承したクラスですので、必要に応じてあなたもCueEventを自作することができます。
### CueScene
複数の`Cue`をまとめたもので、独立したファイルとして保存することができます(拡張子は.asset)。特定のUnityシーンに関連付けられています。内部的にはCueの配列の他、関連付けられたシーン名などが含まれています。なお、.assetはUnityでクラスを外部ファイルに保存する際に一般的に使われる拡張子であり、.assetファイルがすべて`CueScene`のファイルとは限りません(インスペクターから区別することができます)
### CueSceneEditor
CueSceneを作成するエディターです。`CueEditor`と省略されることがあります。UnityのWindowメニュー>EclairCueEditorを選択することで開きます。
### CueScenePlayer
Unityシーン内の実際のゲームオブジェクトにアタッチして使うコンポーネントです。"Manager"といった名前の空のゲームオブジェクトを作成し、そこにアタッチする使い方を想定しています。特定の`CueScene`を指定すると、それを再生します。
