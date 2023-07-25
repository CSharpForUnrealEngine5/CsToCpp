#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterBodyRiverComponent.h")]
public partial class UWaterBodyRiverComponent : UWaterBodyComponent {
// WaterBodyRiverComponent
	public TArray<USplineMeshComponent> SplineMeshComponents;
	public UMaterialInterface LakeTransitionMaterial;
	public UMaterialInstanceDynamic LakeTransitionMID;
	public UMaterialInterface OceanTransitionMaterial;
	public UMaterialInstanceDynamic OceanTransitionMID;
}
