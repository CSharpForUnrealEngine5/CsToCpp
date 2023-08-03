#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Output information for a file media capture.</summary>
[CppInclude("FileMediaOutput.h")]
public partial class UFileMediaOutput : UMediaOutput {
	public static UClass StaticClass() {return default;}
	///<summary>Options on how to save the images.</summary>
	public FImageWriteOptions WriteOptions;
	///<summary>The file path for the images.</summary>
	public FDirectoryPath FilePath;
	///<summary>The base file name of the images. The frame number will be append to the base file name.</summary>
	public string BaseFileName;
	///<summary>Use the default back buffer size or specify a specific size to capture.</summary>
	public bool bOverrideDesiredSize;
	///<summary>Use the default back buffer size or specify a specific size to capture.</summary>
	public FIntPoint DesiredSize;
	///<summary>Use the default back buffer pixel format or specify a specific the pixel format to capture.</summary>
	public bool bOverridePixelFormat;
	///<summary>Use the default back buffer pixel format or specify a specific the pixel format to capture.</summary>
	public EFileMediaOutputPixelFormat DesiredPixelFormat;
	///<summary>Invert the alpha for formats that support alpha.</summary>
	public bool bInvertAlpha;
}
