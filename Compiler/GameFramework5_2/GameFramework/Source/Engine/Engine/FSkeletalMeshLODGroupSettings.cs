namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SkeletalMeshLODSettings.h")]
public partial struct FSkeletalMeshLODGroupSettings {
	public FPerPlatformFloat ScreenSize;
	public float LODHysteresis;
	public EBoneFilterActionOption BoneFilterActionOption;
	public TArray<FBoneFilter> BoneList;
	public TArray<string> BonesToPrioritize;
	public TArray<int> SectionsToPrioritize;
	public float WeightOfPrioritization;
	public UAnimSequence BakePose;
	public FSkeletalMeshOptimizationSettings ReductionSettings;
}
