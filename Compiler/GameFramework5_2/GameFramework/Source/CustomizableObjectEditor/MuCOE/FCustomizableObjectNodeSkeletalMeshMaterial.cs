#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeSkeletalMesh.h")]
public partial struct FCustomizableObjectNodeSkeletalMeshMaterial {
	public string Name;
	public UEdGraphPin_Deprecated MeshPin;
	public TArray<UEdGraphPin_Deprecated> LayoutPins;
	public TArray<UEdGraphPin_Deprecated> ImagePins;
	public FEdGraphPinReference MeshPinRef;
	public TArray<FEdGraphPinReference> LayoutPinsRef;
	public TArray<FEdGraphPinReference> ImagePinsRef;
}
