using _13_InterfaceExercicio;

Console.WriteLine("Interface Exercicio");


SalvarXml salvarXml = new SalvarXml();
salvarXml.Salvar();
salvarXml.Nome();

SalvarJason salvarJson = new SalvarJason();
salvarJson.Salvar();
salvarJson.Nome();

//para conseguir acessar o método compactar precisamos referenciar com a interface 'ISalvar', segue exmeplo abaixo
ISalvar salvarJsonRefISalvar = new SalvarJason();
salvarJsonRefISalvar.Compactar(); //dessa forma podemos acessar esse método da interface 'ISalvar'