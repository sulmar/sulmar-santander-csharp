## Ćwiczenie: Kalkulator odsetek od kredytu hipotecznego (mortgage interest calculator)

### Wprowadzenie

Aby obliczyć odsetki od kredytu, wystarczy przeprowadzić następujące równanie:

```
O = K * r * n / Y
```

gdzie:

- O – odsetki
- K – kwota kapitału pozostałego do spłaty
- r – oprocentowanie kredytu w skali roku (stałe)
- n – liczba dni miesiąca, dla którego obliczamy odsetki
- Y – liczba dni roku (czyli 365 lub 366)

Przykład:

_Przyjmijmy, że wysokość kapitału pozostałego do spłaty to 150 tys. zł, a oprocentowanie w skali roku wynosi 6%. Raty kredytu spłacamy miesięcznie – nasz miesiąc, dla którego obliczamy wysokość odsetek, ma 31 dni, a rok 365._

```
Odsetki = 150.000 zł * 0,06 * 31 / 365 = 764 zł.
```

Po obliczeniu odsetek od kredytu widzimy, że w tym miesiącu odsetki wyniosą 764 zł.

### Zadanie

Utwórz kalkulator odsetek od kredytu hipotecznego na biezacy dzień i podanych parametrów:

- kwota kapitału pozostałego do spłaty
- oprocentowanie kredytu w skali roku (stałe)

_DateTime.Today_ - zwraca aktualną datę
_DateTime.IsLeapYear_ - zwraca informację czy podany rok jest przestępny
