#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for MVVM viewmodel.</summary>
[CppInclude("MVVMViewModelBase.h")]
public partial class UMVVMViewModelBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>K2_AddFieldValueChangedDelegate</summary>
	public  void K2_AddFieldValueChangedDelegate(FFieldNotificationId FieldId,FFieldValueChangedDynamicDelegate Delegate) {}
	///<summary>K2_RemoveFieldValueChangedDelegate</summary>
	public  void K2_RemoveFieldValueChangedDelegate(FFieldNotificationId FieldId,FFieldValueChangedDynamicDelegate Delegate) {}
	///<summary>K2_BroadcastFieldValueChanged</summary>
	public  void K2_BroadcastFieldValueChanged(FFieldNotificationId FieldId) {}
	///<summary>K2_SetPropertyValue</summary>
	public  bool K2_SetPropertyValue(int OldValue,int NewValue) { return default; }
}
