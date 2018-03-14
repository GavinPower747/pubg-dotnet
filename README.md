![PUBG Developer API Logo](https://developer.playbattlegrounds.com/d3fa01d31345504b60eacea226638a02.png)


# Pubg-DotNet
A sync/async client library for communicating with the Pubg developer api.

Very WIP at the moment. 

Contact GavinPower747 on the Pubg Api Discord for more details

## Documentation

### Configuring Api Key

There are a number of ways to configure your api key. You can choose any of the below methods based on your circumstances, you only need to follow one of the examples below.

1. Static Configuration Method

In order to configure your Api Key through our config class you just need to add the following code:

**.Net Framework**
_Global.asax_
```C#
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using Pubg.Net;

namespace FullFrameworkSample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
            PubgApiConfiguration.SetApiKey("myApiKey");
        }
    }
}
```

**.Net Core**
_Startup.cs_
```C#
using Pubg.Net

namespace CoreSample
{
    public class Startup
    {
        public Startup() 
        {
          //...
        }
    
        public void ConfigureServices(IServiceCollection services)
        {
          //.... Other Service config code
          
          PubgApiConfiguration.SetApiKey("myApiKey");
        }
        
        public void Configure(...)
        {
          //...
        }
    }
```
2. Per Request (WIP)

When making a request to one of our services, all of our request objects contain an ApiKey field, simple provide your api key here. Below we use the GetMatchesRequest as an example

```C#
  var matchService = new PubgMatchService();
  var request = new GetPubgMatchesRequest
  {
    ApiKey = "myApiKey"
  }
  
  matchService.GetMatches(Region.(Region), request);
```

3. Configuring your DI container

WIP
