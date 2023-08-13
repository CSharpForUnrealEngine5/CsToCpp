namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_WidgetAnimationEvent.h")]
public partial class UK2Node_WidgetAnimationEvent : UK2Node_Event {
	public static UClass StaticClass() {return default;}
	///<summary>The action to bind to.</summary>
	public EWidgetAnimationEvent Action;
	///<summary>Name of property in Blueprint class that pointer to component we want to bind to</summary>
	public string AnimationPropertyName;
	///<summary>Binds this to a specific user action.</summary>
	public string UserTag;
	///<summary>SourceWidgetBlueprint</summary>
	public UWidgetBlueprint SourceWidgetBlueprint;
}
