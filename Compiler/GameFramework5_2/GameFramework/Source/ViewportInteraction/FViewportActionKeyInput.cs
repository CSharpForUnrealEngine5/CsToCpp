#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewportInteractionTypes.h")]
///<summary>Represents a generic action</summary>
public partial struct FViewportActionKeyInput {
// ViewportActionKeyInput
	public string ActionType;
	public byte Event;
	public bool bIsInputCaptured;
	public bool bIsAxis;
}
