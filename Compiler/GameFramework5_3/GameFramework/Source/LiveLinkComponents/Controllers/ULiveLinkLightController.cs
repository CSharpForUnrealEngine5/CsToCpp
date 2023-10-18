namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Controller that uses LiveLink light data to drive a light component.</summary>
[CppInclude("Controllers/LiveLinkLightController.h")]
public partial class ULiveLinkLightController : ULiveLinkControllerBase {
	public static UClass StaticClass() {return default;}
	///<summary>ComponentToControl_DEPRECATED</summary>
	public FComponentReference ComponentToControl_DEPRECATED;
	///<summary>TransformData_DEPRECATED</summary>
	public FLiveLinkTransformControllerData TransformData_DEPRECATED;
}
