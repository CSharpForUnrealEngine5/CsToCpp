#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/PostProcessComponent.h")]
///<summary>PostProcessComponent. Enables Post process controls for blueprints.</summary>
public partial class UPostProcessComponent : USceneComponent {
// PostProcessComponent
	public FPostProcessSettings Settings;
	public float Priority;
	public float BlendRadius;
	public float BlendWeight;
	public bool bEnabled;
	public bool bUnbound;
	public  void AddOrUpdateBlendable(object /*InBlendableObject*/ InBlendableObject,float InWeight/*=1.0f*/) {}
}
