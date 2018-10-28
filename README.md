# SofiA (Social Fire Alarm)

## Overview

This repository contains 3 projects, which symbolize the essence of the ecosystem of applications that surround Sofia.

The idea of the project is represented much better in the [attached documentation](
https://2018.spaceappschallenge.org/challenges/volcanoes-icebergs-and-asteroids-oh-my/real-time-fire-app/teams/gohub/project)

### Sofia Server

Sofia has a heart, and this is the server, with the ability to process, store and supply information from different media, producing a WebApi (json) so that device/platform can consume without any problem.

![](https://github.com/gohubvlc/sofia-project/raw/master/diagrams/SofiaSummary.jpg)

For the moment we have published 3 points of consumption for the consumption of data of our application:


**Sofia-FirePoints-GeoJson:** Provides possible fire points generated by Sofia (Social Fire Alarm) in GeoJson format (RFC 7946)
 https://hawking.sv.cmu.edu:9016/opennex/climateService/get/29

**Sofia-Add-FirePoint:** Allows create a firepoint from external applications/providers
**Sofia-Add-User:** Allows create a user from external applications/providers

The application is a Console application developed in DotNetCore with C #
https://docs.microsoft.com/en-us/dotnet/core/

### Sofia Mobile

Description:
Mobile applications are the most efficient and fastest way to reach the final consumer. For this we have created an iOS application to consume data directly from **SofiaServer**.

Additional information:

Includes weather consultation services provided by Openweathermap
https://github.com/gohubvlc/sofia-app/blob/master/src/SofiaApp.Host.Core/Services/WeatherService.cs

The application is developed in Xamarin.iOS in C # language https: //docs.microsoft.com/es-es/xamarin/ios/

![](https://github.com/gohubvlc/sofia-project/raw/master/images/APP%20Mockup.jpg)

### IoT application (DIY Project)

As an additional project, we wanted to incorporate a project to demonstrate how easy it can be to consume the APIs we provide, and with very little effort, the community can create their own IoT devices for early detection of fires in the area.

The wizard periodically consults the APIs provided by the server and announces through a synthesized voice where a nearby fire has been detected, with temperature data from the installed sensors or using the OpenWeather services in their area.

We also include a visual aid that changes the color of the LED from green to red.

For the future we could add a physical button as an additional way to inform Sofia about a nearby fire.

These are some photos of the prototype that we gathered for the presentation of the project.

![](https://github.com/gohubvlc/sofia-app/raw/master/Assets/iot.png)

The application is a Console Application in C # language. Executed in a Raspberry PI with Raspbian and MONO installed

How install Mono: https://www.mono-project.com/download/stable/#download-lin-raspbian
GPIO library: https://github.com/netonjm/IoTSharp.Components
