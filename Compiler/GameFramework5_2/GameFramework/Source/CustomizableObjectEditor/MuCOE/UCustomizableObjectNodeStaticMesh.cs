#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeStaticMesh.h")]
public partial class UCustomizableObjectNodeStaticMesh : UCustomizableObjectNodeMesh {
	///<summary>StaticMesh</summary>
	public UStaticMesh StaticMesh;
	///<summary>Images</summary>
	public TArray<FCustomizableObjectNodeStaticMeshLOD> LODs;
	///<summary>Default pin when there is no mesh.</summary>
	public FEdGraphPinReference DefaultPin;
}
