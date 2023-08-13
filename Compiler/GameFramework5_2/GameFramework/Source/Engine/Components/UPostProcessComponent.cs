namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>PostProcessComponent. Enables Post process controls for blueprints.</summary>
[CppInclude("Components/PostProcessComponent.h")]
public partial class UPostProcessComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Post process settings to use for this volume.</summary>
	public FPostProcessSettings Settings;
	///<summary>Priority of this volume. In the case of overlapping volumes the one with the highest priority</summary>
	public float Priority;
	///<summary>World space radius around the volume that is used for blending (only if not unbound).</summary>
	public float BlendRadius;
	///<summary>0:no effect, 1:full effect</summary>
	public float BlendWeight;
	///<summary>Whether this volume is enabled or not.</summary>
	public bool bEnabled;
	///<summary>set this to false to use the parent shape component as volume bounds. True affects the whole world regardless.</summary>
	public bool bUnbound;
	///<summary>Adds an Blendable (implements IBlendableInterface) to the array of Blendables (if it doesn&#39;t exist) and update the weight</summary>
	public void AddOrUpdateBlendable(object /*InBlendableObject*/ InBlendableObject,float InWeight/*=1.0f*/) {}
}
