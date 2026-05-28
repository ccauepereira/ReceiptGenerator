# Gerador de Recibos 🧾

Este repositório contém um sistema de console desenvolvido em **C#** que simula o fluxo de criação de pedidos e geração de recibos detalhados. O projeto foi estruturado utilizando os conceitos fundamentais da **Programação Orientada a Objetos (POO)** e boas práticas da plataforma .NET.

---

## 📂 Estrutura do Projeto

O código está organizado dentro da pasta principal do projeto:

* **`GeradorDeRecibos/`**
  * `Pedido.cs`: Gerencia as regras de negócio do pedido, valores, descontos anuláveis (`double?`) e cálculo dinâmico de datas com `DateTime` e `TimeSpan`.
  * `Recibo.cs`: Responsável por formatar o layout do recibo de forma otimizada usando `StringBuilder`. Possui a classe interna `Saida` para rodar os testes.
  * `DemoRecebu.cs`: O ponto de entrada (`Main`) do programa que inicializa a execução.

---

## 🛠️ Funcionalidades e Conceitos Aplicados

- **Encapsulamento:** Uso de propriedades (`get`/`set`) para proteger e expor os dados das classes.
- **Tipos Anuláveis (Nullable):** Tratamento de campos opcionais (como o desconto) com o operador de coalescência nula (`??`).
- **Manipulação de Datas:** Definição automática da data do pedido, cálculo automático de +7 dias para a entrega e contagem regressiva de dias restantes usando `TimeSpan`.
- **Otimização de Strings:** Uso do `StringBuilder` para construir o layout do recibo no console sem desperdício de memória.

---

## 💻 Exemplo de Saída no Console

Ao rodar o sistema, os recibos são gerados com a seguinte formatação:

```text
========================================
Cliente: Maria Fernanda
Data do pedido: 28/05/2026
Previsão de entrega: quinta-feira, 4 de junho de 2026
Dias restantes: 7
Valor: 150
Desconto: 25
Valor final: 125
========================================
========================================
Cliente: Cauê
Data do pedido: 28/05/2026
Previsão de entrega: quinta-feira, 4 de junho de 2026
Dias restantes: 7
Valor: 200
Desconto: 0
Valor final: 200
========================================
