using System.Numerics;

char Choise = 'a';

List<int> num = new List<int> {7,10,1,5,3,9,8,4,6,2};

void Printmenu()
{
    Console.WriteLine("\n\nP - Print Numbers");
    Console.WriteLine("A - Add  A Number");
    Console.WriteLine("M - Display Mean OF The Numbers");
    Console.WriteLine("S - Display The Smallest Number");
    Console.WriteLine("L - Display The Largest Number");
    Console.WriteLine("F - Find A Number in the List");
    Console.WriteLine("C - Clear The Whole List");
    Console.WriteLine("B - Sort Ascending");
    Console.WriteLine("R - Revers List");
    Console.WriteLine("D - Sort Descending");
    Console.WriteLine("W - Swaping 2 index");
    Console.WriteLine("Q - Quit");

}   

void PrintList()
{
    if (num.Count > 0)
    {
        Console.Clear();
        Console.WriteLine(" ");
        Console.Write("[ ");
        for (int i = 0; i < num.Count; i++)
        {

            Console.Write($"{num[i]} ");


        }

        Console.Write("]");

        Printmenu();
    }





    else
    {
        Console.Clear();
        Console.WriteLine(" ");
        Console.WriteLine("The List is Empty");

        Console.WriteLine(" ");

        Printmenu();
    }

}

void AddNumber()
{
    Console.Clear();
    bool found = false;
    Console.WriteLine(" ");
    Console.WriteLine("Write A Number for Add");
    Console.Write("==>");

    int Added = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < num.Count; i++)
    {
        if (num[i] == Added)
        {

            found = true;

            break;
        }
        else
        {
            found = false;
        }

    }


    while (found)
    {
        Console.Clear();
        Console.WriteLine(" ");
        Console.WriteLine($"{Added} already exists , Enter Another Number");
        Console.Write("==>");

        Added = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < num.Count; i++)
        {
            if (num[i] == Added)
            {

                found = true;
                break;
            }
            else
            {
                found = false;
            }
        }
    }


    if (!found)
    {
        Console.Clear();
        num.Add(Added);
        Console.WriteLine(" ");
        Console.WriteLine($"{Added} is Added");
        Printmenu();
    }

}
void Average()
{
    Console.Clear();
    Console.WriteLine(" ");
    int sum = 0;
    for (int i = 0; i < num.Count; i++)
    {
        sum += num[i];
    }
    Console.WriteLine($"Mean : {sum / num.Count}");
    Printmenu();
}
void Smallest()
{

    Console.Clear();
    Console.WriteLine("");
    int small = num[0];
    for (int i = 1; i < num.Count; i++)
    {
        if (num[i] < small)
        {
            small = num[i];
        }
    }

    Console.WriteLine($"The smallest Number is : {small}");
    Printmenu();
}
void LargNumber()
{
    Console.Clear();
    Console.WriteLine(" ");
    int Larg = num[0];
    for (int i = 1; i < num.Count; i++)
    {
        if (Larg < num[i])
        {
            Larg = num[i];
        }

    }
    Console.WriteLine($"The Largest Number is : {Larg}");
    Printmenu();
}
void FindNumber()
{
    Console.Clear();
    Console.WriteLine(" ");
    Console.WriteLine("Write a Number to sarche");
    Console.Write("==>");


    int Finde = Convert.ToInt32(Console.ReadLine());

    int index = num.IndexOf(Finde);

    if (index != -1)
    {
        Console.Clear();
        Console.WriteLine(" ");
        Console.WriteLine($"Your Number is {Finde} and  location is {index}");
        Printmenu();
    }
    else
    {
        Console.Clear();
        Console.WriteLine(" ");
        Console.WriteLine("The Number is Not Founde !");
        Printmenu();

    }
}
void SortAscending()
{
    Console.Clear();
    Console.WriteLine();

    int Temp = 0;

    for (int i = 0; i < num.Count - 1; i++)
    {
        for (int j = 0; j < num.Count - 1; j++)
        {
            if (num[j] > num[j + 1])
            {
                Temp = num[j + 1];
                num[j + 1] = num[j];
                num[j] = Temp;
            }
        }
    }

    Console.Clear();
    Console.WriteLine(" ");
    Console.Write("[ ");
    for (int i = 0; i < num.Count; i++)
    {

        Console.Write($"{num[i]} ");


    }

    Console.Write("]");

    Printmenu();



}

void SortDescinding()
{

    Console.Clear();
    Console.WriteLine();
    int Temb = 0;

    for (int i = 0; i < num.Count - 1; i++)
    {
        for (int j = 0; j < num.Count - 1; j++)
        {
            if (num[j] < num[j + 1])
            {
                Temb = num[j];
                num[j] = num[j + 1];
                num[j + 1] = Temb;

            }
        }
    }
    Console.Clear();
    Console.WriteLine(" ");
    Console.Write("[ ");
    for (int i = 0; i < num.Count; i++)
    {

        Console.Write($"{num[i]} ");


    }

    Console.Write("]");

    Printmenu();
}

void Swaping2Index()
{

    Console.Clear();
    Console.WriteLine(" ");
    Console.Write("[ ");
    for (int j = 0; j < num.Count; j++)
    {

        Console.Write($"{num[j]} ");


    }

    Console.Write("]");

    Console.WriteLine();

    Console.WriteLine("Write A  Frist Value To Swap");
    Console.Write("==> ");
    int Value1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Write A  Secound Value To Swap");
    Console.Write("==> ");
    int Value2 = Convert.ToInt32(Console.ReadLine());

    int founded = 0;
    int Index1 = -1, Index2 = -1;
    int s = 0;
    while (true)
    {
        if (Value1 == num[s])
        {
            founded += 1;
            Index1 = s;
        }
        else if (Value2 == num[s])
        {

            founded += 1;
            Index2 = s;
        }
        if (founded == 2)
        {

            int T = num[Index1];
            num[Index1] = num[Index2];
            num[Index2] = T;

            Console.WriteLine("Swap is Done . ");
            break;

        }
        if (s == num.Count - 1)
        {
            Console.WriteLine("Invalid Data . ");
            break;

        }

        s++;
    }
    Console.WriteLine(" ");
    Console.Write("[ ");
    for (int j = 0; j < num.Count; j++)
    {

        Console.Write($"{num[j]} ");


    }

    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine();
    Printmenu();
}
void Reversed()
{
    Console.Clear();
    Console.WriteLine();
    Console.Write("[ ");
    for (int i = num.Count-1; i >=0 ; i--)
    {
        Console.Write($"{num[i]} ");
    }

    Console.Write("]");
    Printmenu();
}

void ClearList()
{
    Console.Clear();
    num.Clear();
    Console.WriteLine("");
    Console.WriteLine("the list is Clean");
    Printmenu();

}

Printmenu();

//ملحوظة البرنامج كله  حروف سمول بس 

    do
    {
        Console.Write("==>");
        Choise = Convert.ToChar(Console.ReadLine());

        switch (Choise)
        {
          case 'p':

                PrintList();

              break;

          case 'a':

                AddNumber();
              
              break;
          case 'm':
            
                 Average();

              break;

          case 's':

                Smallest();

              break;
          case 'l':

                LargNumber();
             
              break;

          case 'f':

                FindNumber();
              
                  break;


          case 'c':

                 ClearList();
            
              break;

          case 'd':

                SortAscending();
            break;


        case 'b':
             
                SortDescinding();


            break;

        case 'r':

            Reversed();

            break;  

          case 'q':

              Console.Clear();
              Console.WriteLine("Thanks For use The Program , ");

              break;


        case 'w':


             Swaping2Index();

            break;



          default:
              Console.Clear();
              Console.WriteLine(" ");
              Console.WriteLine("You must enter an option from { p , a , m , s , l , f , c , d , b , w , q , r} ");
              Printmenu();
              break;
        }
    } while (Choise != 'q');


