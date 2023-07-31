#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A blueprintable capture protocol tailored to capturing and exporting frames as images</summary>
[CppInclude("Protocols/UserDefinedCaptureProtocol.h")]
public partial class UUserDefinedImageCaptureProtocol : UUserDefinedCaptureProtocol {
	///<summary>The image format to save as</summary>
	public EDesiredImageFormat Format;
	///<summary>Whether to save images with compression or not. Not supported for bitmaps.</summary>
	public bool bEnableCompression;
	///<summary>The compression quality for the image type. For EXRs, 0 = Default ZIP compression, 1 = No compression, PNGs and JPEGs expect a value between 0 and 100</summary>
	public int CompressionQuality;
	///<summary>* Generate a filename for the specified buffer using this protocol&#39;s file name formatter</summary>
	public  string GenerateFilenameForBuffer(UTexture Buffer,FCapturedPixelsID StreamID) { return default; }
	///<summary>* Generate a filename for the current frame using this protocol&#39;s file name formatter</summary>
	public  string GenerateFilenameForCurrentFrame() { return default; }
	///<summary>* Generate a filename for the current frame using this protocol&#39;s file name formatter</summary>
	public  void WriteImageToDisk(FCapturedPixels PixelData,FCapturedPixelsID StreamID,FFrameMetrics FrameMetrics,bool bCopyImageData/*=false*/) {}
}
