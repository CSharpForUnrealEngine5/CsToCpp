#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Provider for MLDeformer data.</summary>
[CppInclude("VertexDeltaGraphDataInterface.h")]
public partial class UVertexDeltaGraphDataProvider : UComputeDataProvider {
	///<summary>The deformer component that this data provider works on.</summary>
	public UMLDeformerComponent DeformerComponent;
}
