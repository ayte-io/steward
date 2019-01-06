---
title: Configuration
---

Configuration has two scopes: global and project. Global configuration
is mostly used as source for project configuration defaults.

It is legal to have no configuration at all, but some commands (e.g. 
uploading all registered assets) won't make sense.

### Resolution

Steward looks for following files to load configuration from:

- `steward.yml`
- `.steward.yml`
- `github-steward.yml`
- `.github-steward.yml`
- `octosteward.yml`
- `.octosteward.yml`
- all of the aboves in `.config`
- `.config/steward/configuration.yml` 
- `.config/ayte/steward/configuration.yml`
- `steward/configuration.yml`
- `.steward/configuration.yml`

All of the variants above are looked in target directory and every 
directory up the filesystem tree, just like git; target directory is 
workspace for project configuration, `$HOME`, `.config` and
`.local/share/ayte/steward/local` for Linux, `$HOME` and 
`%AppData%/steward/local` for Windows. So if you have configuration in 
`~/Workspace/application/.config/steward.yml` and your cwd is 
`~/Workspace/application/src/main/java`, steward will traverse up to 
`~/Workspace/application` and will find target configuration with ease.

Configuration lookup stops as soon as first occurence is found.

Nested paths may be useful because end user may want to store 
additional files for steward (templates, for example).

### Project

Example configuration

```yaml
version: '0.1' # NOT optional
steward:
  workspace: lib
  # user on whose behalf requests will be made.
  # usually this belongs to global configuration
  user: etki
authentication:
  - source: environment
    type: token
    name: GITHUB_API_TOKEN
  - source: filesystem
    type: token
    name: .local/github/token
project:
  repository: ayte-io/steward
  copyright: Ayte Labs
  email: dev@ayte.team
  # Free-form object that may be used in some of bundled templates
  accounts:
    github: ayte-io
    twitter: so_mad_so_funny
    odnoklassniki: panin
  # Free-form object for contacts. Not used in any of bundled templates
  contacts:
    email: dev@ayte.team
    phone: 8 800 555 35 35
  license:
    # Will be prefixed for all bundled licenses
    prefix: Henlo fren
    # Same for suffix
    suffix: Ayte Labs refuses to have any responsibilities for this mess
    types:
      - MIT
      - UPL
skeleton:
  context:
    alpha: beta
    map:
      key: value
    array:
      - alpha
      - beta:
          gamma: delta
  locations:
    - .config/steward/templates
  files:
    # license variants are picked up from project configuration
    .gitignore:
      variants:
        # for .gitignore that means 'take all those templates and merge them'
        - IDEA
        - Visual Studio
        # this template is not bundled, so it will be searched in locations
        # specified above
        - local-overrides
    CONTRIBUTORS:
      conflict-resolution: concatenate 
      included-by-default: true
      variants:
        - etki
        - ayte-bot
  # skeleton has set of default files, so you can exclude ones you don't need  
  exclude:
    - '*.md'
  # in case exclude pattern was too broad, you can return something back
  include:
    - README.md
release:
  # pattern for assets 
  assets:
    paths:
      - path: bin/Release/steward.exe
        names: 
          - steward.exe
          - steward
        label: Main application
    patterns:
      - pattern: '**/*.exe'
      - pattern: '**/*.dll'
```

Skeleton (including template engine) and 

### Global configuration

As for now, global configuration only provides project defaults, but in 
future it may also have something else, so all the defaults are nested 
under corresponding key:

```yaml
version: '0.1'
defaults:
  authentication:
    - source: filesystem
      type: credentials
      name: /home/etki/.config/ayte/steward/credentials.yml
  project:
    copyright: Ayte Labs
    email: dev@ayte.team
    # Free-form object that may be used in some of bundled templates
    accounts:
      github: ayte-io
      twitter: so_mad_so_funny
      odnoklassniki: panin
  skeleton:
    files:
      .gitignore:
        variants:
          - IDEA
          - Visual Studio
```

### Merge process

All options, with some exceptions stated below, override their 
counterparts in global configuration, even if target section is string
array or untyped map. Exceptions to this rule are:

- Authentication: global section is appended to project section
- Skeleton context is recursively merged with project entries taking 
precedence over global ones. Only maps are merged, arrays and other 
types are simply overwritten.
- Skeleton locations from global configuration are appended to 
locations from project configuration. This allows to keep local 
shared template repo.
