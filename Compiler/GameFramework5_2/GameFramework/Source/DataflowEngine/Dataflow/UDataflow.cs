namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UDataflow (UObject)</summary>
[CppInclude("Dataflow/DataflowObject.h")]
public partial class UDataflow : UEdGraph {
	public static UClass StaticClass() {return default;}
	///<summary>bActive</summary>
	public bool bActive;
	///<summary>Targets</summary>
	public TArray<UObject> Targets;
	///<summary>Material</summary>
	public UMaterial Material;
}
