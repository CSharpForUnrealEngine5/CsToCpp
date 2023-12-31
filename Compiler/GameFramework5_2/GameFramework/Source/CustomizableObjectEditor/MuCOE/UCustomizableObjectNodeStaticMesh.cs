namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeStaticMesh.h")]
public partial class UCustomizableObjectNodeStaticMesh : UCustomizableObjectNodeMesh {
	public static UClass StaticClass() {return default;}
	///<summary>StaticMesh</summary>
	public UStaticMesh StaticMesh;
	///<summary>Images</summary>
	public TArray<FCustomizableObjectNodeStaticMeshLOD> LODs;
	///<summary>Default pin when there is no mesh.</summary>
	public FEdGraphPinReference DefaultPin;
}
