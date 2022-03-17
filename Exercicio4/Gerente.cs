namespace Exercicio4 // mudar aqui
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, double salario) : base(nome, idade, salario) { }

        public override double bonificacao(double salario)
        {
            return salario + 10000.00;
        }
    }
}
