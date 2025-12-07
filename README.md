# Olbrasoft Mapping

[![Build & Publish](https://github.com/Olbrasoft/Mapping/actions/workflows/publish-nuget.yml/badge.svg)](https://github.com/Olbrasoft/Mapping/actions/workflows/publish-nuget.yml)
[![License](https://img.shields.io/badge/license-MIT-green)](LICENSE)

A collection of mapping and projection abstractions with Mapster implementation for .NET applications.

## Packages

### Olbrasoft.Mapping.Abstractions

[![NuGet](https://img.shields.io/nuget/v/Olbrasoft.Mapping.Abstractions.svg)](https://www.nuget.org/packages/Olbrasoft.Mapping.Abstractions/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Olbrasoft.Mapping.Abstractions.svg)](https://www.nuget.org/packages/Olbrasoft.Mapping.Abstractions/)

Core interfaces for mapping and projection operations:

- **IProjector** - Interface with `ProjectTo<TDestination>()` method for queryable projections
- **IMapper** - Interface extending IProjector with `MapTo<TDestination>()` for object mapping

```bash
dotnet add package Olbrasoft.Mapping.Abstractions
```

### Olbrasoft.Mapping.Mapster

[![NuGet](https://img.shields.io/nuget/v/Olbrasoft.Mapping.Mapster.svg)](https://www.nuget.org/packages/Olbrasoft.Mapping.Mapster/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Olbrasoft.Mapping.Mapster.svg)](https://www.nuget.org/packages/Olbrasoft.Mapping.Mapster/)

Implementation of IMapper and IProjector using [Mapster](https://github.com/MapsterMapper/Mapster).

```bash
dotnet add package Olbrasoft.Mapping.Mapster
```

### Olbrasoft.Mapping.Mapster.DependencyInjection.Microsoft

[![NuGet](https://img.shields.io/nuget/v/Olbrasoft.Mapping.Mapster.DependencyInjection.Microsoft.svg)](https://www.nuget.org/packages/Olbrasoft.Mapping.Mapster.DependencyInjection.Microsoft/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Olbrasoft.Mapping.Mapster.DependencyInjection.Microsoft.svg)](https://www.nuget.org/packages/Olbrasoft.Mapping.Mapster.DependencyInjection.Microsoft/)

Microsoft.Extensions.DependencyInjection integration for Mapster-based mapping.

```bash
dotnet add package Olbrasoft.Mapping.Mapster.DependencyInjection.Microsoft
```

## Quick Start

### 1. Install packages

```bash
dotnet add package Olbrasoft.Mapping.Mapster.DependencyInjection.Microsoft
```

### 2. Register services

```csharp
using Olbrasoft.Mapping.Mapster.DependencyInjection.Microsoft;

// In Program.cs
builder.Services.AddMappingMapster();
```

### 3. Use in your code

```csharp
public class MyService
{
    private readonly IMapper _mapper;

    public MyService(IMapper mapper)
    {
        _mapper = mapper;
    }

    public DestinationDto MapEntity(SourceEntity source)
    {
        return _mapper.MapTo<DestinationDto>(source);
    }

    public IQueryable<DestinationDto> ProjectQuery(IQueryable<SourceEntity> query)
    {
        return _mapper.ProjectTo<DestinationDto>(query);
    }
}
```

## Target Frameworks

| Package | .NET Standard | .NET |
|---------|---------------|------|
| Mapping.Abstractions | 2.0, 2.1 | 10.0 |
| Mapping.Mapster | 2.1 | - |
| Mapping.Mapster.DependencyInjection.Microsoft | 2.1 | - |

## License

This project is licensed under the **MIT License**.

## Author

- **Jiří Tůma**
- **Company**: Olbrasoft
- **Repository**: [https://github.com/Olbrasoft/Mapping](https://github.com/Olbrasoft/Mapping)

---

**Copyright © 2021-2025 Olbrasoft**
