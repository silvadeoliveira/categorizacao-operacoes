# Categorização de Operações em Portfólio

## Descrição

Este projeto resolve o desafio de categorizar operações bancárias, com base em regras específicas, usando o **padrão Strategy**. A ideia é separar a lógica de categorização em diferentes "estratégias", permitindo que novas categorias sejam adicionadas facilmente no futuro.

## Como Funciona

Cada operação tem informações como valor, setor do cliente e data do próximo pagamento. As operações são categorizadas em três categorias principais:

1. **EXPIRED:** Pagamentos atrasados há mais de 30 dias.
2. **HIGHRISK:** Valor acima de 1 milhão e cliente do setor privado.
3. **MEDIUMRISK:** Valor acima de 1 milhão e cliente do setor público.

A solução usa o **padrão Strategy** para garantir que as regras de categorização sejam flexíveis e fáceis de modificar. Se, no futuro, novas categorias precisarem ser adicionadas, podemos fazer isso sem alterar muito o código.

## Motivação para usar o Padrão Strategy
Optei por usar o **padrão Strategy por alguns motivos bastante simples, mas que fazem toda a diferença:

- **Facilidade de Expansão:** Se mais categorias forem necessárias, basta criar novas estratégias, sem mexer no código principal.
- **Organização e Clareza:** Cada categoria tem sua própria lógica, tornando o código mais fácil de entender e manter.
- **Desacoplamento:** A categorização fica isolada em classes separadas, o que facilita os testes e a manutenção.

## Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu_usuario/categorizacao-operacoes.git

### 🔗 Referência
Para mais detalhes sobre este padrão, consulte a documentação oficial:  
🔗 [Refactoring Guru - Strategy](https://refactoring.guru/design-patterns/strategy)