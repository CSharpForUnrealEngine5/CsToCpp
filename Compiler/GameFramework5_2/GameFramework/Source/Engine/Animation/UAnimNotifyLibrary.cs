namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A library of commonly used functionality for Notifies, exposed to blueprint.</summary>
[CppInclude("Animation/AnimNotifyLibrary.h")]
public partial class UAnimNotifyLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Get whether the notify state reached the end (was not cancelled)</summary>
	public static bool NotifyStateReachedEnd(FAnimNotifyEventReference EventReference) { return default; }
}
