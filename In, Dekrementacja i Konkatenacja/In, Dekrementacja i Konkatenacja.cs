// Inkrementacja i Dekrementacja, oznacza najzwyczajniej dodawanie i odejmowanie wartości


// Rodzaje inkrementacji

int number = 0;
number += 2;
number++; //zwiększa tylko o 1. (postinkrementacja, ++ przed number (++number) to preinkrementacja)

// dodając inkrementacje w Console.Write() w postaci number++, liczba zwiększy się o jeden ale dopiero w kolejnym wywołaniu, dopiero po dodaniu ++number, wywoła to odrazu.

int number2 = 0;
Console.WriteLine(number2++);
Console.WriteLine(number2);
Console.WriteLine(++number2);

//inne operatory to *=, /=, %=.

int number3 = 10;
number3 %= 3;

Console.WriteLine(number3);

/* konkatenacja to łączenie ciągów znaków, jeżeli dodamy tylko 2 liczby w Console.Write(), to program je doda, natomiast jeżeli dodamy tam tekst, wszystko
skonwertuje się w tekst. */

int num1 = 1;
int num2 = 20;

Console.WriteLine(num1 + num2); // 21
Console.WriteLine("" + num1 + num2); // 120
Console.WriteLine("" + (num1 + num2)); // 21, działa to jak w matematyce z nawiasami.
Console.WriteLine(num1.ToString()); // zmienia typ danych z int na string.

// kontatenacja przez interpolacje

string userName = "adam";
int points = 10;

string sentence = $"{userName} has {points} points";
Console.WriteLine(sentence);

