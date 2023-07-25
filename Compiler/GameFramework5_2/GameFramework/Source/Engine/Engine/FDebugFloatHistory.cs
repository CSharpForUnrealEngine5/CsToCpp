#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Structure for recording float values and displaying them as an Histogram through DrawDebugFloatHistory.</summary>
public partial struct FDebugFloatHistory {
// DebugFloatHistory
	public TArray<float> Samples;
	public int MaxSamples;
	public float MinValue;
	public float MaxValue;
	public bool bAutoAdjustMinMax;
}
