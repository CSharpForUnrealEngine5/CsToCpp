#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UInterchangeAnimationAPI is used to store and retrieve animation data(i.e. DCC node attributes, pipelines will have access to those attributes)</summary>
[CppInclude("Nodes/InterchangeAnimationAPI.h")]
public partial class UInterchangeAnimationAPI : UObject {
	///<summary>Get true if the node transform have animation. Return false if the Attribute is not set.</summary>
	public static bool GetCustomIsNodeTransformAnimated(UInterchangeBaseNode InterchangeBaseNode,bool AttributeValue) { return default; }
	///<summary>Set true if the node transform has animation.</summary>
	public static bool SetCustomIsNodeTransformAnimated(UInterchangeBaseNode InterchangeBaseNode,bool AttributeValue) { return default; }
	///<summary>Get the node transform animation key count. Return false if the Attribute is not set.</summary>
	public static bool GetCustomNodeTransformAnimationKeyCount(UInterchangeBaseNode InterchangeBaseNode,int AttributeValue) { return default; }
	///<summary>Set the node transform animation key count.</summary>
	public static bool SetCustomNodeTransformAnimationKeyCount(UInterchangeBaseNode InterchangeBaseNode,int AttributeValue) { return default; }
	///<summary>Get the animation start time in second for this node transform.</summary>
	public static bool GetCustomNodeTransformAnimationStartTime(UInterchangeBaseNode InterchangeBaseNode,double AttributeValue) { return default; }
	///<summary>Set the animation start time in second for this node transform.</summary>
	public static bool SetCustomNodeTransformAnimationStartTime(UInterchangeBaseNode InterchangeBaseNode,double AttributeValue) { return default; }
	///<summary>Get the animation end time in second for this node transform.</summary>
	public static bool GetCustomNodeTransformAnimationEndTime(UInterchangeBaseNode InterchangeBaseNode,double AttributeValue) { return default; }
	///<summary>Set the animation end time in second for this node transform.</summary>
	public static bool SetCustomNodeTransformAnimationEndTime(UInterchangeBaseNode InterchangeBaseNode,double AttributeValue) { return default; }
	///<summary>Get the payload key needed to retrieve the animation from the source.</summary>
	public static bool GetCustomNodeTransformPayloadKey(UInterchangeBaseNode InterchangeBaseNode,string AttributeValue) { return default; }
	///<summary>Set the payload key needed to retrieve the animation from the source.</summary>
	public static bool SetCustomNodeTransformPayloadKey(UInterchangeBaseNode InterchangeBaseNode,string AttributeValue) { return default; }
}
