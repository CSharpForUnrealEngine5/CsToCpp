namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>AnimNotifyState used to define areas in an animation where IK should be enable</summary>
[CppInclude("AnimNotifyState_IKWindow.h")]
public partial class UAnimNotifyState_IKWindow : UAnimNotifyState {
	public static UClass StaticClass() {return default;}
	///<summary>GoalName</summary>
	public FName GoalName;
	///<summary>BlendIn</summary>
	public FAlphaBlend BlendIn;
	///<summary>BlendOut</summary>
	public FAlphaBlend BlendOut;
	///<summary>bEnable</summary>
	public bool bEnable;
}
