; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{4FFAD16B-8222-4E13-900D-6C9DA0E97D69}
AppName=Taofit
AppVersion=0.0.1
;AppVerName=Taofit 0.0.1
AppPublisher=The Game Bank Company
DefaultDirName={pf}\Taofit
DisableProgramGroupPage=yes
OutputBaseFilename=setup
SetupIconFile=E:\Assets\TaoFit\favicon.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "brazilianportuguese"; MessagesFile: "compiler:Languages\BrazilianPortuguese.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "E:\Projetos C#\Academia\Academia\bin\Debug\Academia.exe"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\Taofit"; Filename: "{app}\Academia.exe"
Name: "{commondesktop}\Taofit"; Filename: "{app}\Academia.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\Academia.exe"; Description: "{cm:LaunchProgram,Taofit}"; Flags: nowait postinstall skipifsilent

