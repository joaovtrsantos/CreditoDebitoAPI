# 💳 Credit and Debit API

## 🧰 Requirements

- Visual Studio  
- SQL Server  
- SQL Server Management Studio (SSMS)

---

## ⚙️ Setup Instructions

### 🔹 Step 1 – Configure the Connection String

Open the solution in Visual Studio and update the `appsettings.json` file to point the connection string to your local SQL Server instance.

![Step 1](https://github.com/joaovtrsantos/CreditoDebitoAPI/assets/57101445/d0cf6919-64f8-403c-a2b2-89d08b2e2b49)

---

### 🔹 Step 2 – Apply Migrations

Open the **Package Manager Console** in Visual Studio, set the **default project** to `Infrastructure`, and run:

```powershell
Update-Database
Check in SSMS if the database has been created properly:




🔹 Step 3 – Run the Application
Run the solution. The Swagger page will automatically open in your default browser.



🚀 Using the API
🔸 Step 4 – Create Transactions
Use the POST /CreditDebit endpoint to create transactions:

Negative value + Type 1 = Credit

Positive value + Type 2 = Debit



🔸 Step 5 – Retrieve All Transactions
Use the GET /CreditDebit endpoint to retrieve all transactions.



🔸 Step 6 – Retrieve Transaction by ID
Use the GET /CreditDebit/by-id/{id} endpoint to retrieve a specific transaction by its ID.



🔸 Step 7 – Daily or Period Balance
Use the GET /Balance/{days} endpoint to check the daily balance or the balance for a specific number of past days.



👨‍💻 Developed by
João Vitor Santos
LinkedIn | GitHub
