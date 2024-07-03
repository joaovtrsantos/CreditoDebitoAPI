# CreditoDebitoAPI

Requisitos: Visual Studio, SQL Server, SSMS(SQL Server Management Studio).

Primeiro passo - Abrir o Visual Studio e alterar a connection string no appsetings.json para apontar para a máquina que deseja rodar
![image](https://github.com/joaovtrsantos/CreditoDebitoAPI/assets/57101445/d0cf6919-64f8-403c-a2b2-89d08b2e2b49)


Segundo passo - No Visual Studio, abrir o Console de gerenciador de pacotes selecionar o projeto padrão como Infrastructure e rodar o comando Update-database, conferir no SSMS se a base de dados foi criada, deve estar com a mesma estrutura da segunda imagem
![image](https://github.com/joaovtrsantos/CreditoDebitoAPI/assets/57101445/4caccc54-06c5-439c-99c5-e8033fe5a667)
![image](https://github.com/joaovtrsantos/CreditoDebitoAPI/assets/57101445/da1e18ac-cf93-4a4b-a37b-e92f6fd89223)

Terceiro passo - Rodar a aplicação, depois disso será aberto a página do swagger no navegador padrão
![image](https://github.com/joaovtrsantos/CreditoDebitoAPI/assets/57101445/9f26bc8a-b322-41b7-ab91-fa55527a8f29)

Quarto passo - Criar lançamentos(negativo de crédito = 1, positivo de débito = 2) no método POST do controlador CreditDebit e executar
![image](https://github.com/joaovtrsantos/CreditoDebitoAPI/assets/57101445/ea430ba9-b098-4706-b16c-719b0e77b2a1)

Quinto passo - Consultar todos os lançamentos no método GET /CreditDebit e executar
![image](https://github.com/joaovtrsantos/CreditoDebitoAPI/assets/57101445/559b5416-6a4f-4db9-8ade-5b2138f3770c)

Sexto passo - Consultar um lançamento específico pelo seu id no método GET /CreditDebit/by-id/{id}
![image](https://github.com/joaovtrsantos/CreditoDebitoAPI/assets/57101445/d2742afe-9091-4b97-9c8a-a27f33da5657)

Sétimo passo - Excecutar o método GET /Balance/{days} no controlador Balance para consultar os consolidados diário ou balanço durante um período determinado de dias, o número informado no campo days, será o número de dias anteriores ao atual que será consultado o balanço.
![image](https://github.com/joaovtrsantos/CreditoDebitoAPI/assets/57101445/a6b22dbf-d491-453b-8e92-a4001050ae0c)






