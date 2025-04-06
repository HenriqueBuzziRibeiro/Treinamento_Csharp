Console.WriteLine("Tabela de Precedência e Associatividade"); // tem bastante situaçõs de precedência, é válido pesquisar na hora que for utilizar

//Ordem de precedência -> *, /, %, +, -
// [] e () alteram a ordem de precedência 

int x = (10 - 2) * 3;
Console.WriteLine(x);

//ordem de precedência para os operadores lógicos -> !, &&, ||

bool y = !(9 != 8) && (5 >= 7 || 8 >= 6);
//vai primeiro ver o '||' por estar entre, depois o '!' (NOT) e por último &&

Console.WriteLine(y);









