namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>AIDataProvider is an object that can provide collection of properties</summary>
[CppInclude("DataProviders/AIDataProvider.h")]
public partial struct FAIDataProviderValue {
	public UAIDataProvider DataBinding;
	public string DataField;
}
