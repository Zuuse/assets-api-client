# assets-api-client
A client API wrapper around the Zuuse Assets API, providing access to assets and their attributes.

## Generation
This project is a lightweight, code-generated wrapper around the Zuuse Assets API.  It is generated using Autorest https://github.com/Azure/autorest/blob/master/docs/generating-a-client.md in PowerShell as:

```
iwr https://zuuseassetsapidev.azurewebsites.net/swagger/docs/v1 -o interface.xml
autorest --input-file=interface.xml --csharp --output-folder=Zuuse.Assets.Client --namespace=Zuuse.Assets.Client
```

Make sure to check the version in Zuuse.Assets.Client.csproj for the NuGet package and make changes as necessary.
