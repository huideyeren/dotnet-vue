

Startup Class
=============





Namespace
    :dn:ns:`dotnet_vue`
Assemblies
    * dotnet_vue

----

.. contents::
   :local:



Inheritance Hierarchy
---------------------


* :dn:cls:`System.Object`
* :dn:cls:`dotnet_vue.Startup`








Syntax
------

.. code-block:: csharp

    public class Startup








.. dn:class:: dotnet_vue.Startup
    :hidden:

.. dn:class:: dotnet_vue.Startup

Constructors
------------

.. dn:class:: dotnet_vue.Startup
    :noindex:
    :hidden:

    
    .. dn:constructor:: dotnet_vue.Startup.Startup(Microsoft.Extensions.Configuration.IConfiguration)
    
        
    
        
        :type configuration: Microsoft.Extensions.Configuration.IConfiguration
    
        
        .. code-block:: csharp
    
            public Startup(IConfiguration configuration)
    

Properties
----------

.. dn:class:: dotnet_vue.Startup
    :noindex:
    :hidden:

    
    .. dn:property:: dotnet_vue.Startup.Configuration
    
        
        :rtype: Microsoft.Extensions.Configuration.IConfiguration
    
        
        .. code-block:: csharp
    
            public IConfiguration Configuration { get; }
    

Methods
-------

.. dn:class:: dotnet_vue.Startup
    :noindex:
    :hidden:

    
    .. dn:method:: dotnet_vue.Startup.Configure(Microsoft.AspNetCore.Builder.IApplicationBuilder, Microsoft.AspNetCore.Hosting.IHostingEnvironment)
    
        
    
        
        :type app: Microsoft.AspNetCore.Builder.IApplicationBuilder
    
        
        :type env: Microsoft.AspNetCore.Hosting.IHostingEnvironment
    
        
        .. code-block:: csharp
    
            public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    
    .. dn:method:: dotnet_vue.Startup.ConfigureServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)
    
        
    
        
        :type services: Microsoft.Extensions.DependencyInjection.IServiceCollection
    
        
        .. code-block:: csharp
    
            public void ConfigureServices(IServiceCollection services)
    

