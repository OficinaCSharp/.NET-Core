# Terceira Aula de .NET Core

## Estrutura de Repetição

Estrutura de repetição é utilizada, quando quero repetir determinados passos que são repetitivos, so que de forma automatizada, por exemplo, quero exibir os valores entre 1 e 10, com o conhecimento que você possui, muito provavelmente você faria desta forma:

```csharp
    Console.WriteLine("1");
    Console.WriteLine("2");
    Console.WriteLine("3");
            .
            .
            .
    Console.WriteLine("10");
```

Desta forma é bem simples e até que rápido, porém e se eu pedir para ti exibir os valores entre 1 e 1.000, o código ficaria gigantesco e visualmente feio, para esses tipos de situações que as estruturas de repetição irão nos auxiliar:

### For

```csharp
    for(int i = 0; i <= 1000; i++)
    {
        Console.WriteLine($"Numero {i}");
    }
```

A sintaxe do For é feita desta forma, primeiro é necessario inserir o comando FOR e abrir parenteses, a primeira parte("int i = 1") é para informar o inicio, ou seja de onde que o laço irá partir, no caso eu estou informando que ele irá partir do numero 1, logo após isso é necessário utilizar o ";" para separar o inicio do fim. 

Após o ponto e virgula é necessario informar a condição, ou seja ate que ponto o meu laço irá, tambem conhecido como o final do laço, no caso eu estou verificando enquanto o valor que está na variavel **i** for <= a 1000 ele irá repetir o laço enquanto essa condição for verdadeira.

Após isso é necessario colocar mais um **;** para separar a condição do incremento, pois no incremento é onde iremos incrementar um valor a variavel **i**, pois toda vez que o laço for executado ele irá adicionar um valor há mais na variavel, por exemplo:

Passagens | i    | Incremento(i++) | Formula      | Condição (i <= 1000)
--------- | ---- | --------------- | ------------ | ------------------:
1º        | 0    | i = i + 1       | i = 0 + 1    | Verdadeiro
2º        | 1    | i = i + 1       | i = 1 + 1    | Verdadeiro
3º        | 2    | i = i + 1       | i = 2 + 1    | Verdadeiro
4º        | 3    | i = i + 1       | i = 3 + 1    | Verdadeiro
.         | .    | .               | .            | .
.         | .    | .               | .            | .
1001º     | 1000 | i = i + 1       | i = 1000 + 1 | Verdadeiro
1002º     | 1001 | i = i + 1       | i = 1001 + 1 | Falso

### While

```csharp
    int j = 1, l = 10;
    while(j <= l)
    {
        Console.WriteLine($"Numero {j}");
        j++;
    }
```

A Sintaxe do While é bem mais simples que a do For, pois aqui so colocamos apenas a condição, a situação mais comum para se utilizar o While é quando você não sabe quando ele irá terminar, ou seja quando ele depende de uma condição, ou seja enquanto a condição for verdadeira ele irá executar o código ate que ela seja falsa. Assim como no For, dentro das chaves **{}** você poderá colocar o código que quiser, ou seja isso te possibilita exibir uma mensagem varias vezes, colocar um If dentro do While/For, colocar um While dentro de um While, um for dentro do While e vice-versa, entre outras coisas que você pode fazer, ou seja as opções são quase ilimitadas.

### Do While

```csharp
    int valor=0;
    do
    {
        Console.WriteLine("Digite '1' para sair");
        valor = Convert.ToInt32(Console.ReadLine());
    } while (valor != 1);
```

O Do While é bem parecido com o While e o For, porem ele possui uma diferença, diferente dos outros repetidores, esse daqui executa um código primeiro, na situação acima é executado um código primeiro, pedindo para o usuario digitar o numero 1 para sair do programa, caso ele digite um numero diferente de 1, o laço se repetirá e irá exibir a mensagem novamente para pessoa, ou seja, o usuário so consegue sair desse looping se ele digitar o valor que está sendo pedido.

O **do** é para indicar que antes de qualquer condição ou qualquer repetição, ele irá executar esse código primeiro e depois de executado ele irá entrar na condição, pra verificar se é pra repetir novamente esse código ou não. Já o While e o For, executando a condição primeiro e depois o código que você digitou

## Exercicio 1

Faça um programa que exiba todos os números entre 4 e 55 e exiba eles na tela

## Exercicio 2

Faça um programa que exiba todos os numeros entre 50 e 4, ou seja comece exibindo do numero 50 e termine no numero 4

## Exercicio 3

Faça um programa que exiba todos os numeros pares entre 1 e 100

## Exercicio 4

Faça um programa que peça para o usuario digitar dois numeros e logo em seguida apareça um menu com 4 opções(1 - soma, 2 - subtrair, 3-multiplicar e 4 - dividir), faça o devido tratamento para que ele não digite um valor invalido do menu, após ser escolhido a operação desejada, exiba o resultado da operação com os dois numeros
