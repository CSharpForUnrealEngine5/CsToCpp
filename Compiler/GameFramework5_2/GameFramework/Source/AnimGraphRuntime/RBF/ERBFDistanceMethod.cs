#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RBF/RBFSolver.h")]
///<summary>Method for determining distance from input to targets</summary>
public enum ERBFDistanceMethod {
	Euclidean=0,
	Quaternion=1,
	SwingAngle=2,
	TwistAngle=3,
	DefaultMethod=4,
}
