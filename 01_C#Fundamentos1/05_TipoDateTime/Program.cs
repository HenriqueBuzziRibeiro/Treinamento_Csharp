Console.WriteLine("## Struct DateTime ##\n");

DateTime hoje = DateTime.Now;  //obtem a data atual

Console.WriteLine(hoje);

//Criar uma data específica usa formato: aaaa, mm, dd
DateTime dataHoje = new DateTime(2022, 09, 06);
Console.WriteLine(dataHoje);

//definir as horas
DateTime dataHoraHoje = new DateTime(2022, 09, 06, 21, 10, 30);
Console.WriteLine(dataHoraHoje +"\n");

Console.ReadKey();

//Extrair informações de 'hoje'
//Console.WriteLine(hoje.Year);
//Console.WriteLine(hoje.Month);
//Console.WriteLine(hoje.Day);
//Console.WriteLine(hoje.Hour);
//Console.WriteLine(hoje.Minute);
//Console.WriteLine(hoje.Second);
//Console.WriteLine(hoje.Millisecond);

//Adicionando valores
//Console.WriteLine(hoje.AddDays(30));
//Console.WriteLine(hoje.AddMonths(1));
//Console.WriteLine(hoje.AddHours(2));
//Console.WriteLine(hoje.AddYears(5));

//Obter dia da semana e do ano
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

//Data no formato longo e curo
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());

Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());




