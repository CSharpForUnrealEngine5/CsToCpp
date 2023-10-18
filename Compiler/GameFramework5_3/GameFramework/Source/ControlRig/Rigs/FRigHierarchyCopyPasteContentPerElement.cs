namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigHierarchyElements.h")]
public partial struct FRigHierarchyCopyPasteContentPerElement {
	public FRigElementKey Key;
	public string Content;
	public TArray<FRigElementKey> Parents;
	public TArray<FRigElementWeight> ParentWeights;
	public FRigCurrentAndInitialTransform Pose;
}
