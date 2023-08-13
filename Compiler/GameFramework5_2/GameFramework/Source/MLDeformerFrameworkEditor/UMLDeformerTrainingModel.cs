namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The training model base class.</summary>
[CppInclude("MLDeformerTrainingModel.h")]
public partial class UMLDeformerTrainingModel : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Get the runtime ML Deformer model object.</summary>
	public UMLDeformerModel GetModel() { return default; }
	///<summary>Get the number of input transforms. This is the number of bones.</summary>
	public int GetNumberSampleTransforms() { return default; }
	///<summary>Get number of input curves.</summary>
	public int GetNumberSampleCurves() { return default; }
	///<summary>Get the number of vertex deltas.</summary>
	public int GetNumberSampleDeltas() { return default; }
	///<summary>Get the number of samples in this data set. This is the number of sample frames we want to train on.</summary>
	public int NumSamples() { return default; }
	///<summary>Set the current sample frame. This will internally call the SampleFrame method, which will update the deltas, curve values and bone rotations.</summary>
	public bool SetCurrentSampleIndex(int Index) { return default; }
	///<summary>Check whether we need to resample the inputs and outputs, or if we can use a cached version.</summary>
	public bool GetNeedsResampling() { return default; }
	///<summary>Specify whether we need to resample any cached data or not, because our input assets, or any other relevant settings changed that would invalidate the cached data.</summary>
	public void SetNeedsResampling(bool bNeedsResampling) {}
	///<summary>Set the number of floats per curve. On default this is one.</summary>
	public void SetNumFloatsPerCurve(int NumFloatsPerCurve) {}
	///<summary>The delta values per vertex for this sample. This is updated after SetCurrentSampleIndex is called. Contains an xyz (3 floats) for each vertex.</summary>
	public TArray<float> SampleDeltas;
	///<summary>The curve weights. This is updated after SetCurrentSampleIndex is called.</summary>
	public TArray<float> SampleCurveValues;
	///<summary>The bone rotations in bone (local) space for this sample. This is updated after SetCurrentSampleIndex is called and is 6 floats per bone (2 columns of 3x3 rotation matrix).</summary>
	public TArray<float> SampleBoneRotations;
}
