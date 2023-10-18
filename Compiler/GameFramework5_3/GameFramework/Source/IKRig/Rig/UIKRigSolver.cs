namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>this is the base class for creating your own solver type that integrates into the IK Rig framework/editor.</summary>
[CppInclude("Rig/Solvers/IKRigSolver.h")]
public partial class UIKRigSolver : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>bIsEnabled</summary>
	public bool bIsEnabled;
}
