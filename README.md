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

Open the **Package Manager Console** in Visual Studio, set the **default project** to `Infrastructure`, and run: Update-Database

Check in SSMS if the database has been created properly:

![image](https://github.com/user-attachments/assets/49524bc5-9a17-49b6-9f5d-fd270edb7945)

![image](https://github.com/user-attachments/assets/bb9b63ec-e555-44fa-9fff-598d51c0a569)

### 🔹 Step 3 – Run the Application
Run the solution. The Swagger page will automatically open in your default browser.

[image](https://github.com/user-attachments/assets/058f3587-128c-48de-a535-bece14e5642e)

🚀 Using the API
###🔸 Step 4 – Create Transactions
Use the POST /CreditDebit endpoint to create transactions:

Negative value + Type 1 = Credit

Positive value + Type 2 = Debit

![image](https://github.com/user-attachments/assets/fc40feaf-cb48-41ce-a622-47379d9f7aec)

### 🔸 Step 5 – Retrieve All Transactions
Use the GET /CreditDebit endpoint to retrieve all transactions.

![image](https://github.com/user-attachments/assets/10d7f176-3901-4cbc-b712-072c7bd4a004)

### 🔸 Step 6 – Retrieve Transaction by ID
Use the GET /CreditDebit/by-id/{id} endpoint to retrieve a specific transaction by its ID.

![image](https://github.com/user-attachments/assets/b766d6ad-02f8-426e-bc42-36761ad83c70)

### 🔸 Step 7 – Daily or Period Balance
Use the GET /Balance/{days} endpoint to check the daily balance or the balance for a specific number of past days.

![image](https://github.com/user-attachments/assets/615cb268-9eeb-4688-95b9-0efad940b075)

---

---

## 👨‍💻 Developed by

**João Vitor Santos**

[![LinkedIn](https://img.shields.io/badge/LinkedIn-blue?logo=linkedin&style=for-the-badge)](https://www.linkedin.com/in/jo%C3%A3o-vitor-d-13032413b/)
[![GitHub](https://img.shields.io/badge/GitHub-black?logo=github&style=for-the-badge)](https://github.com/joaovtrsantos)

