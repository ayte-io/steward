---
title: Authentication
---

Authentication is set either in [configuration](configuration) or
on [cli calls](cli#global-options). Currently two types of 
authentication are supported: token (you should use this one) and user
credentials (you shouldn't use this one, but just for extreme cases).
Authentication is defined by triplet `type-source-value`, where type is
`token` or `credentials`, source is `environment-variable` or 
`filesystem`, and value is either name of environment variable or path 
to file.
 
Both types of authentication value can be expressed directly or stored in 
yaml file:

```yaml
token: %token%
```

```yaml
login: etki
password: hunter2
```

Credentials are expressed in `%login%=%password%` format when specified
directly:

```text
etki=hunter2
```

So don't forget to quote them on CLI calls, since it's likely you will 
have special characters.
