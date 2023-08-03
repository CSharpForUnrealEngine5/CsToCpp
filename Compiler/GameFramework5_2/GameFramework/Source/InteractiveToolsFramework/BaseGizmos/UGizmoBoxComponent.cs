#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple Component intended to be used as part of 3D Gizmos.</summary>
[CppInclude("BaseGizmos/GizmoBoxComponent.h")]
public partial class UGizmoBoxComponent : UGizmoBaseComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Origin</summary>
	public FVector Origin;
	///<summary>Rotation</summary>
	public FQuat Rotation;
	///<summary>Dimensions</summary>
	public FVector Dimensions;
	///<summary>LineThickness</summary>
	public float LineThickness;
	///<summary>bRemoveHiddenLines</summary>
	public bool bRemoveHiddenLines;
	///<summary>bEnableAxisFlip</summary>
	public bool bEnableAxisFlip;
}
