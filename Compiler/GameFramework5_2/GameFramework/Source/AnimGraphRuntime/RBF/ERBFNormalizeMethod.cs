#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RBF/RBFSolver.h")]
///<summary>Method to normalize weights</summary>
public enum ERBFNormalizeMethod {
	OnlyNormalizeAboveOne=0,
	AlwaysNormalize=1,
	NormalizeWithinMedian=2,
	NoNormalization=3,
}
