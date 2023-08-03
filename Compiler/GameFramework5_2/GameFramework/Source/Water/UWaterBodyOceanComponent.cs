#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterBodyOceanComponent.h")]
public partial class UWaterBodyOceanComponent : UWaterBodyComponent {
	public static UClass StaticClass() {return default;}
	///<summary>CollisionBoxes</summary>
	public TArray<UOceanBoxCollisionComponent> CollisionBoxes;
	///<summary>CollisionHullSets</summary>
	public TArray<UOceanCollisionComponent> CollisionHullSets;
	///<summary>VisualExtents_DEPRECATED</summary>
	public FVector2D VisualExtents_DEPRECATED;
	///<summary>CollisionExtents</summary>
	public FVector CollisionExtents;
	///<summary>HeightOffset</summary>
	public float HeightOffset;
}
