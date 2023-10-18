namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Smart Object User Component defines common settings for a Smart Object user.</summary>
[CppInclude("SmartObjectUserComponent.h")]
public partial class USmartObjectUserComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Validation filter used for entering testing entries for a Smart Object slot.</summary>
	public UClass ValidationFilter;
}
