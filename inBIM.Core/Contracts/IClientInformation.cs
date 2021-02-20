using inBIM.Core.Enums;
using System.Diagnostics;

namespace inBIM.Core.Contracts
{
	 public interface IClientInformation
	 {
		  int AppId { get; }
		  string AppPath { get; }
		  Process CurrentProcess { get; }
		  Products Product { get; }
		  Years Year { get; }
	 }
}