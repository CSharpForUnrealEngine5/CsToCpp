#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavCorridor.h")]
public partial struct FNavCorridorParams {
// NavCorridorParams
	public float Width;
	public float ObstacleTaperAngle;
	public float SmallSectorThreshold;
	public float LargeSectorThreshold;
	public float SimplifyEdgeThreshold;
	public bool bSimplifyFlipPortals;
	public bool bSimplifyConvexPortals;
	public bool bSimplifyConcavePortals;
}
