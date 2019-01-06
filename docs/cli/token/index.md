---
title: CLI :: Authentication
---

### issue

Creates new token in exchange of credentials. Format of login and 
password is the same, as in [authentication global options](../). 
Password may be supplied through standard input. If path is provided, 
token is stored there, otherwise it is printed in standard output.

```console
steward token issue %login = type:value% [%password = type:value% %path% %scope%]
```

```console
steward token issue etki hunter2

echo hunter2 | steward token issue etki ~/.config/ayte/steward/token user repo:read
```

Since scope arguments require path argument to be present, it can be 
set to `-` to export response to standard output.

```console
steward token issue etki hunter2

echo hunter2 | steward token issue etki - user repo:read
```

Login may be guarded by 2FA, in that case request is stored and has to be 
confirmed through next command.

### confirm otp

Confirms previous token request.

```console
steward token confirm %otp%
```

```console
steward token confirm 555333
```

The result is the same as in issue command (including stdout/file 
output selection).

### revoke

Revokes specified token.

```console
steward token revoke %token%
```

### list

Lists all active tokens.

```console
steward token list
```
