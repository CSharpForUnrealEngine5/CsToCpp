#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMViewModelBase.h")]
///<summary>Base class for MVVM viewmodel.</summary>
public partial class UMVVMViewModelBase : UObject {
// MVVMViewModelBase
	public  void K2_AddFieldValueChangedDelegate(FFieldNotificationId FieldId,FFieldValueChangedDynamicDelegate Delegate) {}
	public  void K2_RemoveFieldValueChangedDelegate(FFieldNotificationId FieldId,FFieldValueChangedDynamicDelegate Delegate) {}
	public  void K2_BroadcastFieldValueChanged(FFieldNotificationId FieldId) {}
	public  bool K2_SetPropertyValue(int OldValue,int NewValue) { return default; }
}
