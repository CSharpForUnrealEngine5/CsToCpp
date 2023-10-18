namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Gameplay Effect Component (aka GEComponent)</summary>
[CppInclude("GameplayEffectComponent.h")]
public partial class UGameplayEffectComponent : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Friendly name for displaying in the Editor&#39;s Gameplay Effect Component Index (See: UGameplayEffect::GEComponents). We set EditCondition False here so it doesn&#39;t show up otherwise.</summary>
	public string EditorFriendlyName;
}
