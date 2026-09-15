# Úlohy – C#: zapomenutá témata (IT3)

---

## Úlohy – Konstanty

### 1. Obsah kruhu
Vytvoř metodu, která vypočítá **obsah kruhu**.

- použij konstantu pro hodnotu π
- vstupem metody bude poloměr kruhu
- metoda vrátí vypočítaný obsah

---

### 2. Pokuty za překročení rychlosti
Maximální rychlost v obci je pevně daná na **50 km/h**.

Vytvoř metodu, která vypočítá celkovou pokutu podle naměřených rychlostí jednoho auta.

- vstup: `List<int>` naměřených rychlostí
- výstup: celková pokuta
- za každé měření nad **50 km/h** se účtuje **500 Kč**
- pokud je více než **10 měření nad 50 km/h**, připočti dalších **1000 Kč**
- pokud existuje více než **6 měření** a zároveň jsou **všechna měření nad 50 km/h**, připočti dalších **6000 Kč**
- hodnoty, které se během programu nemění, ulož jako konstanty

---

### 3. Výpočet výplaty
Hodinová mzda je **220 Kč**, přesčasová hodina je placená **350 Kč**.

Vytvoř metodu, která vypočítá výplatu zaměstnance.

- vstup:
  - počet hodin ve smlouvě
  - počet skutečně odpracovaných hodin
- hodiny do počtu hodin ve smlouvě jsou placeny běžnou hodinovou mzdou
- každá hodina navíc je placena jako přesčas
- výstupem metody je celková výplata
- pevné sazby ulož jako konstanty

#### Příklad

Pro **26 odpracovaných hodin** a **18 hodin ve smlouvě**:

`18 × 220 + 8 × 350 = 6760 Kč`

---

## Úlohy – `break;` a `continue;`

### 4. Vstup do trezoru
Program má uložený správný číselný kód.

- správný kód ulož jako konstantu
- uživatel má pouze **5 pokusů**, aby se dostal dovnitř
- po zadání správného kódu program ihned oznámí úspěch a další pokusy už neprovádí
- pokud uživatel správný kód nezadá, po pátém pokusu se trezor zablokuje

---

### 5. Automat na nápoje
Cena nápoje je **35 Kč**.

Program má postupně sčítat peníze vhozené uživatelem.

- cenu nápoje ulož jako konstantu
- pokud uživatel zadá jinou hodnotu než platnou minci, program ji ignoruje
- po každé platné minci se její hodnota přičte k vložené částce
- jakmile uživatel vloží dostatek peněz, automat vydá nápoj a ukončí se

---

### 6. Zpracování objednávek
Máš pole cen objednávek, například:

```csharp
int[] objednavky = { 450, -1, 720, 1300, -5, 280 };
```

Vytvoř metodu, která vrátí, zda jsou všechny objednávky validní.

- objednávka je validní, pokud má cenu `>= 0`
- metoda vrací pouze `true` nebo `false`
- jakmile zjistíš, že některá objednávka validní není, není potřeba kontrolovat zbytek pole

---

## Úlohy – `try { } catch { }`

### 7. Výpočet ceny lístku na osobu
Parta kamarádů si koupila skupinový lístek.

Uživatel zadá:

1. cenu skupinového lístku
2. počet osob

Program vypíše, **kolik zaplatila jedna osoba**.

Pomocí `try-catch` ošetři:

- uživatel zadá místo čísla neplatný vstup
- uživatel zadá počet osob `0`

Pro jednotlivé typy problémů použij vhodné konkrétní typy výjimek.

---

*K přepisu úloh z prezentace do Markdownu byl využit ChatGPT.*
