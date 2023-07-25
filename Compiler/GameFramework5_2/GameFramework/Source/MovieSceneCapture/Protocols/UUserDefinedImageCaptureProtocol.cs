#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Protocols/UserDefinedCaptureProtocol.h")]
///<summary>A blueprintable capture protocol tailored to capturing and exporting frames as images</summary>
public partial class UUserDefinedImageCaptureProtocol : UUserDefinedCaptureProtocol {
// UserDefinedImageCaptureProtocol
	public EDesiredImageFormat Format;
	public bool bEnableCompression;
	public int CompressionQuality;
	public string GenerateFilenameForBuffer(UObject Buffer,FCapturedPixelsID StreamID) { return default; }
	public string GenerateFilenameForCurrentFrame() { return default; }
	public void WriteImageToDisk(FCapturedPixels PixelData,FCapturedPixelsID StreamID,FFrameMetrics FrameMetrics,bool bCopyImageData/*=false*/) {}
}
