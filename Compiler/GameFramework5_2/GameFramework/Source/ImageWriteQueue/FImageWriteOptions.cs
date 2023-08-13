namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Options specific to writing image files to disk</summary>
[CppInclude("ImageWriteBlueprintLibrary.h")]
public partial struct FImageWriteOptions {
	public EDesiredImageFormat Format;
	public FOnImageWriteComplete OnComplete;
	public int CompressionQuality;
	public bool bOverwriteFile;
	public bool bAsync;
}
