# Signing and Release Strategy

## Decision Summary

This repository should not use Strong Name Signing.

The current codebase does not show any technical dependency on a strong name identity:

- No `InternalsVisibleTo` attributes reference a public key.
- No project files require a strong name token.
- The solution builds successfully after removing the strong name configuration.

The recommended release model is:

1. Build and pack in GitHub Actions only.
2. Authenticate Azure access through GitHub OIDC workload identity federation.
3. Store the `nuget.org` API key only in Azure Key Vault.
4. Publish packages automatically from signed Git tags such as `v11.0.5`.
5. Keep developer machines free of signing keys and release secrets.

## Evaluation of the Signing Options

### Strong Name Signing

Advantages:

- Provides a stable assembly identity for legacy .NET Framework binding scenarios.
- Can be required by consumers that explicitly load only strong-named assemblies.

Disadvantages:

- It is not a trust or publisher identity mechanism.
- It adds key management overhead without improving NuGet supply-chain security.
- It complicates local builds and contributor onboarding when a private key is required.
- It is unnecessary for modern SDK-style NuGet libraries unless a consumer explicitly depends on it.

Recommendation for this repository:

- Remove it completely.

### NuGet Package Signing

Advantages:

- Adds author-level package integrity metadata.
- Can help in environments that enforce signature validation policies.

Disadvantages:

- Requires certificate lifecycle management.
- Usually adds a Windows-specific signing step.
- Provides limited practical value for most public library consumers compared to repository security, deterministic builds, and controlled publishing.

Recommendation for this repository:

- Do not add author package signing yet.
- Revisit it only if a customer, marketplace, or internal compliance rule explicitly requires signed NuGet packages.

### Code Signing Certificates

Advantages:

- Useful for executables, installers, desktop apps, drivers, and scenarios with operating system trust prompts.
- Can also be reused for author package signing if policy requires it.

Disadvantages:

- Adds cost, renewal, revocation, and operational complexity.
- Does not materially improve the value proposition of a normal public NuGet library for most consumers.
- Does not replace secure CI, locked dependencies, deterministic builds, or repository protection.

Recommendation for this repository:

- Do not adopt a code-signing certificate for the current package.

### Signing Only in CI/CD

Advantages:

- Keeps private material out of the repository.
- Keeps developer workstations free of signing credentials.
- Centralizes auditability and access control.
- Scales well when the project grows.

Disadvantages:

- Requires a well-configured pipeline and release governance.
- If future signing is introduced, the pipeline may need a Windows job and certificate handling.

Recommendation for this repository:

- If signing is ever introduced later, perform it in CI/CD only.

## Recommended Release Architecture

### GitHub Actions

- Use one workflow for validation, packing, and publishing.
- Run validation on `main` and on pull requests.
- Publish only from version tags that match `v*`.

### Azure OIDC Authentication

- Create a Microsoft Entra application or user-assigned identity for GitHub Actions workload identity federation.
- Add a federated credential that is scoped to this repository and the GitHub `release` environment subject.
- Grant that identity only the Azure permissions required to read the relevant Key Vault secret.
- Do not use client secrets or certificates for Azure authentication in the workflow.

### Azure Key Vault

- Store the `nuget.org` API key as a secret named `nuget-org-api-key`.
- Restrict Key Vault access to the GitHub federated identity.
- Keep purge protection enabled.

### Publishing Flow

1. A maintainer creates a Git tag such as `v11.0.5`.
2. GitHub Actions restores dependencies in locked mode.
3. GitHub Actions builds and tests the solution with `ContinuousIntegrationBuild=true`.
4. GitHub Actions packs the NuGet package with the tag version.
5. GitHub Actions authenticates to Azure through OIDC.
6. GitHub Actions reads the `nuget.org` API key from Key Vault.
7. GitHub Actions pushes the generated `.nupkg` file to `nuget.org`.

## Reproducibility and Supply-Chain Controls

This repository now uses the following controls:

- Deterministic builds.
- Deterministic source paths.
- Source Link metadata for repository provenance.
- Locked package restore in CI.
- Secrets isolated to GitHub Actions runtime and Azure Key Vault.
- No strong name key, PFX, or SNK dependency in the solution projects.

## Why a Code-Signing Certificate Is Not Worth It Here

For a single-maintainer public NuGet library, a code-signing certificate is usually not the best next investment.

The higher-value controls are:

- Repository protection.
- Deterministic builds.
- Locked dependency resolution.
- Release automation from CI only.
- Secret isolation through Key Vault.

Add a certificate only when one of these becomes true:

- A consumer explicitly requires author-signed NuGet packages.
- You distribute executable artifacts in addition to the library.
- A compliance program mandates certificate-backed signing.

## Final Recommendation

## GitHub Setup Steps

1. Create the GitHub environment `release`.
2. Create the GitHub repository variables `AZURE_CLIENT_ID`, `AZURE_TENANT_ID`, and `AZURE_SUBSCRIPTION_ID`.
3. Create a Microsoft Entra application or user-assigned managed identity for this repository.
4. Add a federated credential for the GitHub subject `repo:OWNER/REPOSITORY:environment:release`.
5. Grant the identity permission to read secrets from the target Key Vault.
6. Store the `nuget.org` API key in Azure Key Vault as `nuget-org-api-key`.
7. Push the workflow file under `.github/workflows/release.yml`.
8. Run the workflow on a pull request or `main` push to validate restore, build, test, and pack.
9. Create a tag such as `v11.0.5` to publish the package.

Adopt the following architecture decision:

- No Strong Name Signing.
- No code-signing certificate.
- No author package signing for now.
- GitHub Actions workflow as the only release path.
- GitHub OIDC workload identity federation for Azure authentication.
- Azure Key Vault for the `nuget.org` API key.
- Deterministic and locked CI builds.

This is the simplest option that is still secure, modern, and ready for future growth.
