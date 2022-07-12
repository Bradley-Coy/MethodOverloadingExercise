using MethodOverloadingExercise;

//var answer = Methods.Add(2, 2);


//var answer = Methods.Add(2232m, 23212m);

//Console.WriteLine(answer);

//var answer = Methods.Add(10, 10, true);
//Console.WriteLine(answer);

int[] myArray = new int[3];
myArray[0] = 10;
myArray[1] = 20;
myArray[2] = 30;

int[] myArray2 = new int[3] {100, 200, 300};

int[] myArray3 = new int[] {100, 200, 300};

var myArray4 = new int[] { 10_000, 20_000, 30_000 };

int[] myArray5 = { -1, -2, -2 };

foreach (var num in myArray)
{
    Console.WriteLine(num);

}