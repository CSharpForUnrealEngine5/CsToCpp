namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Tracks the session repositories across the server instances.</summary>
[CppInclude("ConcertServerSessionRepositories.h")]
public partial struct FConcertServerSessionRepositoryDatabase {
	public TArray<FConcertServerSessionRepository> Repositories;
}
