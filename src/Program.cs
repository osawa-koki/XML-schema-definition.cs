
using System.Xml;
using System.Xml.Schema;

string xml_path = "./config.xml";
string xsd_path = "./config.xsd";

if (File.Exists(xml_path) == false)
{
  Console.WriteLine("Could not find XML configuration file.");
  return 1;
}
if (File.Exists(xsd_path) == false)
{
  Console.WriteLine("Could not find XSD configuration file.");
  return 1;
}

string xml_content = File.ReadAllText(xml_path);
string xsd_content = File.ReadAllText(xsd_path);

bool validation_check = true;

//XMLスキーマオブジェクトの生成
XmlSchema schema = new();
using (StringReader stringReader = new(xsd_content))
{
  schema = XmlSchema.Read(stringReader, null)!;
}
// スキーマの追加
XmlSchemaSet schemaSet = new();
schemaSet.Add(schema);

// XML文書の検証を有効化
XmlReaderSettings settings = new()
{
  ValidationType = ValidationType.Schema,
  Schemas = schemaSet
};
settings.ValidationEventHandler += (object? sender, ValidationEventArgs e) => { validation_check = false; };

// XMLデータの読み込み
using (StringReader stringReader = new(xml_content))
using (XmlReader xmlReader = XmlReader.Create(stringReader, settings))
{
  while (xmlReader.Read()) { }
}

if (validation_check)
{
  Console.WriteLine("Validation successed!!!");
  return 0;
} else {
  Console.WriteLine("Validation failed...");
  return 1;
}
