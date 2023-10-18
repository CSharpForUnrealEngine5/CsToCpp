namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterBodyRiverComponent.h")]
public partial class UWaterBodyRiverComponent : UWaterBodyComponent {
	public static UClass StaticClass() {return default;}
	///<summary>SplineMeshComponents</summary>
	public TArray<USplineMeshComponent> SplineMeshComponents;
	///<summary>Material used when a river is overlapping a lake.</summary>
	public UMaterialInterface LakeTransitionMaterial;
	///<summary>LakeTransitionMID</summary>
	public UMaterialInstanceDynamic LakeTransitionMID;
	///<summary>This is the material used when a river is overlapping the ocean.</summary>
	public UMaterialInterface OceanTransitionMaterial;
	///<summary>OceanTransitionMID</summary>
	public UMaterialInstanceDynamic OceanTransitionMID;
}
