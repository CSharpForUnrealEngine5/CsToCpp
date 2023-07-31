#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Client workspace data associated with a specific</summary>
[CppInclude("ConcertClientWorkspaceData.h")]
public partial struct FConcertClientWorkspaceData {
	public FGuid SessionIdentifier;
	public TMap<string,long> PersistedFiles;
}
