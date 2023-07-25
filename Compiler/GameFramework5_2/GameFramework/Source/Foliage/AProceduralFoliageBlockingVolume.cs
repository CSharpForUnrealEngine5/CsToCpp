#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ProceduralFoliageBlockingVolume.h")]
///<summary>An invisible volume used to block ProceduralFoliage instances from being spawned.</summary>
public partial class AProceduralFoliageBlockingVolume : AVolume {
// ProceduralFoliageBlockingVolume
	public AProceduralFoliageVolume ProceduralFoliageVolume;
	public FFoliageDensityFalloff DensityFalloff;
}
