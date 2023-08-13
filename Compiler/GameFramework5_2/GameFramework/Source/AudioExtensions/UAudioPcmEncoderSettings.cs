namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PcmCodec.h")]
public partial class UAudioPcmEncoderSettings : UAudioCodecEncoderSettings {
	public static UClass StaticClass() {return default;}
	///<summary>BitDepthConversion</summary>
	public EPcmBitDepthConversion BitDepthConversion;
}
