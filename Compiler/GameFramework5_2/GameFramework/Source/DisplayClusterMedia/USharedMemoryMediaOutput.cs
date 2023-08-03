#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Output information for a SharedMemory media capture.</summary>
[CppInclude("SharedMemoryMediaOutput.h")]
public partial class USharedMemoryMediaOutput : UMediaOutput {
	public static UClass StaticClass() {return default;}
	///<summary>Shared memory will be opened by using this name. Should be unique per media output.</summary>
	public string UniqueName;
}
