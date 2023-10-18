namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Used for common non-physical camera with orthographic or perspective projection.</summary>
[CppInclude("InterchangeCameraFactoryNode.h")]
public partial class UInterchangeStandardCameraFactoryNode : UInterchangeActorFactoryNode {
	public static UClass StaticClass() {return default;}
	///<summary>GetCustomProjectionMode</summary>
	public bool GetCustomProjectionMode(ECameraProjectionMode AttributeValue) { return default; }
	///<summary>SetCustomProjectionMode</summary>
	public bool SetCustomProjectionMode(ECameraProjectionMode AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>GetCustomWidth</summary>
	public bool GetCustomWidth(float AttributeValue) { return default; }
	///<summary>SetCustomWidth</summary>
	public bool SetCustomWidth(float AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>GetCustomNearClipPlane</summary>
	public bool GetCustomNearClipPlane(float AttributeValue) { return default; }
	///<summary>SetCustomNearClipPlane</summary>
	public bool SetCustomNearClipPlane(float AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>GetCustomFarClipPlane</summary>
	public bool GetCustomFarClipPlane(float AttributeValue) { return default; }
	///<summary>SetCustomFarClipPlane</summary>
	public bool SetCustomFarClipPlane(float AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>GetCustomAspectRatio</summary>
	public bool GetCustomAspectRatio(float AttributeValue) { return default; }
	///<summary>SetCustomAspectRatio</summary>
	public bool SetCustomAspectRatio(float AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>GetCustomFieldOfView</summary>
	public bool GetCustomFieldOfView(float AttributeValue) { return default; }
	///<summary>SetCustomFieldOfView</summary>
	public bool SetCustomFieldOfView(float AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
}
