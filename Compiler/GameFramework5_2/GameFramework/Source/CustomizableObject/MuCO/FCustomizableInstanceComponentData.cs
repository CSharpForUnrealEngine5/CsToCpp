#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableInstancePrivateData.h")]
public partial struct FCustomizableInstanceComponentData {
// CustomizableInstanceComponentData
	public TMap<int,TSoftObjectPtr<UClass>> AnimSlotToBP;
	public FReferencedSkeletons Skeletons;
	public FReferencedPhysicsAssets PhysicsAssets;
}
