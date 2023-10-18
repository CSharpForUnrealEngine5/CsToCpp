namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class of factory that creates Source. A source can be created in the editor via the Live Link panel or at runtime via a connection string.</summary>
[CppInclude("LiveLinkSourceFactory.h")]
public partial class ULiveLinkSourceFactory : UObject {
	public static UClass StaticClass() {return default;}
}
