#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FileMediaOutput.h")]
///<summary>Output information for a file media capture.</summary>
public partial class UFileMediaOutput : UMediaOutput {
// FileMediaOutput
	public FImageWriteOptions WriteOptions;
	public FDirectoryPath FilePath;
	public string BaseFileName;
	public bool bOverrideDesiredSize;
	public FIntPoint DesiredSize;
	public bool bOverridePixelFormat;
	public EFileMediaOutputPixelFormat DesiredPixelFormat;
	public bool bInvertAlpha;
}
