# 🧾 InventarioApp & CompraApi

Inventory management system consisting of a **client application (InventarioApp)** and a **REST API (CompraApi)** developed in **C# and .NET**.
It allows you to register products, control stock, and manage purchases using a **client-server** architecture.
---

## 🚀 How to start the project?

### 1️⃣ Clone the repository

Clone both in your local machine:

```bash
git clone https://github.com/calaveiraUwU/InventarioApp.git
git clone https://github.com/calaveiraUwU/CompraApi.git
```
### 2️⃣ Start Api (Server)

cd CompraApi
dotnet run --urls "http://192.168.1.231:5000"

### 3️⃣ Start client app

cd InventarioApp
dotnet run --urls "http://192.168.1.231:5001"
