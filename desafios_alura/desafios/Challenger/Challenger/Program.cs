public class Calculadora
{
    public static double Calcular(double numero1, double numero2, char operacao)
    {
        double resultado = 0;

        switch (operacao)
        {
            case '+':
                resultado = Somar(numero1 + numero2);
                break;
            case '-':
                resultado = Subtrair(numero1 - numero2);
                break;
            case '*':
                resultado = Multiplicar(numero1 * numero2);
                break;
            case '/':
                resultado = Dividir(numero1 / numero2);
                break;
            case '%':
                resultado = Porcentagem(numero1, numero2);
                break;
            case '^':
                resultado = Potencia(numero1, numero2);
                break;
            case 'r':
                resultado = RaizQuadrada(numero1);
                break;
            default:
                resultado = 0;
                break;

        }
    }
}