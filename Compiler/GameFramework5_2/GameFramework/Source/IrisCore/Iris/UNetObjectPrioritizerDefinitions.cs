#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configurable prioritizer definitions. Valid prioritizer definitions are auto-created by the prioritization system.</summary>
[CppInclude("Iris/ReplicationSystem/Prioritization/NetObjectPrioritizerDefinitions.h")]
public partial class UNetObjectPrioritizerDefinitions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Prioritizer definitions.</summary>
	public TArray<FNetObjectPrioritizerDefinition> NetObjectPrioritizerDefinitions;
}
