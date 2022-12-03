int numA;
bool isRepeat=true;
while(isRepeat)
{Console.WriteLine("Введите целое число от одного до семи ");
numA = Convert.ToInt32(Console.ReadLine());
switch (numA)
{
    case 1:
    Console.WriteLine("1-пн");
    isRepeat=false;
    break;
    case 2:
    Console.WriteLine("2-вт");
    isRepeat=false;
    break; 
    case 3:
    Console.WriteLine("3-ср");
    isRepeat=false;
    break;
    case 4:
    Console.WriteLine("4-чт");
    isRepeat=false;
    break;
    case 5:
    Console.WriteLine("5-пт");
    isRepeat=false;
    break;
    case 6:
    Console.WriteLine("6-сб");
    isRepeat=false;
    break;
    case 7:
    Console.WriteLine("7-вс");
    isRepeat=false;
    break;
        default:
    Console.WriteLine("число больше семи");
    isRepeat=true;
    break;
} }

    
