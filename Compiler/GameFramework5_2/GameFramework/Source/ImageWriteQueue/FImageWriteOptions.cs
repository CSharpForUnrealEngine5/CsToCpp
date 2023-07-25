#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImageWriteBlueprintLibrary.h")]
///<summary>Options specific to writing image files to disk</summary>
public partial struct FImageWriteOptions {
// ImageWriteOptions
	public EDesiredImageFormat Format;
	public FOnImageWriteComplete OnComplete;
	public int CompressionQuality;
	public bool bOverwriteFile;
	public bool bAsync;
}
