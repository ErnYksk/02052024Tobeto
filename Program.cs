/* ============== 1 ==============  */

// 1- Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız

List<string> siparisList = new List<string>
        {
            "Pizza Menu",
            "Cheese Burger Menu",
            "Taco Menu",
            "Ramen Menu"
        };

while (true)
{
    Console.WriteLine("Lütfen Sipariş Numaranızı Giriniz (1, 2, 3, 4)");
    int siparisNo;
    if (int.TryParse(Console.ReadLine(), out siparisNo))
    {
        switch (siparisNo)
        {
            case 1:
            case 2:
            case 3:
            case 4:
                Console.WriteLine(siparisList[siparisNo - 1]);
                return;
            default:
                Console.WriteLine("Yanlış numara girdiniz! Geçerli sipariş numaraları: 1, 2, 3, 4");
                break;
        }
    }
    else
    {
        Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
    }
}


/* ============== 2 ==============  */

//2- kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan
//bir algoritma yazınız.(döngü için for döngüsü kullanınız)

List<string> items = new List<string> { "Item A", "Item B", "Item C" };
int secim = 0;
int subTotal = 0;
int grandTotal = 0;

do
{
    Console.WriteLine("Urunler:");

    foreach (string urunList in items)
    {
        Console.WriteLine(urunList);
    }
    Console.WriteLine("Almak istediginiz urunun kodunu giriniz: (Item A icin 1, Item B icin 2, Item C icin 3, Cikis icin Lutfen 0 giriniz) ->");
    secim = int.Parse(Console.ReadLine());
    switch (secim)
    {
        case 0:
            Console.WriteLine("Iyi gunler");
            break;

        case 1:
            Console.WriteLine("Secilen urun:" + items[secim - 1]);
            Console.Write("Lutfen adet giriniz: ");
            int quantityItemA = int.Parse(Console.ReadLine());
            subTotal = quantityItemA * 10;
            Console.WriteLine(quantityItemA + "*" + items[secim - 1]);
            Console.WriteLine("subTotal= " + subTotal);
            break;
        case 2:
            Console.WriteLine("Secilen urun:" + items[secim - 1]);
            Console.Write("Lutfen adet giriniz: ");
            int quantityItemB = int.Parse(Console.ReadLine());
            subTotal = quantityItemB * 15;
            Console.WriteLine(quantityItemB + "*" + items[secim - 1]);
            Console.WriteLine("subTotal= " + subTotal);
            break;

        case 3:
            Console.WriteLine("Secilen urun:" + items[secim - 1]);
            Console.Write("Lutfen adet giriniz: ");
            int quantityItemC = int.Parse(Console.ReadLine());
            subTotal = quantityItemC * 30;
            Console.WriteLine(quantityItemC + "*" + items[secim - 1]);
            Console.WriteLine("subTotal= " + subTotal);
            break;
        default:
            Console.WriteLine("Gecersiz kod girdiniz, Lutfen listedeki kodlari kullanin");
            break;
    }
    if (secim > 0)
    {
        grandTotal += subTotal;
    }
    Console.WriteLine("============");
    Console.WriteLine("Toplam: " + grandTotal);


} while (secim != 0);

Console.WriteLine("Toplam alisveris tutariniz: " + grandTotal);
// Hesaplamalari ve switch icindeki Console.Write satirlarini ayri bir method yapip direk method cagirabiliriz, suanda kendini
// tekrar eden kodlar bulunuyor


/* =========== 3 ============== */

//3 - Do - While ve While döngüsü nedir? Bununla ilgili örnek yapınız.


/*
 While dongusu verilen kosul saglandiginda blok icerisindeki kodlari calistirir, do while ise kosul saglanmasa bile en az 
1 kere kod blogunu calistirir
 */

// While dongusu icin ornek 

int whileLoop = 2;
int doWhileLoop = 2;

while (whileLoop > 5) // Tanimlanan deger sarti saglamamakta
{
    Console.WriteLine("dongu icinde girildi");
    whileLoop++;
}
Console.WriteLine("degerimiz 2 ve sart saglanmadigi icin while dongusu icine girilmedi");
Console.WriteLine("Degerimiz : " + whileLoop);

// Do While dongusu icin ornek 

do // tanimlanan deger sarti saglamamakta ancak do while dongusu oldugu icin dongunun icine 1 kez girecek ve degerimiz 1 artacak
{
    Console.WriteLine("dongu icinde girildi");
    doWhileLoop++;


} while (doWhileLoop > 5);
Console.WriteLine("Degerimiz : " + doWhileLoop);

/* =========== 4 ============== */

// 4 - Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.


// Mukemmel sayi: kendisi haric, tam bolenlerinin toplami kendini veren sayilar (pozitif olmali)

int sum = 0;
List<int> list = new List<int>();

Console.Write("Lutfen pozitif bir sayi giriniz: ");
int input = int.Parse(Console.ReadLine());

if (input == 0 || input < 0)
{
    Console.WriteLine("Gecersiz bir sayi girdiniz!");
}
else
{
    for (int i = 1; i < input; i++)
    {
        if (input % i == 0)
        {
            list.Add(i);
            sum += i;
        }
    }

    if (sum == input)
    {
        Console.WriteLine("Girilen sayi, " + input + ", mukemmel sayidir!");
        Console.WriteLine("Sayinin bolenleri: ");
        foreach (int i in list)
        {
            Console.WriteLine(i);
        }
    }
    else
    {
        Console.WriteLine("Girilen sayi, " + input + ", mukemmel sayi degildir!");

    }
}

/* =========== 5 ============== */
//5- String metotlarını araştırınız. Her bir metot için örnek yapınız.
string str = "Hello World";

// Length
int length = str.Length; // length = 11

// ToUpper()
string upperCase = str.ToUpper(); // upperCase = "HELLO WORLD"

// ToLower()
string lowerCase = str.ToLower(); // lowerCase = "hello world"

// Substring()
string subStr = str.Substring(6); // subStr = "World"

// IndexOf()
int index = str.IndexOf('W'); // index = 6

// Replace()
string newStr = str.Replace("World", "C#"); // newStr = "Hello C#"

// Trim()
string trimmedStr = "   Hello   ".Trim(); // trimmedStr = "Hello"

// Split()
string[] fruits = "apple,banana,orange".Split(','); // fruits = ["apple", "banana", "orange"]

// Contains()
bool contains = str.Contains("World"); // contains = true

// StartsWith()
bool startsWith = str.StartsWith("Hello"); // startsWith = true

// EndsWith()
bool endsWith = str.EndsWith("World"); // endsWith = true

// Concat()
string concatenatedStr = string.Concat("Hello", " ", "World"); // concatenatedStr = "Hello World"

// Compare()
string str1 = "apple";
string str2 = "banana";
int result = string.Compare(str1, str2); // result < 0, çünkü "apple" "banana"'dan alfabetik olarak önce gelir.

// Equals()
bool isEqual = str1.Equals(str2); // isEqual = false

// Join()
string[] fruit = { "apple", "banana", "orange" };
string joinedStr = string.Join(", ", fruits); // joinedStr = "apple, banana, orange"

// IsNullOrEmpty()
string emptyStr = "";
bool isNullOrEmpty = string.IsNullOrEmpty(emptyStr); // isNullOrEmpty = true

// PadLeft() ve PadRight()
string paddedStr = str.PadRight(15, '-'); // paddedStr = "Hello World----"

// Substring() (Başlangıç ve Uzunluk ile)
string subStrWithLength = str.Substring(6, 5); // subStrWithLength = "World"

// ToCharArray()
char[] charArray = str.ToCharArray(); // charArray = ['H', 'e', 'l', 'l', 'o', ' ', 'W', 'o', 'r', 'l', 'd']




/* =========== 6 ============== */

//6- Bir mağazada alınan ürünün fiyatı 300 tl üzerinde ise 50 tl olan kargo ücreti alınmamaktadır. ürünün fiyatı 
// girildiğinde toplam ödemesi gereken tutarı gösteren programı yazınız.


// ikinci ornekte yaptigimiza ek olarak, son kisma toplam fiyati kontrol edip eger 300tl veya fazla ise +shipment ekleyebiliriz

List<string> items6 = new List<string> { "Item A", "Item B", "Item C" };
int secim6 = 0;
int subTotal6 = 0;
int grandTotal6 = 0;
int shipment6 = 50;

do
{
    Console.WriteLine("Urunler:");

    foreach (string urunList in items6)
    {
        Console.WriteLine(urunList);
    }
    Console.WriteLine("Almak istediginiz urunun kodunu giriniz: (Item A icin 1, Item B icin 2, Item C icin 3, Cikis icin Lutfen 0 giriniz) ->");
    secim6 = int.Parse(Console.ReadLine());
    switch (secim6)
    {
        case 0:
            Console.WriteLine("Iyi gunler");
            break;

        case 1:
            Console.WriteLine("Secilen urun:" + items6[secim6 - 1]);
            Console.Write("Lutfen adet giriniz: ");
            int quantityItemA = int.Parse(Console.ReadLine());
            subTotal6 = quantityItemA * 10;
            Console.WriteLine(quantityItemA + "*" + items6[secim6 - 1]);
            Console.WriteLine("subTotal= " + subTotal6);
            break;
        case 2:
            Console.WriteLine("Secilen urun:" + items6[secim6 - 1]);
            Console.Write("Lutfen adet giriniz: ");
            int quantityItemB = int.Parse(Console.ReadLine());
            subTotal6 = quantityItemB * 15;
            Console.WriteLine(quantityItemB + "*" + items6[secim6 - 1]);
            Console.WriteLine("subTotal= " + subTotal6);
            break;

        case 3:
            Console.WriteLine("Secilen urun:" + items6[secim6 - 1]);
            Console.Write("Lutfen adet giriniz: ");
            int quantityItemC = int.Parse(Console.ReadLine());
            subTotal6 = quantityItemC * 30;
            Console.WriteLine(quantityItemC + "*" + items6[secim6 - 1]);
            Console.WriteLine("subTotal= " + subTotal6);
            break;
        default:
            Console.WriteLine("Gecersiz kod girdiniz, Lutfen listedeki kodlari kullanin");
            break;
    }
    if (secim6 > 0)
    {
        grandTotal6 += subTotal6;
    }

    Console.WriteLine("============");
    Console.WriteLine("Toplam: " + subTotal6);


} while (secim6 != 0);

if (0 < subTotal6 && subTotal6 < 300)
{
    grandTotal6 = subTotal6 + shipment6;
}

Console.WriteLine("Toplam alisveris tutariniz: " + grandTotal6);

/* =========== 7 ============== */

//7- iki ürünün kullanıcı tarafından fiyatı girildiğinde toplam fiyat 500 tl'den fazla ise 2.üründen %40 indirim
//yaparak ödenecek tutarı gösteren uygulamayı yazınız.


double total = 0;
double discount = 0.4;
Console.Write("1. urunun fiyatini giriniz: ");
double item1 = double.Parse(Console.ReadLine());

Console.Write("2. urunun fiyatini giriniz: ");
double item2 = double.Parse(Console.ReadLine());

total = item1 + item2;

if (total >= 500)
{
    item2 = item2 - (item2 * discount);
    Console.WriteLine("Toplam: " + total);
    total = item1 + item2;
    Console.WriteLine("-----");
    Console.WriteLine("Toplam 500 birimi gectiginiz icin ikinci urune %40 indirim kazandiniz!");
    Console.WriteLine("Toplam: " + total);


}
else
{
    Console.WriteLine("Toplam: " + total);

}

/* ============== 8 ==============  */

//8 - 1 - 200 arası içinde 3'e veya 5'e tam bölünebilen sayıları listeleyen ve kaç adet olduğunu yazdıran programı yazınız.



List<int> intList = new List<int>();

for (int i = 1; i < 200; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        intList.Add(i);
    }
}

foreach (int numbers in intList)
{
    Console.WriteLine(numbers);
}

Console.WriteLine("Number of the items within the list: " + intList.Count);


