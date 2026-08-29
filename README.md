[![](https://img.shields.io/nuget/v/soenneker.enums.operationtypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.operationtypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.operationtypes/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.operationtypes/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.operationtypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.operationtypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.operationtypes/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.operationtypes/actions/workflows/codeql.yml)

# Soenneker.Enums.OperationTypes

Identifies a comparison or matching operator used to evaluate a filter condition.

## Install

```bash
dotnet add package Soenneker.Enums.OperationTypes
```

## What you get

- `OperatorType` — Identifies a comparison or matching operator used to evaluate a filter condition.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `OperatorType.Equal` | The candidate value must equal the comparison value. | The candidate value must equal the comparison value. |
| `OperatorType.NotEqual` | The candidate value must not equal the comparison value. | The candidate value must not equal the comparison value. |
| `OperatorType.LessThan` | The candidate value must be less than the comparison value. | The candidate value must be less than the comparison value. |
| `OperatorType.LessThanOrEqual` | The candidate value must be less than or equal to the comparison value. | The candidate value must be less than or equal to the comparison value. |
| `OperatorType.GreaterThan` | The candidate value must be greater than the comparison value. | The candidate value must be greater than the comparison value. |
| `OperatorType.GreaterThanOrEqual` | The candidate value must be greater than or equal to the comparison value. | The candidate value must be greater than or equal to the comparison value. |
| `OperatorType.In` | The candidate value must occur in the supplied set. | The candidate value must occur in the supplied set. |
| `OperatorType.NotIn` | The candidate value must not occur in the supplied set. | The candidate value must not occur in the supplied set. |
| `OperatorType.Contains` | The candidate value must contain the supplied value. | The candidate value must contain the supplied value. |
| `OperatorType.StartsWith` | The candidate value must begin with the supplied value. | The candidate value must begin with the supplied value. |
| `OperatorType.EndsWith` | The candidate value must end with the supplied value. | The candidate value must end with the supplied value. |
| `OperatorType.Exists` | The candidate field or value must exist. | Returns `true` when at least one matching document exists; otherwise, `false`. |
