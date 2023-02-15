# XML-schema-definition.cs

XMLスキーマ定義の検証をC#で行うためのサンプルプロジェクト。  

![成果物](./docs/img/fruit.gif)  

## 実行方法

Visual Studioでプロジェクトをそのまま実行する。  
また、検証エラーの状態に変更して、再度実行してみる。  

Docker上で実行する場合には、以下のコマンドを実行。  

```shell
docker build -t xsd-sample .
docker run --name my-xsd-sample xsd-sample
```

## 参考文献

- [東京電機大学 XML Schemaによるスキーマ記述](https://www.mlab.im.dendai.ac.jp/~yamada/web/xml/xmlschema.html)
- [IBM XSDデータ型](https://www.ibm.com/docs/ja/jfsm/1.1.2.1?topic=queries-xsd-data-types)
- [Web tutorials XMLスキーマ](http://memopad.bitter.jp/w3c/schema/el_element.html)
