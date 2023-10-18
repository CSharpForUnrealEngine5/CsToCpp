namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows to set / add a shape library on the running control rig from user data</summary>
[CppInclude("Units/Core/RigUnit_UserData.h")]
public partial struct FRigUnit_SetupShapeLibraryFromUserData {
	public string NameSpace;
	public string Path;
	public string LibraryName;
	public bool ReplaceExisting;
	public bool LogShapeLibraries;
}
