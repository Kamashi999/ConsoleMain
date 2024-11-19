// Zmienne

/* Zmienne możemy przypisać również w sposób podany poniżej,znak "=" jest operatorem przypisania.
Program jest czytany od góry do dołu, oznacza to że jeżeli zmienna zostanie zadeklarowana pod Console.Write
to program nie będzie wiedział o co chodzi. Również jeżeli po zadeklarowaniu zmiennej np. o wartości 1, a następnie
nadpisaniu jej w postaci 3, program wyświetli postać liczbową która została napisana najniżej. Dlatego nazywamy 
to zmienną */

int number;
number = 0;

Console.Write(number);

int number1 = 1;

// Deklaracja + inicjalizacja w jednym ^

/* Posiadamy również Stałe. Używamy do tego "Const" na początku. Nazwy stałych w C# pisane są
wielkimi literami. */

const int MAX_LENGHT = 128;

Console.Write(MAX_LENGHT);

/* Jak podawać nazwy zmiennych. W przypadku zmiennych będziemy używać CamelCase, czyli pierwszy wyraz
zaczynamy małą literą, a następne już wielką np: */

string firstName, lastName, lastVisitedPlace;

// Zmienne prywatne poprzedzamy "_".

class Person { 
    private int _agee;
    private string _name;
};

/* !!! Zmiennych nie możemy zaczynać od liczb, natomiast w dalszej części zmiennej mogą zostać zawarte.
Również nie możemy używać spacji !!! */

// C# również rozpoznaje wielkie i małe litery, czyli możemy mieć zmienne : Num, nUm, nuM.

// C# również ma swoje Keywords'y, których nie możemy używać do tworzenia nazw, np. case.

// Dla czystości kodu, należy używać związłych nazw do zmiennych i funkcji, np. zamiast samego "n", powinno być "number".

// Jeżeli chcemy zmienić nazwę zmiennej, a nie chcemy nie potrzebnie latać po kodzie, wystarczy zaznaczyć tekst i dwukrotnie kliknąć CTRL + R