namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EncodeRootBoneModifier.h")]
public partial class UEncodeRootBoneModifier : UAnimationModifier {
	public static UClass StaticClass() {return default;}
	///<summary>WeightedBoneToComputeRootPosition</summary>
	public TArray<FEncodeRootBoneWeightedBone> WeightedBoneToComputeRootPosition;
	///<summary>WeightedBoneToComputeRootOrientation</summary>
	public TArray<FEncodeRootBoneWeightedBoneAxis> WeightedBoneToComputeRootOrientation;
}
