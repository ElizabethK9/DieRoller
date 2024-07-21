using DieRoller;

Die myDie = new Die(); //When a die is created, a random Face value should be set. 
Console.WriteLine(myDie.FaceValue); 
myDie.Roll(); //Roll the die.
Console.WriteLine(myDie.FaceValue);
myDie.Roll();
Console.WriteLine(myDie.FaceValue);
myDie.Roll();
Console.WriteLine(myDie.FaceValue);

myDie.IsHeld = true;
Console.WriteLine("Holding the die******************");
myDie.Roll();
Console.WriteLine(myDie.FaceValue);
myDie.Roll();
Console.WriteLine(myDie.FaceValue);

Console.ReadKey();