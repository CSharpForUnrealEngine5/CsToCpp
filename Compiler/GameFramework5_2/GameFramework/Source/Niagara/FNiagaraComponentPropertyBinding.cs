namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraComponentRendererProperties.h")]
public partial struct FNiagaraComponentPropertyBinding {
	public FNiagaraVariableAttributeBinding AttributeBinding;
	public FName PropertyName;
	public FNiagaraTypeDefinition PropertyType;
	public FName MetadataSetterName;
	public TMap<string,string> PropertySetterParameterDefaults;
}
