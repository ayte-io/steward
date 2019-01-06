---
title: CLI :: Release :: Assets
---

This section covers up bulk management for assets.

### assets push

Pushes all assets registered in configuration, or, if one ore more 
patterns is present, files that match provided patterns.

```yaml
steward release %release% assets push [...%patterns%]
```

### assets pull

Pulls all release assets matching patterns (all if no patterns are 
passed) into specified directory (current one if it is not specified).

```yaml
steward release %release% assets pull [%directory% ...%patterns%]
```

### assets revoke

Removes all or matching assets from release. If no patterns are 
specified, yanks everything.

```yaml
steward release %release% assets revoke [...%patterns%]
```
