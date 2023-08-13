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
	///<summary>Get the skeletal mesh node unique id. Return false if the attribute is not set.</summary>
	public bool GetCustomSkeletalMeshNodeUid(string AttributeValue) { return default; }
	///<summary>Set the skeletal mesh node unique id. Return false if the attribute cannot be set.</summary>
	public bool SetCustomSkeletalMeshNodeUid(string AttributeValue) { return default; }
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
	public void GetSceneNodeAnimationPayloadKeys(TMap<string,string> OutSceneNodeAnimationPayloadKeys) {}
	///<summary>GetAnimationPayloadKeyFromSceneNodeUid</summary>
	public bool GetAnimationPayloadKeyFromSceneNodeUid(string SceneNodeUid,string OutPayloadKey) { return default; }
	///<summary>SetAnimationPayloadKeyForSceneNodeUid</summary>
	public bool SetAnimationPayloadKeyForSceneNodeUid(string SceneNodeUid,string PayloadKey) { return default; }
	///<summary>RemoveAnimationPayloadKeyForSceneNodeUid</summary>
	public bool RemoveAnimationPayloadKeyForSceneNodeUid(string SceneNodeUid) { return default; }
	///<summary>GetMorphTargetNodeAnimationPayloadKeys</summary>
	public void GetMorphTargetNodeAnimationPayloadKeys(TMap<string,string> OutMorphTargetNodeAnimationPayloads) {}
	///<summary>GetAnimationPayloadKeyFromMorphTargetNodeUid</summary>
	public bool GetAnimationPayloadKeyFromMorphTargetNodeUid(string MorphTargetNodeUid,string OutPayloadKey) { return default; }
	///<summary>SetAnimationPayloadKeyForMorphTargetNodeUid</summary>
	public bool SetAnimationPayloadKeyForMorphTargetNodeUid(string MorphTargetNodeUid,string PayloadKey) { return default; }
	///<summary>RemoveAnimationPayloadKeyForMorphTargetNodeUid</summary>
	public bool RemoveAnimationPayloadKeyForMorphTargetNodeUid(string MorphTargetNodeUid) { return default; }
}
