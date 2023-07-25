#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CrashReporterSettings.h")]
///<summary>Implements per-project cooker settings exposed to the editor</summary>
public partial class UCrashReporterSettings : UObject {
// CrashReporterSettings
	public string UploadSymbolsPath;
	public string DownstreamStorage;
	public TArray<string> RemoteStorage;
}
