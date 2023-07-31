#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/BoneControllerSolvers.h")]
public partial struct FIKFootPelvisPullDownSolver {
	public FVectorRK4SpringInterpolator PelvisAdjustmentInterp;
	public double PelvisAdjustmentInterpAlpha;
	public double PelvisAdjustmentMaxDistance;
	public double PelvisAdjustmentErrorTolerance;
	public int PelvisAdjustmentMaxIter;
}
