namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraMessageStore.h")]
public partial struct FNiagaraMessageStore {
	public TMap<FGuid,UNiagaraMessageDataBase> MessageKeyToMessageMap;
	public TArray<FGuid> DismissedMessageKeys;
}
