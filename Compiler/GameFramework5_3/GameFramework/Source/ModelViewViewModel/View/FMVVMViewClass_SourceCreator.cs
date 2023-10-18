namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Shared data to find or create a ViewModel at runtime.</summary>
[CppInclude("View/MVVMViewClass.h")]
public partial struct FMVVMViewClass_SourceCreator {
	public UClass ExpectedSourceType;
	public UMVVMViewModelContextResolver Resolver;
	public FMVVMViewModelContext GlobalViewModelInstance;
	public FMVVMVCompiledFieldPath FieldPath;
	public FName PropertyName;
	public FName ParentSourceName;
	public byte Flags;
	public bool bCreateInstance_DEPRECATED;
	public bool bIsUserWidgetProperty_DEPRECATED;
	public bool bOptional_DEPRECATED;
}
