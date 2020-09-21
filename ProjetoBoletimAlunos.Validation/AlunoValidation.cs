using FluentValidation;
using ProjetoBoletimAlunos.Models;

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
