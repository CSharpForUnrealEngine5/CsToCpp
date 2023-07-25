#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeStaticMesh.h")]
public partial class UCustomizableObjectNodeStaticMesh : UCustomizableObjectNodeMesh {
// CustomizableObjectNodeStaticMesh
	public UStaticMesh StaticMesh;
	public TArray<FCustomizableObjectNodeStaticMeshLOD> LODs;
	public FEdGraphPinReference DefaultPin;
}
