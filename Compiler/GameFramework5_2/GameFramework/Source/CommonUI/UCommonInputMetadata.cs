#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Metadata CommonUI will try to acquire from Enhanced Input Mapping Contexts (IMC)</summary>
[CppInclude("CommonUITypes.h")]
public partial class UCommonInputMetadata : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Priority in nav-bar</summary>
	public int NavBarPriority;
	///<summary>Generic actions like accept or face button top will be subscribed to by multiple</summary>
	public bool bIsGenericInputAction;
}
