namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Instance UMVVMClassExtension_View for the UUserWdiget</summary>
[CppInclude("View/MVVMView.h")]
public partial class UMVVMView : UUserWidgetExtension {
	public static UClass StaticClass() {return default;}
	///<summary>Initialize the sources if they are not already initialized.</summary>
	public void InitializeSources() {}
	///<summary>Uninitialize the sources if they are already initialized.</summary>
	public void UninitializeSources() {}
	///<summary>The sources were initialized, manually or automatically.</summary>
	public bool AreSourcesInitialized() { return default; }
	///<summary>Initialize the bindings if they are not already initialized.</summary>
	public void InitializeBindings() {}
	///<summary>Uninitialize the bindings if they are already initialized.</summary>
	public void UninitializeBindings() {}
	///<summary>The bindings were initialized, manually or automatically.</summary>
	public bool AreBindingsInitialized() { return default; }
	///<summary>Find and return the viewmodel with the specified name.</summary>
	public object /*ReturnValue*/ GetViewModel(FName ViewModelName) { return default; }
	///<summary>Set the viewmodel of the specified name.</summary>
	public bool SetViewModel(FName ViewModelName,object /*ViewModel*/ ViewModel) { return default; }
	///<summary>Set the first viewmodel matching the exact specified type. If none is found, set the first viewmodel matching a child of the specified type</summary>
	public bool SetViewModelByClass(object /*NewValue*/ NewValue) { return default; }
	///<summary>ClassExtension</summary>
	public UMVVMViewClass ClassExtension;
	///<summary>Sources</summary>
	public TArray<FMVVMViewSource> Sources;
	///<summary>Should log when a binding is executed.</summary>
	public bool bLogBinding;
	///<summary>Is the Construct method called.</summary>
	public bool bConstructed;
	///<summary>Is the Initialize method called.</summary>
	public bool bSourcesInitialized;
	///<summary>Is the Initialize method called.</summary>
	public bool bBindingsInitialized;
	///<summary>The view has at least one binding that need to be ticked every frame.</summary>
	public bool bHasEveryTickBinding;
}
