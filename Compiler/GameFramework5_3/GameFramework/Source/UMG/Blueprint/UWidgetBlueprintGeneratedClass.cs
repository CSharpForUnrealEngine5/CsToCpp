namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The widget blueprint generated class allows us to create blueprint-able widgets for UMG at runtime.</summary>
[CppInclude("Blueprint/WidgetBlueprintGeneratedClass.h")]
public partial class UWidgetBlueprintGeneratedClass : UBlueprintGeneratedClass {
	public static UClass StaticClass() {return default;}
	///<summary>A tree of the widget templates to be created</summary>
	public UWidgetTree WidgetTree;
	///<summary>The extension that are considered static to the class</summary>
	public TArray<UWidgetBlueprintGeneratedClassExtension> Extensions;
	///<summary>The classes native parent requires a native tick</summary>
	public bool bClassRequiresNativeTick;
	///<summary>bCanCallPreConstruct</summary>
	public bool bCanCallPreConstruct;
	///<summary>Bindings</summary>
	public TArray<FDelegateRuntimeBinding> Bindings;
	///<summary>Animations</summary>
	public TArray<UWidgetAnimation> Animations;
	///<summary>All named slots, even the ones that have content already filled into them by a parent class and are not</summary>
	public TArray<FName> NamedSlots;
	///<summary>All named slots mapped the assigned GUID of their UNamedSlot widget. *</summary>
	public TMap<FName,FGuid> NamedSlotsWithID;
	///<summary>Available Named Slots for content in a subclass.  These are slots that are accumulated from all super</summary>
	public TArray<FName> AvailableNamedSlots;
	///<summary>These are the set of named slots that can be used on an instance of the widget.  This set is slightly</summary>
	public TArray<FName> InstanceNamedSlots;
}
