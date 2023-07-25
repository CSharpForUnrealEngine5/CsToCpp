#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigHierarchyElements.h")]
public partial struct FRigHierarchyCopyPasteContentPerElement {
// RigHierarchyCopyPasteContentPerElement
	public FRigElementKey Key;
	public string Content;
	public TArray<FRigElementKey> Parents;
	public TArray<FRigElementWeight> ParentWeights;
	public FRigCurrentAndInitialTransform Pose;
}
