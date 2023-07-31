#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameters used by RBF solver</summary>
[CppInclude("RBF/RBFSolver.h")]
public partial struct FRBFParams {
	public int TargetDimensions;
	public ERBFSolverType SolverType;
	public float Radius;
	public bool bAutomaticRadius;
	public ERBFFunctionType Function;
	public ERBFDistanceMethod DistanceMethod;
	public EBoneAxis TwistAxis;
	public float WeightThreshold;
	public ERBFNormalizeMethod NormalizeMethod;
	public FVector MedianReference;
	public float MedianMin;
	public float MedianMax;
}
