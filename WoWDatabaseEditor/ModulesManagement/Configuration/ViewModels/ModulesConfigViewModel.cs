﻿using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WDE.Module.Attributes;

namespace WoWDatabaseEditor.ModulesManagement.Configuration.ViewModels
{
    [AutoRegister]
    class ModulesConfigViewModel : BindableBase
    {
        public ObservableCollection<ModuleConfigModel> Items { get; }

        public ModulesConfigViewModel(IModulesManager modulesManager)
        {
            Items = new ObservableCollection<ModuleConfigModel>();

            Items.AddRange(modulesManager.Modules.Select(m => new ModuleConfigModel(isEnabled: true, name: m.Assembly.GetName().Name ?? "Unknown name", isLoaded: m.IsLoaded, details: GenerateDetailFor(m.ConflictingAssembly))));
        }

        private string GenerateDetailFor(Assembly? conflictingAssembly)
        {
            if (conflictingAssembly == null)
                return "";

            return $"Conflicts with {conflictingAssembly.GetName().Name} ({conflictingAssembly.Location})";
        }
    }

    class ModuleConfigModel
    {
        public ModuleConfigModel(bool isEnabled, string name, bool isLoaded, string details)
        {
            IsEnabled = isEnabled;
            Name = name;
            IsLoaded = isLoaded;
            Details = details;
        }

        public bool IsEnabled { get; set; }
        public string Name { get; set; }
        public bool IsLoaded { get; set; }
        public string Details { get; set; }
    }
}
