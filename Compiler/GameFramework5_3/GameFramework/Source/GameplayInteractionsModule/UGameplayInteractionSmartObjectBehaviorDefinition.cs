namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SmartObject behavior definition for the GameplayInteractions</summary>
[CppInclude("GameplayInteractionSmartObjectBehaviorDefinition.h")]
public partial class UGameplayInteractionSmartObjectBehaviorDefinition : USmartObjectBehaviorDefinition {
	public static UClass StaticClass() {return default;}
	///<summary>StateTreeReference</summary>
	public FStateTreeReference StateTreeReference;
}
