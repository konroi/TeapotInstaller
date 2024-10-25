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
        public string[] FilesPreset = { "xbdm.xex", "JRPC2.xex", "JRPC.ini", "Teapot.ini", "launch.ini", "TeapotCE.ini", "Teapot.xex" };
        public string ZipName = "TeapotLive3.1.zip";
        public bool S_SUCCESS = false;
        public Exception Ex;

        public Downloader(string SingleFile = null)
        {
            Install(SingleFile);
        }

        public bool GetFileBytesFromZip(string singleFile = null) {
            try{
                using (ZipFile zip = new ZipFile(Definitions.STR_TEMPPATH + ZipName)){
                    foreach (ZipEntry e in zip){
                        if (singleFile == null){
                            if (!FilesPreset.Contains(Path.GetFileName(e.Name))) continue;
                        }else{
                            if (Path.GetFileName(e.Name) != singleFile) continue;
                        }

                        Console.WriteLine("{0}", Path.GetFileName(e.Name));

                        ZipEntry ze = zip.GetEntry(e.Name);
                        if (ze != null){
                            Stream stream = zip.GetInputStream(ze);
                            byte[] data = new byte[ze.Size];
                            stream.Read(data, 0, data.Length);
                            File.WriteAllBytes(Definitions.STR_TEMPPATH + Path.GetFileName(e.Name), data);
                        }
                    }
                }
                File.Delete(Definitions.STR_TEMPPATH + ZipName);
                return true;
            }catch(Exception e){
                Ex = e;
                return false;
            }
        }
        private bool GetTeapotArchive() {
            try{
                using (var client = new WebClient()){
                    Random rand = new Random();
                    client.DownloadFile("https://teapotlive.us/DL/TeapotLive.zip?cb=" + rand.Next(0, 9999), $"{ Definitions.STR_TEMPPATH}{ZipName}");
                }
                return true;
            }catch(Exception e){
                Ex = e;
                return false;
            }
        }

        private void Install(string SingleFile)
        { 
            if (GetTeapotArchive() && GetFileBytesFromZip(SingleFile)){
               this.S_SUCCESS = true;
                return;
            }
        }

    }
}
