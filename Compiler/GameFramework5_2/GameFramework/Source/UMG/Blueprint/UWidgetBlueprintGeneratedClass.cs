#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/WidgetBlueprintGeneratedClass.h")]
///<summary>The widget blueprint generated class allows us to create blueprint-able widgets for UMG at runtime.</summary>
public partial class UWidgetBlueprintGeneratedClass : UBlueprintGeneratedClass {
// WidgetBlueprintGeneratedClass
	public UWidgetTree WidgetTree;
	public TArray<UWidgetBlueprintGeneratedClassExtension> Extensions;
	public TArray<FFieldNotificationId> FieldNotifyNames;
	public bool bClassRequiresNativeTick;
	public bool bCanCallPreConstruct;
	public TArray<FDelegateRuntimeBinding> Bindings;
	public TArray<UWidgetAnimation> Animations;
	public TArray<string> NamedSlots;
	public TMap<string,FGuid> NamedSlotsWithID;
	public TArray<string> AvailableNamedSlots;
	public TArray<string> InstanceNamedSlots;
}
