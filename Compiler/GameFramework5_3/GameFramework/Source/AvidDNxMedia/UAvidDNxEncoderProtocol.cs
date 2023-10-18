namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AvidDNxEncoderProtocol.h")]
public partial class UAvidDNxEncoderProtocol : UFrameGrabberProtocol {
	public static UClass StaticClass() {return default;}
	///<summary>bUncompressed</summary>
	public bool bUncompressed;
	///<summary>NumberOfEncodingThreads</summary>
	public byte NumberOfEncodingThreads;
}
