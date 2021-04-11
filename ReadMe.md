# Community.VisualStudio.Toolkit Extra Bits

This is repository contains 2 packages and some test extensions for VisualStudio, based on [Community.VisualStudio.Toolkit](https://github.com/madskristensen/Community.VisualStudio.Toolkit) and the [ExtensibilityTemplatePack](https://github.com/madskristensen/ExtensibilityTemplatePack)

## Community.VisualStudio.Toolkit.VSGlobals.VSCT

This is a nuget package that contains the VSGlobals.vsct file from the [ExtensibilityTemplatePack](https://github.com/madskristensen/ExtensibilityTemplatePack).
It means the file can be versioned, and updated after the project is created from the template.
It lights up via the `VSCTIncludePath` item group used by the `VSCTCompile` target/task.

## Community.VisualStudio.SDK.BuildTools.VSCTInclude

This is a nuget package that contains logic to create a new item group available from Visual Studio as a Build Action: `VSCTInclude`.
This makes it easy to identify include files, ensure that they are on the Include Path for the `VSCTCompile` target, and gives warnings if you don't actually use them.

### Example Projects
#### VSIXProject1
A project created from the [ExtensibilityTemplatePack](https://github.com/madskristensen/ExtensibilityTemplatePack) using the `VSIX Project w/Command (Community)` template.
It was then altered to use the above packages for testing.
The project has been tested with each package separately and together.

#### VSIXProject2
This is a short form or SDK style project converted from VSIXProject1. 
This is slightly easier to develop and iterate against and debug that the long form VSIXProject1.
**It should be noted that this is _not_ a supported scenario**
Some of the editors etc. for VSIX projects do not work.
However, it does build, compile, and even debug into VS Experimental correctly.
Perhaps this might be a quick win for the VS Team :wink: