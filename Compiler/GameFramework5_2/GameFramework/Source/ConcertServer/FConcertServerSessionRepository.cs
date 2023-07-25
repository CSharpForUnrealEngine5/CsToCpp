#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertServerSessionRepositories.h")]
///<summary>Keep the information about a the session repository.</summary>
public partial struct FConcertServerSessionRepository {
// ConcertServerSessionRepository
	public FGuid RepositoryId;
	public string RepositoryRootDir;
	public string WorkingDir;
	public string SavedDir;
	public int ProcessId;
	public bool bMounted;
}
