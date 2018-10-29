# The process

Description of development and deployment processes.

## Development

1. Create new feature branch from *develop*.
1. Apply new code and push.
1. Rebase on *develop* before create PR:

   ``` bash
   git fetch origin develop:develop
   git rebase develop
   git push -f
   ```

1. Create PR from the feature branch to *develop*. All checks should pass.
1. Squash and merge RP.
1. Remove feature branch from local and remote.

## Release

1. Create new release branch from *develop* and name it *release/YYYY.MM.DD*.
1. Increment version in [appveyor.yml](./appveyor.yml).
1. Apply all changes and push to remote.
1. Create PR from the release branch to *master*. Make sure that all checks pass. It will produce a build with wrong version that should be removed later.
1. Set *Next build number* to *0* in [AppVeyor](https://ci.appveyor.com/project/sgaliamov/scurry/settings).
1. Squash and merge RP. [AppVeyor](https://ci.appveyor.com/project/sgaliamov/scurry/deployments) will publish nuget package.
1. After deploy remove the release branch and clean redundant builds from [AppVeyor](https://ci.appveyor.com/project/sgaliamov/scurry/history).
1. Set version tag for the merge commit and push it to *origin/master*. *Note*: it will not trigger CI/CD because of *skip_tags: true* setting.
1. Add [release notes](https://github.com/sgaliamov/scurry/tags) and publish the release.
1. Create pull request from *master* to *develop* and complete it.
