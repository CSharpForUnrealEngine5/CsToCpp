namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Utility/WidgetSlotPair.h")]
public partial class UWidgetSlotPair : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>WidgetName</summary>
	public string WidgetName;
	///<summary>SlotPropertyNames</summary>
	public TArray<string> SlotPropertyNames;
	///<summary>SlotPropertyValues</summary>
	public TArray<string> SlotPropertyValues;
}
