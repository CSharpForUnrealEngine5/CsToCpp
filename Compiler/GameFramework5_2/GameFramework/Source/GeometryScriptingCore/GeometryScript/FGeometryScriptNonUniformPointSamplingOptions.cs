namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSamplingFunctions.h")]
public partial struct FGeometryScriptNonUniformPointSamplingOptions {
	public float MaxSamplingRadius;
	public EGeometryScriptSamplingDistributionMode SizeDistribution;
	public double SizeDistributionPower;
	public EGeometryScriptSamplingWeightMode WeightMode;
	public bool bInvertWeights;
}
