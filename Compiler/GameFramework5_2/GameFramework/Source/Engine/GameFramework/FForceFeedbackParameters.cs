#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/ForceFeedbackParameters.h")]
///<summary>This structure is used to pass arguments to ClientPlayForceFeedback() client RPC function</summary>
public partial struct FForceFeedbackParameters {
// ForceFeedbackParameters
	public string Tag;
	public bool bLooping;
	public bool bIgnoreTimeDilation;
	public bool bPlayWhilePaused;
}
