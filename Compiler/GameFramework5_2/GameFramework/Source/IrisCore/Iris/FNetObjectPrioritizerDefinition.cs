#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Iris/ReplicationSystem/Prioritization/NetObjectPrioritizerDefinitions.h")]
///<summary>Prioritizer definition. Configurable via UNetObjectPrioritizerDefinitions.</summary>
public partial struct FNetObjectPrioritizerDefinition {
// NetObjectPrioritizerDefinition
	public string PrioritizerName;
	public string ClassName;
	public UClass Class;
	public string ConfigClassName;
	public UClass ConfigClass;
}
