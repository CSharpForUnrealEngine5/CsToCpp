namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Base class for all bone compression codecs.</summary>
[CppInclude("Animation/AnimBoneCompressionCodec.h")]
public partial class UAnimBoneCompressionCodec : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Description for this codec.</summary>
	public string Description;
}
