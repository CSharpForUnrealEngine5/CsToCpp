#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AsyncImageExport.h")]
public partial class UAsyncImageExport : UBlueprintAsyncActionBase {
// AsyncImageExport
	public static UAsyncImageExport ExportImageAsync(UTexture Texture,string OutputFile,int Quality/*=100*/) { return default; }
	public FOnExportImageAsyncComplete Complete;
	public UTexture TextureToExport;
	public int Quality;
	public string TargetFile;
}
