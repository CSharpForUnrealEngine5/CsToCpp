namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimStateAliasNode.h")]
public partial class UAnimStateAliasNode : UAnimStateNodeBase {
	public static UClass StaticClass() {return default;}
	///<summary>bGlobalAlias</summary>
	public bool bGlobalAlias;
	///<summary>StateAliasName</summary>
	public string StateAliasName;
	///<summary>AliasedStateNodes</summary>
	public TSet<TWeakObjectPtr<UAnimStateNodeBase>> AliasedStateNodes;
}
