using System;

public class Account
{
    public int _balance = 0;
    public void Deposit(int amount)
    {
        _balance = _balance + amount;
    }
}
class Circulo
{
    double pi = 3.1416; //propiedad de la clase circulo. Al definir las propiedades de una variable, se está creando un campo de clase//
    // se declarará un método que va a calcular el área del círculo:
    double calculoArea(int radio)
    {
        return pi * radio * radio;
        
    }

}

