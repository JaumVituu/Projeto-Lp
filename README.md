# Projeto LP
Dupla: João Vitor dos Santos
       Iori de Souza Leite
   
Descrição do projeto:
Ele possui 2 cenas. 1 menu e uma tela de "Fim de jogo";
O menu possui um botão de jogar e outro para sair do jogo;
A movimentação do personagem é realizada através dos seguintes botões:
  W - Frente
  S - Trás
  D - Direita
  A - Esquerda
Uma parede de lava que se escalona para os lados a cada segundo carrega a cena de "Fim de jogo" se encostar no jogador;
Canhões detectam através do Raycast se o jogador está na frente dele; se estiver, atira com um prefab de tiro, que caso atinja diminui a vida do jogador em 50% e se autodestrói;
Existe um cubo vermelho pequeno que, ao entrar em contato com o jogador, se autodestrói e aumenta a vida do jogador em 50%;
Existe uma porta dupla que funciona pelo sistema de joints, permitindo que o jogador passe por entre elas;
Existem obstáculos giratórios que, caso atinjam o jogador, diminui a vida dele em 100%;
Existe uma parede transparente azul que, caso colida com o jogador, se destrói e concede as seguintes características:
   - Jogador não tem mais gravidade;
   - Ao apertar a barra de espaço, o jogador vai para cima;
   - Ao apertar o control esquerdo, o jogador vai para baixo;
   - Jogador perde a vida gradativamente;
   - Jogador fica azul;
Se o jogador já estiver com esses efeitos e colidir com o gravitador novamente, ele volta ao normal;
O objetivo do jogo é colidir com a bandeira e passar para a próxima fase.
A fase de "Fim de jogo" é composta pelos botões de Menu Principal e Sair do Jogo.
