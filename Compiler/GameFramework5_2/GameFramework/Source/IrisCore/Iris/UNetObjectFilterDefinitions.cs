namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configurable filter definitions. Valid filter definitions are auto-created by the filter system.</summary>
[CppInclude("Iris/ReplicationSystem/Filtering/NetObjectFilterDefinitions.h")]
public partial class UNetObjectFilterDefinitions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>NetObjectFilterDefinitions</summary>
	public TArray<FNetObjectFilterDefinition> NetObjectFilterDefinitions;
}
