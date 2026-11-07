// //Шаг 2. ref — Swap
// void DoubleValue(ref int number) {
//     number = number * 2;
//     }
//     int x = 5;
//     DoubleValue(ref x);
//     Console.WriteLine(x); // 10 — изменилось
// int a =5;
// int b = 10;
// Console.WriteLine($"До обмена: a = {a}, b= {b}");
// Swap(ref a,ref b);
// void Swap(ref int a, ref int b){
//     int h = a;
//     a = b;
//     b = h;
// }
// Console.WriteLine($"После обмена: a = {a}, b = {b}");
// //Шаг 3. out — частное и остаток
// bool TryDivide(int a, int b, out int result) {
//     if ( b == 0){
//         result = 0;
//         return false;
//     }
//     result = a/b;
//     return true;
// }
// TryDivide(10,2,out int result);
// Console.WriteLine(result);
// TryDivide(10,0,out int result2);
// Console.WriteLine(result2);
// //Шаг 4. in
// CharacterStats hero = new CharacterStats();

// hero.Health = 100;
// hero.Damage = 20;
// hero.Armor = 10;

// PrintStats(in hero);
// void PrintStats(in CharacterStats stats)
// {
//     Console.WriteLine($"Здоровье: {stats.Health}");
//     Console.WriteLine($"Урон: {stats.Damage}");
//     Console.WriteLine($"Броня: {stats.Armor}");
// }

// struct CharacterStats
// {
//     public int Health;
//     public int Damage;
//     public int Armor;
// }
//Шаг 5. Необязательные параметры и именованные аргументы
void ShowHero(string name, int level, string heroClass = "Воин")
{
    Console.WriteLine($"{name}, уровень {level}, класс {heroClass}");
}

ShowHero("Аня", 5);
ShowHero("Макс", 10, "Маг");
ShowHero("Лена", 7, heroClass: "Лучник");
//Итоговая задача. Проектирование системы персонажа
int health = 100;

// ref — использую, потому что нужно изменить здоровье
void ChangeHealth(ref int health)
{
    health = health - 20;
}

// return — использую, чтобы вернуть урон
int GetDamage(int a, int b)
{
    return a - b;
}

// out — использую, чтобы вернуть эффект и успех
bool GetEffect(out int effect)
{
    effect = 30;
    return true;
}

// in — использую, чтобы только читать характеристики
void ShowStats(in CharacterStats hero)
{
    Console.WriteLine($"Здоровье: {hero.Health}");
    Console.WriteLine($"Урон: {hero.Damage}");
    Console.WriteLine($"Защита: {hero.Protection}");
}

// Необязательный параметр — нужен для выбора вывода
void ShowHeroInfo(string name, bool info = true)
{
    Console.WriteLine($"Имя: {name}");

    if (info)
    {
        Console.WriteLine("Уровень: 5");
    }
}

ChangeHealth(ref health);
Console.WriteLine($"Здоровье: {health}");

Console.WriteLine($"Урон: {GetDamage(50, 10)}");

bool result = GetEffect(out int effect);
Console.WriteLine($"Умение: {result}");
Console.WriteLine($"Эффект: {effect}");

CharacterStats hero = new CharacterStats();
hero.Health = health;
hero.Damage = 50;
hero.Protection = 10;

ShowStats(in hero);

ShowHeroInfo("Аня", info: true);

struct CharacterStats
{
    public int Health;
    public int Damage;
    public int Protection;
}