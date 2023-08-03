#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Exposes operations to be performed on a skeletal control anim node</summary>
[CppInclude("SkeletalControlLibrary.h")]
public partial class USkeletalControlLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Get a skeletal control from an anim node</summary>
	public static FSkeletalControlReference ConvertToSkeletalControl(FAnimNodeReference Node,EAnimNodeReferenceConversionResult Result) { return default; }
	///<summary>Get a skeletal control from an anim node (pure)</summary>
	public static void ConvertToSkeletalControlPure(FAnimNodeReference Node,FSkeletalControlReference SkeletalControl,bool Result) {}
	///<summary>Set the alpha value of this skeletal control</summary>
	public static FSkeletalControlReference SetAlpha(FSkeletalControlReference SkeletalControl,float Alpha) { return default; }
	///<summary>Get the alpha value of this skeletal control</summary>
	public static float GetAlpha(FSkeletalControlReference SkeletalControl) { return default; }
}
