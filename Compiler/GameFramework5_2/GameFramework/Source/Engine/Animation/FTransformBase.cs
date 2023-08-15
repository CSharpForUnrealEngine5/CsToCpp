namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is a mapping table between bone in a particular skeletal mesh and bone of this skeleton set.</summary>
[CppInclude("Animation/Rig.h")]
public partial struct FTransformBase {
	public FName Node;
	public FTransformBaseConstraint Constraints;
}
