# BootstrapIconsForDotNet
BootstrapIconsForDotNet is a lightweight .NET 
library that provides over 2000 SVG icons from Bootstrap  (https://icons.getbootstrap.com/)
Icons for easy integration into .NET applications, particularly web projects.

Features
Over 2000 SVG Icons: Includes all Bootstrap Icons in a ready-to-use format.
Easy Integration: Use icons directly in your .NET projects with minimal setup.
High Customizability: Icons are in SVG format, allowing customization of color, size, and other properties.
Installation
Install the library via NuGet:

bash
Copy code
dotnet add package BootstrapIconsForDotNet
Usage
Add a reference to the Icons class to use any icon in your project.

Example in Blazor:
razor
Copy code
# BootstrapIconsForDotNet

BootstrapIconsForDotNet is a lightweight .NET library that provides over 2000 SVG icons from Bootstrap Icons for easy integration into .NET applications, particularly web projects.

## Features

- **Over 2000 SVG Icons**: Includes all Bootstrap Icons in a ready-to-use format.
- **Easy Integration**: Use icons directly in your .NET projects with minimal setup.
- **High Customizability**: Icons are in SVG format, allowing customization of color, size, and other properties.

## Installation

Install the library via NuGet:
## Usage

Add a reference to the Icons class to use any icon in your project.

### Example in Blazor:
This renders the "houses" icon in your Blazor application.

## Icon Reference

The Icons class contains all the icons as public const string fields. Each icon is named in uppercase and underscores, matching the icon name from Bootstrap Icons.

### Example:
## License

This library is licensed under the MIT License.

### Bootstrap Icons License

Icons included in this library are derived from Bootstrap Icons, licensed under the MIT License.
```html
<div>
    @((MarkupString)BootstrapIconsForDotNet.Icons.HOUSES)
</div>
```
This renders the "houses" icon in your Blazor application.

Icon Reference
The Icons class contains all the icons as public const string fields. Each icon is named in uppercase and underscores, matching the icon name from Bootstrap Icons.

Example:

```csharp
public const string HOUSES = """
<svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-houses" viewBox="0 0 16 16">
  <path d="M5.793 1a1 1 0 0 1 1.414 0l.647.646a.5.5 0 1 1-.708.708L6.5 1.707 2 6.207V12.5a.5.5 0 0 0 .5.5.5.5 0 0 1 0 1A1.5 1.5 0 0 1 1 12.5V7.207l-.146.147a.5.5 0 0 1-.708-.708zm3 1a1 1 0 0 1 1.414 0L12 3.793V2.5a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 .5.5v3.293l1.854 1.853a.5.5 0 0 1-.708.708L15 8.207V13.5a1.5 1.5 0 0 1-1.5 1.5h-8A1.5 1.5 0 0 1 4 13.5V8.207l-.146.147a.5.5 0 1 1-.708-.708zm.707.707L5 7.207V13.5a.5.5 0 0 0 .5.5h8a.5.5 0 0 0 .5-.5V7.207z"/>
</svg>
""";
```
License
This library is licensed under the MIT License.

Bootstrap Icons License
Icons included in this library are derived from Bootstrap Icons, licensed under the MIT License.
https://github.com/twbs/bootstrap/blob/main/LICENSE