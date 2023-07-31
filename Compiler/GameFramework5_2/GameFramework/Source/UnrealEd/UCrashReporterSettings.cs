#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements per-project cooker settings exposed to the editor</summary>
[CppInclude("CrashReporterSettings.h")]
public partial class UCrashReporterSettings : UObject {
	///<summary>Directory for uploading locally built binaries and .PDB files</summary>
	public string UploadSymbolsPath;
	///<summary>Local downstream PDB storage path (used for caching remote .PDB files)</summary>
	public string DownstreamStorage;
	///<summary>Remote PDB storage (directory path or http/https URL)</summary>
	public TArray<string> RemoteStorage;
}
