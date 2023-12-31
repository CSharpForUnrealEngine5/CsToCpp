namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_ComponentBoundEvent.h")]
public partial class UK2Node_ComponentBoundEvent : UK2Node_Event {
	public static UClass StaticClass() {return default;}
	///<summary>Delegate property name that this event is associated with</summary>
	public FName DelegatePropertyName;
	///<summary>Delegate property&#39;s owner class that this event is associated with</summary>
	public UClass DelegateOwnerClass;
	///<summary>Name of property in Blueprint class that pointer to component we want to bind to</summary>
	public FName ComponentPropertyName;
}
