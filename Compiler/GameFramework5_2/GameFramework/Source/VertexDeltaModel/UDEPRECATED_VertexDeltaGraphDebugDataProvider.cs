namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Provider for MLDeformer debugging data.</summary>
[CppInclude("VertexDeltaGraphDebugDataInterface.h")]
public partial class UDEPRECATED_VertexDeltaGraphDebugDataProvider : UComputeDataProvider {
	public static UClass StaticClass() {return default;}
	///<summary>DeformerComponent</summary>
	public UMLDeformerComponent DeformerComponent;
	///<summary>DeformerAsset</summary>
	public UMLDeformerAsset DeformerAsset;
}
