#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UPreviewMesh is a utility object that spawns and owns a transient mesh object in the World.</summary>
[CppInclude("PreviewMesh.h")]
public partial class UPreviewMesh : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>If true, we build a spatial data structure internally for the preview mesh, which allows for hit-testing</summary>
	public bool bBuildSpatialDataStructure;
	///<summary>This component is set as the root component of TemporaryParentActor</summary>
	public UDynamicMeshComponent DynamicMeshComponent;
}
