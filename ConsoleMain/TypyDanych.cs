// Typy danych


// Bool używany jest do sprawdzania Prawda/Fałsz
bool Check = true;

Console.Write(Check + "\n");

/* Zmienne liczbowe
Wyróżniamy kilka rodzajów: SByte, Byte, Short, Ushort, Int, Uint...
W zależności od zwięzłości kodu można ich używać do optymalizacji
są one zapisywane w 8,16,32,64 bitach. (8 bitów = 1 bajt!)
SByte zawiera liczby ujemne i dodatnie, Byte tylko dodatnie, ...
*/

Byte liczba1 = 254;

Console.Write(liczba1 + "\n");

// zazwyczaj używana wartość to int.

/* Znaki specjalne: (... + "_")
\n - nowa linia
\t i \v - Tabulacja pozioma/pionowa
\b - backspace
*/

/* Zmienne liczbowe PRZECINKOWE!
Wyróżniamy 3 rodzaje Float, Double, Decimal.
Są one uporządkowane od najmniejszej wyświetlanej liczby po przecinku
do największej wyświetlanej liczby po przecinku.
*/


// Na przykładzie Float, jeżeli liczba jest zbyt długa, należy na jej końcu dopisać litere "f"
float Fpi = 3.141592653589793238462643383279502884197f;

Console.Write(Fpi + "\n");

double Dpi = 3.141592653589793238462643383279502884197;

Console.Write(Dpi + "\n");

// Adekwatnie "m" na końcu
// Funfact! w Decimalu zazwyczaj pisane są programy bankowości.
decimal Depi = 3.141592653589793238462643383279502884197m;

Console.Write(Depi + "\n");


// Wartości tekstowe zapisujemy chociażby za pomocą string.

string imie = "Mateusz";

Console.Write(imie + "\n");

// Zmienna Char - ???

// Zmienna Var, używana jest do zastępywania wszystkich typów

var numer = 2;
Console.Write(numer + "\n");

// Aby zatrzymać wyskakujące okno konsoli po otworzeniu kodu z pliku wywoławczego, należy dodać komendę podaną poniżej

Console.ReadKey();