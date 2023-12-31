namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_ActorBoundEvent.h")]
public partial class UK2Node_ActorBoundEvent : UK2Node_Event {
	public static UClass StaticClass() {return default;}
	///<summary>Delegate property name that this event is associated with</summary>
	public FName DelegatePropertyName;
	///<summary>Delegate property&#39;s owner class that this event is associated with</summary>
	public UClass DelegateOwnerClass;
	///<summary>The event that this event is bound to</summary>
	public AActor EventOwner;
}
