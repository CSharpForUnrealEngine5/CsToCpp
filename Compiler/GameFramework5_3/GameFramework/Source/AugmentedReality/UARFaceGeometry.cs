namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTrackable.h")]
public partial class UARFaceGeometry : UARTrackedGeometry {
	public static UClass StaticClass() {return default;}
	///<summary>GetBlendShapeValue</summary>
	public float GetBlendShapeValue(EARFaceBlendShape BlendShape) { return default; }
	///<summary>GetBlendShapes</summary>
	public TMap<EARFaceBlendShape,float> GetBlendShapes() { return default; }
	///<summary>GetLocalSpaceEyeTransform</summary>
	public FTransform GetLocalSpaceEyeTransform(EAREye Eye) { return default; }
	///<summary>GetWorldSpaceEyeTransform</summary>
	public FTransform GetWorldSpaceEyeTransform(EAREye Eye) { return default; }
	///<summary>The target the eyes are looking at</summary>
	public FVector LookAtTarget;
	///<summary>Whether the face is currently being tracked by the AR system</summary>
	public bool bIsTracked;
	///<summary>BlendShapes</summary>
	public TMap<EARFaceBlendShape,float> BlendShapes;
	///<summary>The transform for the left eye</summary>
	public FTransform LeftEyeTransform;
	///<summary>The transform for the right eye</summary>
	public FTransform RightEyeTransform;
}
