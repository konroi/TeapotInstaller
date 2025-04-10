A very simple Teapot Installer / Repair and configuration mananger. 
This uses ilmerge to pack everything into a single executable "Teapot-Tool.exe"

The post build for this is:
$(ILMergeConsolePath) "$(TargetDir)TeapotInstaller.exe" /out:"$(TargetDir)Teapot-Tool.exe" "$(TargetDir)DotNetZip.dll" "$(TargetDir)MetroFramework.Design.dll" "$(TargetDir)\MetroFramework.dll" "$(TargetDir)MetroFramework.Fonts.dll" "$(TargetDir)ICSharpCode.SharpZipLib.dll"

I will add the latest compiled executable to the repo (Last Built: 04/10/2025)
