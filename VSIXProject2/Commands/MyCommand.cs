using Community.VisualStudio.Toolkit;
using Microsoft.VisualStudio.Shell;
using System;
using Task = System.Threading.Tasks.Task;

namespace VSIXProject2
{
    internal sealed class MyCommand : BaseCommand<MyCommand>
    {
        public MyCommand()
            : base(PackageGuids.CommandSet, PackageIds.MyCommand) { }

        protected override Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            VS.Notifications.ShowMessage("MyCommand", "Button clicked");

            return Task.CompletedTask;
        }
    }
}
