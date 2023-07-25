#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Engine.h")]
///<summary>Helper struct for tracking on screen messages.</summary>
public partial struct FScreenMessageString {
// ScreenMessageString
	public ulong Key;
	public string ScreenMessage;
	public FColor DisplayColor;
	public float TimeToDisplay;
	public float CurrentTimeDisplayed;
	public FVector2D TextScale;
}
