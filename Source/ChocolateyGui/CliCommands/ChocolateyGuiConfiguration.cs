﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Chocolatey" file="ChocolateyGuiConfiguration.cs">
//   Copyright 2014 - Present Rob Reynolds, the maintainers of Chocolatey, and RealDimensions Software, LLC
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace ChocolateyGui.CliCommands
{
    [Serializable]
    public class ChocolateyGuiConfiguration
    {
        public ChocolateyGuiConfiguration()
        {
            RegularOutput = true;
            FeatureCommand = new FeatureCommandConfiguration();
            ConfigCommand = new ConfigCommandConfiguration();
            PurgeCommand = new PurgeCommandConfiguration();
        }

        public string CommandName { get; set; }

        public bool HelpRequested { get; set; }

        public bool UnsuccessfulParsing { get; set; }

        public bool RegularOutput { get; set; }

        public string Input { get; set; }

        public FeatureCommandConfiguration FeatureCommand { get;  set; }

        public ConfigCommandConfiguration ConfigCommand { get; set; }

        public PurgeCommandConfiguration PurgeCommand { get; set; }
    }
}