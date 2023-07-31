#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_AnimDynamics.h")]
public partial class UAnimGraphNode_AnimDynamics : UAnimGraphNode_SkeletalControlBase {
	///<summary>Node</summary>
	public FAnimNode_AnimDynamics Node;
	///<summary>Preview the live physics object on the mesh</summary>
	public bool bPreviewLive;
	///<summary>Show linear (prismatic) limits in the viewport</summary>
	public bool bShowLinearLimits;
	///<summary>Show angular limit ranges in the viewport</summary>
	public bool bShowAngularLimits;
	///<summary>Show planar limit info (actual plane, plane normal) in the viewport</summary>
	public bool bShowPlanarLimit;
	///<summary>Show spherical limits in the viewport (preview live only)</summary>
	public bool bShowSphericalLimit;
	///<summary>If planar limits are enabled and the collision mode isn&#39;t CoM, draw sphere collision sizes</summary>
	public bool bShowCollisionSpheres;
}
