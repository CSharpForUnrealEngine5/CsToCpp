#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Protocols/ImageSequenceProtocol.h")]
public partial class UCompressedImageSequenceProtocol : UImageSequenceProtocol {
	public static UClass StaticClass() {return default;}
	///<summary>Level of compression to apply to the image, between 1 (worst quality, best compression) and 100 (best quality, worst compression)</summary>
	public int CompressionQuality;
}
