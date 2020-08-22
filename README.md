# Umbraco Facets Extensions

<img src="docs/img/logo.png?raw=true" alt="Umbraco Facet Extensions" width="250" align="right" />

[![NuGet release](https://img.shields.io/nuget/v/Our.Umbraco.Extensions.Facets.svg)](https://www.nuget.org/packages/Our.Umbraco.Extensions.Facets/)

## Getting started

This package is supported on Umbraco 8.1+ and requires [Examine.Facets](https://github.com/callumbwhyte/examine-facets) 1.0.0+.

### Installation

Facet Extensions is available from NuGet, or as a manual download directly from GitHub.

#### NuGet package repository

To [install from NuGet](https://www.nuget.org/packages/Our.Umbraco.Extensions.Facets/), run the following command in your instance of Visual Studio.

    PM> Install-Package Our.Umbraco.Extensions.Facets

## Usage

_Read the [Examine Facets](https://github.com/callumbwhyte/examine-facets#usage) docs for information about performing a search._

Normally it is possible to get a list of facets from a result like this:

```
results.GetFacet(string field);
```

Facet Extensions makes it possible to map facet results to any given type, including `IPublishedContent`. The values of the facets will be returned as an `IEnumerable<T>`.

```
results.GetFacet<T>(string field);
```

## Contribution guidelines

To raise a new bug, create an issue on the GitHub repository. To fix a bug or add new features, fork the repository and send a pull request with your changes. Feel free to add ideas to the repository's issues list if you would to discuss anything related to the library.

### Who do I talk to?

This project is maintained by [Callum Whyte](https://callumwhyte.com/) and contributors. If you have any questions about the project please get in touch on [Twitter](https://twitter.com/callumbwhyte), or by raising an issue on GitHub.

## Credits

The package logo uses the [Filter](https://thenounproject.com/term/search/3489190/) icon from the [Noun Project](https://thenounproject.com/) by [DailyYouth](https://thenounproject.com/dailyyouthdsgn/), licensed under [CC BY 3.0 US](https://creativecommons.org/licenses/by/3.0/us/).

## License

Copyright &copy; 2020 [Callum Whyte](https://callumwhyte.com/), and other contributors

Licensed under the [MIT License](LICENSE.md).