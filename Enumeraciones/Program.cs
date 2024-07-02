// Enumeracion

// 1-> organico, 2-> inorganico, 3-> no sacar
SacarBasuraEnum opcionBasura = SacarBasuraEnum.no_sacar;

Console.WriteLine(opcionBasura);


switch (opcionBasura)
{
    case SacarBasuraEnum.organico:

        break;
    case SacarBasuraEnum.inorganico:

        break;
    case SacarBasuraEnum.no_sacar:

        break;
}

enum SacarBasuraEnum
{
    organico = 0,
    inorganico = 1,
    no_sacar = 2, 
}