namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Field Notification system allows a user to know when a property value is modified at runtime (note that it can be a function return value).</summary>
[CppInclude("FieldNotification/FieldNotificationLibrary.h")]
public partial class UFieldNotificationLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Broadcast that the Field value changed.</summary>
	public static void BroadcastFieldValueChanged(UObject Object,FFieldNotificationId FieldId) {}
	///<summary>Broadcast that a list of Field values changed.</summary>
	public static void BroadcastFieldsValueChanged(UObject Object,TArray<FFieldNotificationId> FieldIds) {}
	///<summary>SetPropertyValueAndBroadcast</summary>
	public static bool SetPropertyValueAndBroadcast(bool NewValueByRef,int OldValue,int NewValue,UObject Object,UObject NetOwner,bool bHasLocalRepNotify,bool bShouldFlushDormancyOnSet,bool bIsNetProperty) { return default; }
	///<summary>SetPropertyValueAndBroadcastFields</summary>
	public static bool SetPropertyValueAndBroadcastFields(bool NewValueByRef,int OldValue,int NewValue,UObject Object,UObject NetOwner,bool bHasLocalRepNotify,bool bShouldFlushDormancyOnSet,bool bIsNetProperty,TArray<FFieldNotificationId> ExtraFieldIds) { return default; }
}
