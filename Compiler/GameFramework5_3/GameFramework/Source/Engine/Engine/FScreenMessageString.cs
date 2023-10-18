namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper struct for tracking on screen messages.</summary>
[CppInclude("Engine/Engine.h")]
public partial struct FScreenMessageString {
	public ulong Key;
	public string ScreenMessage;
	public FColor DisplayColor;
	public float TimeToDisplay;
	public float CurrentTimeDisplayed;
	public FVector2D TextScale;
}
