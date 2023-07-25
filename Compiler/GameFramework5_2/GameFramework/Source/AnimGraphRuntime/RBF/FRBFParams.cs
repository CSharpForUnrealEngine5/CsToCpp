#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RBF/RBFSolver.h")]
///<summary>Parameters used by RBF solver</summary>
public partial struct FRBFParams {
// RBFParams
	public int TargetDimensions;
	public ERBFSolverType SolverType;
	public float Radius;
	public bool bAutomaticRadius;
	public ERBFFunctionType Function;
	public ERBFDistanceMethod DistanceMethod;
	public byte TwistAxis;
	public float WeightThreshold;
	public ERBFNormalizeMethod NormalizeMethod;
	public FVector MedianReference;
	public float MedianMin;
	public float MedianMax;
}
