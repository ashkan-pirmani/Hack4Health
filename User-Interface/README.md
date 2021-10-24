# FAIRy Tale Mock UI

<img src="/Hack4Health.webp" width="728" height="132">

This UI represents our solution for the #HackTheSilos challenge at Hack4Health 2021. It is implemented using [ASP.net Core](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core) [SDK Version 5](https://docs.microsoft.com/en-us/aspnet/core/release-notes/aspnetcore-5.0?view=aspnetcore-5.0). We created three dashboard examples, one for a patient, one for a data custodian and one for the mock data generator. 

## Structure overview

You can find the three UIs under `Federated/Areas/EndUser/Views` (including the landing page named `Home`). 

* `Catalogue`: This UI shows some general statistics about mocked data. It could allow a data custodian to get a general overview of her / his data
* `DataGenerator`: A UI to configure the Mock-Generator-AP (see under `Data-Generator`)
* `PatientJourney`: Overview of patient centric data points including links to other data sources (e.g. PubMed).

## Additional Libraries used

* [JQuery](https://jqueryui.com/)
* [amCharts](https://www.amcharts.com/)
