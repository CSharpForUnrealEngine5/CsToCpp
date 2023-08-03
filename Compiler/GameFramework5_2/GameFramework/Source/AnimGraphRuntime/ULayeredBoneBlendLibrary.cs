#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Exposes operations to be performed on a layered bone blend anim node.</summary>
[CppInclude("LayeredBoneBlendLibrary.h")]
public partial class ULayeredBoneBlendLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Get a layered bone blend context from an anim node context.</summary>
	public static FLayeredBoneBlendReference ConvertToLayeredBoneBlend(FAnimNodeReference Node,EAnimNodeReferenceConversionResult Result) { return default; }
	///<summary>Get a layered bone blend context from an anim node context (pure).</summary>
	public static void ConvertToLayeredBlendPerBonePure(FAnimNodeReference Node,FLayeredBoneBlendReference LayeredBoneBlend,bool Result) {}
	///<summary>Get the number of poses that a layered bone blend node has (this does not include the base pose)</summary>
	public static int GetNumPoses(FLayeredBoneBlendReference LayeredBoneBlend) { return default; }
	///<summary>Sets the currently-used blend mask for a blended input pose by name.</summary>
	public static FLayeredBoneBlendReference SetBlendMask(FAnimUpdateContext UpdateContext,FLayeredBoneBlendReference LayeredBoneBlend,int PoseIndex,string BlendMaskName) { return default; }
}
