#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RBF/RBFSolver.h")]
///<summary>Function to use for each target falloff</summary>
public enum ERBFFunctionType {
	Gaussian=0,
	Exponential=1,
	Linear=2,
	Cubic=3,
	Quintic=4,
	DefaultFunction=5,
}
