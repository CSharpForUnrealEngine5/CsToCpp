namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple Component intended to be used as part of 3D Gizmos.</summary>
[CppInclude("BaseGizmos/GizmoArrowComponent.h")]
public partial class UGizmoArrowComponent : UGizmoBaseComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Direction</summary>
	public FVector Direction;
	///<summary>Gap</summary>
	public float Gap;
	///<summary>Length</summary>
	public float Length;
	///<summary>Thickness</summary>
	public float Thickness;
}
