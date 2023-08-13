namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>On each actor to process, add the actor to the layer</summary>
[CppInclude("DataprepOperations.h")]
public partial class UDataprepAddToLayerOperation : UDataprepOperation {
	public static UClass StaticClass() {return default;}
	///<summary>Name of the layer to add the actors to</summary>
	public string LayerName;
}
