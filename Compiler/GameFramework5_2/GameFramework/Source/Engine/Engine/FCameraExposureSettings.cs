#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Scene.h")]
public partial struct FCameraExposureSettings {
// CameraExposureSettings
	public byte Method;
	public float LowPercent;
	public float HighPercent;
	public float MinBrightness;
	public float MaxBrightness;
	public float SpeedUp;
	public float SpeedDown;
	public float Bias;
	public UCurveFloat BiasCurve;
	public UTexture MeterMask;
	public float HistogramLogMin;
	public float HistogramLogMax;
	public float CalibrationConstant;
	public bool ApplyPhysicalCameraExposure;
}
