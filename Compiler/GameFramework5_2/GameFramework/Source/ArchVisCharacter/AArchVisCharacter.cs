#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ArchVisCharacter.h")]
public partial class AArchVisCharacter : ACharacter {
	///<summary>Axis name for direct look up/down inputs (e.g. mouse). This should match an Axis Binding in your input settings</summary>
	public string LookUpAxisName;
	///<summary>Axis name for rate-based look up/down inputs (e.g. joystick). This should match an Axis Binding in your input settings</summary>
	public string LookUpAtRateAxisName;
	///<summary>Axis name for direct turn left/right inputs (e.g. mouse). This should match an Axis Binding in your input settings</summary>
	public string TurnAxisName;
	///<summary>Axis name for rate-based turn left/right inputs (e.g. joystick). This should match an Axis Binding in your input settings</summary>
	public string TurnAtRateAxisName;
	///<summary>Axis name for &quot;move forward/back&quot; control. This should match an Axis Binding in your input settings</summary>
	public string MoveForwardAxisName;
	///<summary>Axis name for &quot;move left/right&quot; control. This should match an Axis Binding in your input settings</summary>
	public string MoveRightAxisName;
	///<summary>Controls how aggressively mouse motion translates to character rotation in the pitch axis.</summary>
	public float MouseSensitivityScale_Pitch;
	///<summary>Controls how aggressively mouse motion translates to character rotation in the yaw axis.</summary>
	public float MouseSensitivityScale_Yaw;
}
