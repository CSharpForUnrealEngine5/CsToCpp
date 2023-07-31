#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Drop one or more session repositories from the server, deleting all the contained files.</summary>
[CppInclude("ConcertMessages.h")]
public partial struct FConcertAdmin_DropSessionRepositoriesRequest {
	public TArray<FGuid> RepositoryIds;
}
