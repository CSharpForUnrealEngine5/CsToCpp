#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Function library containing utility methods for writing images on a global async queue</summary>
[CppInclude("ImageWriteBlueprintLibrary.h")]
public partial class UImageWriteBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Export the specified texture to disk</summary>
	public static void ExportToDisk(UTexture Texture,string Filename,FImageWriteOptions Options) {}
}
