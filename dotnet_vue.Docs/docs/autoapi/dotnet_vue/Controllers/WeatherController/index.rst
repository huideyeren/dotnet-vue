

WeatherController Class
=======================





Namespace
    :dn:ns:`dotnet_vue.Controllers`
Assemblies
    * dotnet_vue

----

.. contents::
   :local:



Inheritance Hierarchy
---------------------


* :dn:cls:`System.Object`
* :dn:cls:`Microsoft.AspNetCore.Mvc.ControllerBase`
* :dn:cls:`Microsoft.AspNetCore.Mvc.Controller`
* :dn:cls:`dotnet_vue.Controllers.WeatherController`








Syntax
------

.. code-block:: csharp

    [Route("api/[controller]")]
    public class WeatherController : Controller, IActionFilter, IAsyncActionFilter, IFilterMetadata, IDisposable








.. dn:class:: dotnet_vue.Controllers.WeatherController
    :hidden:

.. dn:class:: dotnet_vue.Controllers.WeatherController

Constructors
------------

.. dn:class:: dotnet_vue.Controllers.WeatherController
    :noindex:
    :hidden:

    
    .. dn:constructor:: dotnet_vue.Controllers.WeatherController.WeatherController(dotnet_vue.Providers.IWeatherProvider)
    
        
    
        
        :type weatherProvider: dotnet_vue.Providers.IWeatherProvider
    
        
        .. code-block:: csharp
    
            public WeatherController(IWeatherProvider weatherProvider)
    

Methods
-------

.. dn:class:: dotnet_vue.Controllers.WeatherController
    :noindex:
    :hidden:

    
    .. dn:method:: dotnet_vue.Controllers.WeatherController.Forecasts(System.Int32, System.Int32)
    
        
    
        
        :type from: System.Int32
    
        
        :type to: System.Int32
        :rtype: Microsoft.AspNetCore.Mvc.IActionResult
    
        
        .. code-block:: csharp
    
            [HttpGet("[action]")]
            public IActionResult Forecasts([FromQuery(Name = "from")] int from = 0, [FromQuery(Name = "to")] int to = 4)
    

