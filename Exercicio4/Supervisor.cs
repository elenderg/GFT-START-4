namespace Exercicio4
    {
    public class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, double salario) : base( nome, idade, salario)
        {
        }
        public override double bonificacao(double salario){
            return salario + 5000.00;
        }          
    }
}