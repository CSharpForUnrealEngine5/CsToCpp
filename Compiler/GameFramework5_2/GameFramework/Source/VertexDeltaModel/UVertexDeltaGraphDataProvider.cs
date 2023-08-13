namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Provider for MLDeformer data.</summary>
[CppInclude("VertexDeltaGraphDataInterface.h")]
public partial class UVertexDeltaGraphDataProvider : UComputeDataProvider {
	public static UClass StaticClass() {return default;}
	///<summary>The deformer component that this data provider works on.</summary>
	public UMLDeformerComponent DeformerComponent;
}
