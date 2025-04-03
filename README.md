# Rob� Tupiniquim

## Projeto
Desenvolvido durante o curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net) 2025

## Detalhes
A AEB (Ag�ncia Espacial Brasileira) entrou em contato com a turma da
Academia do Programador para realiza��o de um novo projeto.
A ag�ncia est� planejando uma expedi��o � Marte, mas antes, a AEB vai
enviar uma nave espacial (codinome Tupiniquim I) tripulada com um Rob�
para fazer an�lises do planeta vermelho. Os alunos da 11a edi��o da
Academia do Programador, reconhecidos como excelentes programadores,
foram contratados para desenvolver o software que ir� guiar o Rob� nesta
empreitada.

### Sobre o Sistema
A �rea escolhida para an�lise � curiosamente retangular e os rob�s devem
andar por ela com suas c�meras ligadas coletando todo tipo de informa��o.

A posi��o de um rob� � representada por uma combina��o de coordenadas X
e Y e tamb�m uma letra representando a dire��o que ele est� olhando. A �rea
� dividida em um grid para simplificar a navega��o. Um exemplo de posi��o
poderia ser: 0,0,N, significando que o rob� est� na parte inferior esquerda com
a face para o norte. Use as orienta��es: N = norte, S = sul, L = leste, O = oeste.

Para controlar o rob�, a AEB envia simples strings com os comandos. As
letras poss�veis s�o: E, D e M. As letras E e D fazem o rob� virar 90 graus para
esquerda e direita respectivamente, sem sair do lugar. A letra M significa se
mover uma posi��o no grid para frente, mantendo a mesma dire��o.

Assuma que mover o rob� para frente, significa mover sua posi��o de (X, Y)
para (X, Y+1). Por exemplo, um rob� na posi��o (0,0) com a face para o norte,
ao se mover uma posi��o, vai parar em (0,1).

### Entrada
O programa deve possuir os seguintes par�metros:
- A primeira linha deve ser as coordenadas do canto superior direito da
�rea. O canto inferior esquerdo � sempre (0,0).
- O resto das entradas deve ser os comandos que o rob� deve executar.
Cada comando deve ser enviado em 2 partes: a primeira parte � a
posi��o inicial do rob� e a segunda uma s�rie de instru��es que aquele
rob� deve seguir para explorar a �rea.

A posi��o � dada com 2 inteiros e uma letra, separados por espa�os,
correspondendo pelas coordenadas X e Y e a orienta��o do rob�. Cada rob�
vai executar as instru��es de forma sequencial: o segundo rob� s� iniciar�
suas a��es quando o primeiro terminar.

### Sa�da
Para cada rob�, a posi��o final e sua orienta��o depois de executada as
instru��es.

### Exemplo
Para cada rob�, a posi��o final e sua orienta��o depois de executada as
instru��es.

| Input:     | Output esperado: |
|------------|------------------|
| 5 5        | 1 3 N            |
| 1 2 N      | 5 1 L            |
| EMEMEMEMM  |                  |
| 3 3 L      |                  |
| MMDMMDMDDM |                  |

## Requisitos
- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.
- 
## Como Utilizar

#### Clone o Reposit�rio
```
git clone https://github.com/academiadoprogramador-fullstack/robo-tupiniquim-2025.git
```

#### Navegue at� a pasta raiz da solu��o
```
cd robo-tupiniquim-2025
```

#### Restaure as depend�ncias
```
dotnet restore
```

#### Navegue at� a pasta do projeto
```
cd RoboTupiniquim.ConsoleApp
```

#### Execute o projeto
```
dotnet run
```