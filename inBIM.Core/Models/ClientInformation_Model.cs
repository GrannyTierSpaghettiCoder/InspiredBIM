using inBIM.Core.Contracts;
using inBIM.Core.Enums;
using System.Diagnostics;

namespace inBIM.Core.Models
{
	 public class ClientInformation_Model : IClientInformation
	 {
		  public ClientInformation_Model(Products product, Years year)
		  {
			   CurrentProcess = Process.GetCurrentProcess();
			   AppId = CurrentProcess.Id;
			   AppPath = CurrentProcess.MainModule.FileName;
			   Product = product;
			   Year = year;
		  }

		  public int AppId { get; }
		  public string AppPath { get; }
		  public Process CurrentProcess { get; }
		  public Products Product { get; }
		  public Years Year { get; }
	 }
}