#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UInteractiveGizmoManager allows users of the Tools framework to create and operate Gizmo instances.</summary>
[CppInclude("InteractiveGizmoManager.h")]
public partial class UInteractiveGizmoManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>set of Currently-active Gizmos</summary>
	public TArray<FActiveGizmo> ActiveGizmos;
	///<summary>Current set of named GizmoBuilders</summary>
	public TMap<string,UInteractiveGizmoBuilder> GizmoBuilders;
}
