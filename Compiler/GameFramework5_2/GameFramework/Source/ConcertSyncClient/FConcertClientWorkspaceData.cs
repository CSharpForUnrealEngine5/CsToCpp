namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Client workspace data associated with a specific</summary>
[CppInclude("ConcertClientWorkspaceData.h")]
public partial struct FConcertClientWorkspaceData {
	public FGuid SessionIdentifier;
	public TMap<string,long> PersistedFiles;
}
