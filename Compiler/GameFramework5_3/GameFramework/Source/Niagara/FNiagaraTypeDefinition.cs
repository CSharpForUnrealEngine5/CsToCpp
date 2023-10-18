namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraTypes.h")]
public partial struct FNiagaraTypeDefinition {
	public UObject ClassStructOrEnum;
	public ushort UnderlyingType;
	public byte Flags;
	public UStruct Struct_DEPRECATED;
	public UEnum Enum_DEPRECATED;
}
