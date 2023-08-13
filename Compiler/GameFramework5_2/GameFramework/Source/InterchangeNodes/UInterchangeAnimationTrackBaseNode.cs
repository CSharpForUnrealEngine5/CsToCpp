namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Abstract class providing the minimal services required for an animation track node</summary>
[CppInclude("InterchangeAnimationTrackSetNode.h")]
public partial class UInterchangeAnimationTrackBaseNode : UInterchangeBaseNode {
	public static UClass StaticClass() {return default;}
	///<summary>Set how the actor&#39;s animated property should behave once its animation completes.</summary>
	public bool SetCustomCompletionMode(int AttributeValue) { return default; }
	///<summary>Get how the actor&#39;s animated property behaves once this animation is complete.</summary>
	public bool GetCustomCompletionMode(int AttributeValue) { return default; }
}
