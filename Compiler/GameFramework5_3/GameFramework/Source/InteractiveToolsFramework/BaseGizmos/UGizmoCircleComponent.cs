namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple Component intended to be used as part of 3D Gizmos.</summary>
[CppInclude("BaseGizmos/GizmoCircleComponent.h")]
public partial class UGizmoCircleComponent : UGizmoBaseComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Normal</summary>
	public FVector Normal;
	///<summary>Radius</summary>
	public float Radius;
	///<summary>Thickness</summary>
	public float Thickness;
	///<summary>NumSides</summary>
	public int NumSides;
	///<summary>bViewAligned</summary>
	public bool bViewAligned;
	///<summary>bDrawFullCircle</summary>
	public bool bDrawFullCircle;
	///<summary>If the circle was on a 3D sphere, then only the &#39;front&#39; part of the circle can be hit,</summary>
	public bool bOnlyAllowFrontFacingHits;
}
