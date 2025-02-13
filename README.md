# objects_exercise


# Agenda em C# com Encapsulamento

## Descrição
Este projeto implementa uma agenda simples em C#, utilizando o conceito de encapsulamento para proteger os dados dos contatos e garantir a integridade do sistema. A aplicação permite adicionar, remover e visualizar contatos, com a possibilidade de expandir para funcionalidades mais avançadas.

## Tecnologias Utilizadas
* **C#:** Linguagem de programação principal.
* **.NET:** Framework utilizado para desenvolvimento.
* **Visual Studio:** Ambiente de desenvolvimento integrado (IDE) utilizado.

## Estrutura do Projeto
* **Contato.cs:** Classe que representa um contato individual, encapsulando os dados e fornecendo métodos para acesso e modificação.
* **Agenda.cs:** Classe que gerencia a coleção de contatos, oferecendo métodos para adicionar, remover e buscar contatos.
* **Program.cs:** Ponto de entrada da aplicação, onde a interação com o usuário é realizada.

## Encapsulamento
O encapsulamento foi aplicado à classe `Contato` para:
* **Proteger os dados:** Os atributos `nome` e `telefone` são privados, acessados apenas através de propriedades públicas.
* **Validar os dados:** As propriedades podem incluir lógica de validação para garantir a integridade dos dados.
* **Ocultar a complexidade:** A implementação interna da classe é isolada, permitindo alterações sem afetar o código que utiliza a classe.
