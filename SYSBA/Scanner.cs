using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIA;

namespace SYSBA
{
    public class Scanner
    {
        public int mensaje = 0;
        Device oDevice;
        CommonDialog dlg;
        public Scanner()
        {
            try
            {
                dlg = new CommonDialog();
                oDevice = dlg.ShowSelectDevice(WiaDeviceType.ScannerDeviceType, true, false);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("NO SE HA DETECTADO NINGUN ESCANER, INTENTELO MAS TARDE", "SYSBA", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                this.mensaje = 1;
            }

        }

        public System.Drawing.Image Scann()
        {
            try
            {
                ImageFile imageFile = dlg.ShowAcquireImage(oDevice.Type,
                     WiaImageIntent.GrayscaleIntent,
                     WiaImageBias.MinimizeSize,
                     "{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}", false, false, false);
                WIA.Vector vector = imageFile.FileData;
                System.Drawing.Image i = System.Drawing.Image.FromStream(new
                         System.IO.MemoryStream((byte[])vector.get_BinaryData()));
                return i;
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("SE PERDIO LA CONEXIÓN");
                this.mensaje = 1;
                return null;
            }

        }
    }
}
