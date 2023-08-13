namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Retargeter/IKRetargeter.h")]
public partial class URetargetRootSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The settings used to control the motion of the target root bone.</summary>
	public FTargetRootSettings Settings;
	///<summary>Deprecated properties from before FTargetRootSettings / profile refactor</summary>
	public bool RetargetRootTranslation_DEPRECATED;
	///<summary>GlobalScaleHorizontal_DEPRECATED</summary>
	public float GlobalScaleHorizontal_DEPRECATED;
	///<summary>GlobalScaleVertical_DEPRECATED</summary>
	public float GlobalScaleVertical_DEPRECATED;
	///<summary>BlendToSource_DEPRECATED</summary>
	public FVector BlendToSource_DEPRECATED;
	///<summary>StaticOffset_DEPRECATED</summary>
	public FVector StaticOffset_DEPRECATED;
	///<summary>StaticRotationOffset_DEPRECATED</summary>
	public FRotator StaticRotationOffset_DEPRECATED;
}
