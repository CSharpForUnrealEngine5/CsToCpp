namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graph/MovieGraphConfig.h")]
public partial class UMovieGraphMember : UMovieGraphValueContainer {
	public static UClass StaticClass() {return default;}
	///<summary>The optional description of this member, which is user-facing.</summary>
	public string Description;
	///<summary>The name of this member, which is user-facing.</summary>
	public string Name;
	///<summary>A GUID that uniquely identifies this member within its graph.</summary>
	public FGuid Guid;
	///<summary>Whether this member can be edited in the UI.</summary>
	public bool bIsEditable;
}
