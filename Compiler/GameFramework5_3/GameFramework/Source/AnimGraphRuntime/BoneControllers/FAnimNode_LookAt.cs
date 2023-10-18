namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple controller that make a bone to look at the point or another bone</summary>
[CppInclude("BoneControllers/AnimNode_LookAt.h")]
public partial struct FAnimNode_LookAt {
	public FBoneReference BoneToModify;
	public FBoneSocketTarget LookAtTarget;
	public FVector LookAtLocation;
	public FAxis LookAt_Axis;
	public bool bUseLookUpAxis;
	public EInterpolationBlend InterpolationType;
	public FAxis LookUp_Axis;
	public float LookAtClamp;
	public float InterpolationTime;
	public float InterpolationTriggerThreashold;
	public FBoneReference LookAtBone_DEPRECATED;
	public FName LookAtSocket_DEPRECATED;
	public EAxisOption LookAtAxis_DEPRECATED;
	public FVector CustomLookAtAxis_DEPRECATED;
	public EAxisOption LookUpAxis_DEPRECATED;
	public FVector CustomLookUpAxis_DEPRECATED;
}
