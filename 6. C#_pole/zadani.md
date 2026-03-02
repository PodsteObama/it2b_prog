# Úlohy – C#: pole (IT2)

---

## Úlohy – Průchod polem

### 1. Součet prvků v poli
Vytvoř pole čísel (např. desetinných) a spočítej součet všech jeho prvků.

- použij cyklus `foreach` (nebo `for`)
- vypiš výslednou sumu

---

## Úlohy – Statistika nad polem

### 2. Statistika z 10 hodnot
Zkuste si vytvořit pole o délce **10**.

Uživatel zadá **10 desetinných čísel**.

Zjisti a vypiš:
1. **maximum**
2. **rozdíl mezi minimem a maximem**
3. **tři nejnižší hodnoty**
4. **medián**

---

## Úlohy – Procvičení (C#: pole)

### 3. Seřazení a výpis
Vypiš prvky libovolného pole **od největšího po nejmenší**.

---

### 4. Anomálie
Vytvoř funkci, která spočítá, **kolik hodnot v poli jsou anomálie**.

- anomálie je prvek, který je **menší / větší než oba jeho sousedé**
- **okraje pole nejsou anomálie**

#### Příklad:
`{0, 20, 55, 40, 11, 15, 28, 55, 4}` → `2`  
(anomálie: `55`, `11`, `55`)

---

### 5. Hodnota akcií (2 funkce)
Máš pole reprezentující **akcie firmy v čase**.

Vytvoř dvě funkce:

#### 5.1 Akcie nad průměrem
Vrátí **procento**, kolik procent času jsou akcie **nad průměrem**.

- výsledek jako číslo v intervalu `<0; 1>`

**Příklad:**  
`{0, 100, 100}` → `0.66666`

#### 5.2 Délka růstu firmy
Vrátí **největší počet narůstajících hodnot za sebou** (nejdelší souvislý rostoucí úsek).

**Příklad:**  
`{0, 20, 55, 40, 11, 15, 28, 55, 4}` → `4`  
(úsek: `11, 15, 28, 55`)

---

K přepisu úloh z prezentace do markdownu byl využit ChatGPT-5.2
