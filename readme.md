# About

Currying and partial application for C# functions and actions.

## Status

| Master branch | Last build | Test Coverage |
|-|-|-|
| [![Build status](https://ci.appveyor.com/api/projects/status/2ppb58d9a8gmvdfw/branch/master?svg=true)](https://ci.appveyor.com/project/sgaliamov/scurry/branch/master)  |[![Build status](https://ci.appveyor.com/api/projects/status/2ppb58d9a8gmvdfw?svg=true)](https://ci.appveyor.com/project/sgaliamov/scurry) | [![codecov](https://codecov.io/gh/sgaliamov/scurry/branch/master/graph/badge.svg)](https://codecov.io/gh/sgaliamov/scurry) |

## Features

1. Supports all standard Func<> and Action<> delegates.
2. Uncurrying.
3. Partial application with special spacer.
4. All code is auto generated and covered by unit tests.
5. Based on .NET Standard 2.0
6. No external dependencies.

## Examples

TBD

## The process

### Development

1. Create new feature branch from *develop*.
1. Apply new code and push.
1. Rebase on *develop*:
   ``` bash
   git fetch origin develop:develop
   git rebase develop
   git push -f
   ```
1. Create PR from the feature branch to *develop*. All checks should pass. *Note*: despite *skip_branch_with_pr: true* PR will trigger two builds.
1. Squash and merge RP.
1. Remove feature branch from local and remote.

### Release

1. Create new release branch from *develop* and name it *Release/YYYY.MM.DD*.
1. Increment version in [appveyor.yml](./appveyor.yml).
1. Apply all changes and push to remote.
1. Create PR from the release branch to *master*. Make sure that all checks pass. It will produce a build with wrong version that should be removed later.
1. Set *Next build number* to *0* in [AppVeyor](https://ci.appveyor.com/project/sgaliamov/scurry/settings).
1. Squash and merge RP. [AppVeyor](https://ci.appveyor.com/project/sgaliamov/scurry/deployments) will publish nuget package.
1. After deploy remove the release branch and clean redundant builds from [AppVeyor](https://ci.appveyor.com/project/sgaliamov/scurry/history).
1. Set version tag for the merge commit and push it to *origin/master*. *Note*: it will not trigger CI/CD because of *skip_tags: true* setting.
1. Add release notes at https://github.com/sgaliamov/scurry/tags and publish the release.
1. Rebase *develop* on *master*:
   ``` bash
   git checkout develop
   git fetch origin master:master
   git rebase master
   git push -f
   ```

## Road Map

- [ ] use spacer for partial apply
- [ ] implement uncurry
- [ ] implement partial apply
- [ ] pipe function
- [ ] add examples to use
- [ ] add description for the package
- [ ] support out/ref parameters?
- [x] support all actions
- [x] CI/CD on github
- [x] global packages folder
- [x] exclude generated code from git
- [x] support all functions
- [x] unit tests