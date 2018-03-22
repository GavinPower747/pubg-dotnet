![PUBG Developer API Logo](https://developer.playbattlegrounds.com/d3fa01d31345504b60eacea226638a02.png)


# Pubg-DotNet
A sync/async client library for communicating with the Pubg developer api. Supporting .Net Standard 2.0.

Contact GavinPower747 on the Pubg Api Discord for more details

## Installation

### Install via Nuget

From the nuget command line:

	nuget install Pubg-DotNet

From the .Net CLI

  dotnet add package Pubg-DotNet 

From Package Manager:

	PM> Install-Package Pubg-DotNet

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on *Manage NuGet Packages...*
4. Click on the *Browse* tab and search for "Pubg-DotNet".
5. Click on the Pubg-DotNet package, select the appropriate version in the right-tab and click *Install*.

## Configuring Api Key

There are a number of ways to configure your api key. You can choose any of the below methods based on your circumstances, you only need to follow one of the examples below.

1. Static Configuration Method

In order to configure your Api Key through our config class you just need to add the following code:

**In Your Startup class**
```C#
    PubgApiConfiguration.Configure(opt => 
    {
        opt.ApiKey = "myApiKey";
    });
```

2. Per Request

When making a request to one of our services, all of our request objects contain an ApiKey field, simple provide your api key here. Below we use the GetMatchesRequest as an example

```C#
  var matchService = new PubgMatchService();
  var request = new GetPubgMatchesRequest
  {
    ApiKey = "myApiKey"
  }
  
  matchService.GetMatches(Region.(Region), request);
```

3. Service Instanciation

When instanciating your service you can supply it with your api key

```C#
    var matchService = new PubgMatchService("myApiKey");
```
