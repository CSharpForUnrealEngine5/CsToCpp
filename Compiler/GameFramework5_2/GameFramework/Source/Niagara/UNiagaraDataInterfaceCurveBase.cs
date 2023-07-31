#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for curve data interfaces which facilitates handling the curve data in a standardized way.</summary>
[CppInclude("NiagaraDataInterfaceCurveBase.h")]
public partial class UNiagaraDataInterfaceCurveBase : UNiagaraDataInterface {
	///<summary>ShaderLUT</summary>
	public TArray<float> ShaderLUT;
	///<summary>LUTMinTime</summary>
	public float LUTMinTime;
	///<summary>LUTMaxTime</summary>
	public float LUTMaxTime;
	///<summary>LUTInvTimeRange</summary>
	public float LUTInvTimeRange;
	///<summary>LUTNumSamplesMinusOne</summary>
	public float LUTNumSamplesMinusOne;
	///<summary>bUseLUT</summary>
	public bool bUseLUT;
	///<summary>Generates a texture for the curve which can be exposed to material bindings.</summary>
	public bool bExposeCurve;
	///<summary>Do we optimize the LUT, this saves memory but may introduce errors.  Errors can be reduced modifying the threshold.</summary>
	public bool bOptimizeLUT;
	///<summary>bOverrideOptimizeThreshold</summary>
	public bool bOverrideOptimizeThreshold;
	///<summary>HasEditorData</summary>
	public bool HasEditorData;
	///<summary>Threshold used to optimize the LUT.</summary>
	public float OptimizeThreshold;
	///<summary>Sets a custom name for the binding to make it easier to identify.</summary>
	public string ExposedName;
	///<summary>The texture generated and exposed to materials, will be nullptr if we do not expose to the renderers.</summary>
	public UTexture2D ExposedTexture;
}
