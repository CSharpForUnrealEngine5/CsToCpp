#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraComponentRendererProperties.h")]
public partial struct FNiagaraComponentPropertyBinding {
	public FNiagaraVariableAttributeBinding AttributeBinding;
	public string PropertyName;
	public FNiagaraTypeDefinition PropertyType;
	public string MetadataSetterName;
	public TMap<string,string> PropertySetterParameterDefaults;
}
