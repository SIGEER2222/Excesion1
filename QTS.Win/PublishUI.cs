using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QTS.Excesion.Win
{
    public partial class PublishUI : Form
    {
        public PublishUI()
        {
            InitializeComponent();
        }

        private void PublishUI_Load(object sender, EventArgs e)
        {
            //工程包路径默认为上次打包的路径
            //版本号从压缩文件的配置里面拿
            //工程名称也是
            //服务网址从选项页拿
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
