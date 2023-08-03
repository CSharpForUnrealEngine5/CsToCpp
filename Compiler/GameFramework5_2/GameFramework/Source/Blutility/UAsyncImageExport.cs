#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AsyncImageExport.h")]
public partial class UAsyncImageExport : UBlueprintAsyncActionBase {
	public static UClass StaticClass() {return default;}
	///<summary>ExportImageAsync</summary>
	public static UAsyncImageExport ExportImageAsync(UTexture Texture,string OutputFile,int Quality/*=100*/) { return default; }
	///<summary>Complete</summary>
	public FOnExportImageAsyncComplete Complete;
	///<summary>TextureToExport</summary>
	public UTexture TextureToExport;
	///<summary>Quality</summary>
	public int Quality;
	///<summary>TargetFile</summary>
	public string TargetFile;
}
