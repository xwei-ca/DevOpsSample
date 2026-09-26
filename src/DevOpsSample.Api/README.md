# DevOpsSample

A minimal .NET 10.0 Web API demonstrating a typical GitHub Actions DevOps pipeline.

## Pipeline

- **CI** (`.github/workflows/ci.yml`): runs on every PR → restore, build, test.
- **CD Staging** (`.github/workflows/cd-staging.yml`): runs on push to `main` → publish + deploy staging.
- **CD Prod** (`.github/workflows/cd-prod.yml`): runs on tag `v*` → deploy production (manual approval).

## Local dev

```bash
dotnet restore
dotnet build
dotnet test
dotnet run --project src/DevOpsSample.Api
