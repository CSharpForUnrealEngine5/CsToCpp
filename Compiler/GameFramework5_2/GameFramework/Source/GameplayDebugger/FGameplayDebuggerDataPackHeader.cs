#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayDebuggerTypes.h")]
public partial struct FGameplayDebuggerDataPackHeader {
	public short DataVersion;
	public short SyncCounter;
	public int DataSize;
	public int DataOffset;
	public bool bIsCompressed;
}
