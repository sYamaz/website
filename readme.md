# website

https://syamaz.github.io/website/

## packages(nuget)

* [PublishSPAforGitHubPages.Build - GitHub](https://github.com/jsakamoto/PublishSPAforGitHubPages.Build)
* [Skclusive.Material.Component - GitHub](https://github.com/skclusive/Skclusive.Material.Component)

## How to publish

```bash
dotnet publish -c:Release -p:GHPages=true

# Copy all published files

cp -r ./website/bin/Release/net6.0/publish/wwwroot/. ./docs


# Commit and push

```