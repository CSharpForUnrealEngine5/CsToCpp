#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>On each actor to process, add the actor to the layer</summary>
[CppInclude("DataprepOperations.h")]
public partial class UDataprepAddToLayerOperation : UDataprepOperation {
	///<summary>Name of the layer to add the actors to</summary>
	public string LayerName;
}
