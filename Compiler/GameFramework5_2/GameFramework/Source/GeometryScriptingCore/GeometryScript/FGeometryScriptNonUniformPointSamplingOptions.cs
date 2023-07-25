#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSamplingFunctions.h")]
public partial struct FGeometryScriptNonUniformPointSamplingOptions {
// GeometryScriptNonUniformPointSamplingOptions
	public float MaxSamplingRadius;
	public EGeometryScriptSamplingDistributionMode SizeDistribution;
	public double SizeDistributionPower;
	public EGeometryScriptSamplingWeightMode WeightMode;
	public bool bInvertWeights;
}
