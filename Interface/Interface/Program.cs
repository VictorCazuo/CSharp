using Interface;

SalvarXml xml = new();
SalvarJson json = new();

ISalvar salvar_xml = new SalvarXml();
ISalvar salvar_json = new SalvarJson();

xml.Nome();
xml.Salvar();

json.Nome();
json.Salvar();

salvar_xml.Compactar();
salvar_json.Compactar();

