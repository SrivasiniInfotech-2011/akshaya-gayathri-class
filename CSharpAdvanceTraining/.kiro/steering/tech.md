# Technology Stack

## Framework & Runtime
- **.NET 9.0** - Target framework
- **C# Console Application** - Project type
- **Microsoft.NET.Sdk** - SDK used

## Project Configuration
- **ImplicitUsings**: Enabled - Reduces boilerplate using statements
- **Nullable**: Enabled - Nullable reference types are enforced
- **GeneratePackageOnBuild**: True - Automatically generates NuGet package on build
- **StartupObject**: CSharpAdvanceTraining.AccessNamespaceClasses - Custom startup class

## Build & Development Commands

### Building
```bash
# Build the project
dotnet build

# Build in Release mode
dotnet build --configuration Release

# Clean build artifacts
dotnet clean
```

### Running
```bash
# Run the application
dotnet run

# Run with specific startup object (if needed)
dotnet run --project CSharpAdvanceTraining.csproj
```

### Package Management
```bash
# Restore NuGet packages
dotnet restore

# Add a package
dotnet add package [PackageName]

# Remove a package
dotnet remove package [PackageName]
```

## Development Environment
- Compatible with Visual Studio, VS Code, and JetBrains Rider
- Solution file (.sln) provided for IDE integration
- Standard .NET project structure with obj/ and bin/ directories for build artifacts