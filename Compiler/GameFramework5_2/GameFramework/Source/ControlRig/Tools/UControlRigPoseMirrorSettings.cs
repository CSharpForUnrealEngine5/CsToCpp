#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/ControlRigPoseMirrorSettings.h")]
public partial class UControlRigPoseMirrorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>String To Denote Right Side</summary>
	public string RightSide;
	///<summary>String To Denote Left Side</summary>
	public string LeftSide;
	///<summary>Axis to Mirror Translations</summary>
	public EAxis MirrorAxis;
	///<summary>Axis to Flip for Rotations</summary>
	public EAxis AxisToFlip;
}
