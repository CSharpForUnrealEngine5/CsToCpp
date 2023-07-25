#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaveTableTransform.h")]
public partial struct FWaveTableTransform {
// WaveTableTransform
	public EWaveTableCurve Curve;
	public float Scalar;
	public FRichCurve CurveCustom;
	public UCurveFloat CurveShared;
	public TArray<float> WaveTable;
	public FWaveTableSettings WaveTableSettings;
	public float FinalValue;
}
