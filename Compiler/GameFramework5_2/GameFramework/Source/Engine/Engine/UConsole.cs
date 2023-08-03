#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A basic command line console that accepts most commands.</summary>
[CppInclude("Engine/Console.h")]
public partial class UConsole : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The player which the next console command should be executed in the context of.  If nullptr, execute in the viewport.</summary>
	public ULocalPlayer ConsoleTargetPlayer;
	///<summary>DefaultTexture_Black</summary>
	public UTexture2D DefaultTexture_Black;
	///<summary>DefaultTexture_White</summary>
	public UTexture2D DefaultTexture_White;
	///<summary>Holds the history buffer, order is old to new</summary>
	public TArray<string> HistoryBuffer;
}
