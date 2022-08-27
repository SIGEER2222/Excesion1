using Community.VisualStudio.Toolkit;
using Microsoft.VisualStudio.Shell;
using QTS.Excesion.Win;
using System;
using Task = System.Threading.Tasks.Task;

namespace QTS.Excesion
{
    [Command(PackageIds.PublishButton)]
    internal sealed class PublishCMD : BaseCommand<PublishCMD>
    {
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            await VS.MessageBox.ShowWarningAsync("PublishCMD", "点了发布");
            PublishUI package = new PublishUI();
            package.Show();
        }
    }
}
