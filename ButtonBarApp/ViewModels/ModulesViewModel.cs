namespace ButtonBarApp.ViewModels
{
  using System.Collections.Generic;
  using Models;

  /// <summary>
  /// ModulesViewModel class
  /// </summary>
  public class ModulesViewModel
  {
    public ModulesViewModel()
    {
      Modules = new List<ModuleData>
                  {
                    new ModuleData { Name = "Item1", ModuleImage = "/Resources/2.png" },
                    new ModuleData { Name = "Item2", ModuleImage = "/Resources/8.png" },
                    new ModuleData { Name = "Item3", ModuleImage = "/Resources/9.png" },
                    new ModuleData { Name = "Item4", ModuleImage = "/Resources/10.png" },
                  };
    }

    public IList<ModuleData> Modules { get; set; }
  }
}
