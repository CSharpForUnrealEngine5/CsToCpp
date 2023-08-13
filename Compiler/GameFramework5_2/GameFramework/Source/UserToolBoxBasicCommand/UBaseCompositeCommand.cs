namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseCompositeCommand.h")]
public partial class UBaseCompositeCommand : UUTBBaseCommand {
	public static UClass StaticClass() {return default;}
	///<summary>Commands</summary>
	public TArray<UUTBBaseCommand> Commands;
}
