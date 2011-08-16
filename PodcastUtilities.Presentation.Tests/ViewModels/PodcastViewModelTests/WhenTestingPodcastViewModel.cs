﻿using System;
using PodcastUtilities.Common;
using PodcastUtilities.Common.Tests;
using PodcastUtilities.Presentation.ViewModels;

namespace PodcastUtilities.Presentation.Tests.ViewModels.PodcastViewModelTests
{
    public abstract class WhenTestingPodcastViewModel
        : WhenTestingBehaviour
    {
        protected PodcastViewModel ViewModel { get; set; }

        protected override void GivenThat()
        {
            base.GivenThat();

            var podcast = new PodcastInfo
                              {
                                  Folder = "Original Name",
                                  Feed = new FeedInfo { Address = new Uri("http://www.originaladdress.com/ppp.xml") }
                              };

            ViewModel = new PodcastViewModel(podcast);
        }
    }
}