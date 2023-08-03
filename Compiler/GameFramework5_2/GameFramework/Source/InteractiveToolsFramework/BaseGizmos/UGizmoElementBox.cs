#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple object intended to be used as part of 3D Gizmos.</summary>
[CppInclude("BaseGizmos/GizmoElementBox.h")]
public partial class UGizmoElementBox : UGizmoElementBase {
	public static UClass StaticClass() {return default;}
	///<summary>Location of center of box</summary>
	public FVector Center;
	///<summary>Box dimensions</summary>
	public FVector Dimensions;
	///<summary>Box up axis, corresponds to Z dimension</summary>
	public FVector UpDirection;
	///<summary>Box side axis, corresponds to Y dimension</summary>
	public FVector SideDirection;
}
