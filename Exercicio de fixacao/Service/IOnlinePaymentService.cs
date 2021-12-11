namespace Exercicio_de_fixacao.Service
{
    internal interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}