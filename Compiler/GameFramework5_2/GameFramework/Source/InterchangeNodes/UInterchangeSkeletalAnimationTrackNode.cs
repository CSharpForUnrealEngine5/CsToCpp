#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeAnimationTrackSetNode.h")]
///<summary>* Class to hold onto the relationships between a set of animation tracks and the bones, morph targets of a skeleton.</summary>
public partial class UInterchangeSkeletalAnimationTrackNode : UInterchangeAnimationTrackBaseNode {
// InterchangeSkeletalAnimationTrackNode
	public bool GetCustomSkeletonNodeUid(string AttributeValue) { return default; }
	public bool SetCustomSkeletonNodeUid(string AttributeValue) { return default; }
	public bool GetCustomSkeletalMeshNodeUid(string AttributeValue) { return default; }
	public bool SetCustomSkeletalMeshNodeUid(string AttributeValue) { return default; }
	public bool SetCustomAnimationSampleRate(double SampleRate) { return default; }
	public bool GetCustomAnimationSampleRate(double SampleRate) { return default; }
	public bool SetCustomAnimationStartTime(double StartTime) { return default; }
	public bool GetCustomAnimationStartTime(double StartTime) { return default; }
	public bool SetCustomAnimationStopTime(double StopTime) { return default; }
	public bool GetCustomAnimationStopTime(double StopTime) { return default; }
	public void GetSceneNodeAnimationPayloadKeys(TMap<string,string> OutSceneNodeAnimationPayloadKeys) {}
	public bool GetAnimationPayloadKeyFromSceneNodeUid(string SceneNodeUid,string OutPayloadKey) { return default; }
	public bool SetAnimationPayloadKeyForSceneNodeUid(string SceneNodeUid,string PayloadKey) { return default; }
	public bool RemoveAnimationPayloadKeyForSceneNodeUid(string SceneNodeUid) { return default; }
	public void GetMorphTargetNodeAnimationPayloadKeys(TMap<string,string> OutMorphTargetNodeAnimationPayloads) {}
	public bool GetAnimationPayloadKeyFromMorphTargetNodeUid(string MorphTargetNodeUid,string OutPayloadKey) { return default; }
	public bool SetAnimationPayloadKeyForMorphTargetNodeUid(string MorphTargetNodeUid,string PayloadKey) { return default; }
	public bool RemoveAnimationPayloadKeyForMorphTargetNodeUid(string MorphTargetNodeUid) { return default; }
}
