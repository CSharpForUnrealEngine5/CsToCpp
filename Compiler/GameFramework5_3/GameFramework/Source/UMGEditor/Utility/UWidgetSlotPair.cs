namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Utility/WidgetSlotPair.h")]
public partial class UWidgetSlotPair : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>WidgetName</summary>
	public FName WidgetName;
	///<summary>SlotPropertyNames</summary>
	public TArray<FName> SlotPropertyNames;
	///<summary>SlotPropertyValues</summary>
	public TArray<string> SlotPropertyValues;
}
