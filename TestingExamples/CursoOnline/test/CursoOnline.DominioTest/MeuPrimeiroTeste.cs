using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CursoOnline.DominioTest
{
    public class MeuPrimeiroTeste
    {
        [Fact(DisplayName = "DeveAsVariaveisTeremOMesmoValor")]
        public void DeveAsVariaveisTeremOMesmoValor()
        {
            //Three steps = Organize, Act, Assert

            //Organização
            var variavel1 = 1;
            var variavel2 = 1;

            //Ação
            variavel2 = variavel1;
            
            //Assert
            Assert.Equal(variavel1, variavel2);
            //Assert.True(variavel1 == variavel2);
            //Assert.False(variavel1 == variavel2);

        }
    }
}
