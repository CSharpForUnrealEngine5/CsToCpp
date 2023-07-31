#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a generic action</summary>
[CppInclude("ViewportInteractionTypes.h")]
public partial struct FViewportActionKeyInput {
	public string ActionType;
	public EInputEvent Event;
	public bool bIsInputCaptured;
	public bool bIsAxis;
}
