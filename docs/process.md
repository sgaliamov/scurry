# The process

Description of development and deployment processes.

## Development

1. Create new feature branch from *master*.
1. Apply new code and push.
1. Rebase on *master* before create PR:

   ``` bash
   git fetch origin master:master
   git rebase master
   # solve conflicts if any
   git push -f
   ```

1. Create PR from the feature branch to *master*. All checks should pass.
1. Squash and merge RP.

## Release

Add [release notes](https://github.com/sgaliamov/scurry/releases/new), define version tag, and publish the release.

It will publish the package to [nuget.org](https://www.nuget.org/packages/SCurry/).
