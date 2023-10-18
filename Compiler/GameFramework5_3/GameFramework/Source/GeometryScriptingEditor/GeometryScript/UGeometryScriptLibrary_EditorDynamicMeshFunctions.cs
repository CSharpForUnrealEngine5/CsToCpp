namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/EditorDynamicMeshUtilityFunctions.h")]
public partial class UGeometryScriptLibrary_EditorDynamicMeshFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Save current state of TargetMesh so that an undoable/redoable Change can be emitted</summary>
	public static UDynamicMesh BeginTrackedMeshChange(UDynamicMesh TargetMesh,FDynamicMeshChangeContainer ChangeTracker) { return default; }
	///<summary>Emit an undo/redo Change for a modified TargetMesh, based on the ChangeTracker information that was</summary>
	public static UDynamicMesh EmitTrackedMeshChange(UDynamicMesh TargetMesh,FDynamicMeshChangeContainer ChangeTracker) { return default; }
	///<summary>Store a copy of TargetMesh with name DebugMeshName.</summary>
	public static UDynamicMesh StashDebugMesh(UDynamicMesh TargetMesh,string DebugMeshName) { return default; }
	///<summary>Fetch a debug FDynamicMesh3 saved with DebugMeshName from the global debug mesh storage and copy to ToTargetMesh.</summary>
	public static UDynamicMesh FetchDebugMesh(string DebugMeshName,UDynamicMesh ToTargetMesh,bool bClearDebugMesh,bool bDebugMeshExists) { return default; }
}
