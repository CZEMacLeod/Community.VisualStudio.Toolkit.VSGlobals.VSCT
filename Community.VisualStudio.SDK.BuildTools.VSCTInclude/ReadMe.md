# Community.VisualStudio.SDK.BuildTools.VSCTInclude

## Summary

A development time MSBuild extension to [Microsoft.VSSDK.BuildTools](https://www.nuget.org/packages/Microsoft.VSSDK.BuildTools/)

Adds a new item type `VSCTInclude` which ensures that the items path is added to `VSCTIncludePath` and gives a warning if you do _not_ include it in any `VSCTCompile` file.

## Warnings

If you set an item as `VSCTInclude`, but then do not reference it from a `VSCTCompile` item you will get two warnings.

- CVSTK001 No VSCTCompile file includes this VSCTInclude
  - This is shown for each VSCTInclude and jumps you to the include file.
- CSVTK002 Add &lt;Include href="xxxx.vsct"/&gt;
  - This is shown for each VSCTCompile and jumps you to the compile file
  - xxxx.vsct is the name of the VSCTInclude file.
  - Here you can add the relevant snippet
```xml
  <Include href="xxxx.vsct"/>
```

