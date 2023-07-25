#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AzureSpatialAnchorsTypes.h")]
///<summary>Note: this must match winrt::Microsoft::Azure::SpatialAnchors::SessionUserFeedback</summary>
public enum EAzureSpatialAnchorsSessionUserFeedback {
	None=0,
	NotEnoughMotion=1,
	MotionTooQuick=2,
	NotEnoughFeatures=4,
}
