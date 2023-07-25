#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigHierarchyElements.h")]
public partial struct FRigHierarchyCopyPasteContent {
// RigHierarchyCopyPasteContent
	public TArray<FRigHierarchyCopyPasteContentPerElement> Elements;
	public TArray<ERigElementType> Types;
	public TArray<string> Contents;
	public TArray<FTransform> LocalTransforms;
	public TArray<FTransform> GlobalTransforms;
}
