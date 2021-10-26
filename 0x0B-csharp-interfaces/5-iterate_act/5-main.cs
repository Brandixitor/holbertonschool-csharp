using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Door frontDoor = new Door("Front Door");
        Decoration photo = new Decoration("Awkward Family Portrait");
        Decoration antiqueVase = new Decoration("Antique Vase", 2, true);
        Key carKey = new Key("Car Key");

        List<Base> allObjects = new List<Base>();

        allObjects.Add(frontDoor);
        allObjects.Add(photo);
        allObjects.Add(antiqueVase);
        allObjects.Add(carKey);

        RoomObjects.IterateAction(allObjects, typeof(IInteractive));
        RoomObjects.IterateAction(allObjects, typeof(IBreakable));
        RoomObjects.IterateAction(allObjects, typeof(ICollectable));
    }
}