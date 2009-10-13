; -- Example1.iss --
; Demonstrates copying 3 files and creating an icon.

; SEE THE DOCUMENTATION FOR DETAILS ON CREATING .ISS SCRIPT FILES!
;#define ISSI_WizardSmallBitmapImage "C:\CVSHome\SineDialer\SineDialer\installer.bmp"

#define ISSI_WizardSmallBitmapImage_x 498
#define ISSI_WizardSmallBitmapImage_Align
#define ISSI_IncludePath "C:\ISSI"

#include ISSI_IncludePath+"\_issi.isi"

[Setup]
AppName=SineStatsIAX
AppVerName=SineStatsIAX 0.2
DefaultDirName={pf}\SineStatsIAX
DefaultGroupName=SineApps
UninstallDisplayIcon={app}\SineStatsIAX.exe
Compression=lzma
SolidCompression=yes
OutputBaseFileName=SineStatsIAX Installer
AppPublisher=SineApps
AppPublisherURL=http://www.sineapps.com
AppCopyright=Copyright © 2004-5 SineApps LTD.


[_ISTool]
EnableISX=true

[Run]
;Filename: {app}\Install.rtf; Description: Read the installation instructions; Flags: shellexec skipifdoesntexist postinstall skipifsilent
;Filename: {app}\agi; Description: View AGI files to install to Asterisk Server; Flags: postinstall shellexec skipifsilent
Filename: {pf}\SineStatsIAX\SineStatIAX.exe; Description: Launch SineStatsIAX; Flags: shellexec postinstall skipifsilent

[Files]
Source: bin\Debug\SineStatIAX.exe; DestDir: {pf}\SineStatsIAX; DestName: SineStatIAX.exe; Flags: promptifolder
Source: bin\Debug\SineStatIAX.exe.manifest; DestDir: {pf}\SineStatsIAX; DestName: SineStatIAX.exe.manifest; Flags: promptifolder
Source: .\netstats.dll; DestDir: {sys}; Flags: promptifolder

[Icons]
Name: {group}\SineStatsIAX; Filename: {app}\SineStatIAX.exe; Comment: SineApps IAX Statistics Monitoring; IconIndex: 0
Name: {userdesktop}\SineStatsIAX; Filename: {app}\SineStatIAX.exe; Comment: SineApps IAX Statistics Monitoring; IconIndex: 0







[Code]
function InitializeSetup(): Boolean;
var
    ErrorCode: Integer;
    NetFrameWorkInstalled : Boolean;
    Result1 : Boolean;
begin

           NetFrameWorkInstalled := RegKeyExists(HKLM,'SOFTWARE\Microsoft\.NETFramework\policy\v1.0');
           if NetFrameWorkInstalled =true then
           begin
              Result := true;
           end;
           if NetFrameWorkInstalled = false then
           begin
               NetFrameWorkInstalled := RegKeyExists(HKLM,'SOFTWARE\Microsoft\.NETFramework\policy\v1.1');
               if NetFrameWorkInstalled =true then
               begin
                  Result := true;
               end;

               if NetFrameWorkInstalled =false then
               begin
                         Result1 := MsgBox('This setup requires the .NET Framework. Please download and install the .NET Framework and run this setup again. Do you want to download the framwork now?',
                              mbConfirmation, MB_YESNO) = idYes;
                         if Result1 =false then
                         begin
                            Result:=false;
                         end
                         else
                         begin
                              Result:=false;
                                //inno setup 5
                                ShellExec('open', 'http://download.microsoft.com/download/a/a/c/aac39226-8825-44ce-90e3-bf8203e74006/dotnetfx.exe','','',SW_SHOWNORMAL,ewNoWait,ErrorCode);
                                //inno setup 4
                                //InstShellExec('http://download.microsoft.com/download/a/a/c/aac39226-8825-44ce-90e3-bf8203e74006/dotnetfx.exe','','',SW_SHOWNORMAL,ErrorCode);
                        end;
               end;
          end;
end;
[UninstallDelete]
Name: {app}\agi\phpagi.php; Type: filesandordirs
Name: {app}\agi\savestate.php; Type: filesandordirs
Name: {app}\Install.rtf; Type: files
Name: {app}\MySql.Data.dll; Type: files
Name: {app}\PieChart.dll; Type: files
Name: {app}\SineDialer.chm; Type: filesandordirs
Name: {app}\SineDialer.chm; Type: filesandordirs
Name: {app}\SineDialer.exe; Type: filesandordirs
Name: {app}\SineDialer.sql; Type: filesandordirs
Name: {app}; Type: filesandordirs
[Registry]
Root: HKLM; Subkey: Software\GUA; ValueType: string; ValueName: serialaddition; Flags: uninsdeletekey
