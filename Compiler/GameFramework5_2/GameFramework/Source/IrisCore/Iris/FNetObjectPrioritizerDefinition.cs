namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Prioritizer definition. Configurable via UNetObjectPrioritizerDefinitions.</summary>
[CppInclude("Iris/ReplicationSystem/Prioritization/NetObjectPrioritizerDefinitions.h")]
public partial struct FNetObjectPrioritizerDefinition {
	public FName PrioritizerName;
	public FName ClassName;
	public UClass Class;
	public FName ConfigClassName;
	public UClass ConfigClass;
}
