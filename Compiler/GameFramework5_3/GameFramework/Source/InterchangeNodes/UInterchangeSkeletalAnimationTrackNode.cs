namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Class to hold onto the relationships between a set of animation tracks and the bones, morph targets of a skeleton.</summary>
[CppInclude("InterchangeAnimationTrackSetNode.h")]
public partial class UInterchangeSkeletalAnimationTrackNode : UInterchangeAnimationTrackBaseNode {
	public static UClass StaticClass() {return default;}
	///<summary>Get the skeleton factory node unique id. Return false if the attribute is not set.</summary>
	public bool GetCustomSkeletonNodeUid(string AttributeValue) { return default; }
	///<summary>Set the skeleton factory node unique id. Return false if the attribute cannot be set.</summary>
	public bool SetCustomSkeletonNodeUid(string AttributeValue) { return default; }
	///<summary>Set the animation sample rate. Return false if the attribute cannot be set.</summary>
	public bool SetCustomAnimationSampleRate(double SampleRate) { return default; }
	///<summary>Get the animation sample rate. Return false if the attribute is not set.</summary>
	public bool GetCustomAnimationSampleRate(double SampleRate) { return default; }
	///<summary>Set the animation start time. Return false if the attribute cannot be set.</summary>
	public bool SetCustomAnimationStartTime(double StartTime) { return default; }
	///<summary>Get the animation start time. Return false if the attribute is not set.</summary>
	public bool GetCustomAnimationStartTime(double StartTime) { return default; }
	///<summary>Set the animation stop time. Return false if the attribute cannot be set.</summary>
	public bool SetCustomAnimationStopTime(double StopTime) { return default; }
	///<summary>Get the animation stop time. Return false if the attribute is not set.</summary>
	public bool GetCustomAnimationStopTime(double StopTime) { return default; }
	///<summary>GetSceneNodeAnimationPayloadKeys</summary>
	public void GetSceneNodeAnimationPayloadKeys(TMap<string,string> OutSceneNodeAnimationPayloadKeyUids,TMap<string,byte> OutSceneNodeAnimationPayloadKeyTypes) {}
	///<summary>SetAnimationPayloadKeyForSceneNodeUid</summary>
	public bool SetAnimationPayloadKeyForSceneNodeUid(string SceneNodeUid,string InUniqueId,EInterchangeAnimationPayLoadType InType) { return default; }
	///<summary>GetMorphTargetNodeAnimationPayloadKeys</summary>
	public void GetMorphTargetNodeAnimationPayloadKeys(TMap<string,string> OutMorphTargetNodeAnimationPayloadKeyUids,TMap<string,byte> OutMorphTargetNodeAnimationPayloadKeyTypes) {}
	///<summary>SetAnimationPayloadKeyForMorphTargetNodeUid</summary>
	public bool SetAnimationPayloadKeyForMorphTargetNodeUid(string MorphTargetNodeUid,string InUniqueId,EInterchangeAnimationPayLoadType InType) { return default; }
}
