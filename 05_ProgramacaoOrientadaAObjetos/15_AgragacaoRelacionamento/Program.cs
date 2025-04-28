using _15_AgragacaoRelacionamento;

Console.WriteLine("Agregação Relacionamento"); //parecido com composição, porem a 'parte' pode existir sem o 'todo' ao contrário da Composição que a 'parte' e o 'todo' são ligados

Professor prof1 = new Professor("Carlos", "Química");
Professor prof2 = new Professor("Maria", "Inglês");

Departamento dep1 = new Departamento("Exatas");
dep1.IncluirProfessor(prof1);
dep1.IncluirProfessor(prof2);
dep1.ListaProfessores();









