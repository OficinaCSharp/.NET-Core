# Segunda Aula de .NET Core

## Lendo Dados do Usuário

Você ja deve ter percebido que ficar definindo o valor da variavel não é uma coisa muito legal, até porque o nome é variavel, entao se voce mesmo define o valor ela deixa de ser uma variável e vira uma constante, mas para que isso não aconteça dessa vez vamos pedir para o usuário preencher essas variaveis com dados, para isso precisaremos utilizar um novo comando, que é derivado da mesma biblioteca do Console.WriteLine, ou seja a biblioteca System.

```csharp
    Console.WriteLine("Digite seu nome: ");
    nome = Console.ReadLine();
```

Como pode ver eu peço ao usuário através de uma mensagem para que ele digite o nome, logo em seguida eu utilizo da variável que eu ja havia criado e subescrevo ela com o valor que o usuario digitar e para receber este valor eu utilizo o comando **Console.ReadLine()** que como o próprio nome ja diz ele irá ler a linha em que o usuário digitou, ou seja qualquer coisa que o usuário digitar ele irá pegar esse determinado dado e irá armazenar em uma variável.

### Conversão de Variáveis

Mas há um porem nisso tudo, o **Console.ReadLine()** so lê tipos de dados String, pois String aceita tudo, como numeros, valores booleanos e etc, então voce deve estar se perguntando, entao porque na hora de declarar as variaveis não coloco como tudo do tipo String, pelo simples fato que com String você não consegue realizar cálculos, apenas valores do tipo int e double que são possiveis efetuar cálculos, então como faremos para pegar um número digitado pelo usuario e converter esse numero de String para int, simple utilizaremos no comando a seguir:

```csharp
    Console.WriteLine("Digite sua idade: ");
    idade = int.Parse(Console.ReadLine());
```

Para converter um valor do tipo String para int, devemos utilizar o comando **int.Parse(Console.ReadLine());**, a mesma coisa se aplica a valores do tipo double:

```csharp
    Console.WriteLine("Digite seu saldo: ");
    saldo = double.Parse(Console.ReadLine());
    Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos, meu saldo na conta é de {saldo.ToString("c")} ");
```

## Operadores Matemáticos

Como já é visto desde o primário na escola, para realizar operações matemáticas é necessários simbolos, como por exemplo para somar é necessário o simbolo de **+** (Mais), na programação não é diferente, então agora irei mostrar alguns simbolos de operação matemática utilizado na linguagem C#:

```csharp
    double valor1 = 50, valor2 = 35;

    double soma = valor1 + valor2; //Somar
    double sub = valor1 - valor2; //Subtrair
    double mult = valor1 * valor2; //Multiplicar 
    double div = valor1 / valor2; //Dividir
    double restoDiv = valor1 % valor2; //Resto da divisão

    Console.WriteLine($"Resultado da soma é: {soma} ");
    Console.WriteLine($"Resultado da subtração é: {sub} ");
    Console.WriteLine($"Resultado da multiplicação é: {mult} ");
    Console.WriteLine($"Resultado da divisão é: {div} ");
    Console.WriteLine($"Resultado do resto da divisão é: {restoDiv} ");
```

Teste e código.

## Exercicio 1

Faça um programa que calcule a área de um círculo. A fórmula para calcular a área de uma circunferência é: area = π * (raio * raio). Considerando para este problema que π = 3.14159. O usuário deve digitar apenas o valor do raio que será do tipo double e logo após o cálculo deverá ser mostrado o resultado do cálculo.

![Exercicio 1](https://i.imgur.com/SXGjna7.png "Exercicio 1")

## Exercicio 2

Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário.

![Exercicio 2](https://i.imgur.com/Yz9N70J.png "Exercicio 2")

## Exercicio 3

Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre: 
1. a área do triângulo retângulo que tem A por base e C por altura. 
2. a área do círculo de raio C. (pi = 3.14159) 
3. a área do trapézio que tem A e B por bases e C por altura. 
4. a área do quadrado que tem lado B. 
5. a área do retângulo que tem lados A e B.

![Exercicio 3](https://i.imgur.com/E64CFS7.png "Exercicio 3")

## Exercicio 4

Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente às quatro notas de um aluno. Calcule a média com pesos 2, 3, 4 e 1, respectivamente, para cada uma destas notas e mostre esta média acompanhada pela mensagem "Media: ". Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.". Se a média calculada for inferior a 5.0, imprima a mensagem "Aluno reprovado.". Se a média calculada for um valor entre 5.0 e 6.9, inclusive estas, o programa deve imprimir a mensagem "Aluno em exame."

![Exercicio 4](https://i.imgur.com/kFGApLF.png "Exercicio 4")