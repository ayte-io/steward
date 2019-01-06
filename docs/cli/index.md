---
title: CLI
---

<div id="global-options"></div>

### Namespaces

1. [Skeleton](skeleton) - repository bootstrapping
2. [Release](release) - working with releases
3. [Token](token) - creating, listing and revoking access tokens
4. [Git](git) - all the regular git operations that are not handled by
git itself, like simplified squash operation without interactive 
rebase.

### Global options

#### --workspace, -p:w

Sets current workspace:

```
steward --workspace ~/Workspace/application ...
```

#### --repository

Sets repository current work is being done for. This may be useful when 
configuration is absent.

```console
steward --repository ayte-io/steward skeleton
```

#### --configuration, --project-configuration, -c:p

Sets path to project configuration file:

```console
steward --configuration ~/Workspace/application/steward.yml ...
```

Please note that this overrides workspace as well.

#### --global-configuration, -c:g

Sets path to global configuration file:

```console
steward --global-configuration ~/Workspace/application/steward.yml ...
```

#### --token, -a:t

Sets authentication to use when talking to github

```console
steward --token %source:value%
```

Value for that option encodes authentication in `type:source:value` 
format:

- environment:GITHUB_API_TOKEN
- file:.local/github/token.txt
- inline:%token%

#### --credentials, -a:c

```console
steward --credentials %source:value%
```

- environment:GITHUB_CREDENTIALS
- file:.local/github/credentials.yml
- inline:etki=hunter2

#### --login, -a:l, -a:u

```console
steward --login %source:value%
```

- environment:GITHUB_LOGIN
- inline:etki
- file:.local/github/login.txt

#### --password, -a:p

Sets authentication password. you can do it even inline, but please 
remember that such thing is exposed to process scanning / CI logs. 

```console
steward --password %source:value%
```

- environment:GITHUB_PASSWORD
- file:.local/github/password.txt
- inline:hunter2

#### --show-statistics, -s:s

Shows simple stats after task execution.

#### --quiet, -q, -s:q

Suppresses all output, except for specific messages (e.g. fetched 
values).
