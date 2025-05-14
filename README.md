# DotNetConfig

This project demonstrates how to load multiple `appsettings` files in an ASP.NET Core application based on the environment (e.g., Development, Testing).

## How it works

- The application loads:
  - `appsettings.json` (always)
  - `appsettings.{Environment}.json` (if present, e.g., `appsettings.Development.json`, `appsettings.Testing.json`)
- The environment is determined by the `ASPNETCORE_ENVIRONMENT` variable.

## Running with a specific environment

To run the application with a specific environment and load the corresponding `appsettings.{Environment}.json` file, set the `ASPNETCORE_ENVIRONMENT` variable before running the app.

### Windows (Command Prompt)

```sh
set ASPNETCORE_ENVIRONMENT=Testing
dotnet run --no-launch-profile
```

### Windows (PowerShell)

```sh
$env:ASPNETCORE_ENVIRONMENT="Testing"
dotnet run --no-launch-profile
```



## Example

When running with `ASPNETCORE_ENVIRONMENT=Testing`, the API root (`/`) will return:

```
This is from TESTING appsettings.Testing.json
```

When running with `ASPNETCORE_ENVIRONMENT=Development`, it will return:

```
This is from DEVELOPMENT appsettings.Development.json
```

## Project Structure

- `appsettings.json` - Base configuration
- `appsettings.Development.json` - Development-specific settings
- `appsettings.Testing.json` - Testing-specific settings
- `Program.cs` - Loads configuration based on environment

---