namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/AISystemBase.h")]
public partial class UAISystemBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>List of specific AI system class to create, can be game-specific</summary>
	public FSoftClassPath AISystemClassName;
	///<summary>Name of a module used to spawn the AI system. If not empty, this module has to implement IAISystemModule</summary>
	public string AISystemModuleName;
	///<summary>Whether the AI system class should be spawned when connecting as a client</summary>
	public bool bInstantiateAISystemOnClient;
}
