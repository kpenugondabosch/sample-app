# Copilot Custom Instructions for PR Review

## .NET 8 Roslyn Coding Standards
- Enforce all .NET 8 built-in Roslyn coding standards for code style, formatting, and best practices.
- Use modern C# features (nullable reference types, file-scoped namespaces, pattern matching, records, expression-bodied members).
- Avoid obsolete APIs and prefer .NET 8 recommended approaches.

## .editorconfig Overrides
- Apply all rules and overrides specified in the `.editorconfig` file in this repository.
- If `.editorconfig` adds or overrides standards, those must take precedence over defaults.
- Ensure formatting, naming conventions, and code style match `.editorconfig` settings.

## General PR Review Guidelines
- Code should be clear, maintainable, and well-documented.
- All new code should be covered by unit tests where applicable.
- Code changes must not introduce warnings or errors.
- All files should be properly formatted before merging.

## Custom .editorconfig Naming Enforcement

- All **private fields**, including `readonly` and `static`, MUST be prefixed with `_` (underscore) as per `.editorconfig` rules (`dotnet_naming_rule.private_fields_underscored`).
- Pull request reviews should **explicitly highlight** and reject any code that does not comply, regardless of IDE or build warnings.
- Example violation: `private readonly int value;`  
  Correct: `private readonly int _value;`
- This applies to all C# files in the repository.

---

_This file provides custom instructions for Copilot to review pull requests in this repository. All .NET 8 Roslyn standards and .editorconfig rules must be enforced._
