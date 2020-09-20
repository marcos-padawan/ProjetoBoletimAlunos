using FluentValidation;
using ProjetoBoletimAlunos.Context.Models;



namespace ProjetoBoletimAlunos.Validations
{
    public class AlunoValidation : AbstractValidator<Aluno>

    {
        public AlunoValidation()
        {
            RuleFor(s => s.Nome).NotNull().WithMessage("Deu ruim, campo só cabe 100 caract");
        }
    }
}
