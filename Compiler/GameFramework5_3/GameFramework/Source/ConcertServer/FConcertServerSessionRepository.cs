namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Keep the information about a the session repository.</summary>
[CppInclude("ConcertServerSessionRepositories.h")]
public partial struct FConcertServerSessionRepository {
	public FGuid RepositoryId;
	public string RepositoryRootDir;
	public string WorkingDir;
	public string SavedDir;
	public int ProcessId;
	public bool bMounted;
}
