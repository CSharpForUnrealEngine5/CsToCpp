namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableInstancePrivateData.h")]
public partial struct FCustomizableInstanceComponentData {
	public TMap<FName,TSoftObjectPtr<UClass>> AnimSlotToBP;
	public FReferencedSkeletons Skeletons;
	public FReferencedPhysicsAssets PhysicsAssets;
}
