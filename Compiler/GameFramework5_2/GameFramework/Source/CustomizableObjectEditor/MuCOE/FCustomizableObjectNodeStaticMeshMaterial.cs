#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeStaticMesh.h")]
public partial struct FCustomizableObjectNodeStaticMeshMaterial {
	public string Name;
	public UEdGraphPin_Deprecated MeshPin;
	public UEdGraphPin_Deprecated LayoutPin;
	public TArray<UEdGraphPin_Deprecated> ImagePins;
	public FEdGraphPinReference MeshPinRef;
	public FEdGraphPinReference LayoutPinRef;
	public TArray<FEdGraphPinReference> ImagePinsRef;
}
