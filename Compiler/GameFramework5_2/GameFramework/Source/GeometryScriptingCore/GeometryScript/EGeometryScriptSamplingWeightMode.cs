#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSamplingFunctions.h")]
///<summary>Control how active Weights are used to affect point radius</summary>
public enum EGeometryScriptSamplingWeightMode {
	WeightToRadius=0,
	FilledWeightToRadius=1,
	WeightedRandom=2,
}
