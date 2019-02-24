# Primeira Aula de .NET Core

## Iniciando o primeiro projeto
Para Iniciar um projeto em C# utilizando o .NET Core é necessário abrir um terminal de sua preferência, após isso crie uma pasta em algum lugar de sua maquina chamada de "Aula1": 

**Windows:**   
    
    md aula1

**Linux/MacOS:**

    mkdir aula1

Após criada a pasta, basta apenas entrar nela:

**Windows/Linux/MacOS:**   
    
    cd aula1

Agora para inciar um projeto em .NET Core, basta digitar o seguinte comando:

    dotnet new console

Depois de alguns segundos o projeto será criado com sucesso, para abrirmos o mesmo no Visual Studio code basta apenas digitar o seguinte comando:

    code .

## Estrutura de Pastas
Logo em seguida a IDE irá iniciar e assim desta forma, conseguiremos trabalhar em cima de nosso projeto. Logo de cara podemos ver que o próprio framework ja criar algumas pastas e arquivos para a gente, não irei explicar todos os arquivos, pois a maioria deles são dll's e dependências que o framework necessita para funcionar. 

O Arquivo **Aula1_exemplo.csproj** é o arquivo onde podemos ver qual a versão do .NETCore que estamos utilizando nesse projeto, pois em cada projeto você pode utilizar uma versão diferente. O arquivo que mais vamos mexer nesse curso é o **Program.cs** é nele que a maior parte da nossa lógica ficará, pelo menos até o momento em que veremos Orientação a Objetos.

![Pastas](/asset/img/Pastas "Pastas")

## Primeiro Contato com o Código

Após clicar no **Program.cs** podemos ver um pouco de código também já gerado pelo framework.

![Main](/asset/img/main "Main")

O código abaixo é uma biblioteca pronta do próprio C# que utiliza alguns recursos do sistema. O using é o comando para informar ao C# que eu irei utilizar a biblioteca System nesse meu código.

    Using System;

o class Program é o nome da classe que estou utilizando no momento que no caso é referenciado pelo nome do próprio arquivo **Program.cs**, o static void Main é o método principal da minha classe, porém não explicarei a fundo o que ele é, pois isso é assunto para a parte de orientação a objeto, o que é necessário saber é que é dentro desse método que iremos colocar todo o nosso código.

    class Program{
        static void Main(string[] args){

        }
    }

O comando a seguir irá exibir uma mensagem em um terminal no caso "Hello World!!". Console.WriteLine é um comando da biblioteca System (biblioteca na qual importamos na primeira linha de código), Esse comando é reponsavél por exibir/escrever na tela uma mensagem para o usuário.

    Console.WriteLine("Hello World!!");

*Obs: Não se esqueça do ";"(Ponto e virgula) no final de cada linha de comando*

## Compilando o Projeto

Para rodarmos o código é necessário abrir novamente um terminal de comandos, porém dessa vez iremos abrir o terminal do próprio VS Code apertando a tecla:

    ctrl+`

Após o terminal ser aberto basta apenas digitar o seguinte comando para que sua aplicação compile: 

    dotnet run

Após isso, podemos ver a mensagem que esta escrita no Console.WriteLine, no caso **"Hello World!!"**

![Mensagem](/asset/img/mensagem "Mensagem")

## Variáveis

Na maioria das linguagens de programação temos que começar declarando variáveis e no C# não é diferente, mas você deve estar se perguntando o que é uma variável ? variável nada mais é do que um local/endereço onde podemos armazenar dados e como o próprio nome já diz esses dados podem variar, vamos entender um pouco melhor no código. Apague a linha do **Console.WriteLine** e digite os seguintes comandos:

    String nome = "Ronaldo";
    int idade = 19;
    double saldo = 1000.00;
    DateTime data = DateTime.Today;

Eu declarei 4 variáveis e cada uma possui um tipo de dado, porém eu irei explicar isso daqui a pouco, mas o que importa no momento é que você consiga entender como funciona a declaração de uma variável, no caso a variável ela sempre tem que ter um nome, e esse nome você mesmo pode definir, porem coloque um nome que tenha a ver com o dado que você quer armazenar, por exemplo, eu declarei uma variável com o nome **idade** que esta recebendo o valor 19.

Assim como no exemplo anterior demos o nome de **idade** a nossa variável, toda variável precisa ser referenciada através de um NOME. Para criar nomes de variáveis, é necessário seguir algumas regras básicas de sintaxe:

- Todo nome deve ser composto apenas por letras, números e sublinhado ( ‘_’ )
- Deve começar com uma letra
- Não pode ser igual a nenhuma palavra reservada, ou seja, palavras que já possuam um significado próprio para a linguagem como por exemplo, true, var ou if.

Sendo assim, são nomes válidos de variáveis:

    Valor
    meu_nome
    X5

São nomes inválidos:

    5X
    R$3,00
    meu nome

### Tipos de Variáveis

Como havia dito variáveis possuem tipos e você deve identificar qual o tipo da sua variável:

    int - Aceita apenas valores inteiros
    String - Aceita apenas valores do tipo texto/cadeia de caracteres
    double - Aceita valores inteiros e valores que possuem numeros após a virgula
    DateTime - Aceita apenas valores do tipo data ou hora
    char - Aceita apenas um e somente um caracter
    boolean - Variável que aceita apenas TRUE ou FALSE

Essas são alguns tipos de variáveis disponiveis, existem muito mais, porém fica a critério de cada um pesquisar sobre as outras, mas obviamente quando formos utilizar um tipo de variável diferente eu irei explicar sobre ela.

## Exibindo Alguns Dados na Tela

Como haviamos visto o comando Console.WriteLine exibe uma mensagem personalizada pelo próprio desenvolvedor, porém se você quiser exibir dados de uma determinada variável é necessário utilizar a seguinte sintaxe:

    Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos, meu saldo na conta é de {saldo} ");

No inicio do comando precisamos colocar o $(cifrão), para indicar que queremos exibir o valor da variável como texto para o usuário e para informamos que no meio do texto aquilo é de fato uma variável devemos coloca-lá entre **{nome}** (Chaves). Após isso execute o código.

![Concatenação](/asset/img/concatenacao "Concatenação")

Podemos perceber que o saldo da conta não está sendo exibida com os numeros após a virgula, como tipo de dado double, aceita valores inteiros ele entende que aquele valor é inteiro e não exibi os valores, para resolver o problema é simples, basta adicionar a seguinte linha de código:

    Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos, meu saldo na conta é de {saldo.ToString("c")} ");

Repare que eu adicione um comando chamado ToString e inseri nele o caracter "c", este comando transforma o saldo que é um valor do tipo double em um valor do tipo String, e o caracter "c", força os valores após a virgula e ainda por cima, informa qual a moeda daquele saldo, ou seja, se é em dolar, real, libra e etc. Execute o código e veja a diferença