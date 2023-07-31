#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NeuralEnumClasses.h")]
///<summary>After an asynchronous operation has finished, whether the callback functions tied to the delegate will be called from the game/main thread (highly</summary>
public enum ENeuralThreadMode {
	GameThread=0,
	AnyThread=1,
}
