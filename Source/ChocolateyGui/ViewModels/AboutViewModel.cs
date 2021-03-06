﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Chocolatey" file="AboutViewModel.cs">
//   Copyright 2014 - Present Rob Reynolds, the maintainers of Chocolatey, and RealDimensions Software, LLC
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Reflection;
using Caliburn.Micro;
using ChocolateyGui.Models.Messages;

namespace ChocolateyGui.ViewModels
{
    public sealed class AboutViewModel : Screen
    {
        private readonly IEventAggregator _eventAggregator;

        public AboutViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public string ChocolateyGuiVersion
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version.ToString(); }
        }

        public string ChocolateyGuiInformationalVersion
        {
            get { return Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion; }
        }

        public void Back()
        {
            _eventAggregator.PublishOnUIThread(new AboutGoBackMessage());
        }
    }
}