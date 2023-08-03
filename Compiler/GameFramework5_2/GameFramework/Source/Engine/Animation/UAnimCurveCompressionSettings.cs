#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* This object is used to wrap a curve compression codec. It allows a clean integration in the editor by avoiding the need</summary>
[CppInclude("Animation/AnimCurveCompressionSettings.h")]
public partial class UAnimCurveCompressionSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>An animation curve compression codec.</summary>
	public UAnimCurveCompressionCodec Codec;
}
