#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
///<summary>Mount a session repository used to store session files.</summary>
public partial struct FConcertAdmin_MountSessionRepositoryRequest {
// ConcertAdmin_MountSessionRepositoryRequest
	public FGuid RepositoryId;
	public string RepositoryRootDir;
	public bool bAsServerDefault;
	public bool bCreateIfNotExist;
}
