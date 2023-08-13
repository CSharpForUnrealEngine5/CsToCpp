namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRCreativePointerComponent.h")]
public partial class UXRCreativePointerComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>If bScaledByImpact is false, this returns the raw input to the smoothing filter, `TraceMaxLength` units away the +X direction.</summary>
	public FVector GetRawTraceEnd(bool bScaledByImpact/*=true*/) { return default; }
	///<summary>If bScaledByImpact is false, this is the smoothed filter output, roughly `TraceMaxLength` units away, roughly in the +X direction.</summary>
	public FVector GetFilteredTraceEnd(bool bScaledByImpact/*=true*/) { return default; }
	///<summary>GetHitResult</summary>
	public FHitResult GetHitResult() { return default; }
	///<summary>IsEnabled</summary>
	public bool IsEnabled() { return default; }
	///<summary>SetEnabled</summary>
	public void SetEnabled(bool bInEnabled) {}
	///<summary>TraceMaxLength</summary>
	public float TraceMaxLength;
	///<summary>SmoothingLag</summary>
	public float SmoothingLag;
	///<summary>SmoothingMinCutoff</summary>
	public float SmoothingMinCutoff;
	///<summary>bEnabled</summary>
	public bool bEnabled;
}
