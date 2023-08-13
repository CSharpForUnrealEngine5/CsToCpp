namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusMR_Settings.h")]
public partial class UDEPRECATED_UOculusMR_Settings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ClippingReference</summary>
	public EOculusMR_ClippingReference ClippingReference;
	///<summary>bUseTrackedCameraResolution</summary>
	public bool bUseTrackedCameraResolution;
	///<summary>WidthPerView</summary>
	public int WidthPerView;
	///<summary>HeightPerView</summary>
	public int HeightPerView;
	///<summary>CastingLatency</summary>
	public float CastingLatency;
	///<summary>BackdropColor</summary>
	public FColor BackdropColor;
	///<summary>HandPoseStateLatency</summary>
	public float HandPoseStateLatency;
	///<summary>ChromaKeyColor</summary>
	public FColor ChromaKeyColor;
	///<summary>ChromaKeySimilarity</summary>
	public float ChromaKeySimilarity;
	///<summary>ChromaKeySmoothRange</summary>
	public float ChromaKeySmoothRange;
	///<summary>ChromaKeySpillRange</summary>
	public float ChromaKeySpillRange;
	///<summary>ExternalCompositionPostProcessEffects</summary>
	public EOculusMR_PostProcessEffects ExternalCompositionPostProcessEffects;
	///<summary>GetCompositionMethod</summary>
	public EOculusMR_CompositionMethod GetCompositionMethod() { return default; }
	///<summary>SetCompositionMethod</summary>
	public void SetCompositionMethod(EOculusMR_CompositionMethod val) {}
	///<summary>GetCapturingCamera</summary>
	public EOculusMR_CameraDeviceEnum GetCapturingCamera() { return default; }
	///<summary>SetCapturingCamera</summary>
	public void SetCapturingCamera(EOculusMR_CameraDeviceEnum val) {}
	///<summary>Is MRC on and off</summary>
	public bool GetIsCasting() { return default; }
	///<summary>SetIsCasting</summary>
	public void SetIsCasting(bool val) {}
	///<summary>BindToTrackedCameraIndexIfAvailable</summary>
	public void BindToTrackedCameraIndexIfAvailable(int InTrackedCameraIndex) {}
	///<summary>GetBindToTrackedCameraIndex</summary>
	public int GetBindToTrackedCameraIndex() { return default; }
	///<summary>LoadFromIni</summary>
	public void LoadFromIni() {}
	///<summary>SaveToIni</summary>
	public void SaveToIni() {}
	///<summary>Turns MRC on and off (does not get saved to or loaded from ini)</summary>
	public bool bIsCasting;
	///<summary>ExternalComposition: The casting window includes the background and foreground view</summary>
	public EOculusMR_CompositionMethod CompositionMethod;
	///<summary>When CompositionMethod is DirectComposition, the physical camera device which provide the frame</summary>
	public EOculusMR_CameraDeviceEnum CapturingCamera;
}
