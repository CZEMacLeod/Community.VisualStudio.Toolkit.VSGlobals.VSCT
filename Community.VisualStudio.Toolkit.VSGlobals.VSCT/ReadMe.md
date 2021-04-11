# Community.VisualStudio.Toolkit.VSGlobals.VSCT

This is a nuget package that contains the `VSGlobals.vsct` file from the [ExtensibilityTemplatePack](https://github.com/madskristensen/ExtensibilityTemplatePack).

It means the file can be versioned, and updated after the project is created from the template.
It lights up via the `VSCTIncludePath` item group used by the `VSCTCompile` target/task.

Parts of this project are based on work
Copyright 2020 Mads Kristensen

An explanation of using `VSGlobals.vsct` is available at [Writing Visual Studio Extensions with Mads - Improving our community templates](https://www.youtube.com/watch?v=Gzpntvp0yzo&t=1s)

## How to use

1) Remove any local copy of `VSGlobals.vsct` you may have in your local project.
   i) It may be hidden/nested under VSCommandTable.vsct
2) Install the package into your VSIX project
3)
    i)  If you started with a project created from the [ExtensibilityTemplatePack](https://github.com/madskristensen/ExtensibilityTemplatePack) using the `VSIX Project w/Command (Community)` template, you don't need to do anything. :joy:
    ii) If you used an older template, or a different template you can now include and use the globals.

Ensure you have the following in your `VSCommandTable.vsct` file
```xml
  <Include href="VSGlobals.vsct"/>
```

Replace items like
```xml
  <Parent guid="guidSHLMainMenu" id="IDM_VS_MENU_TOOLS"/>
```
with
```xml
  <Parent guid="VSMainMenu" id="View.DevWindowsGroup.OtherWindows.Group1"/>
```

The top level groups are 
- VSMainMenu
- VSNuGet
- VSTerminal
- VSFeedback
- VSEditor
- VSEditor2

If you have the latest [ExtensibilityTemplatePack](https://github.com/madskristensen/ExtensibilityTemplatePack) (V2.1.11 or higher) installed you will get intellisense and popups to show you where your item will be added.
See [Writing Visual Studio Extensions with Mads - Improving our community templates](https://www.youtube.com/watch?v=Gzpntvp0yzo&t=1s) for a demonstration and more information.