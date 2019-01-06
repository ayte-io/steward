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

### assets withdraw

Removes all or matching assets from release.

```yaml
steward release %release% assets withdraw [...%patterns%]
```
