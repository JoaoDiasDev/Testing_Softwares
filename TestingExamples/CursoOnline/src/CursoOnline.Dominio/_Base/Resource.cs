namespace CursoOnline.Dominio._Base
{
    public static class Resource
    {
        public static string NomeInvalido { get; set; } = "Nome inválido";
        public static string EmailInvalido { get; set; } = "Email inválido";
        public static string CargaHorariaInvalida { get; set; } = "Carga horária inválida";
        public static string ValorInvalido { get; set; } = "Valor inválido";
        public static string NomeDoCursoJaExiste { get; set; } = "Nome do curso já consta no banco de dados";
        public static string PublicoAlvoInvalido { get; set; } = "Publico Alvo inválido";
        public static string CpfInvalido { get; set; } = "CPF inválido";
        public static string CpfJaCadastrado { get; set; } = "CPF já cadastrado";
        public static string AlunoInvalido { get; set; } = "Aluno inválido";
        public static string CursoInvalido { get; set; } = "Curso inválido";
        public static string ValorPagoMaiorQueValorDoCurso { get; set; } = "Valor pago na matricula não pode ser maior que valor do curso";
        public static string PublicosAlvoDiferentes { get; set; } = "Publico alvo do aluno e curso são diferentes";
        public static string CursoNaoEncontrado { get; set; } = "Curso não encontrado";
        public static string AlunoNaoEncontrado { get; set; } = "Aluno não encontrado";
        public static string NotaDoAlunoInvalida { get; set; } = "Nota do aluno invalida";
        public static string MatriculaNaoEncontrada { get; set; } = "Matricula não encontrada";
        public static string MatriculaCancelada { get; set; } = "Ação não permitida por matricula está cancelada";
        public static string MatriculaConcluida { get; set; } = "Ação não permitida por matricula está conclída";
    }
}
