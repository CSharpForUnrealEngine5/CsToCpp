#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlFieldPath.h")]
///<summary>Holds a path from a UObject to a field.</summary>
public partial struct FRCFieldPathInfo {
// RCFieldPathInfo
	public TArray<FRCFieldPathSegment> Segments;
	public uint PathHash;
}
