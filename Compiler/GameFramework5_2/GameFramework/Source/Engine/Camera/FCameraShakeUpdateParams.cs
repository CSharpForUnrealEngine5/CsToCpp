#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Camera/CameraShakeBase.h")]
///<summary>Parameters for updating a camera shake.</summary>
public partial struct FCameraShakeUpdateParams {
// CameraShakeUpdateParams
	public float DeltaTime;
	public float ShakeScale;
	public float DynamicScale;
	public float BlendingWeight;
	public FMinimalViewInfo POV;
}
