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

---

_This file provides custom instructions for Copilot to review pull requests in this repository. All .NET 8 Roslyn standards and .editorconfig rules must be enforced._
