using Community.VisualStudio.Toolkit;
using Microsoft.VisualStudio.Shell;
using System.Windows.Forms;
using Task = System.Threading.Tasks.Task;
using QTS.Excesion.Win;
namespace QTS.Excesion
{
    [Command(PackageIds.PackButton)]
    internal sealed class PackCMD : BaseCommand<PackCMD>
    {
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            await VS.MessageBox.ShowWarningAsync("QTSExcesion", "点了打包");
            PublishUI package = new PublishUI();
            package.Show();
        }
    }
}
