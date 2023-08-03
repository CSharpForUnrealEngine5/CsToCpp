#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple Component intended to be used as part of 3D Gizmos.</summary>
[CppInclude("BaseGizmos/GizmoLineHandleComponent.h")]
public partial class UGizmoLineHandleComponent : UGizmoBaseComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Normal</summary>
	public FVector Normal;
	///<summary>HandleSize</summary>
	public float HandleSize;
	///<summary>Thickness</summary>
	public float Thickness;
	///<summary>Direction</summary>
	public FVector Direction;
	///<summary>Length</summary>
	public float Length;
	///<summary>bImageScale</summary>
	public bool bImageScale;
}
