using System.IO;
using System.Reflection;

namespace inBIM.Core.Helpers
{
	 public struct Dependancy_Helpers
	 {
		  public static void LoadDependancies()
		  {
			   var currentdirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			   var dependancy = new FileInfo(Path.Combine(currentdirectory, "System.Windows.Interactivity.dll"));
			   if(dependancy.Exists)
			   {
					Assembly.Load(AssemblyName.GetAssemblyName(dependancy.FullName));
			   };
		  }
	 }
}