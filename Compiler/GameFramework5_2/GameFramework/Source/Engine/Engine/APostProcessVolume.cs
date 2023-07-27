#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PostProcessVolume.h")]
///<summary>for FPostprocessSettings</summary>
public partial class APostProcessVolume : AVolume {
// PostProcessVolume
	public FPostProcessSettings Settings;
	public float Priority;
	public float BlendRadius;
	public float BlendWeight;
	public bool bEnabled;
	public bool bUnbound;
	public  void AddOrUpdateBlendable(object /*InBlendableObject*/ InBlendableObject,float InWeight/*=1.0f*/) {}
}
