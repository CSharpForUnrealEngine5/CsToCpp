namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A library of commonly used functionality for Notifies, exposed to blueprint.</summary>
[CppInclude("Animation/AnimNotifyLibrary.h")]
public partial class UAnimNotifyLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Get whether the notify state reached the end (was not cancelled)</summary>
	public static bool NotifyStateReachedEnd(FAnimNotifyEventReference EventReference) { return default; }
	///<summary>Get the current anim notify time in seconds for when this notify was fired</summary>
	public static float GetCurrentAnimationTime(FAnimNotifyEventReference EventReference) { return default; }
	///<summary>Get the current anim notify time as a ratio (0 -&gt; 1) through the animation for when this notify was fired</summary>
	public static float GetCurrentAnimationTimeRatio(FAnimNotifyEventReference EventReference) { return default; }
	///<summary>Gets the current time in seconds relative to the start of the notify state, clamped to the range of the notify</summary>
	public static float GetCurrentAnimationNotifyStateTime(FAnimNotifyEventReference EventReference) { return default; }
	///<summary>Gets the current time as a ratio (0 -&gt; 1) relative to the start of the notify state</summary>
	public static float GetCurrentAnimationNotifyStateTimeRatio(FAnimNotifyEventReference EventReference) { return default; }
}
