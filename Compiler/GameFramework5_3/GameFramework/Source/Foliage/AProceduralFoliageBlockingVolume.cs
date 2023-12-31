namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An invisible volume used to block ProceduralFoliage instances from being spawned.</summary>
[CppInclude("ProceduralFoliageBlockingVolume.h")]
public partial class AProceduralFoliageBlockingVolume : AVolume {
	public static UClass StaticClass() {return default;}
	///<summary>ProceduralFoliageVolume</summary>
	public AProceduralFoliageVolume ProceduralFoliageVolume;
	///<summary>DensityFalloff</summary>
	public FFoliageDensityFalloff DensityFalloff;
}
