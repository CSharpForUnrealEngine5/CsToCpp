namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GizmoEdMode.h")]
public partial class UGizmoEdMode : UEdMode {
	public static UClass StaticClass() {return default;}
	///<summary>GizmoFactories</summary>
	public TArray<object /*GizmoFactories*/> GizmoFactories;
	///<summary>InteractiveGizmos</summary>
	public TArray<UInteractiveGizmo> InteractiveGizmos;
}
