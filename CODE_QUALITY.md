# Code Quality & Formatting

Este proyecto utiliza un sistema automatizado de formateo y calidad de código que se ejecuta antes de cada commit.

## 🛠️ Herramientas Configuradas

### 1. EditorConfig (`.editorconfig`)

Configuración universal de estilo de código para todos los editores.

**Reglas principales:**

-   ✅ Espacios en lugar de tabs (4 espacios para C#, 2 para JS/JSON/CSS)
-   ✅ Máximo 120 columnas por línea
-   ✅ Fin de línea LF (Unix)
-   ✅ Insertar línea final al final de archivos
-   ✅ Eliminar espacios en blanco finales

**Convenciones de nombres C#:**

-   `PascalCase` para clases, interfaces, métodos públicos, propiedades
-   `camelCase` para campos privados
-   Interfaces deben empezar con `I` (ej: `IService`)
-   Métodos async deben terminar en `Async` (ej: `LoadDataAsync`)

### 2. dotnet format

Formateador oficial de C# que aplica las reglas de `.editorconfig`.

**Comandos disponibles:**

```bash
# Verificar formato sin hacer cambios
dotnet format --verify-no-changes

# Aplicar formato automáticamente
dotnet format
```

### 3. Prettier

Formateador para JavaScript, JSON, CSS y HTML.

**Configuración en `.prettierrc`:**

-   Print width: 120
-   Tab width: 2 espacios
-   Comillas dobles
-   Plugin de Tailwind CSS para ordenar clases

**Comandos disponibles:**

```bash
cd BlazorApp

# Verificar formato
npm run format:check

# Aplicar formato
npm run format
```

**Archivos ignorados** (`.prettierignore`):

-   Archivos `.razor` y `.cshtml` (manejados por dotnet format)
-   `node_modules/`
-   `bin/`, `obj/`
-   `output.css` generado

## 🔒 Pre-commit Hook

El hook de pre-commit (`.husky/pre-commit`) ejecuta automáticamente:

1. **dotnet format** - Formatea y verifica código C#
2. **prettier** - Formatea JavaScript, JSON, CSS, HTML
3. **dotnet test** - Ejecuta todas las pruebas unitarias

Si alguna verificación falla, el commit se bloquea y debes:

1. Revisar los cambios aplicados automáticamente
2. Hacer `git add` de los archivos corregidos
3. Intentar el commit nuevamente

## 📝 Uso en Desarrollo

### Para formatar manualmente todo el código:

```bash
# Formatear C# y Razor
dotnet format

# Formatear JS/CSS/JSON/HTML
cd BlazorApp
npm run format
```

### Para verificar antes de commit:

```bash
# Verificar C#
dotnet format --verify-no-changes

# Verificar JS/CSS/etc
cd BlazorApp
npm run format:check

# Ejecutar tests
cd ../BlazorApp.Tests
dotnet test
```

## 🎯 Recomendaciones

### VS Code

Instala las siguientes extensiones:

-   **EditorConfig for VS Code** - Aplica reglas de `.editorconfig`
-   **C# Dev Kit** - Soporte para C# y formateo
-   **Prettier - Code formatter** - Formateo automático al guardar

Configuración recomendada en `settings.json`:

```json
{
    "editor.formatOnSave": true,
    "editor.defaultFormatter": "esbenp.prettier-vscode",
    "[csharp]": {
        "editor.defaultFormatter": "ms-dotnettools.csharp"
    },
    "files.eol": "\n",
    "files.trimTrailingWhitespace": true,
    "files.insertFinalNewline": true
}
```

### Visual Studio

-   Habilita "Format document on save" en opciones
-   Las reglas de `.editorconfig` se aplican automáticamente

## 🚫 Bypass Pre-commit (No Recomendado)

Si necesitas hacer un commit sin ejecutar las verificaciones:

```bash
git commit --no-verify -m "mensaje"
```

⚠️ **Advertencia:** Evita usar `--no-verify` excepto en casos excepcionales. El pre-commit asegura la calidad del código.

## 📚 Más Información

-   [EditorConfig](https://editorconfig.org/)
-   [dotnet format](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-format)
-   [Prettier](https://prettier.io/)
-   [Husky](https://typicode.github.io/husky/)
