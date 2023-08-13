namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UPointLightGizmo provides a gizmo to allow for editing point light properties in viewport</summary>
[CppInclude("PointLightGizmo.h")]
public partial class UPointLightGizmo : UInteractiveGizmo {
	public static UClass StaticClass() {return default;}
	///<summary>The Gizmo that is used to scale the attenuation</summary>
	public UScalableSphereGizmo AttenuationGizmo;
	///<summary>The target Point Light</summary>
	public APointLight LightActor;
	///<summary>World</summary>
	public UWorld World;
	///<summary>A transform proxy to represent the light actor in gizmos</summary>
	public USubTransformProxy TransformProxy;
}
