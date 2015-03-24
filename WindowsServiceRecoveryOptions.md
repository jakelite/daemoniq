# Setting Service Recovery Options #

Daemoniq supports for setting up service recovery options via the app.config file. This is enabled by adding a recoveryOptions element inside the service definition. The attributes exposed by this element allows users to set recovery options at the same level of abstraction as the Recovery tab of the Service Properties window of the services.msc applet.

[![](http://technet.microsoft.com/en-us/library/Cc749870.exch0305_big(en-us,TechNet.10).gif)](http://daemoniq.org)

The sample configuration file below illustrates this feature.

```
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <configSections>
    <section name="daemoniq" type="Daemoniq.Configuration.DaemoniqConfigurationSection, Daemoniq" />
    <section name="castle" type="Castle.Windsor.Configuration.AppDomain.CastleSectionHandler, Castle.Windsor" />
  </configSections>
  <castle>
    <components>
      <component id="Dummy1"
                 service="Daemoniq.Framework.IServiceInstance, Daemoniq"
                 type="Daemoniq.Samples.DummyService, Daemoniq.Samples">
      </component>
    </components>
  </castle>
  <daemoniq>
    <services>
      <service
        serviceName="Dummy1"
        displayName="Dummy Service 1"
        description="This is a dummy service"
        serviceStartMode="Automatic">
        <recoveryOptions firstFailureAction="RestartTheService"
                         secondFailureAction="RunAProgram"
                         subsequentFailureAction="RestartTheComputer"
                         daysToResetFailAcount="2"
                         minutesToRestartService="5"
                         rebootMessage="This computer is going to reboot =D..."
                         commandToLaunchOnFailure="C:\Program Files\OmgWtfBbq.exe" />
      </service>
    </services>
  </daemoniq>
</configuration>
```

_Note: acceptable values for `firstFailureAction`, `secondFailureAction` and `subsequentFailureAction`  are `TakeNoAction`, `RestartTheService`, `RunAProgram` and `RestartTheComputer`._