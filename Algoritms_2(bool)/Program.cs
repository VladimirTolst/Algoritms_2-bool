using System.Timers;

bool[,] inputBool =
    {{false,false,false},
    {false,false,true}, 
    {false,true,false}, 
    {false,true,true},
    {true,false,false},
    {true,false,true},
    {true,true,false},
    {true,true,true}};

Console.WriteLine("x y z !x !y !x|!y !z !x|!y|!z x|!y&!z");
for (int i = 0; i < 8; i++)
{
    Console.Write(Convert.ToInt32(inputBool[i, 0]) + " ");
    Console.Write(Convert.ToInt32(inputBool[i, 1]) + " ");
    Console.Write(Convert.ToInt32(inputBool[i, 2]) + " ");
    if (!inputBool[i, 0])
    {
        Console.Write(" 1 ");
    }
    else
    {
        Console.Write(" 0 ");
    }

    if (!inputBool[i, 1]) 
    {
        Console.Write(" 1 ");
    }
    else
    {
        Console.Write(" 0 ");
    }

    if (!inputBool[i, 0] || !inputBool[i, 1])
    {
        Console.Write("  1   ");
    }
    else
    {
        Console.Write("  0   ");
    }

    if (inputBool[i, 2])
    {
        Console.Write(" 1 ");
    }
    else
    {
        Console.Write(" 0 ");
    }

    if (!inputBool[i, 0] || !inputBool[i, 1] || !inputBool[i,2])
    {
        Console.Write("   1    ");
    }
    else
    {
        Console.Write("   0    ");
    }

    if (inputBool[i, 0] || !inputBool[i, 1] & !inputBool[i,2])
    {
        Console.Write("   1    ");
    }
    else
    {
        Console.Write("   0    ");
    }
    Console.WriteLine();



}