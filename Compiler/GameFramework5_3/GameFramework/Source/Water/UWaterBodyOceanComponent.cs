namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterBodyOceanComponent.h")]
public partial class UWaterBodyOceanComponent : UWaterBodyComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Rebuilds the ocean mesh to completely fill the zone to which it belongs.</summary>
	public void FillWaterZoneWithOcean() {}
	///<summary>CollisionBoxes</summary>
	public TArray<UOceanBoxCollisionComponent> CollisionBoxes;
	///<summary>CollisionHullSets</summary>
	public TArray<UOceanCollisionComponent> CollisionHullSets;
	///<summary>CollisionExtents</summary>
	public FVector CollisionExtents;
	///<summary>The extent of the ocean, centered around water zone to which the ocean belongs.</summary>
	public FVector2D OceanExtents;
	///<summary>Saved water zone location so that the ocean mesh can be regenerated relative to it and match it perfectly without being loaded.</summary>
	public FVector2D SavedZoneLocation;
	///<summary>HeightOffset</summary>
	public float HeightOffset;
	///<summary>VisualExtents_DEPRECATED</summary>
	public FVector2D VisualExtents_DEPRECATED;
}
