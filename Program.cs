Woman woman1 = new Woman();
Woman woman2 = new Woman("Tata", "Ivanec");
Man man1 = new Man("Van", "Dam");
Man man2 = new Man();

Generic<Human> humanMassive = new Generic<Human>();

humanMassive.AddElement(woman1);
humanMassive.AddElement(man1);
humanMassive.AddElement(woman2);
humanMassive.AddElement(man2);
Console.WriteLine($"Name  {humanMassive[1].FirstName}");

Console.WriteLine($"Array Length = {humanMassive.ArrayLength()}");

humanMassive.RemoveElement(2);
Console.WriteLine($"Array Length = {humanMassive.ArrayLength()}");

GenerateElemets(5);

void GenerateElemets(int numberOfElements)
{
    Generic<Human> humanMassiveGenerate = new Generic<Human>();
    for (int i = 0; i < numberOfElements; i++)
    {
        Woman woman = new Woman();
        Man man = new Man();
        humanMassiveGenerate.AddElement(woman);       
    }

    Console.WriteLine($"Generated Array Length = {humanMassiveGenerate.ArrayLength()}");
}

Woman woman3 = new Woman("Dusya", "Musya");
Woman woman4 = new Woman("Tata", "Ivanec");
Man man3 = new Man("Van", "Dam");
Man man4 = new Man("Reny", "Peny");

Generic<Human> humanMassive1 = new Generic<Human>();

humanMassive1.AddElement(man3);
humanMassive1.AddElement(man4);
humanMassive1.ToString();