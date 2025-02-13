<html>
    <head>
    <meta charset="utf-8"/>
    <title> cursophp2
        
    </title>
    </head>
    <body>
    
    <?php
    //area de teste
    //a308 ate a310
   echo 'utilizando a tag padrão'; 
    ?>
    <br/>
    <?= 'utilizando a tag de impressão'; ?>
    <br/>
    <? echo 'utilizando tag curta'; ?>
    <br/>
    <?php
//a311 saida de dados com echo e print
    echo 'comando echo';
   
?>
<br/>
<?php
 print "comando print";

?>

<?php
//a312 funcionamento do php diferenças entre paginas estaticas e dinamicas

// a principal diferença entre as duas é que a pagina estatica nao usa servidor portanto nao
// e tratada com um servidor mas sim de uma forma simples
// ja a pagina dinamica tem o conceito mais complexo porque utiliza servidores para tratamento de dados
// que usamos no site com isso tudo a pagina dinamica tem mais etapadas de processamento do que o pagina estatica

//foto para esclarecer a aula 
//https://photos.fife.usercontent.google.com/pw/AP1GczPaqIULUh2f3Gz9gszNpGZpbzZdD1Jvi7meg2RPam_UwFZA1W8HU1W4=w1024-h572-s-no-gm?authuser=0

//a313 comentários

# comentário shell 
//comentario de 1 linha
/* 
comentarios de varias linhas 
*/
?>

<!--comentário em html (fica exposto para o usuario-->
<?php 
// a314 variaveis 

//variaveis em php devem iniciar com a tag $ e não podem conter espaços nem caracters especiais 
// as variaveis em php nao devem ser especificadas no momento da declaração apenas no momento da inserção de dados

//php diferencia letras maiusculas  e minusculas Nome e Variavel e variavel pro php são 2 variaveis diferentes


?>
<br>
<br>
<br>
<?php
echo 
'
315. Variáveis - Prática (string, int, float e boolean)
';
/*
anotações:
o retorno da variavel bool é 1 se o retorno for true e vazio se for false

*/ 

//instaciamento de variaveis 

//string
$nome315 = 'jorge sant ana';

//int
$idade315 = 29;

//float
$peso315 = 82.5;

//boolean (true or false) true = 1 e false (vazio)
$fumante315 = true;
?>

<h1>ficha cadastral</h1>
<br>
<!-- tem que instancia a tag php pra poder invocar a variavel -->
<p>Nome: <?= $nome315 ?></p>
<p>Idade: <?= $idade315 ?></p>
<p>Peso: <?= $peso315 ?></p>
<p>Fumante: <?= $fumante315 ?></p>
<!--a316 mudando dados das variaveis-->

<!--317 concatenação-->

<?php 
echo 
'
317. concatenação
'; ?>

<br>
<br>

<?php
/*a contatenação é a a função de juntar 1 ou mais
variaveis dentro de uma frase estatica 
tambem da pra usar aspas duplas e essa ultima não precisa adicionar ponto pra instanciar a
variavel */

$nome317 = 'Gabriel';
$idade317=21 ;  
echo 'olá '. $nome317. " tenha uma boa tarde! voce tem  $idade317 anos";

?>

<?php 
/*a318 variaveis constantes

variaveis constantes sao variaveis que seus valores não podem ser alterados muitas vezes so uma vez
*/
define('bd_url','endereco_bd_dev');
define('bd_usuario','usuario_dev');
define('bd_senha','senha_dev');

echo bd_url . '<br />';
echo bd_usuario. '<br />';
echo bd_senha . '<br />';
/*caso tente alterar o valor de algumas dessas variaveis denovo ira resultar em um erro */
/* a319 if/else */

/*if ( condiçao)`
{se a condição for atendida esse bloco de codigo vai ser executado}
senão esse bloco de codigo vai ser executado
else if(se nao vamos tentar outra alternativa de condição)

{se a segunda condição  for atendida e a primeira nao, vai cair nesse bloco de codigo que vai ser executado}

else
{se nenhuma condição for atendida esse bloco de codigo vai ser executado}

a320 operadores de comparação condicionais 
o php oferece 9 operadores para atender determinadas condições

operadores if/ else
igual (===) - verifica se os valores comparadossao iguais
identico (===) - verifica se os valores comparadossao iguais e do mesmo tipo
diferente(!=)  - verifica seos valorescomparados são direfentes
diferente (<>) - verifica se os valores comparados sao diferentes
não identico (!===) - verifica se os valores comparados sao diferentes e de tipos diferentes 
menor(<) - verifica se o valoresquerdo e menor que o valor da direita
maior (>) - verifica se o valor da esquerda é maior que o valor dadireita
menor igual (<=) - verifica se o valor da esquerda e menor ou igual ao da direita
maior igual (>=) - verofocase o valor da esquerda emaior ou igual ao valor da direita

*/

/*
321 if/else parte 2

*/

//se a condição não for atendida vai cair no else e se a condição for atendida vai cair no if
if(false)
{
    echo 'verdadeiro';
}

else
{
    echo 'falso';
}

//==

if(2 == 2)
{ echo 'verdadeiro';}

else 
{ echo 'false';}

//=== apesar de visualmente ter o mesmo numero o computador interpreta como diferente porque esta em formato de texto
if(2 === '2')
{ echo 'verdadeiro';}

else 
{ echo 'false';}

//!= ou <> tem que ser diferente 


if(2 != '2')
{ echo 'verdadeiro';}

else 
{ echo 'false';}

// tem que ser diferente no tipo de dado e valor
if(2 !== '2')
{ echo 'verdadeiro';}

else 
{ echo 'false';}

// < o valor da esquerda tem que ser menor que o comparado pra condição ser atendida
if(1 < 2)
{ echo 'verdadeiro';}

else 
{ echo 'false';}

// > o valor da esquerda tem que ser menor que o comparado
if(2 > 1)
{ echo 'verdadeiro';}

else 
{ echo 'false';}


// verifica se o valor da esquerda e menor ou igual ao da direita 
if(1 <= 2)
{ echo 'verdadeiro';}

else 
{ echo 'false';}
// verifica se o valor da esquerda e maior ou igual ao da direita 
if(2 >= 1)
{ echo 'verdadeiro';}

else 
{ echo 'false';}

/*a322 operadores logicos

operador e (and ou  &&) - verdadeiro se todas as expressoes forem verdadeiras 
operador ou (or ou ||) - verdadeiro se pelo menos uma das expressoes for verdadeira 
operador xor (xor ) - verdadeiro apenas se uma das expressoes for verdadeiro, mas não ambas
operador negação (!) - inverte o resultado da expressão*/ 

/*
a323 praticando com operadores logicos
(())estabelecer prioridade quanto mais dentro dos parenteses maior a prioridade

*/


//operador e (and ou  &&) - verdadeiro se todas as expressoes forem verdadeiras
if(2 == 2 and 3 == 3 )
{ echo 'verdadeiro';}

else 
{ echo 'false';}

//operador ou (or ou ||) - verdadeiro se pelo menos uma das expressoes for verdadeira 
if(2 == 2 or 1 == 3 )
{ echo 'verdadeiro';}

else 
{ echo 'false';}

//operador xor (xor ) - verdadeiro apenas se uma das expressoes for verdadeiro, mas não ambas
if(2 == 2 xor 2 == 3 )
{ echo 'verdadeiro';}

else 
{ echo 'false';}

//operador negação (!) - inverte o resultado da expressão
// no caso abaixo a expressão retornaria true ira retornar false
if(!(2 == 2 xor 2 == 3) )
{ echo 'verdadeiro';}

else 
{ echo 'false';}
?>

<?php
//a324 if/else praticando um pouco mais

$usuario_possui_cartao_loja = true;
$valor_compra = 99;

$valor_frete = 50;
$recebeu_desconto_frete = false;

if($usuario_possui_cartao_loja == true && $valor_compra >= 100)
{ $valor_frete = 0;
$recebeu_desconto_frete = true;}

?>
<h1> detalhes do pedido</h1>

<p> possui cartao da loja ?

<?php 
if($usuario_possui_cartao_loja == true)
{echo 'sim';}
else 
{ echo 'nao';}

?>
</p>

<p> valor da compra: <?= $valor_compra ?> </p>
    
<p>recebeu desconto no frete?

<?php 
if($recebeu_desconto_frete == true)
{echo 'sim';}
else 
{ echo 'nao';}

?>
</p>
<p> valor do frete: <?= $valor_frete ?></p>

<?php
//325 condições encadeadas


if($usuario_possui_cartao_loja == true && $valor_compra >= 100)
{ $valor_frete = 0;
$recebeu_desconto_frete = true;}

else if ($usuario_possui_cartao_loja && $valor_compra >= 400)
{
    $valor_frete = 10;
}

else if ($usuario_possui_cartao_loja && $valor_compra >= 300)
{
    $valor_frete = 25;
}

else { $recebeu_desconto_frete = false;}

?>
<h1> detalhes do pedido</h1>

<p> possui cartao da loja ?

<?php 
if($usuario_possui_cartao_loja == true)
{echo 'sim';}
else 
{ echo 'nao';}

?>
</p>

<p> valor da compra: <?= $valor_compra ?> </p>
    
<p>recebeu desconto no frete?

<?php 
if($recebeu_desconto_frete == true)
{echo 'sim';}
else 
{ echo 'nao';}

?>
</p>
<p> valor do frete: <?= $valor_frete ?></p>

<?php 
//a326 operador ternario


$usuario_possui_cartao_loja326 = $usuario_possui_cartao_loja? 'sim' : 'nao';

echo $usuario_possui_cartao_loja326;

$valor_compra326 = 40;
$valor_frete326 = 50;
$recebeu_desconto_frete326 = true;

$valor_frete_aux326 = $usuario_possui_cartao_loja326 && $valor_compra326 >= 400 ? 0 : ($usuario_possui_cartao_loja326 && $valor_compra326 >= 300 ? 10 : ($usuario_possui_cartao_loja326 && $valor_compra326 >=100 ? 25 : $valor_frete326));
$recebeu_desconto_frete326 = $valor_frete326 != $valor_frete_aux326 ? true : false;

$valor_frete326 = $valor_frete326;


?>
<h1> detalhes do pedido 326 </h1>

<p> possui cartao da loja ?

<?php 
if($usuario_possui_cartao_loja326 == true)
{echo 'sim';}
else 
{ echo 'nao';}

?>
</p>

<p> valor da compra: <?= $valor_compra326 ?> </p>
    
<p>recebeu desconto no frete?

<?php 
if($recebeu_desconto_frete326 == true)
{echo 'sim';}
else 
{ echo 'nao';}

?>
</p>
<p> valor do frete: <?= $valor_frete326 ?></p>


</body>
</html>
