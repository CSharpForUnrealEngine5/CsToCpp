#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_SwitchEnum.h")]
public partial class UK2Node_SwitchEnum : UK2Node_Switch {
	public static UClass StaticClass() {return default;}
	///<summary>Name of the enum being switched on</summary>
	public UEnum Enum;
	///<summary>List of the current entries in the enum</summary>
	public TArray<string> EnumEntries;
	///<summary>List of the current entries in the enum</summary>
	public TArray<string> EnumFriendlyNames;
}
