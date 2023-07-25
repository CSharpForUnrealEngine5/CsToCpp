#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusMR_Settings.h")]
public partial class UDEPRECATED_UOculusMR_Settings : UObject {
// UOculusMR_Settings
	public EOculusMR_ClippingReference ClippingReference;
	public bool bUseTrackedCameraResolution;
	public int WidthPerView;
	public int HeightPerView;
	public float CastingLatency;
	public FColor BackdropColor;
	public float HandPoseStateLatency;
	public FColor ChromaKeyColor;
	public float ChromaKeySimilarity;
	public float ChromaKeySmoothRange;
	public float ChromaKeySpillRange;
	public EOculusMR_PostProcessEffects ExternalCompositionPostProcessEffects;
	public EOculusMR_CompositionMethod GetCompositionMethod() { return default; }
	public void SetCompositionMethod(EOculusMR_CompositionMethod val) {}
	public EOculusMR_CameraDeviceEnum GetCapturingCamera() { return default; }
	public void SetCapturingCamera(EOculusMR_CameraDeviceEnum val) {}
	public bool GetIsCasting() { return default; }
	public void SetIsCasting(bool val) {}
	public void BindToTrackedCameraIndexIfAvailable(int InTrackedCameraIndex) {}
	public int GetBindToTrackedCameraIndex() { return default; }
	public void LoadFromIni() {}
	public void SaveToIni() {}
	public bool bIsCasting;
	public EOculusMR_CompositionMethod CompositionMethod;
	public EOculusMR_CameraDeviceEnum CapturingCamera;
}
