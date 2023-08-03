#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineHighResSetting.h")]
public partial class UMoviePipelineHighResSetting : UMoviePipelineSetting {
	public static UClass StaticClass() {return default;}
	///<summary>How many tiles should the resulting movie render be broken into? A tile should be no larger than</summary>
	public int TileCount;
	///<summary>This bias encourages the engine to use a higher detail texture when it would normally use a lower detail</summary>
	public float TextureSharpnessBias;
	///<summary>How much should each tile overlap each other (0-0.5). Decreasing the overlap will result in smaller individual</summary>
	public float OverlapRatio;
	///<summary>Sub Surface Scattering relies on history which is not available when using tiling. This can be overriden to use more samples</summary>
	public bool bOverrideSubSurfaceScattering;
	///<summary>* How many samples should the Burley Sub Surface Scattering use?</summary>
	public int BurleySampleCount;
	///<summary>* If true, allocate a unique history for each tile. This is needed to make some render features work, but should be disabled</summary>
	public bool bAllocateHistoryPerTile;
}
