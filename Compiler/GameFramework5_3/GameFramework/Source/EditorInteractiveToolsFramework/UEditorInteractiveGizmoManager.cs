namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UEditorInteractiveGizmoManager allows users of the Tools framework to register and create selection-based Gizmo instances.</summary>
[CppInclude("EditorInteractiveGizmoManager.h")]
public partial class UEditorInteractiveGizmoManager : UInteractiveGizmoManager {
	public static UClass StaticClass() {return default;}
	///<summary>Actual registry</summary>
	public UEditorInteractiveGizmoRegistry Registry;
	///<summary>set of Currently-active Gizmos</summary>
	public TArray<FActiveEditorGizmo> ActiveEditorGizmos;
	///<summary>Cache for already built gizmos, currently this only caches the transform</summary>
	public TMap<UInteractiveGizmoBuilder,UInteractiveGizmo> CachedGizmoMap;
}
