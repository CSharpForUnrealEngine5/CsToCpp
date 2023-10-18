namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mount a session repository used to store session files.</summary>
[CppInclude("ConcertMessages.h")]
public partial struct FConcertAdmin_MountSessionRepositoryRequest {
	public FGuid RepositoryId;
	public string RepositoryRootDir;
	public bool bAsServerDefault;
	public bool bCreateIfNotExist;
}
