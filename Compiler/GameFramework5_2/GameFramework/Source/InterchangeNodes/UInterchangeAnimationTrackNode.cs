#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class to represent an animation on the property of a camera, light or scene node</summary>
[CppInclude("InterchangeAnimationTrackSetNode.h")]
public partial class UInterchangeAnimationTrackNode : UInterchangeAnimationTrackBaseNode {
	///<summary>Set the actor dependency to this object.</summary>
	public  bool SetCustomActorDependencyUid(string DependencyUid) { return default; }
	///<summary>Get the actor dependency to this object.</summary>
	public  bool GetCustomActorDependencyUid(string DependencyUid) { return default; }
	///<summary>Set the property animated by this track.</summary>
	public  bool SetCustomTargetedProperty(int TargetedProperty) { return default; }
	///<summary>Get the property animated by this track.</summary>
	public  bool GetCustomTargetedProperty(int TargetedProperty) { return default; }
	///<summary>Set the payload key needed to retrieve the animation for this track.</summary>
	public  bool SetCustomAnimationPayloadKey(string PayloadKey) { return default; }
	///<summary>Get the payload key needed to retrieve the animation for this track.</summary>
	public  bool GetCustomAnimationPayloadKey(string PayloadKey) { return default; }
	///<summary>Set the number of frames for the animation of this track.</summary>
	public  bool SetCustomFrameCount(int AttributeValue) { return default; }
	///<summary>Get the number of frames for the animation of this track.</summary>
	public  bool GetCustomFrameCount(int AttributeValue) { return default; }
}
