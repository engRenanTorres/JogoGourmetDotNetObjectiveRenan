# Jogo de Adivinhação

## Descrição
Este projeto foi desenvolvido por Renan Torres. Ele é um jogo de adivinhação desenvolvido em C# utilizando o framework .NET. 
Ele foi criado para demonstrar habilidades em programação orientada a objetos e padrões de design, como parte de um teste de processo seletivo na Objective em 2024.

Também foi utilizado o Repossitory Pattern para facilitar integração com possíveis bancos de dados.

## Objetivo
O objetivo do jogo é adivinhar a palavra correta com base nas dicas fornecidas pelo programa. A aplicação oferece uma interface amigável para interagir com o usuário e validar suas tentativas de adivinhação.

## Tecnologias Utilizadas
- **Linguagem**: C#
- **Framework**: .NET 8.0
- **Padrão de Design**: MVP (Model-View-Presenter)
- **Plataforma**: Windows Forms

## Boas Prátricas adotadas
- **Inversão de Dependências**: Para deixar o código mais utilizavel
- **Padrão de Design**: MVP (Model-View-Presenter)
- **Repository Pattern**: Para facilitar integração com possíveis bancos de dados.

## Estrutura do Projeto
O projeto segue o padrão de design MVP, que separa a lógica de negócios, a interface do usuário e o comportamento da aplicação em diferentes componentes:

- **Model**: Representa a lógica de negócios e os dados do jogo.
- **View**: Interface do usuário que interage com o jogador.
- **Presenter**: Camada intermediária que manipula a lógica de interação entre a Model e a View.

## Excutável do Projeto
  disponível em https://www.dropbox.com/scl/fo/i9zaiwnmi9j8yz5vxpi0r/APH73BsF6Ns9h1xen7kPapM?rlkey=z10tnpn0ds206e29c1rz9k57m&st=ykpop2lk&dl=0

## Arquitetura
```plaintext
JogoGourmetDotNetObjectiveRenan
├── Models
│   ├── FoodGuess.cs
│   ├── FoodGuessData.cs
│   ├── IFoodRepository.cs
│   ├── ITipsRepository.cs
├── Views
│   ├── IFoodGuessView.cs
│   ├── FoodGuessView.cs
├── Presenteres
│   ├── FoodGuessPresenter.cs
├── Repositories
│   ├── FakeData.cs
│   ├── FoodRepository.cs
│   ├── TipsRepository.cs
├── Program.cs
└── README.md
