using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Net;

using ICSharpCode.SharpZipLib.Zip;

namespace TeapotInstaller
{
    class Downloader
    {
        public string tempPath = string.Empty;
        public string[] files = { "xbdm.xex", "Teapot.ini", "launch.ini", "TeapotCE.ini", "Teapot.xex" };
        public string ZipName = "TeapotLive3.1.zip";
        public bool S_SUCCESS = false;
        public Exception Ex;

        public Downloader()
        {
            Install();
        }

        private bool GetFileBytesFromZip() {
            try{
                using (ZipFile zip = new ZipFile(tempPath + ZipName)){
                    foreach (ZipEntry e in zip){
                        if (!files.Contains(Path.GetFileName(e.Name))) continue;
                        Console.WriteLine("{0}", Path.GetFileName(e.Name));

                        ZipEntry ze = zip.GetEntry(e.Name);
                        if (ze != null){
                            Stream stream = zip.GetInputStream(ze);
                            byte[] data = new byte[ze.Size];
                            stream.Read(data, 0, data.Length);
                            File.WriteAllBytes(tempPath + Path.GetFileName(e.Name), data);
                        }
                    }
                }
                File.Delete(tempPath + ZipName);
                return true;
            }catch(Exception e){
                Ex = e;
                return false;
            }
        }
        private bool GetTeapotArchive() {
            try{
                using (var client = new WebClient()){
                    client.DownloadFile("https://teapotlive.us/DL/Teapotv3.1.zip", tempPath + ZipName);
                }
                return true;
            }catch(Exception e){
                Ex = e;
                return false;
            }
        }

        private void Install()
        {
            Directory.CreateDirectory(Path.GetTempPath() + "Teapot");
            this.tempPath = $"{Path.GetTempPath()}Teapot\\";
            if (GetTeapotArchive() && GetFileBytesFromZip()){
               this.S_SUCCESS = true;
                return;
            }
        }

    }
}
