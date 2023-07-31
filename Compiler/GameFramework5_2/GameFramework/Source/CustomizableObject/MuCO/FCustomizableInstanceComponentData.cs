#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableInstancePrivateData.h")]
public partial struct FCustomizableInstanceComponentData {
	public TMap<int,TSoftObjectPtr<UClass>> AnimSlotToBP;
	public FReferencedSkeletons Skeletons;
	public FReferencedPhysicsAssets PhysicsAssets;
}
