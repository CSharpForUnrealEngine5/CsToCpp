namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This structure is used to pass arguments to ClientPlayForceFeedback() client RPC function</summary>
[CppInclude("GameFramework/ForceFeedbackParameters.h")]
public partial struct FForceFeedbackParameters {
	public FName Tag;
	public bool bLooping;
	public bool bIgnoreTimeDilation;
	public bool bPlayWhilePaused;
}
