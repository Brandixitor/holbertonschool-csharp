using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Door sideDoor = new Door("Side Door");
        Decoration photo = new Decoration("Awkward Family Portrait");
        Decoration antiqueVase = new Decoration("Antique Vase", 5, true);

        Objs<Decoration> decorations = new Objs<Decoration>();

        decorations.Add(photo);
        decorations.Add(antiqueVase);

        foreach (Decoration deco in decorations)
        {
            Console.WriteLine(deco);
            while (deco.durability > 0)
                deco.Break();
        }

        Console.WriteLine("------------");

        Objs<IInteractive> interactables = new Objs<IInteractive>();

        interactables.Add(sideDoor);
        interactables.Add(photo);
        interactables.Add(antiqueVase);

        foreach (IInteractive obj in interactables)
        {
            Console.WriteLine(obj);
            obj.Interact();
        }
    }
}