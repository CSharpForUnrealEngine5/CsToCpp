#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceCurveBase.h")]
///<summary>Base class for curve data interfaces which facilitates handling the curve data in a standardized way.</summary>
public partial class UNiagaraDataInterfaceCurveBase : UNiagaraDataInterface {
// NiagaraDataInterfaceCurveBase
	public TArray<float> ShaderLUT;
	public float LUTMinTime;
	public float LUTMaxTime;
	public float LUTInvTimeRange;
	public float LUTNumSamplesMinusOne;
	public bool bUseLUT;
	public bool bExposeCurve;
	public bool bOptimizeLUT;
	public bool bOverrideOptimizeThreshold;
	public bool HasEditorData;
	public float OptimizeThreshold;
	public string ExposedName;
	public UTexture2D ExposedTexture;
}
