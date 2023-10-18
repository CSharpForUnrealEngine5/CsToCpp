namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for MassAIBehavior definitions. This is the type of definitions that MassEntity queries will look for.</summary>
[CppInclude("MassSmartObjectBehaviorDefinition.h")]
public partial class USmartObjectMassBehaviorDefinition : USmartObjectBehaviorDefinition {
	public static UClass StaticClass() {return default;}
	///<summary>Indicates the amount of time the Massentity</summary>
	public float UseTime;
}
