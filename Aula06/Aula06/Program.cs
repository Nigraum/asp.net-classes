int hora = DateTime.Now.Hour;
string message = string.Empty;

switch (hora)
{
    case 10:
    case 15:
        message = "Hora do intervalo.";
        break;

    case 12:
        message = "Almoço";
        break;
   
    default:
        message = string.Empty;
        break;
}