[![](https://img.shields.io/nuget/v/soenneker.enums.operationtypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.operationtypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.operationtypes/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.operationtypes/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.operationtypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.operationtypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.operationtypes/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.operationtypes/actions/workflows/codeql.yml)

# Soenneker.Enums.OperationTypes

A string-backed enum-value type for representing comparison and matching operators in filter contracts.

## Install

```bash
dotnet add package Soenneker.Enums.OperationTypes
```

## Usage

```csharp
using Soenneker.Enums.OperationTypes;

OperatorType operation = OperatorType.GreaterThanOrEqual;
string wireValue = operation.Value; // "GreaterThanOrEqual"

if (OperatorType.TryFromValue(input, out OperatorType? parsed))
{
    // Translate parsed through an allowlisted query implementation
}
```

Available values:

- Equality: `Equal`, `NotEqual`
- Ordering: `LessThan`, `LessThanOrEqual`, `GreaterThan`, `GreaterThanOrEqual`
- Set membership: `In`, `NotIn`
- Text or collection matching: `Contains`, `StartsWith`, `EndsWith`
- Presence: `Exists`

`System.Text.Json` serializes the type as the shown string value. `FromValue` throws for unknown input; use `TryFromValue` when parsing filters. `FromName` and `TryFromName` are also generated.

The type labels an operation; it does not evaluate values or build a database query. The consumer defines supported field/operator combinations, type conversion, null behavior, string comparison rules, and the meaning of `Exists`. Translate operators through an explicit allowlist and parameterize comparison values—never concatenate request fields, operators, or values into SQL or another query language.
