#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SkeletalControlLibrary.h")]
///<summary>Exposes operations to be performed on a skeletal control anim node</summary>
public partial class USkeletalControlLibrary : UBlueprintFunctionLibrary {
// SkeletalControlLibrary
	public static FSkeletalControlReference ConvertToSkeletalControl(FAnimNodeReference Node,EAnimNodeReferenceConversionResult Result) { return default; }
	public static void ConvertToSkeletalControlPure(FAnimNodeReference Node,FSkeletalControlReference SkeletalControl,bool Result) {}
	public static FSkeletalControlReference SetAlpha(FSkeletalControlReference SkeletalControl,float Alpha) { return default; }
	public static float GetAlpha(FSkeletalControlReference SkeletalControl) { return default; }
}
