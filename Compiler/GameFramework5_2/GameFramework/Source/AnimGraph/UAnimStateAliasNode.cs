#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimStateAliasNode.h")]
public partial class UAnimStateAliasNode : UAnimStateNodeBase {
// AnimStateAliasNode
	public bool bGlobalAlias;
	public string StateAliasName;
	public TSet<TWeakObjectPtr<UAnimStateNodeBase>> AliasedStateNodes;
}
