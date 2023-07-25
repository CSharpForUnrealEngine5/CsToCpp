#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayDebuggerTypes.h")]
public partial struct FGameplayDebuggerDataPackHeader {
// GameplayDebuggerDataPackHeader
	public short DataVersion;
	public short SyncCounter;
	public int DataSize;
	public int DataOffset;
	public bool bIsCompressed;
}
