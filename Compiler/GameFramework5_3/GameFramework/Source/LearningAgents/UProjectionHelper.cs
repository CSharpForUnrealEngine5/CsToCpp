namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A helper for projecting onto surfaces.</summary>
[CppInclude("LearningAgentsHelpers.h")]
public partial class UProjectionHelper : ULearningAgentsHelper {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new projection helper to the given manager component.</summary>
	public static UProjectionHelper AddProjectionHelper(ULearningAgentsManagerComponent InManagerComponent,FName Name/*=NAME_None*/) { return default; }
	///<summary>Projects a transform onto the zero height ground plane resulting in translation only in XY and rotation only around the Z.</summary>
	public FTransform ProjectTransformOntoGroundPlane(int AgentId,FTransform Transform,FVector LocalForwardVector/*=FVector.ForwardVector*/) { return default; }
	///<summary>Projects a position and rotation onto the zero height ground plane resulting in translation only in XY and rotation only around the Z.</summary>
	public void ProjectPositionRotationOntoGroundPlane(FVector OutPosition,FRotator OutRotation,int AgentId,FVector InPosition,FRotator InRotation,FVector LocalForwardVector/*=FVector.ForwardVector*/) {}
}
