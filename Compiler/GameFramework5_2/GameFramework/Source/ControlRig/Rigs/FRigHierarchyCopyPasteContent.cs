#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigHierarchyElements.h")]
public partial struct FRigHierarchyCopyPasteContent {
	public TArray<FRigHierarchyCopyPasteContentPerElement> Elements;
	public TArray<ERigElementType> Types;
	public TArray<string> Contents;
	public TArray<FTransform> LocalTransforms;
	public TArray<FTransform> GlobalTransforms;
}
