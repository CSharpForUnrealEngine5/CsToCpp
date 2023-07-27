#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MLDeformerTrainingModel.h")]
///<summary>The training model base class.</summary>
public partial class UMLDeformerTrainingModel : UObject {
// MLDeformerTrainingModel
	public  UMLDeformerModel GetModel() { return default; }
	public  int GetNumberSampleTransforms() { return default; }
	public  int GetNumberSampleCurves() { return default; }
	public  int GetNumberSampleDeltas() { return default; }
	public  int NumSamples() { return default; }
	public  bool SetCurrentSampleIndex(int Index) { return default; }
	public  bool GetNeedsResampling() { return default; }
	public  void SetNeedsResampling(bool bNeedsResampling) {}
	public  void SetNumFloatsPerCurve(int NumFloatsPerCurve) {}
	public TArray<float> SampleDeltas;
	public TArray<float> SampleCurveValues;
	public TArray<float> SampleBoneRotations;
}
