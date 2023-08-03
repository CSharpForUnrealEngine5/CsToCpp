#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/EditorDynamicMeshUtilityFunctions.h")]
public partial class UGeometryScriptLibrary_EditorDynamicMeshFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Save current state of TargetMesh so that an undoable/redoable Change can be emitted</summary>
	public static UDynamicMesh BeginTrackedMeshChange(UDynamicMesh TargetMesh,FDynamicMeshChangeContainer ChangeTracker) { return default; }
	///<summary>Emit an undo/redo Change for a modified TargetMesh, based on the ChangeTracker information that was</summary>
	public static UDynamicMesh EmitTrackedMeshChange(UDynamicMesh TargetMesh,FDynamicMeshChangeContainer ChangeTracker) { return default; }
}
