#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTrackable.h")]
public partial class UARFaceGeometry : UARTrackedGeometry {
// ARFaceGeometry
	public  float GetBlendShapeValue(EARFaceBlendShape BlendShape) { return default; }
	public  TMap<EARFaceBlendShape,float> GetBlendShapes() { return default; }
	public  FTransform GetLocalSpaceEyeTransform(EAREye Eye) { return default; }
	public  FTransform GetWorldSpaceEyeTransform(EAREye Eye) { return default; }
	public FVector LookAtTarget;
	public bool bIsTracked;
	public TMap<EARFaceBlendShape,float> BlendShapes;
	public FTransform LeftEyeTransform;
	public FTransform RightEyeTransform;
}
