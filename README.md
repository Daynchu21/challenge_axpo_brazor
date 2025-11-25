# Challenge Axpo Blazor

A minimal Blazor WebAssembly frontend project for a short challenge interview.

## Project Structure

This repository contains a Blazor WebAssembly standalone application built with .NET 8.0.

```
BlazorApp/
├── Pages/              # Razor pages/components
├── Layout/             # Layout components
├── wwwroot/            # Static files
├── Program.cs          # Application entry point
└── BlazorApp.csproj    # Project file
```

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later

## Getting Started

### Build the project

```bash
cd BlazorApp
dotnet build
```

### Run the project

```bash
cd BlazorApp
dotnet run
```

The application will be available at `http://localhost:5000` (or the port shown in the console output).

### Publish for deployment

```bash
cd BlazorApp
dotnet publish -c Release
```

The published files will be in `BlazorApp/bin/Release/net8.0/publish/wwwroot/`.

## Features

This minimal Blazor app includes:
- Home page
- Counter page (demonstrates state management)
- Weather forecast page (demonstrates data fetching)
- Responsive navigation menu
- Bootstrap styling

## Technology Stack

- Blazor WebAssembly
- .NET 8.0
- C#
- HTML/CSS
- Bootstrap 5
