---
title: GitHub Steward :: CLI :: Release
---

### Asset management

Asset management is covered in separate sections. There are different 
APIs for [managing single assets](asset) and
 [all assets at once](assets).

### Commands

#### create

Creates new release. Standard input may be used instead of description 
argument.

```
steward release %name% create [%title% %description%|stdin --prerelease|-p --draft|-d]
```

```
steward release 0.1.0 create

steward release 0.1.0 create 'My First Release' 'Check this out!' --draft

echo 'Foxes are better than kittens' | steward release 0.1.0 create 'My First Release' --draft
```

#### title set

Sets release title. Standard input may be used instead of title 
argument.

```console
steward release %name% title set %title%
```

```console
steward release 0.1.0 title set 'My First Release'

cat description.txt | steward release 0.1.0 title set
```

#### title get

Retrieves release title

```console
steward release %name% title get
```

```console
steward release 0.1.0 title get
```

#### description set

Sets release description. Standard input may be used instead of 
description argument.

```console
steward release %name% description set [%description%]
```

```console
steward release 0.1.0 description set 'This thing does tricks!'

cat description.txt | steward release 0.1.0 description set
```

#### description get

Retrieves specified release description.

```console
steward release %name% description get
```

```console
steward release 0.1.0 description get
```

#### set draft

Sets draft flag for specified release.

```console
steward release %name% set draft [true | false]
```

```console
steward release 0.1.0 set draft true
# same as above
steward release 0.1.0 set draft

steward release 0.1.0 set draft false
```

#### get draft

Retrieves draft flag for specified release.

```console
steward release %name% get draft
```

```console
# returns string true or false
steward release 0.1.0 get draft
```

#### set prerelease

Sets prerelease flag for specified release.

```console
steward release %name% set prerelease [true | false]
```

```console
steward release 0.1.0 set prerelease true
# same as above
steward release 0.1.0 set prerelease

steward release 0.1.0 set prerelease false
```

#### get prerelease

Retrieves prerelease flag for specified release.

```console
steward release %name% get prerelease
```

```console
# returns string true or false
steward release 0.1.0 get prerelease
```

#### withdraw

Yanks release. Your users won't be happy unless you're fighting 
bumblebee-level bug.

```console
steward release %name% withdraw
```
