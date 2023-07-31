#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigHierarchy.h")]
public partial struct FRigTransformStackEntry {
	public FRigElementKey Key;
	public ERigTransformStackEntryType EntryType;
	public ERigTransformType TransformType;
	public FTransform OldTransform;
	public FTransform NewTransform;
	public bool bAffectChildren;
	public TArray<string> Callstack;
}
