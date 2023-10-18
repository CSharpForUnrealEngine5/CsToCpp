namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Protocols/VideoCaptureProtocol.h")]
public partial class UVideoCaptureProtocol : UFrameGrabberProtocol {
	public static UClass StaticClass() {return default;}
	///<summary>bUseCompression</summary>
	public bool bUseCompression;
	///<summary>CompressionQuality</summary>
	public float CompressionQuality;
}
