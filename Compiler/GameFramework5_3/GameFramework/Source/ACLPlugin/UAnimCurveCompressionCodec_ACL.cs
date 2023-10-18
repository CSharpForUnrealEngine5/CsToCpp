namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Uses the open source Animation Compression Library with default settings suitable for general purpose animation curves.</summary>
[CppInclude("AnimCurveCompressionCodec_ACL.h")]
public partial class UAnimCurveCompressionCodec_ACL : UAnimCurveCompressionCodec {
	public static UClass StaticClass() {return default;}
	///<summary>The curve precision to target when compressing the animation curves.</summary>
	public float CurvePrecision;
	///<summary>The mesh deformation precision to target when compressing morph target animation curves.</summary>
	public float MorphTargetPositionPrecision;
	///<summary>The skeletal mesh used to estimate the morph target deformation during compression.</summary>
	public USkeletalMesh MorphTargetSource;
}
