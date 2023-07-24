[![.NET Core Desktop](https://github.com/weberson22/TDD-Calculadora/actions/workflows/dotnet-desktop.yml/badge.svg)](https://github.com/weberson22/TDD-Calculadora/actions/workflows/dotnet-desktop.yml)

# TDD-Calculadora

Uma calculadora simples em c# que realiza operações básicas de adição, subtração, multiplicação e divisão.
Usamos esse teste para dar inicio ao **TDD (Test-Driven Development)**.  
E ao **CI (Continuous Integration)** que é uma prática de desenvolvimento de software que envolve a integração frequente do código de diferentes desenvolvedores em um repositório compartilhado

## Uso

```csharp
using System;

public class Main {
    public static void Main(string[] args) {
        CalculadoraSimples calculadora = new CalculadoraSimples();

        int num1 = 10;
        int num2 = 5;

        int resultadoSoma = calculadora.Somar(num1, num2);
        Console.WriteLine("Soma: " + resultadoSoma);

        int resultadoSubtracao = calculadora.Subtrair(num1, num2);
        Console.WriteLine("Subtração: " + resultadoSubtracao);

        int resultadoMultiplicacao = calculadora.Multiplicar(num1, num2);
        Console.WriteLine("Multiplicação: " + resultadoMultiplicacao);

        int resultadoDivisao = calculadora.Dividir(num1, num2);
        Console.WriteLine("Divisão: " + resultadoDivisao);
    }
}
```

# Contribuição
Contribuições são bem-vindas! Se você deseja contribuir para aprimorar a Calculadora Simples, siga estes passos:

**Faça um fork do repositório**  

Crie um branch para sua feature (**git checkout -b feature/sua-feature**)  

**Faça suas alterações**  

Commit suas mudanças (**git commit -m 'Adicione sua mensagem aqui'**)  
Push para o branch (**git push origin feature/sua-feature**)  

**Abra um Pull Request**

# Licença
Este projeto está sob a licença MIT. Consulte o arquivo **LICENSE** para mais detalhes.

# Contato
Se você tiver alguma dúvida ou sugestão, sinta-se à vontade para entrar em contato comigo através do meu e-mail: **carlinhos_usa@hotmail.com**
