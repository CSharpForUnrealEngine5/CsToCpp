namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Commandlet for replacing one kind of actor with another kind of actor, copying changed properties from the most-derived common superclass</summary>
[CppInclude("Commandlets/ReplaceActorCommandlet.h")]
public partial class UReplaceActorCommandlet : UCommandlet {
	public static UClass StaticClass() {return default;}
}
