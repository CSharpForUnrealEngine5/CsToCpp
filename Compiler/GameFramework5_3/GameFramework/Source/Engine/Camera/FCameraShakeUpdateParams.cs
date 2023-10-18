namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameters for updating a camera shake.</summary>
[CppInclude("Camera/CameraShakeBase.h")]
public partial struct FCameraShakeUpdateParams {
	public float DeltaTime;
	public float ShakeScale;
	public float DynamicScale;
	public FMinimalViewInfo POV;
}
