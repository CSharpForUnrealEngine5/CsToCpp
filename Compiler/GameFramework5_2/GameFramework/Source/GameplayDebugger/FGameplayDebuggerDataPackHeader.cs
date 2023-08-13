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
