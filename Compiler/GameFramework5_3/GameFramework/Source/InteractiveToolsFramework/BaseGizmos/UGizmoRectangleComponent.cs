namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple Component intended to be used as part of 3D Gizmos.</summary>
[CppInclude("BaseGizmos/GizmoRectangleComponent.h")]
public partial class UGizmoRectangleComponent : UGizmoBaseComponent {
	public static UClass StaticClass() {return default;}
	///<summary>DirectionX</summary>
	public FVector DirectionX;
	///<summary>DirectionY</summary>
	public FVector DirectionY;
	///<summary>When true, instead of using the provided DirectionY, the component will</summary>
	public bool bOrientYAccordingToCamera;
	///<summary>OffsetX</summary>
	public float OffsetX;
	///<summary>OffsetY</summary>
	public float OffsetY;
	///<summary>LengthX</summary>
	public float LengthX;
	///<summary>LengthY</summary>
	public float LengthY;
	///<summary>Thickness</summary>
	public float Thickness;
	///<summary>SegmentFlags</summary>
	public byte SegmentFlags;
}
