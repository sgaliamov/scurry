# About

Currying and partial application for C# functions and actions.

## Build status

| Master branch | Last build | Test Coverage |
|-|-|-|
| [![Build status](https://ci.appveyor.com/api/projects/status/2ppb58d9a8gmvdfw/branch/master?svg=true)](https://ci.appveyor.com/project/sgaliamov/scurry/branch/master)  |[![Build status](https://ci.appveyor.com/api/projects/status/2ppb58d9a8gmvdfw?svg=true)](https://ci.appveyor.com/project/sgaliamov/scurry) | [![codecov](https://codecov.io/gh/sgaliamov/scurry/branch/master/graph/badge.svg)](https://codecov.io/gh/sgaliamov/scurry) |

## Features

1. Supports all standard Func<> and Action<> classes.
2. Uncurrying.
3. Partial application with special spacer.
4. All code is auto generated and covered by unit tests.
5. Based on .NET Standard 2.0
6. No external dependencies.

## Examples

TBD

## Road Map

- [ ] support all actions
- [ ] implement uncurry
- [ ] implement partial apply
- [ ] use spacer for partial apply
- [ ] pipe function
- [ ] Add examples to use
- [ ] Support out/ref parameters?
- [x] CI/CD on github
- [x] global packages folder
- [x] exclude generated code from git
- [x] support all functions
- [x] unit tests

## The process

### Development

1. Create new feature branch from *develop*.
1. Apply new code and push it.
1. Create PR from feature branch to *develop*. All checks should pass. *Note*: now creation of PR trigger two builds despite *skip_branch_with_pr: true*.
1. Rebase on *develop*.
1. Push all changes to remote.
1. Squash and merge RP.
1. Delete feature branch from local and remote.

### Release

1. Create new release branch from *develop* and name it *Release/YYYY-MM-DD*.
1. Rebase on *master*:
   ``` bash
   git fetch origin master:master
   git rebase master
   ```
1. Apply all changes and push to remote.
1. Create PR from the release branch to *master*. Make sure that all checks pass.
1. Increment version in [appveyor.yml](./appveyor.yml) and push again. It will produce a build with wrong version that should be removed later.
1. Set *Next build number* to *0* in [AppVeyor](https://ci.appveyor.com/project/sgaliamov/scurry/settings).
1. Squash and merge RP. [AppVeyor](https://ci.appveyor.com/project/sgaliamov/scurry/deployments) will publish nuget package.
1. Remove redundant builds from [AppVeyor](https://ci.appveyor.com/project/sgaliamov/scurry/history).
1. Set version tag for the merge commit and push it to *origin/master*. *Note*: it will not trigger CI/CD because of *skip_tags: true* setting.
1. Add release notes at https://github.com/sgaliamov/scurry/releases and publish the release.

### To do

- Add description for package.