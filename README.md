# Axpo Contract Onboarding (Blazor WebAssembly)

A single-page Blazor WebAssembly app that showcases a contract onboarding workspace with reusable UI primitives, navigation, and themed styling built on .NET 8.

## Project structure

-   `BlazorApp/` – Main WebAssembly project with routing, layout, pages, and styles.
    -   `Pages/` – Razor pages/components.
    -   `Layout/` – Layout components and app shell.
    -   `wwwroot/` – Static assets and global styles.
    -   `Program.cs` – Application entry point and DI configuration.

> If you add extra projects (e.g. `BlazorApp.Tests/` for bUnit/xUnit tests or a separate components library), document them here as well.

## Core features

-   **App shell with shared navigation and footer** driven by route constants (for example `/`, `/contracts`, `/analytics`, `/support`) so pages plug into a consistent layout.
-   **Design tokens and theming** defined in `wwwroot/css/app.css` to unify typography, surfaces, spacing, and navigation hover/active states across the app.
-   **Contract onboarding page** that can fetch mock contract overview data, display loading/error/empty states, and render each section within accessible accordion-style panels.
-   **Supplemental workspace pages** (e.g. Analytics and Support) to demonstrate multi-route navigation with shared styling and typography tokens.

## Tooling & architecture

-   **Husky** configured to run git hooks (e.g. linting/tests) on commit to keep the codebase consistent.
-   **SOLID principles** applied across services and components to keep the onboarding workflow modular, testable, and easy to extend.

## CI/CD & deployment

-   **GitHub Actions** workflow configured to build and deploy the Blazor WebAssembly app.
-   Production build is **automatically deployed to Netlify** on pushes to the main branch.

## Prerequisites

-   [.NET 8 SDK](https://dotnet.microsoft.com/download) for building and running the WebAssembly app.
-   (Optional) The same .NET 8 SDK for running tests if you add a test project (xUnit + bUnit, etc.).

## Running the app

```bash
cd BlazorApp

dotnet run
