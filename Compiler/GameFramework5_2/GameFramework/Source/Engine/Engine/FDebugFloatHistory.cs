#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure for recording float values and displaying them as an Histogram through DrawDebugFloatHistory.</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FDebugFloatHistory {
	public TArray<float> Samples;
	public int MaxSamples;
	public float MinValue;
	public float MaxValue;
	public bool bAutoAdjustMinMax;
}
