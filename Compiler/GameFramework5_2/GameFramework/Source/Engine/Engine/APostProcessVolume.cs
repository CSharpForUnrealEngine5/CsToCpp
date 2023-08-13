namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>for FPostprocessSettings</summary>
[CppInclude("Engine/PostProcessVolume.h")]
public partial class APostProcessVolume : AVolume {
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
	///<summary>Whether this volume covers the whole world, or just the area inside its bounds.</summary>
	public bool bUnbound;
	///<summary>Adds an Blendable (implements IBlendableInterface) to the array of Blendables (if it doesn&#39;t exist) and update the weight</summary>
	public void AddOrUpdateBlendable(object /*InBlendableObject*/ InBlendableObject,float InWeight/*=1.0f*/) {}
}
