#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Inference agents have a neural network that can process senses and output actuations via their Think method. You</summary>
[CppInclude("Agents/MLAdapterAgent_Inference.h")]
public partial class UMLAdapterAgent_Inference : UMLAdapterAgent {
	public static UClass StaticClass() {return default;}
	///<summary>Reference to neural network asset data.</summary>
	public UNNEModelData ModelData;
}
