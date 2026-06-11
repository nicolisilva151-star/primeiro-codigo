Console.WriteLine("Informe um numero>:!");
int variavelQueSalvaUmNumero = int.Parse(Console.ReadLine()!);
if (variavelQueSalvaUmNumero % 2 == 0) {
    Console.WriteLine($"Numero {variavelQueSalvaUmNumero} e par");
} else {
    Console.WriteLine($"Numero {variavelQueSalvaUmNumero} e impar");
}


