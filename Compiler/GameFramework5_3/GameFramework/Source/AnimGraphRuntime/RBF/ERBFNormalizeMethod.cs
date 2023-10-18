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
