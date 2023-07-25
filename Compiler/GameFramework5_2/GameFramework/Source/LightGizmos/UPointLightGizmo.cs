#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PointLightGizmo.h")]
///<summary>UPointLightGizmo provides a gizmo to allow for editing point light properties in viewport</summary>
public partial class UPointLightGizmo : UInteractiveGizmo {
// PointLightGizmo
	public UScalableSphereGizmo AttenuationGizmo;
	public APointLight LightActor;
	public UWorld World;
	public USubTransformProxy TransformProxy;
}
