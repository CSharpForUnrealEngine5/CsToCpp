#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Console.h")]
///<summary>A basic command line console that accepts most commands.</summary>
public partial class UConsole : UObject {
// Console
	public ULocalPlayer ConsoleTargetPlayer;
	public UTexture2D DefaultTexture_Black;
	public UTexture2D DefaultTexture_White;
	public TArray<string> HistoryBuffer;
}
