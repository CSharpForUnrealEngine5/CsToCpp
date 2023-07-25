#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigHierarchy.h")]
public partial struct FRigTransformStackEntry {
// RigTransformStackEntry
	public FRigElementKey Key;
	public byte EntryType;
	public byte TransformType;
	public FTransform OldTransform;
	public FTransform NewTransform;
	public bool bAffectChildren;
	public TArray<string> Callstack;
}
