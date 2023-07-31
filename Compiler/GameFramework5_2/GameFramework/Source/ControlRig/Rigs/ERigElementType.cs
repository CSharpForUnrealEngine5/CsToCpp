#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigHierarchyDefines.h")]
///<summary>* This is rig element types that we support</summary>
public enum ERigElementType {
	None=0,
	Bone=1,
	Null=2,
	Space=-1,
	Control=4,
	Curve=8,
	RigidBody=16,
	Reference=32,
	Last=64,
	All=-1,
	ToResetAfterConstructionEvent=-1,
}
