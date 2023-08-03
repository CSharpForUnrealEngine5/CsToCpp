#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A library of commonly used functionality for Notifies related to mirroring, exposed to blueprint.</summary>
[CppInclude("Animation/AnimNotifyMirrorInspectionLibrary.h")]
public partial class UAnimNotifyMirrorInspectionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Get whether the animation which triggered this notify was mirrored.</summary>
	public static bool IsTriggeredByMirroredAnimation(FAnimNotifyEventReference EventReference) { return default; }
	///<summary>If the notify is mirrored, return the mirror data table that was active.</summary>
	public static UMirrorDataTable GetMirrorDataTable(FAnimNotifyEventReference EventReference) { return default; }
}
