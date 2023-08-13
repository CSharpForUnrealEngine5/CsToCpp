namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Prioritizer definition. Configurable via UNetObjectPrioritizerDefinitions.</summary>
[CppInclude("Iris/ReplicationSystem/Prioritization/NetObjectPrioritizerDefinitions.h")]
public partial struct FNetObjectPrioritizerDefinition {
	public string PrioritizerName;
	public string ClassName;
	public UClass Class;
	public string ConfigClassName;
	public UClass ConfigClass;
}
