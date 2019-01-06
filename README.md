# Work-in-progress

Of course this project isn't anything close to completion. Currently 
this is just well-formed idea, that hopefully will see the light one 
day.

# [GitHub | Octo] Steward

## Motivation

There is very useful GitHub functionality that is not used extensively, 
for example, releases and assets. This project is targeted to provide 
CLI-friendly ways to use them, so your CI would be much easier than it
was.

## Installation

Just look into [releases section](https://github.com/ayte-io/steward/releases) 
and pick latest one.

## Usage

### Documentation

It was too big for readme, so it is available on 
[auxiliary website](https://ayte-io.github.io/steward). But hey, here's
standard quick intro:

### Thirty-seconds example

```console
mkdir /tmp/steward && cd /tmp/steward

echo "{version: '0.1', project: {repository: ayte-io/steward}}" > steward.yml

steward skeleton \
  .gitignore:idea .gitignore:visual-studio \
  license:mit license:upl \
  --exclude CHANGELOG.md
# result:
# - .gitignore
# - LICENSE-MIT
# - LICENSE-UPL-1.0
# - README.md
# 
# CHANGELOG.md would be generated if it hasn't been excluded

# Creates CONTRIBUTORS file using variants `etki` and `ayte-bot`
steward skeleton entry CONTRIBUTORS etki ayte-bot

cat password.txt | steward token issue etki ~/.config/ayte/steward/access-token
steward token confirm otp 333444

...

steward release 0.1.0 create \
    'My first release!' \ # title
    'Steward is a dead-simple GitHub helper application' \ # description
    0.1.0 \ # git revision
    --draft

steward release 0.1.0 assets push
steward release 0.1.0 asset push 'docs/*.md'
steward release 0.1.0 asset revoke README.md

steward release 0.1.0 set draft false
```

## Licensing

MIT & UPL

Ayte Labs, 2019
