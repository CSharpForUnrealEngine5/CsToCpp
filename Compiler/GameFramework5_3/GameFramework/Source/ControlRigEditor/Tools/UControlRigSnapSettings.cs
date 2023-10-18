namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/ControlRigSnapSettings.h")]
public partial class UControlRigSnapSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>When snapping keep offset, if false snap completely</summary>
	public bool bKeepOffset;
	///<summary>When snapping, also snap position</summary>
	public bool bSnapPosition;
	///<summary>When snapping, also snap rotation</summary>
	public bool bSnapRotation;
	///<summary>When snapping, also snap scale</summary>
	public bool bSnapScale;
	///<summary>BakingKeySettings</summary>
	public EBakingKeySettings BakingKeySettings;
	///<summary>FrameIncrement</summary>
	public int FrameIncrement;
	///<summary>bReduceKeys</summary>
	public bool bReduceKeys;
	///<summary>Tolerance</summary>
	public float Tolerance;
}
