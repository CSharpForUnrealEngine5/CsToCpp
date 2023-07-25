#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterBodyOceanComponent.h")]
public partial class UWaterBodyOceanComponent : UWaterBodyComponent {
// WaterBodyOceanComponent
	public TArray<UOceanBoxCollisionComponent> CollisionBoxes;
	public TArray<UOceanCollisionComponent> CollisionHullSets;
	public FVector2D VisualExtents_DEPRECATED;
	public FVector CollisionExtents;
	public float HeightOffset;
}
