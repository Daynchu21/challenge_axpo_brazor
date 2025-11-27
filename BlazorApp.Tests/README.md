# BlazorApp.Tests

Proyecto de pruebas unitarias para BlazorApp utilizando xUnit y bUnit.

## Tests Implementados

### AccordionTests

1. **Accordion_SeExpande_AlHacerClick** - Verifica que el accordion se expande al hacer clic en el header
2. **Accordion_SeColapsa_AlHacerClickDosVeces** - Verifica que el accordion se colapsa al hacer clic dos veces
3. **ContractSummaryAccordion_RenderizaCorrectamente_LosItems** - Verifica que todos los items del contrato se renderizan correctamente, incluyendo los que tienen iconos
4. **Accordion_MuestraIconoChevron_ConClaseCorrecta** - Verifica que el icono chevron cambia de clase según el estado (collapsed/expanded)
5. **Accordion_TieneAtributosDeAccesibilidad** - Verifica que el componente tiene los atributos de accesibilidad apropiados (aria-label, aria-controls)

## Ejecutar Tests

```bash
cd BlazorApp.Tests
dotnet test
```

## Ejecutar Tests con Detalles

```bash
dotnet test --verbosity normal
```

## Tecnologías

- **xUnit** - Framework de pruebas unitarias
- **bUnit** - Librería de testing para componentes Blazor
- **.NET 10.0**
