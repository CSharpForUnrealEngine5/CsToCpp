namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a path from a UObject to a field.</summary>
[CppInclude("RemoteControlFieldPath.h")]
public partial struct FRCFieldPathInfo {
	public TArray<FRCFieldPathSegment> Segments;
	public uint PathHash;
}
