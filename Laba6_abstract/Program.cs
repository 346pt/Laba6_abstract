using System;

Jaguar jaguar = new Jaguar();
Console.WriteLine(jaguar.GetInfo());

Ty75 ty75 = new Ty75();
Console.WriteLine(ty75.GetInfo());

Titanic titanic = new Titanic();
Console.WriteLine(titanic.GetInfo());
public abstract class Transport
{
    public abstract double Speed { get; }
    public abstract double Capacity { get; }
    public abstract double Range { get; }

    public abstract string GetInfo();
}

public abstract class Automobile : Transport
{
    public override abstract double Speed { get; }
    public override abstract double Capacity { get; }
    public override abstract double Range { get; }
}

public abstract class Airplane : Transport
{
    public override abstract double Speed { get; }
    public override abstract double Capacity { get; }
    public override abstract double Range { get; }
}

public abstract class Ship : Transport
{
    public override abstract double Speed { get; }
    public override abstract double Capacity { get; }
    public override abstract double Range { get; }
}

public class Jaguar : Automobile
{
    public override double Speed => 250;
    public override double Capacity => 2000;
    public override double Range => 100;

    public override string GetInfo()
    {
        return $"Ягуар со скоростью {Speed} км/ч грузоподъемностью в {Capacity} кг может проехать {Range} км";
    }
}

public class Ty75 : Airplane
{
    public override double Speed => 1000;
    public override double Capacity => 1200;
    public override double Range => 130;

    public override string GetInfo()
    {
        return $"Ty75 со скоростью {Speed} грузоподъемностью в {Capacity} кг может пролететь {Range} км";
    }
}

public class Titanic : Ship
{
    public override double Speed => 120;
    public override double Capacity => 100000;
    public override double Range => 2000;

    public override string GetInfo()
    {
        return $"Титаник со скоростью {Speed} грузоподъемностью в {Capacity} кг может проплыть {Range} км";
    }
}