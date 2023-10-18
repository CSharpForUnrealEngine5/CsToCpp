namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UMeshSurfacePointTool is a base Tool implementation that can be used to implement various</summary>
[CppInclude("BaseTools/MeshSurfacePointTool.h")]
public partial class UMeshSurfacePointTool : USingleSelectionTool {
	public static UClass StaticClass() {return default;}
	///<summary>TargetWorld</summary>
	public TWeakObjectPtr<UWorld> TargetWorld;
}
