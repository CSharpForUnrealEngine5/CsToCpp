namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaveTableTransform.h")]
public partial struct FWaveTableTransform {
	public EWaveTableCurve Curve;
	public float Scalar;
	public FRichCurve CurveCustom;
	public UCurveFloat CurveShared;
	public FWaveTableData TableData;
	public float Duration;
	public FWaveTableSettings WaveTableSettings;
	public TArray<float> WaveTable;
	public float FinalValue;
}
