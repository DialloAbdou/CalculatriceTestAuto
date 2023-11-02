using Calcul;
using DotNetty.Transport.Channels;
using FluentAssertions;

namespace CalculTest
{
    public class CalculServiceTest
    {

        private CalculService service;

        public CalculServiceTest()
        {
            service = new CalculService();
        }
        [Theory]
        [InlineData(5, 5, 10)]
        [InlineData(0, 0, 0)]
        [InlineData(-10, -20, -30)]

        public void additon_should_return_Value_After_Sum_Two_Parametre_Passed(int a, int b, int expected)
        {
            // Arrange => preparer mon environnement de travail

            // Action
            int resultat = service.addition(a, b);
            // Assert
            resultat.Should().Be(expected);
            Assert.Equal(expected, resultat);
        }


        [Theory]
        [InlineData(5, 5, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(-10, -20, 10)]
        public void soustration_should_return_value_after_subtraction_two_parameters(int a, int b, int expected)
        {
            // Arrange => preparer mon environnement de travail
            // Action
            var resultat = service.soustration(a, b);
            // Assert
            // using FluentAssert
            resultat.Should().Be(expected); 
            //Assert.Equal(expected, resultat);
        }


        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(0, 0, 0)]
        [InlineData(-10, -20, 200)]
        public void Multiplication_should_return_value_after_subtraction_two_parameters(int a, int b, int expected)
        {
            // Arrange => preparer mon environnement de travail
            // Action
            var resultat = service.Mulitiplication(a, b);
            // Assert
            resultat.Should().Be(expected);
          //  Assert.Equal(expected, resultat);
        }


        [Theory]
        [InlineData(5, 5, 1)]
        [InlineData(20, 5, 4)]
        public void division_should_return_value_after_divided_two_parameters(int a, int b, int expected)
        {
            // Arrange => preparer mon environnement de travail
            // Action
            var resultat = service.division(a, b);
            // Assert
            resultat.Should().Be(expected);
          //  Assert.Equal(expected, resultat);
        }

        [Fact]
        public void division_should_ThrowArgumentExeception_When_second_param_equalTo_Zero()
        {
            // Arrange => preparer mon environnement de travail
            // Action
            Action action = () => service.division(10, 0);
             action.Should().Throw<DivideByZeroException>();
           // Assert.Throws<DivideByZeroException>(() => service.division(10, 0));
            // Assert

        }
    }
}
