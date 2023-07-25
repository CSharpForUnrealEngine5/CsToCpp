#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/BoneControllerSolvers.h")]
public partial struct FIKFootPelvisPullDownSolver {
// IKFootPelvisPullDownSolver
	public FVectorRK4SpringInterpolator PelvisAdjustmentInterp;
	public double PelvisAdjustmentInterpAlpha;
	public double PelvisAdjustmentMaxDistance;
	public double PelvisAdjustmentErrorTolerance;
	public int PelvisAdjustmentMaxIter;
}
