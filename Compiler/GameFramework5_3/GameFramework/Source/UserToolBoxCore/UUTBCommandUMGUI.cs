namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UTBBaseUICommand.h")]
public partial class UUTBCommandUMGUI : UUserWidget {
	public static UClass StaticClass() {return default;}
	///<summary>DoesSupportClass</summary>
	public bool DoesSupportClass(UClass ObjectClass) { return default; }
	///<summary>ExecuteCommand</summary>
	public void ExecuteCommand() {}
	///<summary>Command</summary>
	public UUTBBaseCommand Command;
}
