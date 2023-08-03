#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimCompress.h")]
public partial class UAnimCompress : UAnimBoneCompressionCodec {
	public static UClass StaticClass() {return default;}
	///<summary>Compression algorithms requiring a skeleton should set this value to true.</summary>
	public bool bNeedsSkeleton;
	///<summary>Format for bitwise compression of translation data.</summary>
	public AnimationCompressionFormat TranslationCompressionFormat;
	///<summary>Format for bitwise compression of rotation data.</summary>
	public AnimationCompressionFormat RotationCompressionFormat;
	///<summary>Format for bitwise compression of scale data.</summary>
	public AnimationCompressionFormat ScaleCompressionFormat;
}
