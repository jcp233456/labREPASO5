# GEMINI.md - labREPASO5

## Project Overview
**labREPASO5** is a Windows Forms application developed in C# for managing vehicle rentals. It allows for the registration and tracking of customers, vehicles, and rental transactions, ultimately generating financial reports based on distance traveled.

### Architecture
- **UI Layer:** Windows Forms (`Form1.cs`).
- **Domain Model:** Simple POCO classes (`Cliente.cs`, `Vehiculo.cs`, `Alquiler.cs`, `Reporte.cs`).
- **Persistence:** Flat-file storage using `StreamWriter`/`StreamReader` to read/write `.txt` files (`Clientes.txt`, `Vehiculos.txt`, `Alquileres.txt`) in the application's working directory.

### Key Technologies
- **Language:** C#
- **Framework:** .NET Framework 4.7.2
- **Platform:** Windows Forms (WinForms)

## Building and Running
As a legacy .NET Framework project, it is best managed via Visual Studio or MSBuild.

### Prerequisites
- .NET Framework 4.7.2 SDK
- Visual Studio (recommended) or MSBuild

### Commands
- **Build:** 
  ```powershell
  msbuild labREPASO5.csproj /t:Build /p:Configuration=Debug
  ```
- **Run:** 
  Execute the compiled binary: `bin\Debug\labREPASO5.exe`
- **Test:** 
  No automated tests identified in the codebase. Manual testing via the UI is required.

## Development Conventions
- **Namespace:** `labREPASO5`
- **Persistence Pattern:** Data is loaded from text files on application start (`Form1_Load`) and saved immediately after each new entry is added (e.g., `GuardarCliente()`).
- **Naming:** Follows standard C# PascalCase for classes and properties, though some private fields and methods use camelCase (e.g., `mostrarCliente`).
- **Data Handling:** 
  - Uses `List<T>` for in-memory storage.
  - Reports are generated dynamically by joining `Alquiler`, `Cliente`, and `Vehiculo` lists via nested loops in `buttonReporte_Click`.

## Important Files
- `Form1.cs`: Contains all the UI logic and data persistence methods.
- `Vehiculo.cs`, `Cliente.cs`, `Alquiler.cs`: Core data structures.
- `labREPASO5.csproj`: Project configuration and dependency list.
