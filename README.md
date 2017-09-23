# EquineExchange.ImageHosting

EquineExchange.ImageHosting is a simple image host backed by [Azure Blob Storage](https://azure.microsoft.com/en-us/services/storage/blobs/) and [ImageResizer](https://imageresizing.net/).
It's sufficient to be used as-is for development and test environments where user load isn't a concern, but for production use you should put it behind a CDN.

## Usage

This site is meant to be used as-is with little to no customization.
The license, [AzureReader2](https://imageresizing.net/docs/v4/plugins/azurereader2), and other basic settings are loaded from `appSettings` so you're able to configure them in the Azure Portal.

### Settings

| Name                                       | Default value           | Description                                                                                     |
| :----------------------------------------- | :---------------------- | :---------------------------------------------------------------------------------------------- |
| app:imageResizer.license                   |                         | The ImageResizer license                                                                        |
| app:azureReader.connectionString           | StorageConnectionString | The name of the connection string or the actual connection string to use                        |
| app:azureReader.prefix                     | ~/m                     | The virtual folder all resize requests should use, anything outside here won't hit blob storage |
| app:azureReader.redirectToBlobIfUnmodified | false                   | Since this is meant to be the source of a CDN there's no reason to redirect here                |
| app:azureReader.requireImageExtension      | true                    | Helps ensure the right content type is served to the client                                     |
| app:azureReader.untrustedData              | true                    | Re-encodes all the images to help limit malicious uploads from possibly harming your users      |

### Example

```xml
<configuration>
    <connectionStrings>
        <add name="StorageConnectionString" connectionString="UseDevelopmentStorage=true;" />
    </connectionStrings>

    <appSettings>
        <add key="app:imageResizer.license" value="..." />

        <add key="app:azureReader.connectionString" value="StorageConnectionString" />
        <add key="app:azureReader.prefix" value="~/m" />
        <add key="app:azureReader.redirectToBlobIfUnmodified" value="false" />
        <add key="app:azureReader.requireImageExtension" value="true" />
        <add key="app:azureReader.untrustedData" value="true" />
    </appSettings>
</configuration>
```

## ImageResizer

Under the ImageResizer licensing model [you will need to purchase a license](https://imageresizing.net/pricing) even if you comply with their OSS license.
The reason for needing a license is we've chosen to use the NuGet packages instead of compiling our own assemblies, this means the license checks are still in place and the red dot will show in the bottom right corner.
There's a new OSS license that costs $7/year (you may need to contact them about purchasing it) which is a fair trade off for not having to maintain our own fork without the checks.

## Copyright and license

Copyright (c) 2017 Equine Exchange, LLC under [the MIT License](LICENSE).
