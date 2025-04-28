using _16_HerancaXComposicao;

Console.WriteLine("Herança X Composição");

ComportamentoAndar andar = new ComportamentoAndar();
ComportamentoNadar nadar = new ComportamentoNadar();

var humano = new Humano(andar); //o construtor tem que receber como parâmetro um objeto do tipo 'ComportamentoAndar'
humano.Locomocao(); //observar como o 'nameof' irá aparecer quando executarmos, irá aparecer o nome da classe

var macaco = new Macaco(andar);
macaco.Locomocao();

var sardinha = new Sardinha(nadar);
sardinha.Locomocao();

