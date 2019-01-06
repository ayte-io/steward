---
title: CLI :: Skeleton 
---

### skeleton

Bootstraps repository with usual files

```console
steward skeleton [...%file:variant%]
```

```console
steward skeleton \
    license:mit license:upl \
    contributors:etki contributors:ayte-bot contributors:general-rigby
```

TBD

### skeleton entry

Creates/replaces single file in repository.

```console
steward skeleton entry %path% [...%variant%]
```

```console
steward skeleton entry contributors ayte-bot etki general-rigby
```
