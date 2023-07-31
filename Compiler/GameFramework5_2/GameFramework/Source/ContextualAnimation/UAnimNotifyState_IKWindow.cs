#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>AnimNotifyState used to define areas in an animation where IK should be enable</summary>
[CppInclude("AnimNotifyState_IKWindow.h")]
public partial class UAnimNotifyState_IKWindow : UAnimNotifyState {
	///<summary>GoalName</summary>
	public string GoalName;
	///<summary>BlendIn</summary>
	public FAlphaBlend BlendIn;
	///<summary>BlendOut</summary>
	public FAlphaBlend BlendOut;
	///<summary>bEnable</summary>
	public bool bEnable;
}
