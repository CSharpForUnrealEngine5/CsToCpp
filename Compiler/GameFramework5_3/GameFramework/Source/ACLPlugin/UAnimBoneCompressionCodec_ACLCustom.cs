namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Uses the open source Animation Compression Library with custom settings suitable for debugging purposes.</summary>
[CppInclude("AnimBoneCompressionCodec_ACLCustom.h")]
public partial class UAnimBoneCompressionCodec_ACLCustom : UAnimBoneCompressionCodec_ACLBase {
	public static UClass StaticClass() {return default;}
	///<summary>The rotation format to use.</summary>
	public ACLRotationFormat RotationFormat;
	///<summary>The translation format to use.</summary>
	public ACLVectorFormat TranslationFormat;
	///<summary>The scale format to use.</summary>
	public ACLVectorFormat ScaleFormat;
	///<summary>The threshold used to detect constant rotation tracks.</summary>
	public float ConstantRotationThresholdAngle;
	///<summary>The threshold used to detect constant translation tracks.</summary>
	public float ConstantTranslationThreshold;
	///<summary>The threshold used to detect constant scale tracks.</summary>
	public float ConstantScaleThreshold;
	///<summary>The skeletal meshes used to estimate the skinning deformation during compression.</summary>
	public TArray<USkeletalMesh> OptimizationTargets;
}
