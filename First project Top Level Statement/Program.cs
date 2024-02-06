//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hello, Step!");

// Value type - значимые типы 
// - наследуется от struct
// - создается в stack

bool ch = true;             // Boolean

byte byt = 15;              // Byte
sbyte sbyt = 0;             // SByte
char symbol = 'a';          // Char
short srt = default;        // Int16
ushort usrt = 25;           // UInt16
int number = -3265;         // Int32
uint number1 = 3265;        // UInt32
long number2 = 264618;      // Int64
ulong number3 = 264618;     // UInt64

float flt = 0.65F;          // Single
double dbl = .3659;         // Double

decimal dec = 365.236M;     // Decimal


// Reference type - ссылочный тип
// - наследуется от class
// - создается в heap
// - создается через new

string name = "Nadir";                      // String
string name2 = new string("Nadir");         // String

//Console.WriteLine(sizeof(int));
//Console.WriteLine(typeof(string));