#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class to represent an animation which instances another animation track set node</summary>
[CppInclude("InterchangeAnimationTrackSetNode.h")]
public partial class UInterchangeAnimationTrackSetInstanceNode : UInterchangeAnimationTrackBaseNode {
	public static UClass StaticClass() {return default;}
	///<summary>Set the time scale used for the level sequence instance.</summary>
	public  bool SetCustomTimeScale(float AttributeValue) { return default; }
	///<summary>Get the time scale used for the level sequence instance.</summary>
	public  bool GetCustomTimeScale(float AttributeValue) { return default; }
	///<summary>Set the level sequence instance duration in number of frames.</summary>
	public  bool SetCustomDuration(int AttributeValue) { return default; }
	///<summary>Get the level sequence instance duration in number of frames.</summary>
	public  bool GetCustomDuration(int AttributeValue) { return default; }
	///<summary>Set the frame where the level sequence instance starts.</summary>
	public  bool SetCustomStartFrame(int AttributeValue) { return default; }
	///<summary>Get the frame where the level sequence instance starts.</summary>
	public  bool GetCustomStartFrame(int AttributeValue) { return default; }
	///<summary>Set the unique id of the level sequence this instance references.</summary>
	public  bool SetCustomTrackSetDependencyUid(string AttributeValue) { return default; }
	///<summary>Get the unique id of the level sequence this instance references.</summary>
	public  bool GetCustomTrackSetDependencyUid(string AttributeValue) { return default; }
}
