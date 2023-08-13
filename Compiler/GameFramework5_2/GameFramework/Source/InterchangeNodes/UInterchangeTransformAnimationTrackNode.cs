namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class to represent an animation on the transform of a camera, light or scene node</summary>
[CppInclude("InterchangeAnimationTrackSetNode.h")]
public partial class UInterchangeTransformAnimationTrackNode : UInterchangeAnimationTrackNode {
	public static UClass StaticClass() {return default;}
	///<summary>Set which channels of this animation should be used. This is a bitwise mask.</summary>
	public bool SetCustomUsedChannels(int AttributeValue) { return default; }
	///<summary>Get which channels of this animation should be used. This is a bitmask.</summary>
	public bool GetCustomUsedChannels(int AttributeValue) { return default; }
}
