---
layout: home
---

Hi there! You're on documentation page for [GitHub Steward](), an 
application to simplify the process of working with GitHub, mostly 
through CLI in CI or local environments.

### Glossary

Workspace: directory in which steward operates. By default, it is 
directory relative to which configuration has been found, and it can be
overriden in configuration.

### Conventions

#### Relative path/pattern resolution

All relative paths are first tried to be resolved in workspace, then,
if first round returned nothing, in current working directory (if it 
differs from workspace). Patterns follow the same rule, so if pattern 
lookup returned at least single file in workspace, then it won't be 
applied to current working directory. If no configuration has been 
found, current directory will be used.

### Configuration

Described on [dedicated page](configuration).

### CLI

Following commands are currently available

- [skeleton]() - for bootstrapping new repositories.
- [release]() - creating and editing releases and their assets.
