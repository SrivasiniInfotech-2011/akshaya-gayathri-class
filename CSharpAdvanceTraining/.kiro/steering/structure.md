# Project Structure

## Root Directory Organization
```
CSharpAdvanceTraining/
├── .kiro/                          # Kiro AI assistant configuration
├── bin/                            # Build output directory (generated)
├── obj/                            # Build intermediate files (generated)
├── Sample/                         # Sample implementations subdirectory
├── *.cs                           # Individual topic demonstration files
├── CSharpAdvanceTraining.csproj   # Project file
├── CSharpAdvanceTraining.sln      # Solution file
└── Program.cs                     # Main entry point (currently inactive)
```

## File Organization Patterns

### Topic-Based Files
Each C# concept is demonstrated in its own dedicated file:
- `AccessModifiers.cs` - Access modifiers (static, sealed, abstract, virtual)
- `AccessSpecifiers.cs` - Public, private, protected access levels
- `Arrays.cs` - Array operations and examples
- `Functions.cs` - Method definitions and usage
- `Interfaces.cs` - Interface implementations
- `Loops.cs` - Iteration constructs
- `Namespaces.cs` - Namespace organization examples
- `Operators.cs` - Operator demonstrations
- `Reflections.cs` - Reflection API usage
- `Structure.cs` - Struct definitions
- `Threading.cs` - Multi-threading examples
- `UsingKeyWord.cs` - Using statement patterns

### Namespace Conventions
- **Primary namespace**: `CSharpAdvanceTraining`
- **Legacy namespace**: `CSharp` (used in older demonstration files)
- **Sample namespace**: `CSharpAdvanceTraining.Sample` (for organized examples)
- **Nested namespaces**: Used for logical grouping (e.g., `Mynamespace.Consts`, `Mynamespace.MyMath`)

### Code Organization Rules
- One main concept per file
- Extensive inline comments explaining concepts
- Multiple example classes within single files for related concepts
- Static Main methods in demonstration classes for standalone execution
- Commented-out code blocks preserved for educational reference

### Build Artifacts
- `bin/` and `obj/` directories contain generated build files
- These should not be modified manually
- Clean builds will regenerate these directories