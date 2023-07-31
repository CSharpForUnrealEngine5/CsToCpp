#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithFileProducer.h")]
public partial class UDatasmithDirProducer : UDataprepContentProducer {
	///<summary>The folder were datasmith will look for files to import</summary>
	public string FolderPath;
	///<summary>Semi-column separated string containing the extensions to consider. By default, set to * to get all extensions.</summary>
	public string ExtensionString;
	///<summary>If checked, sub-directories will be traversed</summary>
	public bool bRecursive;
	///<summary>FileProducer</summary>
	public UDatasmithFileProducer FileProducer;
	///<summary>TessellationOptions</summary>
	public UDatasmithCommonTessellationOptions TessellationOptions;
}
