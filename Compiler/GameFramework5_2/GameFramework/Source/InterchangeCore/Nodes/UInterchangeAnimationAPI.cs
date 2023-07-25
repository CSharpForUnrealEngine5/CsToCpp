#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Nodes/InterchangeAnimationAPI.h")]
///<summary>UInterchangeAnimationAPI is used to store and retrieve animation data(i.e. DCC node attributes, pipelines will have access to those attributes)</summary>
public partial class UInterchangeAnimationAPI : UObject {
// InterchangeAnimationAPI
	public bool GetCustomIsNodeTransformAnimated(UObject InterchangeBaseNode,bool AttributeValue) { return default; }
	public bool SetCustomIsNodeTransformAnimated(UObject InterchangeBaseNode,bool AttributeValue) { return default; }
	public bool GetCustomNodeTransformAnimationKeyCount(UObject InterchangeBaseNode,int AttributeValue) { return default; }
	public bool SetCustomNodeTransformAnimationKeyCount(UObject InterchangeBaseNode,int AttributeValue) { return default; }
	public bool GetCustomNodeTransformAnimationStartTime(UObject InterchangeBaseNode,double AttributeValue) { return default; }
	public bool SetCustomNodeTransformAnimationStartTime(UObject InterchangeBaseNode,double AttributeValue) { return default; }
	public bool GetCustomNodeTransformAnimationEndTime(UObject InterchangeBaseNode,double AttributeValue) { return default; }
	public bool SetCustomNodeTransformAnimationEndTime(UObject InterchangeBaseNode,double AttributeValue) { return default; }
	public bool GetCustomNodeTransformPayloadKey(UObject InterchangeBaseNode,string AttributeValue) { return default; }
	public bool SetCustomNodeTransformPayloadKey(UObject InterchangeBaseNode,string AttributeValue) { return default; }
}
