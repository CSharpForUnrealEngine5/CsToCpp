namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterBodyRiverActor.h")]
public partial class AWaterBodyRiver : AWaterBody {
	public static UClass StaticClass() {return default;}
	///<summary>RiverGenerator_DEPRECATED</summary>
	public UDEPRECATED_RiverGenerator RiverGenerator_DEPRECATED;
	///<summary>Material used when a river is overlapping a lake.</summary>
	public UMaterialInterface LakeTransitionMaterial_DEPRECATED;
	///<summary>LakeTransitionMID_DEPRECATED</summary>
	public UMaterialInstanceDynamic LakeTransitionMID_DEPRECATED;
	///<summary>This is the material used when a river is overlapping the ocean.</summary>
	public UMaterialInterface OceanTransitionMaterial_DEPRECATED;
	///<summary>OceanTransitionMID_DEPRECATED</summary>
	public UMaterialInstanceDynamic OceanTransitionMID_DEPRECATED;
}
