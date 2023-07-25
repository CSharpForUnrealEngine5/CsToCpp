#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
///<summary>Drop one or more session repositories from the server, deleting all the contained files.</summary>
public partial struct FConcertAdmin_DropSessionRepositoriesRequest {
// ConcertAdmin_DropSessionRepositoriesRequest
	public TArray<FGuid> RepositoryIds;
}
