Console.WriteLine();
Console.WriteLine("Type Specific int");
Printer printer = new Printer(10);

for(int i = 0; i < 10; i++){
    int element = i+1;
    Console.WriteLine($"Adding {element} to the printer");
    printer.Add(element);
}

Console.WriteLine();
Console.WriteLine("Printing all jobs from the printer");
for(int i = 0; i < 10; i++) {
    int document = printer.Print();
    Console.WriteLine($"Printing document: " + document);
}

Console.WriteLine();
Console.WriteLine("Printing int using Generic Type");
GenericPrinter<int> intPrinter = new GenericPrinter<int>(10);

for(int i = 0; i < 10; i++){
    int element = i+1;
    Console.WriteLine($"Adding {element} to the printer");
    intPrinter.Add(element);
}

Console.WriteLine();
Console.WriteLine("Printing all jobs from the printer");
for(int i = 0; i < 10; i++) {
    int document = intPrinter.Print();
    Console.WriteLine($"Printing document: " + document);
}

Console.WriteLine();
Console.WriteLine("Printing String using Generic Type");
GenericPrinter<string> stringPrinter = new GenericPrinter<string>(10);

for(int i = 0; i < 10; i++){
    int element = i+1;
    Console.WriteLine($"Adding {element} to the printer");
    stringPrinter.Add($"Element: {element}");
}

Console.WriteLine();
Console.WriteLine("Printing all jobs from the printer");
for(int i = 0; i < 10; i++) {
    string document = stringPrinter.Print();
    Console.WriteLine($"Printing document: " + document);
}

Console.WriteLine();
Console.WriteLine("Printing Humans using Generic Type");
GenericPrinter<Human> humanPrinter = new GenericPrinter<Human>(10);

for(int i = 0; i < 10; i++){
    Human element = new Human($"Human Name {i+1}");
    Console.WriteLine($"Adding {element} to the printer");
    humanPrinter.Add(element);
}

Console.WriteLine();
Console.WriteLine("Printing all jobs from the printer");
for(int i = 0; i < 10; i++) {
    Human document = humanPrinter.Print();
    Console.WriteLine($"Printing document: " + document);
}