namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DeformMeshPolygonsTool.h")]
public partial class UDeformMeshPolygonsTool : UMeshSurfacePointTool {
	public static UClass StaticClass() {return default;}
	///<summary>PreviewMeshActor</summary>
	public AInternalToolFrameworkActor PreviewMeshActor;
	///<summary>DynamicMeshComponent</summary>
	public UDynamicMeshComponent DynamicMeshComponent;
	///<summary>TransformProps</summary>
	public UDeformMeshPolygonsTransformProperties TransformProps;
}
