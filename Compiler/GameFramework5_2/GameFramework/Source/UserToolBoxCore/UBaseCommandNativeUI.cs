#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Native base class for Command UI Customization</summary>
[CppInclude("UTBBaseUICommand.h")]
public partial class UBaseCommandNativeUI : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>MyCommand</summary>
	public UUTBBaseCommand MyCommand;
}
